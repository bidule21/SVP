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
        private int shotCount;
        private Label[] labels;
        private TextBox[] textboxes;
        private Profile profile;
        private Member member;
        public frmManualResult(Profile profile, Member member)
        {
            InitializeComponent();
            labels = new Label[shotCount];
            textboxes = new TextBox[shotCount];
            this.shotCount = 10; // Change to profile Value
            this.profile = profile;
            this.member = member;
            for (int i = 0;i< shotCount;i++)
            {
                int x = i % 10;
                int y = i / 10;
                labels[i] = new Label();
                labels[i].Text = (1 + i).ToString() + ". Schuss:";
                labels[i].Size = new Size(64, 13);
                labels[i].Location = new Point(10 + (100 * x), 100 + (50 * y));

                textboxes[i] = new TextBox();
                textboxes[i].Size = new Size(30, 20);
                textboxes[i].Location = new Point(74 + (100 * x), 97 + (50 * y));
                this.Controls.Add(labels[i]);
                this.Controls.Add(textboxes[i]);
            }
            int width = ((shotCount / 10) == 0) ? shotCount : 10;
            int height = (shotCount / 10) + 1;
            this.Size = new Size(30 + (100 * width), 160 + (50 * height));
            btnCancel.Location = new Point(this.Size.Width - 184, this.Size.Height - 74);
            btnOK.Location = new Point(this.Size.Width - 103, this.Size.Height - 74);
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
            seq.Member = this.member;
            for (short i = 0;i<this.shotCount;i++)
            {
                double val;
                if(this.textboxes[i].Text.Equals("") || !double.TryParse(this.textboxes[i].Text, out val))
                {
                    MessageBox.Show("Konnte Schuss Nr. " + (i + 1).ToString() + " nicht lesen!");
                    return;
                }else
                {
                    seq.Shots.Add(new Shot { ShotNumber = (short)(1 + i), Value = val, Valid = true,  });
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
