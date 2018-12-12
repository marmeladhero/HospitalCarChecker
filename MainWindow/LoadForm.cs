using ConfigurationApplication;
using MetroFramework.Controls;
using StyleConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class LoadForm : MetroFramework.Forms.MetroForm
    {
        public string Password { get; private set; }
        IniFile config = new IniFile("connection.ini");
        public LoadForm()
        {
            InitializeComponent();
            InitializeConfig();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            this.TextBox_Password.UseSystemPasswordChar = true;
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            try
            {              
                if (HelpTools.CheckBoxesOnEmpty(this.Controls.OfType<MetroTextBox>()))
                {
                    if (IsConnected())
                    {
                        config.Write(string.IsInterned("Server"), string.IsInterned("Name"), this.TextBox_ServerName.Text);
                        config.Write(string.IsInterned("Server"), string.IsInterned("Port"), this.TextBox_ServerPort.Text);
                        config.Write(string.IsInterned("Server"), string.IsInterned("Login"), this.TextBox_Login.Text);
                        config.Write(string.IsInterned("Server"), string.IsInterned("InitialCatalog"), this.TextBox_InitialCatalog.Text);
                        Password = this.TextBox_Password.Text;
                        MetroFramework.MetroMessageBox.Show(this, "Сохранение прошло успешно", string.Intern("Успех"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Невозможно сохранить, ошибка подключения", string.Intern("Ошибка"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", string.Intern("Ошибка"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, string.Intern("Ошибка"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsConnected()
        {
           return   SqlProcessing.SqlWorker.TestConnection(SqlProcessing.SqlWorker.FormatConnectionString(
                    this.TextBox_ServerName.Text,
                    int.Parse(this.TextBox_ServerPort.Text),
                    this.TextBox_InitialCatalog.Text,
                    this.TextBox_Login.Text,
                    this.TextBox_Password.Text));
        }
        private void TestConnection()
        {
            if (IsConnected())
                MetroFramework.MetroMessageBox.Show(this, "Соединение успешно", string.Intern("Успех"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "Подключение к серверу неудачно", string.Intern("Ошибка"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Button_CheckConnection_Click(object sender, EventArgs e)
        {
            try
            {
                TestConnection();
            }
            catch (FormatException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, string.Intern("Ошибка"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void TextBox_ServerPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TilePassword_Click(object sender, EventArgs e)
        {
            if (TextBox_Password.UseSystemPasswordChar)            
                this.TextBox_Password.UseSystemPasswordChar = false;            
            else            
                this.TextBox_Password.UseSystemPasswordChar = true;            
        }


    }
}
