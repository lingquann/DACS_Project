namespace QLyPhongTro.FormCon
{
    partial class FormPhong
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
            dgvPhong = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            btnCapNhat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvPhong
            // 
            dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhong.BackgroundColor = Color.White;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(2, 164);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.RowTemplate.Height = 29;
            dgvPhong.Size = new Size(1076, 391);
            dgvPhong.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.FromArgb(198, 226, 255);
            btnTimKiem.Location = new Point(788, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(511, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(261, 27);
            txtTimKiem.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(306, 28);
            label1.TabIndex = 10;
            label1.Text = "QUẢN LÝ DANH MỤC PHÒNG";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCapNhat.BackColor = Color.FromArgb(198, 226, 255);
            btnCapNhat.Location = new Point(888, 107);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(198, 226, 255);
            btnThem.Location = new Point(788, 107);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "+Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // FormPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 226, 255);
            ClientSize = new Size(1078, 555);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvPhong);
            Name = "FormPhong";
            Text = "FormPhong";
            Load += FormPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhong;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label1;
        private Button btnCapNhat;
        private Button btnThem;
    }
}