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
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.lblProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
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
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbRead.Controls.Add(this.pBar);
            this.gbRead.Controls.Add(this.lblProfile);
            this.gbRead.Controls.Add(this.label1);
            this.gbRead.Controls.Add(this.btnRead);
            this.gbRead.Controls.Add(this.lblMember);
            this.gbRead.Controls.Add(this.label5);
            this.gbRead.Controls.Add(this.lblClub);
            this.gbRead.Controls.Add(this.label4);
            this.gbRead.Controls.Add(this.label3);
            this.gbRead.Controls.Add(this.cbPrice);
            this.gbRead.Enabled = false;
            this.gbRead.Location = new System.Drawing.Point(8, 474);
            this.gbRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRead.Name = "gbRead";
            this.gbRead.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRead.Size = new System.Drawing.Size(580, 215);
            this.gbRead.TabIndex = 17;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 171);
            this.pBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(529, 28);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBar.TabIndex = 16;
            this.pBar.Visible = false;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(151, 66);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(13, 17);
            this.lblProfile.TabIndex = 15;
            this.lblProfile.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Profil:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(417, 135);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(124, 28);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(151, 130);
            this.lblMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(13, 17);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schütze / Schützin:";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(151, 98);
            this.lblClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(13, 17);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Verein:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pokal";
            // 
            // cbPrice
            // 
            this.cbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(155, 30);
            this.cbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(245, 24);
            this.cbPrice.TabIndex = 0;
            this.cbPrice.SelectedIndexChanged += new System.EventHandler(this.cbPrice_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(421, 87);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 28);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(421, 52);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(124, 28);
            this.btnNewMember.TabIndex = 15;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnNewClubGroup
            // 
            this.btnNewClubGroup.Location = new System.Drawing.Point(421, 14);
            this.btnNewClubGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewClubGroup.Name = "btnNewClubGroup";
            this.btnNewClubGroup.Size = new System.Drawing.Size(124, 28);
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
            this.cbMember.Location = new System.Drawing.Point(153, 52);
            this.cbMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(259, 24);
            this.cbMember.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // lblClubGroup
            // 
            this.lblClubGroup.AutoSize = true;
            this.lblClubGroup.Location = new System.Drawing.Point(8, 20);
            this.lblClubGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubGroup.Name = "lblClubGroup";
            this.lblClubGroup.Size = new System.Drawing.Size(53, 17);
            this.lblClubGroup.TabIndex = 11;
            this.lblClubGroup.Text = "Verein:";
            // 
            // cbClubGroup
            // 
            this.cbClubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClubGroup.FormattingEnabled = true;
            this.cbClubGroup.Location = new System.Drawing.Point(153, 16);
            this.cbClubGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClubGroup.Name = "cbClubGroup";
            this.cbClubGroup.Size = new System.Drawing.Size(259, 24);
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
            this.Price,
            this.show});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvResults.Location = new System.Drawing.Point(596, 0);
            this.dvResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.Size = new System.Drawing.Size(508, 700);
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
            this.gbCompetition.Location = new System.Drawing.Point(4, 39);
            this.gbCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCompetition.Name = "gbCompetition";
            this.gbCompetition.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCompetition.Size = new System.Drawing.Size(584, 249);
            this.gbCompetition.TabIndex = 19;
            this.gbCompetition.TabStop = false;
            this.gbCompetition.Text = "Pokalschießen";
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.AutoSize = true;
            this.lblCompetitionName.Location = new System.Drawing.Point(4, 20);
            this.lblCompetitionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(0, 17);
            this.lblCompetitionName.TabIndex = 3;
            // 
            // btnEndCompetition
            // 
            this.btnEndCompetition.Location = new System.Drawing.Point(176, 213);
            this.btnEndCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndCompetition.Name = "btnEndCompetition";
            this.btnEndCompetition.Size = new System.Drawing.Size(196, 28);
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
            this.dvCompetition.Location = new System.Drawing.Point(8, 49);
            this.dvCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvCompetition.Name = "dvCompetition";
            this.dvCompetition.ReadOnly = true;
            this.dvCompetition.RowHeadersVisible = false;
            this.dvCompetition.Size = new System.Drawing.Size(568, 156);
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
            this.btnEditCompetition.Location = new System.Drawing.Point(380, 213);
            this.btnEditCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditCompetition.Name = "btnEditCompetition";
            this.btnEditCompetition.Size = new System.Drawing.Size(196, 28);
            this.btnEditCompetition.TabIndex = 0;
            this.btnEditCompetition.Text = "Pokalschießen bearbeiten";
            this.btnEditCompetition.UseVisualStyleBackColor = true;
            this.btnEditCompetition.Click += new System.EventHandler(this.btnEditCompetition_Click);
            // 
            // btnCreateCompetition
            // 
            this.btnCreateCompetition.Location = new System.Drawing.Point(4, 4);
            this.btnCreateCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCompetition.Name = "btnCreateCompetition";
            this.btnCreateCompetition.Size = new System.Drawing.Size(196, 28);
            this.btnCreateCompetition.TabIndex = 0;
            this.btnCreateCompetition.Text = "Pokalschießen erstellen";
            this.btnCreateCompetition.UseVisualStyleBackColor = true;
            this.btnCreateCompetition.Click += new System.EventHandler(this.btnCreateCompetition_Click);
            // 
            // btnContinueCompetition
            // 
            this.btnContinueCompetition.Location = new System.Drawing.Point(208, 4);
            this.btnContinueCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinueCompetition.Name = "btnContinueCompetition";
            this.btnContinueCompetition.Size = new System.Drawing.Size(196, 28);
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
            this.gbMember.Location = new System.Drawing.Point(4, 295);
            this.gbMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMember.Name = "gbMember";
            this.gbMember.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMember.Size = new System.Drawing.Size(584, 171);
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
            // Price
            // 
            this.Price.HeaderText = "Pokal";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // show
            // 
            this.show.HeaderText = "Anzeigen";
            this.show.Name = "show";
            this.show.ReadOnly = true;
            // 
            // TabCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.btnContinueCompetition);
            this.Controls.Add(this.gbCompetition);
            this.Controls.Add(this.btnCreateCompetition);
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbRead);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TabCompetition";
            this.Size = new System.Drawing.Size(1104, 700);
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
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPrice;
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
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn show;
    }
}
