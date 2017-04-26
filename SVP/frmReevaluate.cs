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
        private price price;
        public frmReevaluate(price p)
        {
            InitializeComponent();
            price = p;
        }

        private void reloadControls()
        {
            cbProfile.Items.Clear();
            cbMember.Items.Clear();
            using (svpEntities context = new svpEntities())
            {
                cbProfile.Items.AddRange(context.profile.Where(x => x.id != price.profile_id).ToArray());
                var bestResult = context.price.Include("sequence").FirstOrDefault(x => x.id == price.id).sequence.Max(x => x.shot.Sum(y => y.value));
                var listWinnerSequences = context.price.Include("sequence").Include("member").FirstOrDefault(x => x.id == price.id).sequence.Where(y => y.shot.Sum(z => z.value) == bestResult);
                foreach (sequence s in listWinnerSequences)
                { 
                    if (s.sequence2 != null)
                        continue;
                    cbMember.Items.Add(s.member);
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
            using (svpEntities context = new svpEntities())
            {
                disagprofile profile = context.disagprofile.Where(x => x.profile_id == ((ComboboxItem)cbProfile.SelectedItem).Id).First();
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => Common.readShots(profile.value));
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
                sequence sequence = new sequence();
                sequence.date = DateTime.Now;
                sequence.member_id = ((ComboboxItem)cbMember.SelectedItem).Id;
                sequence.profile_id = ((ComboboxItem)cbProfile.SelectedItem).Id;
                //ToDo add new Sequence to old Sequence and update controls
            }

        }
    }
}
