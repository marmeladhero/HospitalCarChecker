namespace MainWindow
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ConfigurationApplication;
    using DataGridViewWorker;
    using SqlProcessing;

    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        SqlWorker sqlWorker;
        TimeSpan interval;
        string Password { set; get; }

        bool bIsDataLoading = false;
        string ConnectionString;
        /// <summary>
        /// Таблица для хранение полученных данных
        /// </summary>
        DataTable myTable;
        /// <summary>
        /// Строка запроса
        /// </summary>
        string sqlQuery = string.Empty;
        /// <summary>
        /// config.ini
        /// </summary>
        IniFile config = new IniFile();
        IniFile connectionConfig = new IniFile("connection.ini");
        /// <summary>
        /// Экшон для обновления DataTable
        /// </summary>
        Action<DataTable> actUpdTable;

        CancellationToken _token;
        CancellationTokenSource _source;

        public MainForm()
        {
            InitializeComponent();
            InitializeConfiguration();
            InitializeStyle();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlQuery = $"SELECT i.id, i.othername, i.gov_number, c.dt FROM imeies i INNER JOIN coordinates c ON i.id=c.imei_id";

            actUpdTable = new Action<DataTable>(UpdateDataGrid);
            _source = new CancellationTokenSource();
            _token = _source.Token;

            LoadForm form = new LoadForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                myTable = SqlWorker.CreateTable(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss"));
                myTable.Columns.Add(new DataColumn("TimeB", typeof(DateTime)));
                this.TileUpdateBD.Enabled = true;
                ControlsAction(true);
                Password = form.Password;
                InitializeConnection();
            }
            else
            {
                this.TileUpdateBD.Enabled = false;
                ControlsAction(false);
            }
        }

        #region Controls
        private void ControlsAction(bool IsEnable)
        {
            this.ButtonAllData.Enabled = IsEnable;
            this.TileSaveXLSX.Enabled = IsEnable;
            this.TileSaveXLS.Enabled = IsEnable;
            this.DateTimeFrom.Enabled = IsEnable;
            this.DateTimeTo.Enabled = IsEnable;
            this.Button_ApplyDataChanges.Enabled = IsEnable;
        }

        private void LockElements(bool IsLoading)
        {
            if (IsLoading)
            {
                ControlsAction(false);
                this.ProgressBar.Visible = true;
                this.TileUpdateBD.Text = "Остановить";
                this.TileUpdateBD.Image = Properties.Resources._2931151___bin_close_delete_exit_recycle_remove_x1;
            }
            else
            {
                ControlsAction(true);
                this.ProgressBar.Visible = false;
                this.TileUpdateBD.Text = "Обновить";
                this.TileUpdateBD.Image = Properties.Resources._3071848___cloud_computer_device_digital_download_technology;
            }
        }
        #endregion

        #region MenuStrip        
        private void ConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm form = new LoadForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //TODO: Update Connection Info
                InitializeConnection();
            }
        }
        private void AppSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm_Configuration form = new OptionsForm_Configuration();
            if (form.ShowDialog() == DialogResult.OK)
            {
                InitializeConfiguration();
                InitializeStyle();              
            }
        }
        #endregion

        private void TileUpdateBD_Click(object sender, EventArgs e)
        {
            bIsMbox = false;
            if (bIsDataLoading) // Останавливаем
            {
                _source.Cancel();
                sqlWorker.EventTableHandler -= SqlWorker_EventTableHandler;
                Thread.Sleep(200);
                sqlWorker = null;
                bIsDataLoading = false;
            }
            else // // Загружаем из БД
            {
                sqlWorker = SqlWorker.GetInstance(ConnectionString, _source.Token);
                sqlWorker.EventTableHandler += SqlWorker_EventTableHandler;
                sqlWorker.EventJobIsDoneHandler += SqlWorker_EventJobIsDoneHandler;
                sqlWorker.Start(sqlQuery);
                bIsDataLoading = true;
            }

            LockElements(bIsDataLoading);
        }

        /// <summary>
        /// для того чтобы куча меседжей не посыполось из потоков
        /// </summary>
        bool bIsMbox = false;
        private void SqlWorker_EventJobIsDoneHandler(bool IsJobDone)
        {   
            if (IsJobDone)
            {
                if (!bIsMbox)
                {
                    bIsMbox = true;
                    LabelLastUpdate_INFO.Invoke(new Action(() => {
                        LabelLastUpdate_INFO.Text = DateTime.Now.ToLongDateString();
                    }));
                    bIsDataLoading = false;
                    LockElements(bIsDataLoading);
                    MetroFramework.MetroMessageBox.Show(this, "Загрузка завершена", "Успех", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!bIsMbox)
                {
                    bIsMbox = true;

                    MetroFramework.MetroMessageBox.Show(this, "Не все данные загружены", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        #region EXCEL SAVER
        MyExcel.ExcelWorker worker = new MyExcel.ExcelWorker(10, 5);
        private void TileSaveXLSX_Click(object sender, EventArgs e)
        {
            worker.WriteAndSave(DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".xlsx", this.DGV.GetDataTable(myTable.TableName), true);               
        }
        private void TileSaveXLS_Click(object sender, EventArgs e)
        {
            worker.WriteAndSave(DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".xls", this.DGV.GetDataTable(myTable.TableName), true);
        }
        #endregion
        /// <summary>
        /// Обработка и проверка на интервал
        /// </summary>
        /// <param name="table"></param>
        private async void SqlWorker_EventTableHandler(DataTable table)
        {
            DateTime curRow, nextRow;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                curRow = (DateTime)table.Rows[i][3];
                nextRow = (DateTime)table.Rows[i + 1][3];

                var q = nextRow - curRow;

                if (q > interval)
                {
                    string[] arr = new string[]
                    {
                            table.Rows[i][0].ToString(),
                            table.Rows[i][1].ToString(),
                            table.Rows[i][2].ToString(),
                            table.Rows[i][3].ToString(),
                            nextRow.ToString("dd/MM/yyyy HH:mm:ss")
                    };
                    myTable.Rows.Add(arr);
                }
            }

            if (myTable.Rows.Count > 0)
            { 
                try
                {
                    await Task.Run(new Action(() =>
                    {
                        DGV.Invoke(actUpdTable, myTable);

                    }), _token);
                }
                catch (TaskCanceledException)
                {

                }
            }
        }        
        private void UpdateDataGrid(DataTable table)
        {
            this.DGV.DataSource = table;
            LabelCount.Text = this.DGV.Rows.Count.ToString();
        }
        private void Button_ApplyDataChanges_Click(object sender, EventArgs e)
        { 
            myTable.DefaultView.RowFilter = $"TimeA >= '{DateTimeFrom.Value.Date}' AND TimeA <= '{DateTimeTo.Value.Date}'";
            int a = DGV.Rows.Count;
            a = DGV.SelectedRows.Count;
        }
        private void ButtonAllData_Click(object sender, EventArgs e)
        {
            myTable.DefaultView.RowFilter = string.Empty;
        }        
    }
}
    

