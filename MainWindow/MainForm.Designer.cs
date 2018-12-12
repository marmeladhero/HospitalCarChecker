namespace MainWindow
{
    using ConfigurationApplication;

    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimeFrom = new MetroFramework.Controls.MetroDateTime();
            this.DateTimeTo = new MetroFramework.Controls.MetroDateTime();
            this.Button_ApplyDataChanges = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Label_ItemCount = new MetroFramework.Controls.MetroLabel();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.LabelLastUpdate = new MetroFramework.Controls.MetroLabel();
            this.LabelCount = new MetroFramework.Controls.MetroLabel();
            this.LabelLastUpdate_INFO = new MetroFramework.Controls.MetroLabel();
            this.ButtonAllData = new MetroFramework.Controls.MetroButton();
            this.DGV = new MetroFramework.Controls.MetroGrid();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.TileUpdateBD = new MetroFramework.Controls.MetroTile();
            this.TileSaveXLS = new MetroFramework.Controls.MetroTile();
            this.TileSaveXLSX = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(30, 88);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(757, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionToolStripMenuItem,
            this.AppSettingsToolStripMenuItem});
            this.OptionsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.OptionsToolStripMenuItem.Text = "Настройки";
            // 
            // ConnectionToolStripMenuItem
            // 
            this.ConnectionToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem";
            this.ConnectionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ConnectionToolStripMenuItem.Text = "Подключения";
            this.ConnectionToolStripMenuItem.Click += new System.EventHandler(this.ConnectionToolStripMenuItem_Click);
            // 
            // AppSettingsToolStripMenuItem
            // 
            this.AppSettingsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppSettingsToolStripMenuItem.Name = "AppSettingsToolStripMenuItem";
            this.AppSettingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AppSettingsToolStripMenuItem.Text = "Приложения";
            this.AppSettingsToolStripMenuItem.Click += new System.EventHandler(this.AppSettingsToolStripMenuItem_Click);
            // 
            // DateTimeFrom
            // 
            this.DateTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFrom.Location = new System.Drawing.Point(209, 121);
            this.DateTimeFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeFrom.Name = "DateTimeFrom";
            this.DateTimeFrom.Size = new System.Drawing.Size(189, 29);
            this.DateTimeFrom.TabIndex = 4;
            // 
            // DateTimeTo
            // 
            this.DateTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeTo.Location = new System.Drawing.Point(425, 121);
            this.DateTimeTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeTo.Name = "DateTimeTo";
            this.DateTimeTo.Size = new System.Drawing.Size(200, 29);
            this.DateTimeTo.TabIndex = 5;
            // 
            // Button_ApplyDataChanges
            // 
            this.Button_ApplyDataChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ApplyDataChanges.Location = new System.Drawing.Point(631, 121);
            this.Button_ApplyDataChanges.Name = "Button_ApplyDataChanges";
            this.Button_ApplyDataChanges.Size = new System.Drawing.Size(85, 29);
            this.Button_ApplyDataChanges.TabIndex = 6;
            this.Button_ApplyDataChanges.Text = "Применить";
            this.Button_ApplyDataChanges.UseSelectable = true;
            this.Button_ApplyDataChanges.Click += new System.EventHandler(this.Button_ApplyDataChanges_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(404, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(15, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "-";
            // 
            // Label_ItemCount
            // 
            this.Label_ItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_ItemCount.AutoSize = true;
            this.Label_ItemCount.Location = new System.Drawing.Point(33, 416);
            this.Label_ItemCount.Name = "Label_ItemCount";
            this.Label_ItemCount.Size = new System.Drawing.Size(133, 19);
            this.Label_ItemCount.TabIndex = 12;
            this.Label_ItemCount.Text = "Кол-во совпадений:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(261, 416);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.Size = new System.Drawing.Size(387, 23);
            this.ProgressBar.TabIndex = 13;
            this.ProgressBar.Visible = false;
            // 
            // LabelLastUpdate
            // 
            this.LabelLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelLastUpdate.AutoSize = true;
            this.LabelLastUpdate.Location = new System.Drawing.Point(33, 442);
            this.LabelLastUpdate.Name = "LabelLastUpdate";
            this.LabelLastUpdate.Size = new System.Drawing.Size(159, 19);
            this.LabelLastUpdate.TabIndex = 14;
            this.LabelLastUpdate.Text = "Последние обновление:";
            // 
            // LabelCount
            // 
            this.LabelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(172, 416);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(16, 19);
            this.LabelCount.TabIndex = 17;
            this.LabelCount.Text = "0";
            // 
            // LabelLastUpdate_INFO
            // 
            this.LabelLastUpdate_INFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelLastUpdate_INFO.AutoSize = true;
            this.LabelLastUpdate_INFO.Location = new System.Drawing.Point(198, 442);
            this.LabelLastUpdate_INFO.Name = "LabelLastUpdate_INFO";
            this.LabelLastUpdate_INFO.Size = new System.Drawing.Size(63, 19);
            this.LabelLastUpdate_INFO.TabIndex = 18;
            this.LabelLastUpdate_INFO.Text = "11.12.2018";
            // 
            // ButtonAllData
            // 
            this.ButtonAllData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAllData.Location = new System.Drawing.Point(722, 121);
            this.ButtonAllData.Name = "ButtonAllData";
            this.ButtonAllData.Size = new System.Drawing.Size(65, 29);
            this.ButtonAllData.TabIndex = 20;
            this.ButtonAllData.Text = "Все";
            this.ButtonAllData.UseSelectable = true;
            this.ButtonAllData.Click += new System.EventHandler(this.ButtonAllData_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV.Location = new System.Drawing.Point(33, 162);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(754, 242);
            this.DGV.TabIndex = 21;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile4.Location = new System.Drawing.Point(168, 121);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(35, 29);
            this.metroTile4.TabIndex = 11;
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile4.TileImage = global::MainWindow.Properties.Resources._3643785___calendar_date_month_time_year1;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // TileUpdateBD
            // 
            this.TileUpdateBD.ActiveControl = null;
            this.TileUpdateBD.Location = new System.Drawing.Point(33, 117);
            this.TileUpdateBD.Name = "TileUpdateBD";
            this.TileUpdateBD.Size = new System.Drawing.Size(133, 39);
            this.TileUpdateBD.TabIndex = 10;
            this.TileUpdateBD.Text = "Обновить";
            this.TileUpdateBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TileUpdateBD.TileImage = ((System.Drawing.Image)(resources.GetObject("TileUpdateBD.TileImage")));
            this.TileUpdateBD.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TileUpdateBD.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileUpdateBD.UseCustomBackColor = true;
            this.TileUpdateBD.UseCustomForeColor = true;
            this.TileUpdateBD.UseSelectable = true;
            this.TileUpdateBD.UseTileImage = true;
            this.TileUpdateBD.Click += new System.EventHandler(this.TileUpdateBD_Click);
            // 
            // TileSaveXLS
            // 
            this.TileSaveXLS.ActiveControl = null;
            this.TileSaveXLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TileSaveXLS.Location = new System.Drawing.Point(654, 410);
            this.TileSaveXLS.Name = "TileSaveXLS";
            this.TileSaveXLS.Size = new System.Drawing.Size(62, 62);
            this.TileSaveXLS.TabIndex = 9;
            this.TileSaveXLS.TileImage = global::MainWindow.Properties.Resources._3044882___extension_file_spreadsheet_xls;
            this.TileSaveXLS.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileSaveXLS.UseCustomBackColor = true;
            this.TileSaveXLS.UseCustomForeColor = true;
            this.TileSaveXLS.UseSelectable = true;
            this.TileSaveXLS.UseTileImage = true;
            this.TileSaveXLS.Click += new System.EventHandler(this.TileSaveXLS_Click);
            // 
            // TileSaveXLSX
            // 
            this.TileSaveXLSX.ActiveControl = null;
            this.TileSaveXLSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TileSaveXLSX.Location = new System.Drawing.Point(722, 410);
            this.TileSaveXLSX.Name = "TileSaveXLSX";
            this.TileSaveXLSX.Size = new System.Drawing.Size(62, 62);
            this.TileSaveXLSX.TabIndex = 8;
            this.TileSaveXLSX.TileImage = global::MainWindow.Properties.Resources._3044880___extension_file_spreadsheet_xlsx;
            this.TileSaveXLSX.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileSaveXLSX.UseCustomBackColor = true;
            this.TileSaveXLSX.UseCustomForeColor = true;
            this.TileSaveXLSX.UseSelectable = true;
            this.TileSaveXLSX.UseTileImage = true;
            this.TileSaveXLSX.Click += new System.EventHandler(this.TileSaveXLSX_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 490);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.ButtonAllData);
            this.Controls.Add(this.LabelLastUpdate_INFO);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.LabelLastUpdate);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Label_ItemCount);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.TileUpdateBD);
            this.Controls.Add(this.TileSaveXLS);
            this.Controls.Add(this.TileSaveXLSX);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Button_ApplyDataChanges);
            this.Controls.Add(this.DateTimeTo);
            this.Controls.Add(this.DateTimeFrom);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(807, 349);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "МонТекС";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeConnection()
        {
            string serverName = string.Empty;
            if (connectionConfig.KeyExists(string.Intern("Name"), string.Intern("Server")))
                serverName = connectionConfig.ReadINI(string.IsInterned("Server"), "Name");
            int port = 0;
            if (connectionConfig.KeyExists("Port", string.IsInterned("Server")))
                port = int.Parse(connectionConfig.ReadINI(string.IsInterned("Server"), "Port"));
            string Login = string.Empty;
            if (connectionConfig.KeyExists("Login", string.IsInterned("Server")))
                Login = connectionConfig.ReadINI(string.IsInterned("Server"), "Login");
            string InitalizeCatalog = string.Empty;
            if (connectionConfig.KeyExists("InitialCatalog", string.IsInterned("Server")))
                InitalizeCatalog = connectionConfig.ReadINI(string.IsInterned("Server"), "InitialCatalog");
            ConnectionString = SqlProcessing.SqlWorker.FormatConnectionString(serverName, port, InitalizeCatalog, Login, Password);
        }

        private void InitializeConfiguration()
        {
            int days = 0;
            if (config.KeyExists(string.Intern("Days"), string.Intern("Interval")))
            {
                days = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Days")));
            }
            int minutes = 0;
            if (config.KeyExists(string.Intern("Minutes"), string.Intern("Interval")))
            {
                minutes = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Minutes")));
            }
            int hours = 0;
            if (config.KeyExists(string.Intern("Hours"), string.Intern("Interval")))
            {
                hours = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Hours")));
            }
            interval = new System.TimeSpan(days, hours, minutes, 0);
        }

        private void InitializeStyle()
        {
            this.Style = StyleConfiguration.MetroConfiguration.ColorStyle;
            StyleConfiguration.MetroConfiguration.UpdateStyle(this.menuStrip1);
            this.ProgressBar.Style = this.Style;
            this.Update();
        }
        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppSettingsToolStripMenuItem;
        private MetroFramework.Controls.MetroDateTime DateTimeFrom;
        private MetroFramework.Controls.MetroDateTime DateTimeTo;
        private MetroFramework.Controls.MetroButton Button_ApplyDataChanges;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile TileSaveXLSX;
        private MetroFramework.Controls.MetroTile TileSaveXLS;
        private MetroFramework.Controls.MetroTile TileUpdateBD;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLabel Label_ItemCount;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        private MetroFramework.Controls.MetroLabel LabelLastUpdate;
        private MetroFramework.Controls.MetroLabel LabelCount;
        private MetroFramework.Controls.MetroLabel LabelLastUpdate_INFO;
        private MetroFramework.Controls.MetroButton ButtonAllData;
        private MetroFramework.Controls.MetroGrid DGV;
    }
}

