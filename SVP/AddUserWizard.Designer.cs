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
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.addMemberPage = new AeroWizard.WizardPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.addMemberPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.addMemberPage);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";
            // 
            // addMemberPage
            // 
            this.addMemberPage.Controls.Add(this.txtMemberShortName);
            this.addMemberPage.Controls.Add(this.label6);
            this.addMemberPage.Controls.Add(this.dtMemberBirthday);
            this.addMemberPage.Controls.Add(this.txtMemberName);
            this.addMemberPage.Controls.Add(this.txtMemberFirstname);
            this.addMemberPage.Controls.Add(this.label4);
            this.addMemberPage.Controls.Add(this.label3);
            this.addMemberPage.Controls.Add(this.label2);
            this.addMemberPage.Controls.Add(this.label1);
            this.addMemberPage.Controls.Add(this.cbMemberClub);
            this.addMemberPage.Name = "addMemberPage";
            this.addMemberPage.Size = new System.Drawing.Size(527, 261);
            this.addMemberPage.TabIndex = 1;
            this.addMemberPage.Text = "Mitglied hinzufügen";
            this.addMemberPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addMemberPage_Commit);
            this.addMemberPage.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.addMemberPage_Initialize);
            // 
            // txtMemberShortName
            // 
            this.txtMemberShortName.Location = new System.Drawing.Point(101, 131);
            this.txtMemberShortName.MaxLength = 10;
            this.txtMemberShortName.Name = "txtMemberShortName";
            this.txtMemberShortName.Size = new System.Drawing.Size(228, 23);
            this.txtMemberShortName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kurzname:";
            // 
            // dtMemberBirthday
            // 
            this.dtMemberBirthday.Location = new System.Drawing.Point(101, 102);
            this.dtMemberBirthday.Name = "dtMemberBirthday";
            this.dtMemberBirthday.Size = new System.Drawing.Size(228, 23);
            this.dtMemberBirthday.TabIndex = 7;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(101, 73);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(228, 23);
            this.txtMemberName.TabIndex = 6;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // txtMemberFirstname
            // 
            this.txtMemberFirstname.Location = new System.Drawing.Point(101, 44);
            this.txtMemberFirstname.Name = "txtMemberFirstname";
            this.txtMemberFirstname.Size = new System.Drawing.Size(228, 23);
            this.txtMemberFirstname.TabIndex = 5;
            this.txtMemberFirstname.TextChanged += new System.EventHandler(this.txtMemberFirstname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Geburtsdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verein / Gruppe:";
            // 
            // cbMemberClub
            // 
            this.cbMemberClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberClub.FormattingEnabled = true;
            this.cbMemberClub.Location = new System.Drawing.Point(101, 15);
            this.cbMemberClub.Name = "cbMemberClub";
            this.cbMemberClub.Size = new System.Drawing.Size(228, 23);
            this.cbMemberClub.TabIndex = 0;
            // 
            // AddUserWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddUserWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.addMemberPage.ResumeLayout(false);
            this.addMemberPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage addMemberPage;
        private System.Windows.Forms.DateTimePicker dtMemberBirthday;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberFirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMemberClub;
        private System.Windows.Forms.TextBox txtMemberShortName;
        private System.Windows.Forms.Label label6;
    }
}