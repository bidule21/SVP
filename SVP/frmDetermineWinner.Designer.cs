namespace SVP
{
    partial class frmDetermineWinner
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
            this.dvResultList = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvResultList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvResultList
            // 
            this.dvResultList.AllowUserToAddRows = false;
            this.dvResultList.AllowUserToDeleteRows = false;
            this.dvResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResultList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvResultList.Location = new System.Drawing.Point(0, 0);
            this.dvResultList.Name = "dvResultList";
            this.dvResultList.ReadOnly = true;
            this.dvResultList.Size = new System.Drawing.Size(667, 204);
            this.dvResultList.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(580, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // frmDetermineWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dvResultList);
            this.Name = "frmDetermineWinner";
            this.ShowInTaskbar = false;
            this.Text = "Gewinner festlegen";
            this.Load += new System.EventHandler(this.frmDetermineWinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvResultList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvResultList;
        private System.Windows.Forms.Button btnOk;
    }
}