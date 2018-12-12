using ConfigurationApplication;

namespace MainWindow
{
    partial class LoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Initializing

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.label_ServerName = new MetroFramework.Controls.MetroLabel();
            this.label_ServerPort = new MetroFramework.Controls.MetroLabel();
            this.TextBox_ServerName = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_ServerPort = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Login = new MetroFramework.Controls.MetroTextBox();
            this.Label_Login = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.Label_Password = new MetroFramework.Controls.MetroLabel();
            this.TextBox_InitialCatalog = new MetroFramework.Controls.MetroTextBox();
            this.Label_InitialCatalog = new MetroFramework.Controls.MetroLabel();
            this.Button_Apply = new MetroFramework.Controls.MetroButton();
            this.Button_Cancel = new MetroFramework.Controls.MetroButton();
            this.Button_CheckConnection = new MetroFramework.Controls.MetroButton();
            this.TilePassword = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label_ServerName
            // 
            this.label_ServerName.AutoSize = true;
            this.label_ServerName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_ServerName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_ServerName.Location = new System.Drawing.Point(33, 88);
            this.label_ServerName.Name = "label_ServerName";
            this.label_ServerName.Size = new System.Drawing.Size(123, 25);
            this.label_ServerName.TabIndex = 2;
            this.label_ServerName.Text = "Имя сервера:";
            // 
            // label_ServerPort
            // 
            this.label_ServerPort.AutoSize = true;
            this.label_ServerPort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_ServerPort.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_ServerPort.Location = new System.Drawing.Point(33, 117);
            this.label_ServerPort.Name = "label_ServerPort";
            this.label_ServerPort.Size = new System.Drawing.Size(58, 25);
            this.label_ServerPort.TabIndex = 3;
            this.label_ServerPort.Text = "Порт:";
            // 
            // TextBox_ServerName
            // 
            // 
            // 
            // 
            this.TextBox_ServerName.CustomButton.Image = null;
            this.TextBox_ServerName.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TextBox_ServerName.CustomButton.Name = "";
            this.TextBox_ServerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_ServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_ServerName.CustomButton.TabIndex = 1;
            this.TextBox_ServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_ServerName.CustomButton.UseSelectable = true;
            this.TextBox_ServerName.CustomButton.Visible = false;
            this.TextBox_ServerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_ServerName.Lines = new string[0];
            this.TextBox_ServerName.Location = new System.Drawing.Point(162, 90);
            this.TextBox_ServerName.MaxLength = 100;
            this.TextBox_ServerName.Name = "TextBox_ServerName";
            this.TextBox_ServerName.PasswordChar = '\0';
            this.TextBox_ServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_ServerName.SelectedText = "";
            this.TextBox_ServerName.SelectionLength = 0;
            this.TextBox_ServerName.SelectionStart = 0;
            this.TextBox_ServerName.ShortcutsEnabled = true;
            this.TextBox_ServerName.Size = new System.Drawing.Size(214, 23);
            this.TextBox_ServerName.TabIndex = 4;
            this.TextBox_ServerName.UseSelectable = true;
            this.TextBox_ServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_ServerName.WaterMarkFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // TextBox_ServerPort
            // 
            // 
            // 
            // 
            this.TextBox_ServerPort.CustomButton.Image = null;
            this.TextBox_ServerPort.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TextBox_ServerPort.CustomButton.Name = "";
            this.TextBox_ServerPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_ServerPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_ServerPort.CustomButton.TabIndex = 1;
            this.TextBox_ServerPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_ServerPort.CustomButton.UseSelectable = true;
            this.TextBox_ServerPort.CustomButton.Visible = false;
            this.TextBox_ServerPort.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_ServerPort.Lines = new string[0];
            this.TextBox_ServerPort.Location = new System.Drawing.Point(162, 119);
            this.TextBox_ServerPort.MaxLength = 100;
            this.TextBox_ServerPort.Name = "TextBox_ServerPort";
            this.TextBox_ServerPort.PasswordChar = '\0';
            this.TextBox_ServerPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_ServerPort.SelectedText = "";
            this.TextBox_ServerPort.SelectionLength = 0;
            this.TextBox_ServerPort.SelectionStart = 0;
            this.TextBox_ServerPort.ShortcutsEnabled = true;
            this.TextBox_ServerPort.Size = new System.Drawing.Size(214, 23);
            this.TextBox_ServerPort.TabIndex = 5;
            this.TextBox_ServerPort.UseSelectable = true;
            this.TextBox_ServerPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_ServerPort.WaterMarkFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_ServerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ServerPort_KeyPress);
            // 
            // TextBox_Login
            // 
            // 
            // 
            // 
            this.TextBox_Login.CustomButton.Image = null;
            this.TextBox_Login.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TextBox_Login.CustomButton.Name = "";
            this.TextBox_Login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Login.CustomButton.TabIndex = 1;
            this.TextBox_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Login.CustomButton.UseSelectable = true;
            this.TextBox_Login.CustomButton.Visible = false;
            this.TextBox_Login.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_Login.Lines = new string[0];
            this.TextBox_Login.Location = new System.Drawing.Point(162, 168);
            this.TextBox_Login.MaxLength = 100;
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.PasswordChar = '\0';
            this.TextBox_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Login.SelectedText = "";
            this.TextBox_Login.SelectionLength = 0;
            this.TextBox_Login.SelectionStart = 0;
            this.TextBox_Login.ShortcutsEnabled = true;
            this.TextBox_Login.Size = new System.Drawing.Size(214, 23);
            this.TextBox_Login.TabIndex = 7;
            this.TextBox_Login.UseSelectable = true;
            this.TextBox_Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Login.WaterMarkFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Login.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_Login.Location = new System.Drawing.Point(33, 166);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(66, 25);
            this.Label_Login.TabIndex = 6;
            this.Label_Login.Text = "Логин:";
            // 
            // TextBox_Password
            // 
            // 
            // 
            // 
            this.TextBox_Password.CustomButton.Image = null;
            this.TextBox_Password.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.TextBox_Password.CustomButton.Name = "";
            this.TextBox_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Password.CustomButton.TabIndex = 1;
            this.TextBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Password.CustomButton.UseSelectable = true;
            this.TextBox_Password.CustomButton.Visible = false;
            this.TextBox_Password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_Password.IconRight = true;
            this.TextBox_Password.Lines = new string[0];
            this.TextBox_Password.Location = new System.Drawing.Point(162, 197);
            this.TextBox_Password.MaxLength = 100;
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '\0';
            this.TextBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.SelectionLength = 0;
            this.TextBox_Password.SelectionStart = 0;
            this.TextBox_Password.ShortcutsEnabled = true;
            this.TextBox_Password.Size = new System.Drawing.Size(171, 23);
            this.TextBox_Password.TabIndex = 9;
            this.TextBox_Password.UseSelectable = true;
            this.TextBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Password.WaterMarkFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Password.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_Password.Location = new System.Drawing.Point(33, 195);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(78, 25);
            this.Label_Password.TabIndex = 8;
            this.Label_Password.Text = "Пароль:";
            // 
            // TextBox_InitialCatalog
            // 
            // 
            // 
            // 
            this.TextBox_InitialCatalog.CustomButton.Image = null;
            this.TextBox_InitialCatalog.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TextBox_InitialCatalog.CustomButton.Name = "";
            this.TextBox_InitialCatalog.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_InitialCatalog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_InitialCatalog.CustomButton.TabIndex = 1;
            this.TextBox_InitialCatalog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_InitialCatalog.CustomButton.UseSelectable = true;
            this.TextBox_InitialCatalog.CustomButton.Visible = false;
            this.TextBox_InitialCatalog.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_InitialCatalog.IconRight = true;
            this.TextBox_InitialCatalog.Lines = new string[0];
            this.TextBox_InitialCatalog.Location = new System.Drawing.Point(162, 237);
            this.TextBox_InitialCatalog.MaxLength = 100;
            this.TextBox_InitialCatalog.Name = "TextBox_InitialCatalog";
            this.TextBox_InitialCatalog.PasswordChar = '\0';
            this.TextBox_InitialCatalog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_InitialCatalog.SelectedText = "";
            this.TextBox_InitialCatalog.SelectionLength = 0;
            this.TextBox_InitialCatalog.SelectionStart = 0;
            this.TextBox_InitialCatalog.ShortcutsEnabled = true;
            this.TextBox_InitialCatalog.Size = new System.Drawing.Size(214, 23);
            this.TextBox_InitialCatalog.TabIndex = 11;
            this.TextBox_InitialCatalog.UseSelectable = true;
            this.TextBox_InitialCatalog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_InitialCatalog.WaterMarkFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Label_InitialCatalog
            // 
            this.Label_InitialCatalog.AutoSize = true;
            this.Label_InitialCatalog.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_InitialCatalog.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_InitialCatalog.Location = new System.Drawing.Point(33, 235);
            this.Label_InitialCatalog.Name = "Label_InitialCatalog";
            this.Label_InitialCatalog.Size = new System.Drawing.Size(117, 25);
            this.Label_InitialCatalog.TabIndex = 10;
            this.Label_InitialCatalog.Text = "База данных:";
            // 
            // Button_Apply
            // 
            this.Button_Apply.Location = new System.Drawing.Point(196, 280);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(87, 43);
            this.Button_Apply.TabIndex = 12;
            this.Button_Apply.Text = "Сохранить";
            this.Button_Apply.UseSelectable = true;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(289, 280);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(87, 43);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Отмена";
            this.Button_Cancel.UseSelectable = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_CheckConnection
            // 
            this.Button_CheckConnection.Location = new System.Drawing.Point(33, 280);
            this.Button_CheckConnection.Name = "Button_CheckConnection";
            this.Button_CheckConnection.Size = new System.Drawing.Size(87, 43);
            this.Button_CheckConnection.TabIndex = 14;
            this.Button_CheckConnection.Text = "Проверка";
            this.Button_CheckConnection.UseSelectable = true;
            this.Button_CheckConnection.Click += new System.EventHandler(this.Button_CheckConnection_Click);
            // 
            // TilePassword
            // 
            this.TilePassword.ActiveControl = null;
            this.TilePassword.Location = new System.Drawing.Point(339, 192);
            this.TilePassword.Name = "TilePassword";
            this.TilePassword.Size = new System.Drawing.Size(37, 28);
            this.TilePassword.TabIndex = 15;
            this.TilePassword.TileImage = ((System.Drawing.Image)(resources.GetObject("TilePassword.TileImage")));
            this.TilePassword.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TilePassword.UseCustomBackColor = true;
            this.TilePassword.UseSelectable = true;
            this.TilePassword.UseTileImage = true;
            this.TilePassword.Click += new System.EventHandler(this.TilePassword_Click);
            // 
            // LoadForm
            // 
            this.AcceptButton = this.Button_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(395, 340);
            this.Controls.Add(this.TilePassword);
            this.Controls.Add(this.Button_CheckConnection);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.TextBox_InitialCatalog);
            this.Controls.Add(this.Label_InitialCatalog);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.TextBox_ServerPort);
            this.Controls.Add(this.TextBox_ServerName);
            this.Controls.Add(this.label_ServerPort);
            this.Controls.Add(this.label_ServerName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoadForm";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.Text = "Настройки подключения";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeConfig()
        {
            this.TextBox_ServerName.Text = config.ReadINI("Server", "Name");

            if (config.KeyExists("Name", string.Intern("Server")))
                this.TextBox_ServerName.Text = config.ReadINI(string.IsInterned("Server"), "Name");
            if (config.KeyExists("Port", string.IsInterned("Server")))
                this.TextBox_ServerPort.Text = config.ReadINI(string.IsInterned("Server"), "Port");
            if (config.KeyExists("Login", string.IsInterned("Server")))
                this.TextBox_Login.Text = config.ReadINI(string.IsInterned("Server"), "Login");
            if (config.KeyExists("InitialCatalog", string.IsInterned("Server")))
                this.TextBox_InitialCatalog.Text = config.ReadINI(string.IsInterned("Server"), "InitialCatalog");
        }
        #endregion

        private MetroFramework.Controls.MetroLabel label_ServerName;
        private MetroFramework.Controls.MetroLabel label_ServerPort;
        private MetroFramework.Controls.MetroTextBox TextBox_ServerName;
        private MetroFramework.Controls.MetroTextBox TextBox_ServerPort;
        private MetroFramework.Controls.MetroTextBox TextBox_Login;
        private MetroFramework.Controls.MetroLabel Label_Login;
        private MetroFramework.Controls.MetroTextBox TextBox_Password;
        private MetroFramework.Controls.MetroLabel Label_Password;
        private MetroFramework.Controls.MetroTextBox TextBox_InitialCatalog;
        private MetroFramework.Controls.MetroLabel Label_InitialCatalog;
        private MetroFramework.Controls.MetroButton Button_Apply;
        private MetroFramework.Controls.MetroButton Button_Cancel;
        private MetroFramework.Controls.MetroButton Button_CheckConnection;
        private MetroFramework.Controls.MetroTile TilePassword;
    }
}