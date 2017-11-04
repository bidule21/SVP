using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace SVP
{
    public partial class TabShowMember : UserControl
    {
        public TabShowMember()
        {
            InitializeComponent();
        }

        private void reloadContorls()
        {
            cbClub.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbClub.Items.AddRange(context.Clubs.ToArray());
            }
        }

        private void TabShowCompetition_Load(object sender, EventArgs e)
        {
            reloadContorls();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex >= 0)
                LoadMember(((Member)cbMember.SelectedItem).Id);
        }

        internal void LoadMember(int memberId)
        {
            dvResults.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var member = context.Participants.OfType<Member>().First(x => x.Id == memberId);
                foreach (Sequence s in member.Sequences)
                {
                    if (s.PreviousSequence != null)
                        continue;
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Date.ToShortDateString() });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = (s.Price == null) ? "" : s.Price.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Profile.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = s.Shots.Sum(x => x.Value) });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = (s.NextSequence == null) ? "" : s.NextSequence.Shots.Sum(x => x.Value).ToString() });
                    dvResults.Rows.Add(row);
                }
                foreach (Price p in member.PricesWon)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Competition.Date.ToShortDateString() });
                    dvAwards.Rows.Add(row);
                }
                foreach (Award a in member.Awards)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe" });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Competition.Date.ToShortDateString() });
                    dvAwards.Rows.Add(row);
                }
            }
        }

        private void TabShowCompetition_Enter(object sender, EventArgs e)
        {
            reloadContorls();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex < 0)
                return;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "Excel-Datei|*.xlsx";
            var member = ((Member)cbMember.SelectedItem);
            sfd.FileName = DateTime.Now.Date.ToShortDateString() + member.Firstname + " " + member.Name;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    member = context.Participants.OfType<Member>().First(x => x.Id == member.Id);
                    ExcelPackage pckg = new ExcelPackage(new System.IO.FileInfo(sfd.FileName), new System.IO.FileInfo(System.IO.Path.Combine(Application.StartupPath, SVP.Properties.Settings.Default.ExcelTemplate)));
                    pckg.Workbook.Names["TITEL"].Value = "Auswertung für " + member.Firstname + " " + member.Name;
                    pckg.Workbook.Names["Date"].Value = DateTime.Now.Date.ToShortDateString();
                    int row = pckg.Workbook.Names["HeaderStart"].Start.Row;
                    int column = pckg.Workbook.Names["HeaderStart"].Start.Column;
                    int shotCount = 10;
                    int i;
                    for (i = 0; i < shotCount; i++)
                    {
                        pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = (i + 1) + ".";
                        pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                    }
                    pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = "Summe";
                    pckg.Workbook.Worksheets[1].Cells[row, column + i + 1].Value = "Pokal";
                    pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                    pckg.Workbook.Worksheets[1].Cells[row, column + i + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    pckg.Workbook.Worksheets[1].Cells[row, column + i + 1].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                    row++;
                    foreach (Sequence s in member.Sequences)
                    {
                        for (i = 0; i < s.Shots.Count; i++)
                        {
                            if (s.NextSequence == null)
                                pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = s.Shots.ElementAt(i).Value.ToString();
                            else
                                pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = s.Shots.ElementAt(i).Value.ToString() + " (" + s.NextSequence.Shots.ElementAt(i).Value.ToString() + ")";
                            pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                            pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        }
                        if (s.NextSequence == null)
                            pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = s.Shots.Sum(x => x.Value);
                        else
                            pckg.Workbook.Worksheets[1].Cells[row, column + i].Value = s.Shots.Sum(x => x.Value) + " (" + s.NextSequence.Shots.Sum(x => x.Value) + ")";
                        pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                        pckg.Workbook.Worksheets[1].Cells[row, column + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        if (s.Price != null)
                            pckg.Workbook.Worksheets[1].Cells[row, column + 1 + i].Value = s.Price.Name;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1 + i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1 + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        row++;
                    }
                    row++;
                    if (member.Awards.Count > 0)
                    {
                        pckg.Workbook.Worksheets[1].Cells[row, column, row, column + 4].Merge = true;
                        pckg.Workbook.Worksheets[1].Cells[row, column].Value = "Ehrenscheiben";
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Font.Bold = true;
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Font.Size = 16;
                        row++;
                        pckg.Workbook.Worksheets[1].Cells[row, column].Value = "Pokalschießen";
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Font.Bold = true;
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Value = "Ehrenscheibe";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Font.Bold = true;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Value = "Datum";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Font.Bold = true;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        row++;
                    }
                    
                    foreach (Award a in member.Awards)
                    {
                        pckg.Workbook.Worksheets[1].Cells[row, column].Value = a.Competition.Name;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Value = a.Name;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Value = a.Competition.Date.Date.ToShortDateString();
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        row++;
                    }
                    pckg.Workbook.Worksheets[1].Cells.AutoFitColumns();
                    pckg.Save();
                    MessageBox.Show("Export erfolgreich!");
                }
            }
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMember.Items.Clear();
            cbMember.SelectedIndex = -1;
            int clubId = ((Club)cbClub.SelectedItem).Id;
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbMember.Items.AddRange(context.Participants.OfType<Member>().Where(x => x.Club.Id == clubId).ToArray());
            }
        }

        private void btn_editMember_Click(object sender, EventArgs e)
        {
            frmUserWizard wizard = new frmUserWizard(((Member)cbMember.SelectedItem));
            wizard.Show();
        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = cbMember.SelectedIndex >= 0;
            btn_editMember.Enabled = btnLoad.Enabled;
        }
    }
}
