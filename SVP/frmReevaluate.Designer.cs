namespace SVP
{
    partial class frmReevaluate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRead = new System.Windows.Forms.GroupBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.btnSetProfile = new System.Windows.Forms.Button();
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRead.SuspendLayout();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(205, 41);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(235, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Fertig";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbMember
            // 
            this.cbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(110, 18);
            this.cbMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(190, 21);
            this.cbMember.TabIndex = 21;
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(114, 16);
            this.cbProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(190, 21);
            this.cbProfile.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Schütze / Schützin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Profil:";
            // 
            // gbRead
            // 
            this.gbRead.Controls.Add(this.btnRead);
            this.gbRead.Controls.Add(this.cbMember);
            this.gbRead.Controls.Add(this.label3);
            this.gbRead.Enabled = false;
            this.gbRead.Location = new System.Drawing.Point(12, 281);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(317, 71);
            this.gbRead.TabIndex = 26;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 359);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(317, 23);
            this.pBar.TabIndex = 27;
            this.pBar.Visible = false;
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btnSetProfile);
            this.gbProfile.Controls.Add(this.cbProfile);
            this.gbProfile.Controls.Add(this.label4);
            this.gbProfile.Location = new System.Drawing.Point(8, 205);
            this.gbProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProfile.Size = new System.Drawing.Size(321, 71);
            this.gbProfile.TabIndex = 28;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profile";
            // 
            // btnSetProfile
            // 
            this.btnSetProfile.Location = new System.Drawing.Point(209, 40);
            this.btnSetProfile.Name = "btnSetProfile";
            this.btnSetProfile.Size = new System.Drawing.Size(93, 23);
            this.btnSetProfile.TabIndex = 24;
            this.btnSetProfile.Text = "&OK";
            this.btnSetProfile.UseVisualStyleBackColor = true;
            this.btnSetProfile.Click += new System.EventHandler(this.btnSetProfile_Click);
            // 
            // dvResults
            // 
            this.dvResults.AllowUserToAddRows = false;
            this.dvResults.AllowUserToDeleteRows = false;
            this.dvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.Value});
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvResults.Location = new System.Drawing.Point(0, 0);
            this.dvResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowHeadersVisible = false;
            this.dvResults.RowTemplate.Height = 28;
            this.dvResults.Size = new System.Drawing.Size(337, 176);
            this.dvResults.TabIndex = 29;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Ringe";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // frmReevaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 429);
            this.ControlBox = false;
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReevaluate";
            this.ShowInTaskbar = false;
            this.Text = "Gewinner feststellen";
            this.Load += new System.EventHandler(this.frmReevaluate_Load);
            this.gbRead.ResumeLayout(false);
            this.gbRead.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRead;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Button btnSetProfile;
        private System.Windows.Forms.DataGridView dvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}