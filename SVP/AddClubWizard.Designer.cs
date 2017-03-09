namespace SVP
{
    partial class AddClubWizard
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
            this.addClubPage = new AeroWizard.WizardPage();
            this.cbClubTemporary = new System.Windows.Forms.CheckBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.addClubPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.addClubPage);
            this.wizardControl1.Size = new System.Drawing.Size(574, 415);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "Schießstand Verwaltungs Programm";

            // 
            // addClubPage
            // 
            this.addClubPage.Controls.Add(this.cbClubTemporary);
            this.addClubPage.Controls.Add(this.txtClubName);
            this.addClubPage.Controls.Add(this.label5);
            this.addClubPage.Name = "addClubPage";
            this.addClubPage.Size = new System.Drawing.Size(527, 261);
            this.addClubPage.TabIndex = 2;
            this.addClubPage.Text = "Verein oder Gruppe hinzufügen";
            this.addClubPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.addClubPage_Commit);
            // 
            // cbClubTemporary
            // 
            this.cbClubTemporary.AutoSize = true;
            this.cbClubTemporary.Location = new System.Drawing.Point(6, 37);
            this.cbClubTemporary.Name = "cbClubTemporary";
            this.cbClubTemporary.Size = new System.Drawing.Size(177, 19);
            this.cbClubTemporary.TabIndex = 2;
            this.cbClubTemporary.Text = "Temporäre/r Gruppe / Verein";
            this.cbClubTemporary.UseVisualStyleBackColor = true;
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(54, 8);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(184, 23);
            this.txtClubName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name: ";
            // 
            // AddClubWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 415);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddClubWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.addClubPage.ResumeLayout(false);
            this.addClubPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage addClubPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbClubTemporary;
        private System.Windows.Forms.TextBox txtClubName;
    }
}