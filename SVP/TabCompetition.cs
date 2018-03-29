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
            dvResults.Rows.Clear();
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
                    foreach (Price p in currentCompetition.Prices)
                        foreach (Sequence s in p.Sequences)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Tag = s.Id;
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Member.ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Shots.Sum(shot => shot.Value) });
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Profile.ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Price.ToString() });
                            row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = s });

                            dvResults.Rows.Add(row);
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
            frmUserWizard wizard = new frmUserWizard();
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
                        foreach (Member m in context.Participants.OfType<Member>().Where(x => x.Club.Id == ((Club)(cbClubGroup.SelectedItem)).Id).OrderBy(x => x.Name))
                            cbMember.Items.Add(m);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0 && cbClubGroup.SelectedIndex >= 0)
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
                if (cbPrice.Items.Count > 0)
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
                Profile profile = context.Profiles.FirstOrDefault(x => x.Id == ((Price)cbPrice.SelectedItem).Profile.Id);
                Member member = context.Participants.OfType<Member>().First(x => x.Id == ((Member)cbMember.SelectedItem).Id);
                Price price = context.Prices.Find(((Price)cbPrice.SelectedItem).Id);
                ManualProfile manualProfile = context.Profiles.OfType<ManualProfile>().FirstOrDefault(x => x.Id == profile.Id);
                DisagProfile disagProfile = context.Profiles.OfType<DisagProfile>().FirstOrDefault(x => x.Id == profile.Id);
                Sequence sequence = null;
                if (disagProfile != null)
                {
                    System.Threading.Tasks.Task<List<RMResult>> ta = System.Threading.Tasks.Task.Factory.StartNew<List<RMResult>>(() => Common.readShots(disagProfile.Value));
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
                    sequence = new Sequence();
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

                }
                else if (manualProfile != null)
                {
                    frmManualResult manualResult = new frmManualResult(manualProfile.ShotCount);
                    if (manualResult.ShowDialog() != DialogResult.OK)
                    {
                        pBar.Visible = false;
                        cbPrice.Enabled = true;
                        btnRead.Enabled = true;
                        return;
                    }
                    sequence = manualResult.Sequence;
                }
                else
                {
                    throw new Exception("Found no matching Profile!");
                }
                sequence.Date = DateTime.Now;
                sequence.Member = member;
                sequence.Profile = profile;
                sequence.Price = price;

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.Id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(s => s.Value) });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Profile.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Price.ToString() });
                row.Cells.Add(new DataGridViewButtonCell() { UseColumnTextForButtonValue = true, Value = sequence });
                dvResults.Rows.Add(row);
                context.Sequences.Add(sequence);
                context.SaveChanges();
                Monitor.GetMonitor().AddSequence(context.Sequences.Include("Shots").First(x => x.Id == sequence.Id));
                cbPrice.Items.Remove(cbPrice.SelectedItem);
                if (cbPrice.Items.Count > 0)
                    cbPrice.SelectedIndex = 0;

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
                    wizard.Competition.Date = DateTime.Now;
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

            reload_Controls();
        }

        private void btnEditCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionWizard wizard = new AddCompetitionWizard(this.currentCompetition);
            if (wizard.ShowDialog() == DialogResult.OK)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    Competition c = context.Competitions.Find(wizard.Competition.Id);
                    c.Name = wizard.Competition.Name;
                    foreach (var price in wizard.Competition.Prices)
                    {
                        if (price.Id == 0)
                            c.Prices.Add(price);
                        else
                        {
                            Price p = context.Prices.Find(price.Id);
                            p.Name = price.Name;
                            p.Evaluation = p.Evaluation;
                        }
                    }
                    foreach (Award award in wizard.Competition.Awards)
                    {
                        if (award.Id == 0)
                            c.Awards.Add(award);
                        else
                        {
                            Award a = context.Awards.Find(award.Id);
                            a.Name = award.Name;
                        }
                    }
                    context.SaveChanges();

                }
                reload_Controls();
            }
        }

        private void btnEndCompetition_Click(object sender, EventArgs e)
        {
            //TODO: We are using a way to much contexts heres whe should reduce that to one
            if (MessageBox.Show("Willst du das Pokalschießen wirklich beenden? Ein weiteres fortführen ist nicht möglich.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bool allWinnersSet = true;
                foreach (Price p in currentCompetition.Prices)
                {
                    frmDetermineWinner frmwinner = new frmDetermineWinner(p);
                    frmwinner.ShowDialog();
                    using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                    {
                        Price price = context.Prices.Find(p.Id);
                        allWinnersSet = allWinnersSet & (price.Winner != null);
                    }
                }
                foreach (Award a in currentCompetition.Awards)
                {
                    frmChooseWinner frmWinner = new frmChooseWinner(a);
                    frmWinner.ShowDialog();
                    using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                    {
                        Award award = context.Awards.Find(a.Id);
                        allWinnersSet = allWinnersSet & (award.Winner != null);
                    }
                }
                if (allWinnersSet)
                {
                    using (SVPEntitiesContainer context = new SVPEntitiesContainer())
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
                Monitor.GetMonitor().AddSequence((Sequence)dvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, false);
            }
        }

        private void cbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProfile.Text = ((Price)cbPrice.SelectedItem).Profile.ToString();
        }
    }
}
