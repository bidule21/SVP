namespace SVP
{
    partial class TabSettings
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
            this.btnManageProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageProfile
            // 
            this.btnManageProfile.Location = new System.Drawing.Point(0, 3);
            this.btnManageProfile.Name = "btnManageProfile";
            this.btnManageProfile.Size = new System.Drawing.Size(116, 23);
            this.btnManageProfile.TabIndex = 0;
            this.btnManageProfile.Text = "Profile Verwalten";
            this.btnManageProfile.UseVisualStyleBackColor = true;
            this.btnManageProfile.Click += new System.EventHandler(this.btnManageProfile_Click);
            // 
            // TabSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnManageProfile);
            this.Name = "TabSettings";
            this.Size = new System.Drawing.Size(844, 477);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageProfile;
    }
}
