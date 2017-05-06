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
    public partial class AddCompetitionWizard : Form
    {
        private Competition myCompetition;
        public Competition Competition { get { return myCompetition; } }
        public AddCompetitionWizard()
        {
            InitializeComponent();
        }

        public AddCompetitionWizard(Competition competition)
        {
            InitializeComponent();
            myCompetition = competition;
        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtCompetitionName.Text.Length == 0)
                e.Cancel = true;
            else if (myCompetition != null)
            {
                myCompetition.Name = txtCompetitionName.Text;
                startPage.NextPage = competitionOverviewPage;
            }
            else
            {
                if (rbGroupCompetition.Checked)
                    myCompetition = new GroupCompetition();
                else
                    myCompetition = new SingleCompetition();
                myCompetition.Name = txtCompetitionName.Text;
            }
        }

        private void addPricePage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(txtPriceName.Text.Length > 0 && cbProfile.SelectedIndex >= 0)
            {
                Price p = new Price() { Name = txtPriceName.Text };
                p.Profile = ((Profile)cbProfile.SelectedItem);
                myCompetition.Prices.Add(p);
                cbProfile.SelectedIndex = -1;
                txtPriceName.Text = "";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void addAwardPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtAwardName.Text.Length > 0)
            {
                myCompetition.Awards.Add(new Award() { Name = txtAwardName.Text });
                txtAwardName.Text = "";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void competitionOverviewPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbAddAward.Checked)
                competitionOverviewPage.NextPage = addAwardPage;
            else if (rbAddPrice.Checked)
                competitionOverviewPage.NextPage = addPricePage;
            else if (rbFinished.Checked)
                competitionOverviewPage.NextPage = null;
        }

        private void rbOverview_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddAward.Checked)
                competitionOverviewPage.NextPage = addAwardPage;
            else if (rbAddPrice.Checked)
                competitionOverviewPage.NextPage = addPricePage;
            else if (rbFinished.Checked)
                competitionOverviewPage.NextPage = null;
            competitionOverviewPage.IsFinishPage = rbFinished.Checked;
            wizardControl1.Update();
        }

        private void competitionOverviewPage_Enter(object sender, EventArgs e)
        {
            dvCompetition.Rows.Clear();
            foreach (Award a in myCompetition.Awards)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                dvCompetition.Rows.Add(row);
            }
            foreach (Price p in myCompetition.Prices)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                dvCompetition.Rows.Add(row);
            }
        }

        private void AddCompetitionWizard_Load(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbProfile.Items.AddRange(context.Profiles.ToArray());
            }
        }

        private void startPage_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            if (myCompetition != null)
            {
                txtCompetitionName.Text = myCompetition.Name;
                rbGroupCompetition.Checked = myCompetition is GroupCompetition;
                rbGroupCompetition.Enabled = false;
            }
        }

        private void wizardControl1_Cancelling(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myCompetition = null;
        }
    }
}
