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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void reload_Controls()
        {
            cbClub.Items.Clear();
            cbProfile.Items.Clear();
            using (svpEntities context = new svpEntities())
            {
                cbClub.Items.AddRange(context.club.ToArray());
                foreach (var p in context.profile)
                {
                    cbProfile.Items.Add(new ComboboxItem(p.name, p.id));
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            reload_Controls();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddUserWizard wizard = new AddUserWizard();
            wizard.ShowDialog();
            cbClub_SelectedIndexChanged(null, null);
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            AddClubWizard wizard = new AddClubWizard();
            wizard.ShowDialog();
            reload_Controls();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClub.SelectedIndex >= 0)
            {
                using (svpEntities context = new svpEntities())
                {
                    cbMember.Items.Clear();
                    foreach (member m in context.member.Where(x => x.club_id == ((club)(cbClub.SelectedItem)).id))
                        cbMember.Items.Add(new ComboboxItem(m.ToString(), m.id));
                }
            }
        }
    }
}
