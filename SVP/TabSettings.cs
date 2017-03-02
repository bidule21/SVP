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
    }
}
