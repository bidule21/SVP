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
    public partial class frmDetermineWinner : Form
    {
        private price price;
        public frmDetermineWinner(price p)
        {
            InitializeComponent();
            this.Text += " " + p.name;
            this.price = p;
        }

        public frmDetermineWinner(award a)
        {
            InitializeComponent();
            this.Text += " " + a.name;
        }

        //TODO: swap member with participant to add group support
        private void frmDetermineWinner_Load(object sender, EventArgs e)
        {
            using (svpEntities context = new svpEntities())
            {
                var bestResult = context.price.Include("sequence").FirstOrDefault(x => x.id == price.id).sequence.Max(x => x.shot.Sum(y => y.value));
                int count = context.price.Include("sequence").FirstOrDefault(x => x.id == price.id).sequence.Where(x => x.shot.Sum(y => y.value) == bestResult).Count();
                int place = 1;
                foreach (var sequence in context.price.Include("sequence").Include("member").Include("shot").FirstOrDefault(x => x.id == price.id).sequence.OrderBy(x => x.shot.Sum(y => y.value)))
                {
                    bool reevaluateSeq = false;
                    sequence seq = (sequence.sequence1.Count() == 0) ? sequence : sequence.sequence1.First();
                    if(count > 1)
                    {
                        reevaluateSeq = true;
                    }else if (count < 1)
                    {
                        throw new Exception("Something really weird happend: found no Sequences with the Best Result");
                    }
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = sequence.id;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.member.name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = sequence.shot.Sum(x => x.value )});
                    row.Cells.Add(new DataGridViewCheckBoxCell() { Value = reevaluateSeq });
                    dvResultList.Rows.Add(row);
                }

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //TODO: reevaluate the checked Rows
        }
    }
}
