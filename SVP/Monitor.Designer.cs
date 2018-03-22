namespace SVP
{
    partial class Monitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgResultList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbResults = new System.Windows.Forms.Label();
            this.lbCurrentResult = new System.Windows.Forms.Label();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.rtResults = new System.Windows.Forms.RichTextBox();
            this.lbNews1 = new System.Windows.Forms.Label();
            this.lbNews2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultList
            // 
            this.dgResultList.AllowUserToAddRows = false;
            this.dgResultList.AllowUserToDeleteRows = false;
            this.dgResultList.AllowUserToResizeColumns = false;
            this.dgResultList.AllowUserToResizeRows = false;
            this.dgResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResultList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.result,
            this.profile});
            this.dgResultList.Location = new System.Drawing.Point(824, 15);
            this.dgResultList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgResultList.MultiSelect = false;
            this.dgResultList.Name = "dgResultList";
            this.dgResultList.ReadOnly = true;
            this.dgResultList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgResultList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgResultList.RowTemplate.Height = 40;
            this.dgResultList.Size = new System.Drawing.Size(401, 654);
            this.dgResultList.TabIndex = 0;
            this.dgResultList.TabStop = false;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 121;
            // 
            // result
            // 
            this.result.Frozen = true;
            this.result.HeaderText = "Ergebnis";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.result.Width = 163;
            // 
            // profile
            // 
            this.profile.HeaderText = "Wertungsprofil";
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            this.profile.Width = 239;
            // 
            // lbResults
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResults.Location = new System.Drawing.Point(16, 490);
            this.lbResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(123, 36);
            this.lbResults.TabIndex = 2;
            this.lbResults.Text = "Schütze";
            // 
            // lbCurrentResult
            // 
            this.lbCurrentResult.AutoSize = true;
            this.lbCurrentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentResult.Location = new System.Drawing.Point(641, 490);
            this.lbCurrentResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentResult.Name = "lbCurrentResult";
            this.lbCurrentResult.Size = new System.Drawing.Size(34, 46);
            this.lbCurrentResult.TabIndex = 3;
            this.lbCurrentResult.Text = "-";
            // 
            // pbTarget
            // 
            this.pbTarget.Image = global::SVP.Properties.Resources.Zielscheibe;
            this.pbTarget.Location = new System.Drawing.Point(16, 15);
            this.pbTarget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(731, 471);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTarget.TabIndex = 1;
            this.pbTarget.TabStop = false;
            // 
            // rtResults
            // 
            this.rtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResults.Location = new System.Drawing.Point(16, 539);
            this.rtResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtResults.Name = "rtResults";
            this.rtResults.ReadOnly = true;
            this.rtResults.Size = new System.Drawing.Size(763, 43);
            this.rtResults.TabIndex = 4;
            this.rtResults.Text = "";
            // 
            // lbNews1
            // 
            this.lbNews1.AutoSize = true;
            this.lbNews1.BackColor = System.Drawing.Color.Red;
            this.lbNews1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNews1.ForeColor = System.Drawing.Color.White;
            this.lbNews1.Location = new System.Drawing.Point(14, 628);
            this.lbNews1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNews1.Name = "lbNews1";
            this.lbNews1.Size = new System.Drawing.Size(145, 46);
            this.lbNews1.TabIndex = 5;
            this.lbNews1.Text = "NEWS";
            // 
            // lbNews2
            // 
            this.lbNews2.AutoSize = true;
            this.lbNews2.BackColor = System.Drawing.Color.Red;
            this.lbNews2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNews2.ForeColor = System.Drawing.Color.White;
            this.lbNews2.Location = new System.Drawing.Point(167, 628);
            this.lbNews2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNews2.Name = "lbNews2";
            this.lbNews2.Size = new System.Drawing.Size(145, 46);
            this.lbNews2.TabIndex = 6;
            this.lbNews2.Text = "NEWS";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 683);
            this.Controls.Add(this.lbNews2);
            this.Controls.Add(this.lbNews1);
            this.Controls.Add(this.rtResults);
            this.Controls.Add(this.lbCurrentResult);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.dgResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Monitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResultList;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Label lbResults;
        private System.Windows.Forms.Label lbCurrentResult;
        private System.Windows.Forms.RichTextBox rtResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
        private System.Windows.Forms.Label lbNews1;
        private System.Windows.Forms.Label lbNews2;
    }
}

