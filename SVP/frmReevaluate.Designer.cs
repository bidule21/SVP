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
            this.dvResults = new System.Windows.Forms.DataGridView();
            this.btnSetProfile = new System.Windows.Forms.Button();
            this.gbRead.SuspendLayout();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(308, 63);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(140, 35);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(353, 598);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
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
            this.cbMember.Location = new System.Drawing.Point(165, 27);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(283, 28);
            this.cbMember.TabIndex = 21;
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(171, 25);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(283, 28);
            this.cbProfile.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Schütze / Schützin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Profil:";
            // 
            // gbRead
            // 
            this.gbRead.Controls.Add(this.btnRead);
            this.gbRead.Controls.Add(this.cbMember);
            this.gbRead.Controls.Add(this.label3);
            this.gbRead.Enabled = false;
            this.gbRead.Location = new System.Drawing.Point(18, 433);
            this.gbRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRead.Name = "gbRead";
            this.gbRead.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRead.Size = new System.Drawing.Size(476, 110);
            this.gbRead.TabIndex = 26;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(18, 553);
            this.pBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(476, 35);
            this.pBar.TabIndex = 27;
            this.pBar.Visible = false;
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.btnSetProfile);
            this.gbProfile.Controls.Add(this.cbProfile);
            this.gbProfile.Controls.Add(this.label4);
            this.gbProfile.Location = new System.Drawing.Point(12, 316);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(482, 109);
            this.gbProfile.TabIndex = 28;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profile";
            // 
            // dvResults
            // 
            this.dvResults.AllowUserToAddRows = false;
            this.dvResults.AllowUserToDeleteRows = false;
            this.dvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvResults.Location = new System.Drawing.Point(0, 0);
            this.dvResults.Name = "dvResults";
            this.dvResults.ReadOnly = true;
            this.dvResults.RowTemplate.Height = 28;
            this.dvResults.Size = new System.Drawing.Size(506, 271);
            this.dvResults.TabIndex = 29;
            // 
            // btnSetProfile
            // 
            this.btnSetProfile.Location = new System.Drawing.Point(314, 61);
            this.btnSetProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetProfile.Name = "btnSetProfile";
            this.btnSetProfile.Size = new System.Drawing.Size(140, 35);
            this.btnSetProfile.TabIndex = 24;
            this.btnSetProfile.Text = "&OK";
            this.btnSetProfile.UseVisualStyleBackColor = true;
            this.btnSetProfile.Click += new System.EventHandler(this.btnSetProfile_Click);
            // 
            // frmReevaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 645);
            this.ControlBox = false;
            this.Controls.Add(this.dvResults);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
    }
}