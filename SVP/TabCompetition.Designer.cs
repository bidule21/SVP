namespace SVP
{
    partial class TabCompetition
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRead = new System.Windows.Forms.GroupBox();
            this.btnReRead = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnNewClubGroup = new System.Windows.Forms.Button();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClubGroup = new System.Windows.Forms.Label();
            this.cbClubGroup = new System.Windows.Forms.ComboBox();
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.gbCompetition = new System.Windows.Forms.GroupBox();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.btnEndCompetition = new System.Windows.Forms.Button();
            this.dvCompetition = new System.Windows.Forms.DataGridView();
            this.PriceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditCompetition = new System.Windows.Forms.Button();
            this.btnCreateCompetition = new System.Windows.Forms.Button();
            this.btnContinueCompetition = new System.Windows.Forms.Button();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
            this.gbCompetition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).BeginInit();
            this.gbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRead
            // 
            this.gbRead.Controls.Add(this.btnReRead);
            this.gbRead.Controls.Add(this.btnRead);
            this.gbRead.Controls.Add(this.lblMember);
            this.gbRead.Controls.Add(this.label5);
            this.gbRead.Controls.Add(this.lblClub);
            this.gbRead.Controls.Add(this.label4);
            this.gbRead.Controls.Add(this.label3);
            this.gbRead.Controls.Add(this.cbProfile);
            this.gbRead.Enabled = false;
            this.gbRead.Location = new System.Drawing.Point(6, 385);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(435, 175);
            this.gbRead.TabIndex = 17;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // btnReRead
            // 
            this.btnReRead.Enabled = false;
            this.btnReRead.Location = new System.Drawing.Point(313, 139);
            this.btnReRead.Name = "btnReRead";
            this.btnReRead.Size = new System.Drawing.Size(93, 23);
            this.btnReRead.TabIndex = 13;
            this.btnReRead.Text = "Nachwertung";
            this.btnReRead.UseVisualStyleBackColor = true;
            this.btnReRead.Click += new System.EventHandler(this.btnReRead_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(313, 110);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(113, 86);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(10, 13);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schütze / Schützin:";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(113, 60);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(10, 13);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Verein:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profil:";
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(116, 24);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(185, 21);
            this.cbProfile.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(316, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(316, 42);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 15;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnNewClubGroup
            // 
            this.btnNewClubGroup.Location = new System.Drawing.Point(316, 11);
            this.btnNewClubGroup.Name = "btnNewClubGroup";
            this.btnNewClubGroup.Size = new System.Drawing.Size(93, 23);
            this.btnNewClubGroup.TabIndex = 14;
            this.btnNewClubGroup.Text = "Neuer Verein";
            this.btnNewClubGroup.UseVisualStyleBackColor = true;
            this.btnNewClubGroup.Click += new System.EventHandler(this.btnNewClub_Click);
            // 
            // cbMember
            // 
            this.cbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(115, 42);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(195, 21);
            this.cbMember.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // lblClubGroup
            // 
            this.lblClubGroup.AutoSize = true;
            this.lblClubGroup.Location = new System.Drawing.Point(6, 16);
            this.lblClubGroup.Name = "lblClubGroup";
            this.lblClubGroup.Size = new System.Drawing.Size(40, 13);
            this.lblClubGroup.TabIndex = 11;
            this.lblClubGroup.Text = "Verein:";
            // 
            // cbClubGroup
            // 
            this.cbClubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClubGroup.FormattingEnabled = true;
            this.cbClubGroup.Location = new System.Drawing.Point(115, 13);
            this.cbClubGroup.Name = "cbClubGroup";
            this.cbClubGroup.Size = new System.Drawing.Size(195, 21);
            this.cbClubGroup.TabIndex = 10;
            this.cbClubGroup.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
            // 
            // dvResults
            // 
            this.dvResults.AllowUserToAddRows = false;
            this.dvResults.AllowUserToDeleteRows = false;
            this.dvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value,
            this.profile,
            this.show});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvResults.Location = new System.Drawing.Point(447, 0);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.Size = new System.Drawing.Size(381, 569);
            this.dvResults.TabIndex = 18;
            this.dvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvResults_CellClick);
            // 
            // gbCompetition
            // 
            this.gbCompetition.Controls.Add(this.lblCompetitionName);
            this.gbCompetition.Controls.Add(this.btnEndCompetition);
            this.gbCompetition.Controls.Add(this.dvCompetition);
            this.gbCompetition.Controls.Add(this.btnEditCompetition);
            this.gbCompetition.Enabled = false;
            this.gbCompetition.Location = new System.Drawing.Point(3, 32);
            this.gbCompetition.Name = "gbCompetition";
            this.gbCompetition.Size = new System.Drawing.Size(438, 202);
            this.gbCompetition.TabIndex = 19;
            this.gbCompetition.TabStop = false;
            this.gbCompetition.Text = "Pokalschießen";
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.Location = new System.Drawing.Point(3, 16);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(0, 13);
            this.lblCompetitionName.TabIndex = 3;
            // 
            // btnEndCompetition
            // 
            this.btnEndCompetition.Location = new System.Drawing.Point(132, 173);
            this.btnEndCompetition.Name = "btnEndCompetition";
            this.btnEndCompetition.Size = new System.Drawing.Size(147, 23);
            this.btnEndCompetition.TabIndex = 2;
            this.btnEndCompetition.Text = "Pokalschießen beenden";
            this.btnEndCompetition.UseVisualStyleBackColor = true;
            this.btnEndCompetition.Click += new System.EventHandler(this.btnEndCompetition_Click);
            // 
            // dvCompetition
            // 
            this.dvCompetition.AllowUserToAddRows = false;
            this.dvCompetition.AllowUserToDeleteRows = false;
            this.dvCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceName,
            this.PriceKind});
            this.dvCompetition.Location = new System.Drawing.Point(6, 40);
            this.dvCompetition.Name = "dvCompetition";
            this.dvCompetition.ReadOnly = true;
            this.dvCompetition.RowHeadersVisible = false;
            this.dvCompetition.Size = new System.Drawing.Size(426, 127);
            this.dvCompetition.TabIndex = 1;
            // 
            // PriceName
            // 
            this.PriceName.HeaderText = "Name";
            this.PriceName.Name = "PriceName";
            this.PriceName.ReadOnly = true;
            this.PriceName.Width = 220;
            // 
            // PriceKind
            // 
            this.PriceKind.HeaderText = "Art";
            this.PriceKind.Name = "PriceKind";
            this.PriceKind.ReadOnly = true;
            this.PriceKind.Width = 200;
            // 
            // btnEditCompetition
            // 
            this.btnEditCompetition.Location = new System.Drawing.Point(285, 173);
            this.btnEditCompetition.Name = "btnEditCompetition";
            this.btnEditCompetition.Size = new System.Drawing.Size(147, 23);
            this.btnEditCompetition.TabIndex = 0;
            this.btnEditCompetition.Text = "Pokalschießen bearbeiten";
            this.btnEditCompetition.UseVisualStyleBackColor = true;
            this.btnEditCompetition.Click += new System.EventHandler(this.btnEditCompetition_Click);
            // 
            // btnCreateCompetition
            // 
            this.btnCreateCompetition.Location = new System.Drawing.Point(3, 3);
            this.btnCreateCompetition.Name = "btnCreateCompetition";
            this.btnCreateCompetition.Size = new System.Drawing.Size(147, 23);
            this.btnCreateCompetition.TabIndex = 0;
            this.btnCreateCompetition.Text = "Pokalschießen erstellen";
            this.btnCreateCompetition.UseVisualStyleBackColor = true;
            this.btnCreateCompetition.Click += new System.EventHandler(this.btnCreateCompetition_Click);
            // 
            // btnContinueCompetition
            // 
            this.btnContinueCompetition.Location = new System.Drawing.Point(156, 3);
            this.btnContinueCompetition.Name = "btnContinueCompetition";
            this.btnContinueCompetition.Size = new System.Drawing.Size(147, 23);
            this.btnContinueCompetition.TabIndex = 1;
            this.btnContinueCompetition.Text = "Pokalschießen fortführen";
            this.btnContinueCompetition.UseVisualStyleBackColor = true;
            this.btnContinueCompetition.Click += new System.EventHandler(this.btnContinueCompetition_Click);
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.lblClubGroup);
            this.gbMember.Controls.Add(this.cbClubGroup);
            this.gbMember.Controls.Add(this.label2);
            this.gbMember.Controls.Add(this.cbMember);
            this.gbMember.Controls.Add(this.btnNewClubGroup);
            this.gbMember.Controls.Add(this.btnNewMember);
            this.gbMember.Controls.Add(this.btnStart);
            this.gbMember.Enabled = false;
            this.gbMember.Location = new System.Drawing.Point(3, 240);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(438, 139);
            this.gbMember.TabIndex = 20;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Schütze / Schützin";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Ringe";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // profile
            // 
            this.profile.HeaderText = "Profile";
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // show
            // 
            this.show.HeaderText = "Anzeigen";
            this.show.Name = "show";
            this.show.ReadOnly = true;
            // 
            // TabCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.btnContinueCompetition);
            this.Controls.Add(this.gbCompetition);
            this.Controls.Add(this.btnCreateCompetition);
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbRead);
            this.Name = "TabCompetition";
            this.Size = new System.Drawing.Size(828, 569);
            this.Load += new System.EventHandler(this.TabTraining_Load);
            this.gbRead.ResumeLayout(false);
            this.gbRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).EndInit();
            this.gbCompetition.ResumeLayout(false);
            this.gbCompetition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCompetition)).EndInit();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRead;
        private System.Windows.Forms.Button btnReRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnNewClubGroup;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClubGroup;
        private System.Windows.Forms.ComboBox cbClubGroup;
        private System.Windows.Forms.DataGridView dvResults;
        private System.Windows.Forms.GroupBox gbCompetition;
        private System.Windows.Forms.Button btnEndCompetition;
        private System.Windows.Forms.DataGridView dvCompetition;
        private System.Windows.Forms.Button btnEditCompetition;
        private System.Windows.Forms.Button btnCreateCompetition;
        private System.Windows.Forms.Button btnContinueCompetition;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
        private System.Windows.Forms.DataGridViewButtonColumn show;
    }
}
