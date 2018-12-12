namespace MainWindow
{
    using ConfigurationApplication;

    partial class OptionsForm_Configuration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm_Configuration));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.numericDays = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TileCancel = new MetroFramework.Controls.MetroTile();
            this.TileSave = new MetroFramework.Controls.MetroTile();
            this.ComboBox_Style = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(33, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(185, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Интервал для поиска";
            // 
            // numericDays
            // 
            this.numericDays.Location = new System.Drawing.Point(222, 146);
            this.numericDays.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericDays.Name = "numericDays";
            this.numericDays.Size = new System.Drawing.Size(65, 27);
            this.numericDays.TabIndex = 3;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(221, 212);
            this.numericMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(64, 27);
            this.numericMinutes.TabIndex = 4;
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(222, 179);
            this.numericHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(65, 27);
            this.numericHours.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(100, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Дни:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(100, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Часы:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(100, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Минуты:";
            // 
            // TileCancel
            // 
            this.TileCancel.ActiveControl = null;
            this.TileCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TileCancel.Location = new System.Drawing.Point(69, 245);
            this.TileCancel.Name = "TileCancel";
            this.TileCancel.Size = new System.Drawing.Size(106, 42);
            this.TileCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileCancel.TabIndex = 9;
            this.TileCancel.Text = "Выйти";
            this.TileCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileCancel.UseSelectable = true;
            this.TileCancel.UseStyleColors = true;
            this.TileCancel.Click += new System.EventHandler(this.TileCancel_Click);
            // 
            // TileSave
            // 
            this.TileSave.ActiveControl = null;
            this.TileSave.Location = new System.Drawing.Point(181, 245);
            this.TileSave.Name = "TileSave";
            this.TileSave.Size = new System.Drawing.Size(106, 42);
            this.TileSave.TabIndex = 10;
            this.TileSave.Text = "Сохранить";
            this.TileSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TileSave.UseSelectable = true;
            this.TileSave.Click += new System.EventHandler(this.TileSave_Click);
            // 
            // ComboBox_Style
            // 
            this.ComboBox_Style.FormattingEnabled = true;
            this.ComboBox_Style.ItemHeight = 23;
            this.ComboBox_Style.Location = new System.Drawing.Point(100, 91);
            this.ComboBox_Style.Name = "ComboBox_Style";
            this.ComboBox_Style.Size = new System.Drawing.Size(187, 29);
            this.ComboBox_Style.TabIndex = 11;
            this.ComboBox_Style.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(33, 95);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 25);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Стиль:";
            // 
            // OptionsForm_Configuration
            // 
            this.AcceptButton = this.TileSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.TileCancel;
            this.ClientSize = new System.Drawing.Size(315, 323);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.ComboBox_Style);
            this.Controls.Add(this.TileSave);
            this.Controls.Add(this.TileCancel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.numericHours);
            this.Controls.Add(this.numericMinutes);
            this.Controls.Add(this.numericDays);
            this.Controls.Add(this.metroLabel2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm_Configuration";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки приложения";
            this.Load += new System.EventHandler(this.OptionsForm_Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeData()
        {
            foreach (var i in System.Enum.GetValues(typeof(MetroFramework.MetroColorStyle)))
            {
                this.ComboBox_Style.Items.Add(i.ToString());
            }

            this.ComboBox_Style.Style = this.Style = StyleConfiguration.MetroConfiguration.ColorStyle;
            this.ComboBox_Style.Text = this.Style.ToString();
        }
        private void InitializeConfig()
        {
            if (config.KeyExists(string.Intern("Days"), string.Intern("Interval")))
            {
                this.numericDays.Value = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Days")));
            }
            if (config.KeyExists(string.Intern("Minutes"), string.Intern("Interval")))
            {
                this.numericMinutes.Value = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Minutes")));
            }
            if (config.KeyExists(string.Intern("Hours"), string.Intern("Interval")))
            {
                this.numericHours.Value = int.Parse(config.ReadINI(string.Intern("Interval"), string.Intern("Hours")));
            }
        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown numericDays;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile TileCancel;
        private MetroFramework.Controls.MetroTile TileSave;
        private MetroFramework.Controls.MetroComboBox ComboBox_Style;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}