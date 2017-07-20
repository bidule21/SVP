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
    public partial class AddClubWizard : Form
    {
        public AddClubWizard()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtClubName.TextLength <= 0)
            {
                MessageBox.Show("Bitte einen Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    Club newClub = new Club();
                    newClub.Name = txtClubName.Text;
                    context.Clubs.Add(newClub);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler beim Speichern des Mitglieds\r\n{0}", ex.Message));
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
