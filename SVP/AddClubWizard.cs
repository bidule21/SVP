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
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    Club newClub = new Club();
                    newClub.Name = txtClubName.Text;
                    context.Clubs.Add(newClub);
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
