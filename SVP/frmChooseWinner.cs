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
    public partial class frmChooseWinner : Form
    {
        private Award award;

        public frmChooseWinner(Award award)
        {
            this.award = award;
            InitializeComponent();
        }

        private void frmChooseWinner_Load(object sender, EventArgs e)
        {
            lblName.Text = award.Name;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbClub.Items.AddRange(context.Clubs.ToArray());
            }
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex < 0)
                return;
            cbMember.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var club = context.Clubs.Find(((Club)cbClub.SelectedItem).Id);
                cbMember.Items.AddRange(club.Members.ToArray());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var a = context.Awards.Find(this.award.Id);
                var winner = context.Participants.Find(((Member)cbMember.SelectedItem).Id);
                a.Winner = (Member)winner;
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
