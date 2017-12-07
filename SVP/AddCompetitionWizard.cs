using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            gbPriceAward.Enabled = true;
            gbCompetition.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myCompetition = null;
            this.Close();
        }

        private void AddCompetitionWizardNew_Load(object sender, EventArgs e)
        {
            if (myCompetition != null)
            {
                txtCompetitionName.Text = myCompetition.Name;
                rbGroupCompetition.Checked = myCompetition is GroupCompetition;
                rbGroupCompetition.Enabled = false;
                reloadControls();
            }
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    cbProfile.Items.AddRange(context.Profiles.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Laden der Profile\r\n{0}", ex.Message));
            }
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            if (txtPriceName.Text.Length <= 0)
            {
                MessageBox.Show("Bitte einen Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbProfile.SelectedIndex < 0)
            {
                MessageBox.Show("Bitte ein Profil auswählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Price p = new Price() { Name = txtPriceName.Text };
            p.Profile = ((Profile)cbProfile.SelectedItem);
            myCompetition.Prices.Add(p);
            cbProfile.SelectedIndex = -1;
            txtPriceName.Text = "";
            reloadControls();
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            if (txtAwardName.Text.Length <= 0)
            {
                MessageBox.Show("Bitte einen Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            myCompetition.Awards.Add(new Award() { Name = txtAwardName.Text });
            txtAwardName.Text = "";
            reloadControls();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCompetitionName.Text.Length == 0)
            {
                MessageBox.Show("Bitte einen Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbGroupCompetition.Checked)
                myCompetition = new GroupCompetition();
            else
                myCompetition = new SingleCompetition();
            myCompetition.Name = txtCompetitionName.Text;
            gbPriceAward.Enabled = true;
            gbCompetition.Enabled = false;
        }

        private void reloadControls()
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.myCompetition == null)
            {
                MessageBox.Show("Bitte Pokalschießen anlegen!");
                return;
            }
            if((this.myCompetition.Awards.Count + this.myCompetition.Prices.Count) == 0)
            {
                MessageBox.Show("Bitte Ehrenscheiben/Preise anlegen!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
