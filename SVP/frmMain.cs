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
                foreach (var c in context.club)
                {
                    cbClub.Items.Add(new ComboboxItem(c.name, c.id));
                }
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
        }

        private void btnNewClub_Click(object sender, EventArgs e)
        {
            AddClubWizard wizard = new AddClubWizard();
            wizard.ShowDialog();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
