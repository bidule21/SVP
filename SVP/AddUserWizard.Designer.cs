namespace SVP
{
    partial class AddUserWizard
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
            this.txtMemberShortName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtMemberBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMemberClub = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMemberShortName
            // 
            this.txtMemberShortName.Location = new System.Drawing.Point(110, 122);
            this.txtMemberShortName.MaxLength = 10;
            this.txtMemberShortName.Name = "txtMemberShortName";
            this.txtMemberShortName.Size = new System.Drawing.Size(228, 20);
            this.txtMemberShortName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kurzname:";
            // 
            // dtMemberBirthday
            // 
            this.dtMemberBirthday.Location = new System.Drawing.Point(110, 93);
            this.dtMemberBirthday.Name = "dtMemberBirthday";
            this.dtMemberBirthday.Size = new System.Drawing.Size(228, 20);
            this.dtMemberBirthday.TabIndex = 17;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(110, 64);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(228, 20);
            this.txtMemberName.TabIndex = 16;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMember_TextChanged);
            // 
            // txtMemberFirstname
            // 
            this.txtMemberFirstname.Location = new System.Drawing.Point(110, 35);
            this.txtMemberFirstname.Name = "txtMemberFirstname";
            this.txtMemberFirstname.Size = new System.Drawing.Size(228, 20);
            this.txtMemberFirstname.TabIndex = 15;
            this.txtMemberFirstname.TextChanged += new System.EventHandler(this.txtMember_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Geburtsdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vorname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Verein / Gruppe:";
            // 
            // cbMemberClub
            // 
            this.cbMemberClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberClub.FormattingEnabled = true;
            this.cbMemberClub.Location = new System.Drawing.Point(110, 6);
            this.cbMemberClub.Name = "cbMemberClub";
            this.cbMemberClub.Size = new System.Drawing.Size(228, 21);
            this.cbMemberClub.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(262, 173);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUserWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMemberShortName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtMemberBirthday);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMemberClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUserWizard";
            this.Text = "Mitglied bearbeiten";
            this.Load += new System.EventHandler(this.AddUserWizardNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberShortName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtMemberBirthday;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMemberClub;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}