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
    public partial class TabShowCompetition : UserControl
    {
        public TabShowCompetition()
        {
            InitializeComponent();
        }

        private void reloadContorls()
        {
            cbCompetitions.Items.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                cbCompetitions.Items.AddRange(context.Competitions.ToArray());
            }
        }

        private void TabShowCompetition_Load(object sender, EventArgs e)
        {
            reloadContorls();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(cbCompetitions.SelectedIndex > 0)
                LoadCompetition(((Competition)cbCompetitions.SelectedItem).Id);
        }

        internal void LoadCompetition(int competitionID)
        {
            dvResults.Rows.Clear();
            using (SVPEntitiesContainer context = new SVPEntitiesContainer())
            {
                var competition = context.Competitions.Find(competitionID);
                foreach(Award a in competition.Awards)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = competition.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Ehrenscheibe"});
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = a.Winner });
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    dvResults.Rows.Add(row);
                }
                foreach(Price p in competition.Prices)
                {
                    int place = 1;
                    foreach (Sequence seq in p.Sequences.OrderByDescending(x => x.Shots.Sum(y => y.Value)).ThenByDescending(x => (x.NextSequence == null) ? 0 : x.NextSequence.Shots.Sum(y => y.Value)))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = competition.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Pokal" });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Name });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = place++ });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = seq.Member + ((p.Winner == seq.Member) ? " (Gewinner)" : "") });
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = seq.Shots.Sum(x => x.Value)});
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = (seq.NextSequence == null) ? "" : seq.NextSequence.Shots.Sum(x => x.Value).ToString() });
                        dvResults.Rows.Add(row);
                    }
                }
            }
        }

        private void TabShowCompetition_Enter(object sender, EventArgs e)
        {
            reloadContorls();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "Excel-Datei|*.xlsx";
            var competition = ((Competition)cbCompetitions.SelectedItem);
            sfd.FileName = "Pokalschießen " + competition.Date.ToShortDateString();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (SVPEntitiesContainer context = new SVPEntitiesContainer())
                {
                    competition = context.Competitions.Find(competition.Id);
                    if (competition is SingleCompetition)
                    {
                        ExcelPackage pckg = new ExcelPackage(new System.IO.FileInfo(sfd.FileName), new System.IO.FileInfo(System.IO.Path.Combine(Application.StartupPath, SVP.Properties.Settings.Default.ExcelTemplate)));
                        pckg.Workbook.Names["TITEL"].Value = competition.Name;
                        pckg.Workbook.Names["Date"].Value = competition.Date.ToShortDateString();
                        int row = pckg.Workbook.Names["HeaderStart"].Start.Row;
                        int column = pckg.Workbook.Names["HeaderStart"].Start.Column;
                        int shotCount = 10;
                        pckg.Workbook.Worksheets[1].Cells[row, column].Value = "Platz";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Value = "Vorname";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Value = "Nachname";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 3].Value = "Verein";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 4].Value = "Pokal";
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 3].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 3].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 4].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 4].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        pckg.Workbook.Worksheets[1].Cells[row, column + 5].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 5].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        int i;
                        for (i = 0; i < shotCount; i++)
                        {
                            pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = (i + 1) + ".";
                            pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                            pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        }
                        pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = "Summe";
                        pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                        row++;
     
                        foreach (Price p in competition.Prices)
                        {
                            int place = 1;
                            double lastResult = 0;
                            double lastNextResult = 0;
                            foreach (Sequence s in p.Sequences.OrderByDescending(x => x.Shots.Sum(y => y.Value)).ThenByDescending(x => x.NextSequence == null ? 0 : x.NextSequence.Shots.Sum(y => y.Value)))
                            {
                                pckg.Workbook.Worksheets[1].Cells[row, column].Value = place.ToString() + ".";
                                pckg.Workbook.Worksheets[1].Cells[row, column + 1].Value = s.Member.Firstname;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 2].Value = s.Member.Name;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 3].Value = s.Member.Club;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 4].Value = p.Name;
                                pckg.Workbook.Worksheets[1].Cells[row, column].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                pckg.Workbook.Worksheets[1].Cells[row, column + 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 3].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                pckg.Workbook.Worksheets[1].Cells[row, column + 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 4].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                
                                for (i = 0; i < s.Shots.Count; i++)
                                {
                                    if (s.NextSequence == null)
                                        pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = s.Shots.ElementAt(i).Value.ToString();
                                    else
                                        pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = s.Shots.ElementAt(i).Value.ToString() + " (" + s.NextSequence.Shots.ElementAt(i).Value.ToString() + ")";
                                    pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                    pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                }
                                if (s.NextSequence == null)
                                    pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = s.Shots.Sum(x => x.Value);
                                else
                                    pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Value = s.Shots.Sum(x => x.Value) + " (" + s.NextSequence.Shots.Sum(x => x.Value) + ")";
                                pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                                pckg.Workbook.Worksheets[1].Cells[row, column + 5 + i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                                if (s.Shots.Sum(x => x.Value) == lastResult)
                                {
                                    if (s.NextSequence != null)
                                    {
                                        if (s.NextSequence.Shots.Sum(x => x.Value) != lastNextResult)
                                            place++;
                                        lastNextResult = s.NextSequence.Shots.Sum(x => x.Value);
                                    }
                                }
                                else
                                {
                                    place++;
                                }
                                lastResult = s.Shots.Sum(x => x.Value);
                                row++;
                            }
                        }
                        row++;
                        if (competition.Awards.Count > 0)
                        {
                            pckg.Workbook.Worksheets[1].Cells[row, column].Value = "Ehrenscheiben";
                            pckg.Workbook.Worksheets[1].Cells[row, column].Style.Font.Bold = true;
                            row++;
                        }
                        foreach (Award a in competition.Awards)
                        {
                            pckg.Workbook.Worksheets[1].Cells[row, column].Value = a.Winner.Firstname;
                            pckg.Workbook.Worksheets[1].Cells[row, column + 1].Value = a.Winner.Name;
                            pckg.Workbook.Worksheets[1].Cells[row, column + 2].Value = a.Winner.Club;
                            pckg.Workbook.Worksheets[1].Cells[row, column + 3].Value = a.Name;
                            row++;
                        }
                        pckg.Workbook.Worksheets[1].Cells.AutoFitColumns(3);
                        pckg.Save();
                        MessageBox.Show("Export erfolgreich!");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
