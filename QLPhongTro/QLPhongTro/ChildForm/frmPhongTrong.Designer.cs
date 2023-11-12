namespace QLPhongTro.ChildForm
{
    partial class frmPhongTrong
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
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongTrong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Location = new System.Drawing.Point(1, 141);
            this.dgvPhongTrong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.RowHeadersWidth = 51;
            this.dgvPhongTrong.RowTemplate.Height = 24;
            this.dgvPhongTrong.Size = new System.Drawing.Size(1109, 415);
            this.dgvPhongTrong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phòng trống";
            // 
            // frmPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1110, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongTrong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhongTrong";
            this.Text = "frmPhongTrong";
            this.Load += new System.EventHandler(this.frmPhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.Label label1;
    }
}