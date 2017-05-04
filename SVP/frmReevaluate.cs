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
        private Price price;
        public frmReevaluate(Price p)
        {
            InitializeComponent();
            price = p;
        }

        private void reloadControls()
        {
            cbProfile.Items.Clear();
            cbMember.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbProfile.Items.AddRange(context.Profiles.Where(x => x.Id != price.Profile.Id).ToArray());
                var bestResult = context.Prices.Include("Sequence").FirstOrDefault(x => x.Id == price.Id).Sequences.Max(x => x.Shots.Sum(y => y.Value));
                var listWinnerSequences = context.Prices.Include("Sequence").Include("Member").FirstOrDefault(x => x.Id == price.Id).Sequences.Where(y => y.Shots.Sum(z => z.Value) == bestResult);
                foreach (Sequence s in listWinnerSequences)
                { 
                    //ToDo: Change Database Schema sequence <--> sequence
                    //if (s. != null)
                    //    continue;
                    //cbMember.Items.Add(s.member);
                }
            }
        }

        private void frmReevaluate_Load(object sender, EventArgs e)
        {
            reloadControls();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex < 0 || cbProfile.SelectedIndex < 0)
                return;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                Profile profile = context.Profiles.Where(x => x.Id == ((ComboboxItem)cbProfile.SelectedItem).Id).First();
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
                sequence.Member.Id = ((ComboboxItem)cbMember.SelectedItem).Id;
                sequence.Profile.Id= ((ComboboxItem)cbProfile.SelectedItem).Id;
                //ToDo add new Sequence to old Sequence and update controls
            }

        }
    }
}
