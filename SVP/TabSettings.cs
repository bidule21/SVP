using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVP
{
    public partial class TabSettings : UserControl
    {
        public TabSettings()
        {
            InitializeComponent();
        }

        private void btnManageProfile_Click(object sender, EventArgs e)
        {
            ProfileWizard wizard = new ProfileWizard();
            wizard.ShowDialog();
        }

		private void rbDisplay_CheckedChanged(object sender, EventArgs e)
		{
			btnApplayDisplaySetting.Enabled = true;
		}

		private void btnApplayDisplaySetting_Click(object sender, EventArgs e)
		{
			if (rbDisplayEverything.Checked)
				Monitor.GetMonitor().SetDisplaySetting(DisplaySetting.Everything);
			else if (rbDisplayEverythingAnonym.Checked)
				Monitor.GetMonitor().SetDisplaySetting(DisplaySetting.EverythingAnonym);
			else if (rbDisplayShotImageWithPoints.Checked)
				Monitor.GetMonitor().SetDisplaySetting(DisplaySetting.ShotImageWithPoints);
			else if (rbDisplayShotImage.Checked)
				Monitor.GetMonitor().SetDisplaySetting(DisplaySetting.ShotImage);
		}
	}
}
