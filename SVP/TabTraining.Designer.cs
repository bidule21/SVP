namespace SVP
{
    partial class TabTraining
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
            this.btnNewClub = new System.Windows.Forms.Button();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
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
            this.gbRead.Location = new System.Drawing.Point(6, 94);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(400, 175);
            this.gbRead.TabIndex = 17;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // btnReRead
            // 
            this.btnReRead.Enabled = false;
            this.btnReRead.Location = new System.Drawing.Point(301, 139);
            this.btnReRead.Name = "btnReRead";
            this.btnReRead.Size = new System.Drawing.Size(93, 23);
            this.btnReRead.TabIndex = 13;
            this.btnReRead.Text = "Nachwertung";
            this.btnReRead.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(301, 110);
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
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(313, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(313, 36);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 15;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnNewClub
            // 
            this.btnNewClub.Location = new System.Drawing.Point(313, 9);
            this.btnNewClub.Name = "btnNewClub";
            this.btnNewClub.Size = new System.Drawing.Size(93, 23);
            this.btnNewClub.TabIndex = 14;
            this.btnNewClub.Text = "Neuer Verein";
            this.btnNewClub.UseVisualStyleBackColor = true;
            this.btnNewClub.Click += new System.EventHandler(this.btnNewClub_Click);
            // 
            // cbMember
            // 
            this.cbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(112, 36);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(195, 21);
            this.cbMember.TabIndex = 13;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Verein:";
            // 
            // cbClub
            // 
            this.cbClub.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(112, 9);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(195, 21);
            this.cbClub.TabIndex = 10;
            this.cbClub.SelectedIndexChanged += new System.EventHandler(this.cbClub_SelectedIndexChanged);
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
            this.display});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvResults.Location = new System.Drawing.Point(447, 0);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.Size = new System.Drawing.Size(381, 569);
            this.dvResults.TabIndex = 18;
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
            this.value.Width = 50;
            // 
            // profile
            // 
            this.profile.HeaderText = "Profile";
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // display
            // 
            this.display.HeaderText = "Anzeigen";
            this.display.Name = "display";
            this.display.ReadOnly = true;
            // 
            // TabTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnNewClub);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClub);
            this.Name = "TabTraining";
            this.Size = new System.Drawing.Size(828, 569);
            this.Load += new System.EventHandler(this.TabTraining_Load);
            this.gbRead.ResumeLayout(false);
            this.gbRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnNewClub;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.DataGridView dvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn display;
    }
}
