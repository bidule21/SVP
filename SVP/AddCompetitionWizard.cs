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
        private competition myCompetition;
        public competition Competition { get { return myCompetition; } }
        public AddCompetitionWizard()
        {
            InitializeComponent();
        }

        public AddCompetitionWizard(competition competition)
        {
            InitializeComponent();
            myCompetition = competition;
        }

        private void startPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (txtCompetitionName.Text.Length == 0)
                e.Cancel = true;
            else
            {
                myCompetition = new competition();
                myCompetition.group_competition = rbGroupCompetition.Checked;
                myCompetition.name = txtCompetitionName.Text;
            }
        }

        private void addPricePage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if(txtPriceName.Text.Length > 0 && cbEvaluation.SelectedIndex >= 0)
            {
                price p = new price() { name = txtPriceName.Text };
                p.evaluation_id = ((evaluation)cbEvaluation.SelectedItem).id;
                myCompetition.price.Add(p);
                cbEvaluation.SelectedIndex = -1;
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
                myCompetition.award.Add(new award() { name = txtAwardName.Text });
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
            foreach (award a in myCompetition.award)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                dvCompetition.Rows.Add(row);
            }
            foreach (price p in myCompetition.price)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                dvCompetition.Rows.Add(row);
            }
        }

        private void AddCompetitionWizard_Load(object sender, EventArgs e)
        {
            if(myCompetition != null)
            {
                wizardControl1.NextPage(competitionOverviewPage);
            }
            using (svpEntities context = new svpEntities())
            {
                cbEvaluation.Items.AddRange(context.evaluation.ToArray());
            }
        }
    }
}
