using DisagLib;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Web;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Net;

namespace SVP
{
    public partial class AddClubWizard : Form
    {
        public AddClubWizard()
        {
            InitializeComponent();
        }

        private void addClubPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtClubName.TextLength > 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    club newClub = new club();
                    newClub.name = txtClubName.Text;
                    newClub.isTemporary = cbClubTemporary.Checked;
                    context.club.Add(newClub);
                    context.SaveChanges();
                    txtClubName.Text = "";
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
