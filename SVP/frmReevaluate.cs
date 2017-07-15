using DisagLib;
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
    public partial class frmReevaluate : Form
    {
        private List<Sequence> sequences;
        private Price price;
        private Profile profile;
        public frmReevaluate(Price price, List<Sequence> sequences)
        {
            InitializeComponent();
            this.price = price;
            this.sequences = sequences;
        }
        void reloadMembers()
        {
            cbMember.Items.Clear();
            cbMember.SelectedIndex = -1;
            cbMember.Text = null;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                foreach (Sequence s in sequences)
                {
                    Sequence seq = context.Sequences.Find(s.Id);
                    if (seq.NextSequence == null)
                    {
                        var sequence = context.Sequences.Find(s.Id);
                        cbMember.Items.Add(sequence.Member);
                    }
                }
            }
            
            btnOk.Enabled = cbMember.Items.Count == 0;
        }
        private void reloadControls()
        {
            cbProfile.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbProfile.Items.AddRange(context.Profiles.Where(x => x.Id != price.Profile.Id).ToArray());
            }
            btnOk.Enabled = cbMember.Items.Count == 0;
            reloadMembers();
        }

        private void frmReevaluate_Load(object sender, EventArgs e)
        {
            reloadControls();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex < 0)
                return;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => Common.readShots(profile.Value));
                while (!ta.IsCompleted)
                {
                    Application.DoEvents();
                }
                if (ta.Result == null)
                {
                    pBar.Visible = false;
                    btnRead.Enabled = true;
                    return;
                }
                Sequence sequence = new Sequence();
                sequence.Date = DateTime.Now;
                sequence.Member = ((Member)cbMember.SelectedItem);
                sequence.Profile = this.profile;
                foreach(RMResult s in ta.Result)
                {
                    Shot shot = new Shot();
                    shot.Angle = s.Angle;
                    shot.FactorValue = s.FactorValue;
                    shot.ShotNumber = (short)s.ShotNumber;
                    shot.Valid = s.Validity == ValidFlag.Valid;
                    shot.Value = s.Rings;
                    sequence.Shots.Add(shot);
                }

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = sequence.Id;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Member.Name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.Shots.Sum(x => x.Value) });
                dvResults.Rows.Add(row);
                context.Participants.Attach(sequence.Member);
                context.Profiles.Attach(sequence.Profile);
                foreach(Sequence s in sequences)
                {
                    Sequence seq = context.Sequences.Find(s.Id);
                    if(seq.Member.Id == sequence.Member.Id)
                    {
                        seq.NextSequence = sequence;
                    }
                }
                context.SaveChanges();
            }
            reloadMembers();
        }

        private void btnSetProfile_Click(object sender, EventArgs e)
        {
            if(cbProfile.SelectedIndex >= 0)
            {
                this.profile = (Profile)cbProfile.SelectedItem;
                gbProfile.Enabled = false;
                gbRead.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
