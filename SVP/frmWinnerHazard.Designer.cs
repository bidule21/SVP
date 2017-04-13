namespace SVP
{
    partial class frmWinnerHazard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHazardMembers = new System.Windows.Forms.Label();
            this.gbRead = new System.Windows.Forms.GroupBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Es gibt einen Gewinner Konflikt zwischen folgenden Schützen/Schützinnen:";
            // 
            // lblHazardMembers
            // 
            this.lblHazardMembers.AutoSize = true;
            this.lblHazardMembers.Location = new System.Drawing.Point(12, 32);
            this.lblHazardMembers.Name = "lblHazardMembers";
            this.lblHazardMembers.Size = new System.Drawing.Size(35, 13);
            this.lblHazardMembers.TabIndex = 1;
            this.lblHazardMembers.Text = "label2";
            // 
            // gbRead
            // 
            this.gbRead.Controls.Add(this.pBar);
            this.gbRead.Controls.Add(this.lblPrice);
            this.gbRead.Controls.Add(this.label2);
            this.gbRead.Controls.Add(this.btnRead);
            this.gbRead.Controls.Add(this.lblMember);
            this.gbRead.Controls.Add(this.label5);
            this.gbRead.Controls.Add(this.lblClub);
            this.gbRead.Controls.Add(this.label4);
            this.gbRead.Controls.Add(this.label3);
            this.gbRead.Controls.Add(this.cbProfile);
            this.gbRead.Enabled = false;
            this.gbRead.Location = new System.Drawing.Point(12, 74);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(435, 175);
            this.gbRead.TabIndex = 18;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "Einlesen";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(9, 139);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(397, 23);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBar.TabIndex = 16;
            this.pBar.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(113, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(10, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Profil:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(313, 110);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Einlesen";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(113, 106);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(10, 13);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schütze / Schützin:";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(113, 80);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(10, 13);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
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
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pokal";
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(116, 51);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(185, 21);
            this.cbProfile.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bitte werten Sie die untenstehenden Bögen nochmal";
            // 
            // frmWinnerHazard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.lblHazardMembers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmWinnerHazard";
            this.Text = "frmWinnerHazard";
            this.gbRead.ResumeLayout(false);
            this.gbRead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHazardMembers;
        private System.Windows.Forms.GroupBox gbRead;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label label6;
    }
}