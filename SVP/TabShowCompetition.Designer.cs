namespace SVP
{
    partial class TabShowCompetition
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCompetition = new System.Windows.Forms.GroupBox();
            this.cbCompetitions = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.gbExport = new System.Windows.Forms.GroupBox();
            this.btnShowOnMonitor = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.Competition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReevaluatedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCompetition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
            this.gbExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCompetition
            // 
            this.gbCompetition.Controls.Add(this.cbCompetitions);
            this.gbCompetition.Controls.Add(this.btnLoad);
            this.gbCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCompetition.Location = new System.Drawing.Point(0, 0);
            this.gbCompetition.Name = "gbCompetition";
            this.gbCompetition.Size = new System.Drawing.Size(1266, 77);
            this.gbCompetition.TabIndex = 0;
            this.gbCompetition.TabStop = false;
            this.gbCompetition.Text = "Pokalschießen";
            // 
            // cbCompetitions
            // 
            this.cbCompetitions.FormattingEnabled = true;
            this.cbCompetitions.Location = new System.Drawing.Point(6, 25);
            this.cbCompetitions.Name = "cbCompetitions";
            this.cbCompetitions.Size = new System.Drawing.Size(295, 28);
            this.cbCompetitions.TabIndex = 17;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(308, 21);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 35);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "OK";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dvResults
            // 
            this.dvResults.AllowUserToAddRows = false;
            this.dvResults.AllowUserToDeleteRows = false;
            this.dvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competition,
            this.Price,
            this.Type,
            this.Place,
            this.Member,
            this.Value,
            this.ReevaluatedValue});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvResults.Location = new System.Drawing.Point(0, 77);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.RowTemplate.Height = 28;
            this.dvResults.Size = new System.Drawing.Size(1266, 657);
            this.dvResults.TabIndex = 1;
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.btnShowOnMonitor);
            this.gbExport.Controls.Add(this.btnExport);
            this.gbExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbExport.Enabled = false;
            this.gbExport.Location = new System.Drawing.Point(0, 652);
            this.gbExport.Name = "gbExport";
            this.gbExport.Size = new System.Drawing.Size(1266, 82);
            this.gbExport.TabIndex = 2;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Exportieren";
            // 
            // btnShowOnMonitor
            // 
            this.btnShowOnMonitor.Location = new System.Drawing.Point(907, 27);
            this.btnShowOnMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowOnMonitor.Name = "btnShowOnMonitor";
            this.btnShowOnMonitor.Size = new System.Drawing.Size(204, 35);
            this.btnShowOnMonitor.TabIndex = 16;
            this.btnShowOnMonitor.Text = "Alle auf Monitor anzeigen";
            this.btnShowOnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1119, 27);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(140, 35);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Exportieren";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // Competition
            // 
            this.Competition.HeaderText = "Pokalschießen";
            this.Competition.Name = "Competition";
            this.Competition.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Pokal / Ehrenscheibe";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Preis";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.HeaderText = "Platzierung";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Member
            // 
            this.Member.HeaderText = "Schütze / Schützin";
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            this.Member.Width = 200;
            // 
            // Value
            // 
            this.Value.HeaderText = "Ringe";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // ReevaluatedValue
            // 
            this.ReevaluatedValue.HeaderText = "Nachgewertet";
            this.ReevaluatedValue.Name = "ReevaluatedValue";
            this.ReevaluatedValue.ReadOnly = true;
            // 
            // TabShowCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbExport);
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbCompetition);
            this.Name = "TabShowCompetition";
            this.Size = new System.Drawing.Size(1266, 734);
            this.Load += new System.EventHandler(this.TabShowCompetition_Load);
            this.Enter += new System.EventHandler(this.TabShowCompetition_Enter);
            this.gbCompetition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).EndInit();
            this.gbExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompetition;
        private System.Windows.Forms.DataGridView dvResults;
        private System.Windows.Forms.GroupBox gbExport;
        private System.Windows.Forms.ComboBox cbCompetitions;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShowOnMonitor;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReevaluatedValue;
    }
}
