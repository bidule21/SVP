namespace SVP
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTraining = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewClub = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReRead = new System.Windows.Forms.Button();
            this.tvResults = new Aga.Controls.Tree.TreeViewAdv();
            this.tabControl1.SuspendLayout();
            this.tpTraining.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTraining);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTraining
            // 
            this.tpTraining.Controls.Add(this.tvResults);
            this.tpTraining.Controls.Add(this.groupBox1);
            this.tpTraining.Controls.Add(this.btnStart);
            this.tpTraining.Controls.Add(this.btnNewMember);
            this.tpTraining.Controls.Add(this.btnNewClub);
            this.tpTraining.Controls.Add(this.cbMember);
            this.tpTraining.Controls.Add(this.label2);
            this.tpTraining.Controls.Add(this.label1);
            this.tpTraining.Controls.Add(this.cbClub);
            this.tpTraining.Location = new System.Drawing.Point(4, 22);
            this.tpTraining.Name = "tpTraining";
            this.tpTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tpTraining.Size = new System.Drawing.Size(828, 569);
            this.tpTraining.TabIndex = 0;
            this.tpTraining.Text = "Trainingsschießen";
            this.tpTraining.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbProfile
            // 
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(116, 24);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(121, 21);
            this.cbProfile.TabIndex = 0;
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(117, 6);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(121, 21);
            this.cbClub.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verein:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Schütze / Schützin:";
            // 
            // cbMember
            // 
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(117, 33);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(121, 21);
            this.cbMember.TabIndex = 4;
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
            // btnNewClub
            // 
            this.btnNewClub.Location = new System.Drawing.Point(244, 4);
            this.btnNewClub.Name = "btnNewClub";
            this.btnNewClub.Size = new System.Drawing.Size(93, 23);
            this.btnNewClub.TabIndex = 6;
            this.btnNewClub.Text = "Neuer Verein";
            this.btnNewClub.UseVisualStyleBackColor = true;
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(244, 33);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 7;
            this.btnNewMember.Text = "Neuer Schütze";
            this.btnNewMember.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(244, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReRead);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.lblMember);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblClub);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbProfile);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einlesen";
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
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(113, 60);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(10, 13);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "-";
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
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(113, 86);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(10, 13);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "-";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(233, 110);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnReRead
            // 
            this.btnReRead.Enabled = false;
            this.btnReRead.Location = new System.Drawing.Point(233, 139);
            this.btnReRead.Name = "btnReRead";
            this.btnReRead.Size = new System.Drawing.Size(93, 23);
            this.btnReRead.TabIndex = 13;
            this.btnReRead.Text = "Nachwertung";
            this.btnReRead.UseVisualStyleBackColor = true;
            // 
            // tvResults
            // 
            this.tvResults.BackColor = System.Drawing.SystemColors.Window;
            this.tvResults.ColumnHeaderHeight = 0;
            this.tvResults.DefaultToolTipProvider = null;
            this.tvResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.tvResults.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvResults.FullRowSelectActiveColor = System.Drawing.Color.Empty;
            this.tvResults.FullRowSelectInactiveColor = System.Drawing.Color.Empty;
            this.tvResults.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tvResults.Location = new System.Drawing.Point(368, 3);
            this.tvResults.Model = null;
            this.tvResults.Name = "tvResults";
            this.tvResults.NodeFilter = null;
            this.tvResults.SelectedNode = null;
            this.tvResults.Size = new System.Drawing.Size(457, 563);
            this.tvResults.TabIndex = 10;
            this.tvResults.Text = "treeViewAdv1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tabControl1.ResumeLayout(false);
            this.tpTraining.ResumeLayout(false);
            this.tpTraining.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTraining;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnNewClub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private Aga.Controls.Tree.TreeViewAdv tvResults;
    }
}