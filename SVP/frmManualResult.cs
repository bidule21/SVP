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
    public partial class frmManualResult : Form
    {
        public Sequence Sequence { get; private set; }
        public frmManualResult(int shotCount)
        {
            InitializeComponent();
            for (int i = 1; i <= shotCount; i++)
                dgResults.Rows.Add(string.Format("Schuss {0}", i));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Sequence seq = new Sequence();
            seq.Date = DateTime.Now;
            short i = 0;
            foreach (DataGridViewRow row in dgResults.Rows)
            {
                i++;
                double val;
                if ((row.Cells[1].Value is null) || row.Cells[1].Value.Equals("") || !double.TryParse(row.Cells[1].Value.ToString(), out val))
                {
                    MessageBox.Show(string.Format("Konnte {0} nicht lesen!", row.Cells[0].Value.ToString()));
                    return;
                }
                else
                {
                    seq.Shots.Add(new Shot { ShotNumber = i, Value = val, Valid = true, });
                }
            }
            this.Sequence = seq;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
