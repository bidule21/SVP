using DisagLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Monitor.GetMonitor().Show();
			DisplaySetting setting;
			if (!Enum.TryParse<DisplaySetting>(SVP.Properties.Settings.Default.MonitorDisplaySetting, out setting))
				setting = DisplaySetting.Everything;
			Monitor.GetMonitor().SetDisplaySetting(setting);
            tpCompetition.Controls[0].Enabled = false;
            this.Text = this.Text + " Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Möchtest du SVP wirklich beenden?", "Beenden", MessageBoxButtons.YesNo) == DialogResult.No);
        }
    }
}
