using ConfigurationApplication;
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
    public partial class OptionsForm_Configuration : MetroFramework.Forms.MetroForm
    {
        IniFile config = new IniFile();
        public OptionsForm_Configuration()
        {
            InitializeComponent();
            InitializeData();
            InitializeConfig();
        }

        private void OptionsForm_Configuration_Load(object sender, EventArgs e)
        {

        }

        private void TileCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TileSave_Click(object sender, EventArgs e)
        {
            StyleConfiguration.MetroConfiguration.SetStyle(this.ComboBox_Style.Text);
            config.Write(string.Intern("Interval"), string.Intern("Days"), this.numericDays.Value.ToString());
            config.Write(string.Intern("Interval"), string.Intern("Minutes"), this.numericMinutes.Value.ToString());
            config.Write(string.Intern("Interval"), string.Intern("Hours"), this.numericHours.Value.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
