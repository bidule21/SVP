using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisagLib;
using System.Linq.Expressions;

namespace SVP
{
    public partial class TabCompetition : UserControl
    {
        private Competition currentCompetition;
        public TabCompetition()
        {
            InitializeComponent();
        }
        private void reload_Controls()
        {
            cbClubGroup.Items.Clear();
            cbPrice.Items.Clear();
            dvCompetition.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                foreach (var p in context.Profiles)
                {
                    cbPrice.Items.Add(new ComboboxItem(p.Name, p.Id));
                }

                gbCompetition.Enabled = (currentCompetition != null);
                gbMember.Enabled = (currentCompetition != null);
                if (currentCompetition != null)
                {
                    lblCompetitionName.Text = currentCompetition.Name;
                    dvCompetition.Rows.Clear();
                    foreach (Award a in currentCompetition.Awards)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                        dvCompetition.Rows.Add(row);
                    }
                    foreach (Price p in currentCompetition.Prices)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                        dvCompetition.Rows.Add(row);
                    }
                    if (currentCompetition.GetType() == typeof(GroupCompetition))
                    {
                        lblClubGroup.Text = "Gruppe: ";
                        btnNewClubGroup.Text = "Neue Gruppe";
                        cbClubGroup.Items.AddRange(context.Participants.OfType<Group>().Where(x => x.GroupCompetition.Id == currentCompetition.Id).OrderBy(x => x.Name).ToArray());
                    }
                    else
                    {
                        lblClubGroup.Text = "Verein: ";
                        btnNewClubGroup.Text = "Neuer Verein";
                        cbClubGroup.Items.AddRange(context.Clubs.OrderBy(x => x.Name).ToArray());
                    }
                }
            }
        }


        private List<RMResult> readShots(string profile)
        {
            DISAGRM machine = new DISAGRM();
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => machine.GetShots(profile));
                ta.Wait(30000); //30 Sec
                if (ta.IsCompleted)
                    return ta.Result;
                else
                    throw new Exception("Die Maschine hat nicht schnell genug geantwortet");
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim einlesen der Ergebnisse:\r\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                machine.Stop();
            }
            return null;
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddUserWizard wizard = new AddUserWizard();
            wizard.ShowDialog();
            cbClub_SelectedIndexChanged(null, null);
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            if (currentCompetition.GetType() != typeof(GroupCompetition))
            {
                AddClubWizard wizard = new AddClubWizard();
                wizard.ShowDialog();
            }
            else
            {
                AddGroupWizard wizard = new AddGroupWizard(currentCompetition);
                wizard.ShowDialog();
            }
            reload_Controls();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClubGroup.SelectedIndex >= 0)
            {
                cbMember.Items.Clear();
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    if (currentCompetition.GetType() == typeof(GroupCompetition))
                    {
                        var group = context.Participants.Include("member").OfType<Group>().First(x => x.Id == ((Group)(cbClubGroup.SelectedItem)).Id);
                        foreach (Member m in group.Member.OrderBy(x => x.Name))
                            cbMember.Items.Add(m);
                    }
                    else
                    {
                        foreach (Member m in context.Participants.OfType<Member>().Where(x => x.Club.Id == ((Club)(cbClubGroup.SelectedItem)).Id).OrderBy(x => x.Name)
                            cbMember.Items.Add(m);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
            {
                gbRead.Enabled = true;
                btnRead.Enabled = true;
                lblClub.Text = cbClubGroup.SelectedItem.ToString();
                lblMember.Text = cbMember.SelectedItem.ToString();
                cbPrice.Items.Clear();
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    foreach (var price in currentCompetition.Prices)
                    {
                        bool hasShotYet = false;
                        var sequences = context.Prices.Include("Sequences").First(x => x.Id == price.Id).Sequences;
                        foreach (var sequence in sequences)
                            if (sequence.Member.Id == ((Member)cbMember.SelectedItem).Id)
                                hasShotYet = true;
                        if (!hasShotYet)
                            cbPrice.Items.Add(price);
                    }
                }
                if(cbPrice.Items.Count > 0)
                    cbPrice.SelectedIndex = 0;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cbPrice.SelectedIndex < 0)
                return;
            btnRead.Enabled = false;
            pBar.Visible = true;
            cbPrice.Enabled = false;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                Profile profile = ((Price)cbPrice.SelectedItem).Profile;
                System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => Common.readFakeShots(profile.Value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    pBar.Visible = false;
                    cbPrice.Enabled = true;
                    btnRead.Enabled = true;
                    return;
                }
                
                Sequence sequence = new Sequence();
                sequence.Date = DateTime.Now;
                sequence.Member = ((Member)cbMember.SelectedItem);
                sequence.Profile = profile;
                sequence.Price = ((Price)cbPrice.SelectedItem);
                context.Participants.Attach(sequence.Member);
                context.Profiles.Attach(sequence.Profile);
                context.Prices.Attach(sequence.Price);
                cbPrice.Items.Remove(cbPrice.SelectedItem);
                foreach (RMResult result in ta.Result)
                {
                    Shot s = new Shot();
                    s.Value = result.Rings;
                    s.Angle = result.Angle;
                    s.FactorValue = result.FactorValue;
                    s.ShotNumber = (short)result.ShotNumber;
                    s.Valid = (result.Validity == ValidFlag.Valid);
                    sequence.Shots.Add(s);
                }
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.Id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(s => s.Value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Profile.ToString() });
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = sequence });

                dvResults.Rows.Add(row);
                context.Sequences.Add(sequence);
                context.SaveChanges();
                gbRead.Enabled = (cbPrice.Items.Count > 0);
                btnRead.Enabled = true;
                pBar.Visible = false;
                cbPrice.Enabled = true;
            }
        }

        private void TabTraining_Load(object sender, EventArgs e)
        {
            reload_Controls();
        }

        private void btnCreateCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard();
            if (wizard.ShowDialog() == DialogResult.OK && wizard.Competition != null)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    foreach (var price in wizard.Competition.Prices)
                        context.Profiles.Attach(price.Profile);
                    context.Competitions.Add(wizard.Competition);
                    context.SaveChanges();

                    currentCompetition = context.Competitions.Include("Prices.Profile").Where(x => x.Id == wizard.Competition.Id).FirstOrDefault();
                }
                reload_Controls();
            }
        }

        private void btnContinueCompetition_Click(object sender, EventArgs e)
        {
            frmChooseCompetition choose = new frmChooseCompetition();
            choose.ShowDialog();
            if (choose.Competition == null)
                return;
            currentCompetition = choose.Competition;
            foreach (Price p in currentCompetition.Prices)
                foreach (Sequence s in p.Sequences)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = s.Id;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Member.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Shots.Sum(shot => shot.Value) });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Profile.ToString() });
                    row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = s });

                    dvResults.Rows.Add(row);
                }
            reload_Controls();
        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard(this.currentCompetition);
            if (wizard.ShowDialog() == DialogResult.OK)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    context.SaveChanges(); //ToDo: Check if this is right.

                }
                reload_Controls();
            }
        }

        private void btnEndCompetition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Willst du das Pokalschießen wirklich beenden? Ein weiteres fortführen ist nicht möglich.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    bool allWinnersSet = true;
                    foreach (Price p in currentCompetition.Prices)
                    {
                        frmDetermineWinner frmwinner = new frmDetermineWinner(p);
                        frmwinner.ShowDialog();
                        Price price = context.Prices.Find(p.Id);
                        allWinnersSet = allWinnersSet & (price.Winner != null);
                    }
                    //ToDo Set Award Winner
                    if(allWinnersSet)
                    {
                        Competition comp = context.Competitions.Find(currentCompetition.Id);
                        comp.Finished = true;
                        context.SaveChanges();
                        currentCompetition = null;
                        reload_Controls();
                    }
                }
            }
        }

        private void dvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Monitor.GetMonitor().DisplaySequence((Sequence)dvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfile.Text = ((Price)cbPrice.SelectedItem).Profile.ToString();
        }
    }
}
