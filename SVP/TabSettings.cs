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
			btnApplayDisplaySetting.Enabled = false;
			SVP.Properties.Settings.Default.MonitorDisplaySetting = Monitor.GetMonitor().DisplaySetting.ToString();
			SVP.Properties.Settings.Default.Save();
		}

		private void TabSettings_Load(object sender, EventArgs e)
		{
			switch (Monitor.GetMonitor().DisplaySetting)
			{
				case DisplaySetting.Everything:
					rbDisplayEverything.Checked = true;
					break;
				case DisplaySetting.EverythingAnonym:
					rbDisplayEverythingAnonym.Checked = true;
					break;
				case DisplaySetting.ShotImageWithPoints:
					rbDisplayShotImageWithPoints.Checked = true;
					break;
				case DisplaySetting.ShotImage:
					rbDisplayShotImage.Checked = true;
					break;
				default:
					rbDisplayEverything.Checked = true;
					break;
			}
            txtNews.Text = SVP.Properties.Settings.Default.News;
        }

        private void btnApplyNews_Click(object sender, EventArgs e)
        {
            SVP.Properties.Settings.Default.News = txtNews.Text;
            SVP.Properties.Settings.Default.Save();
            if (txtNews.Text.Equals(""))
                Monitor.GetMonitor().SetDisplayNews(null);
            else
                Monitor.GetMonitor().SetDisplayNews(txtNews.Text);
        }
    }
}
