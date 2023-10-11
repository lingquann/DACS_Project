namespace QLyPhongTro.FormCon
{
    partial class FormLoaiPhong
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
            label1 = new Label();
            dgvDmLoaiPhong = new DataGridView();
            label2 = new Label();
            txtTenLoaiPhong = new TextBox();
            label3 = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDmLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(344, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ DANH MỤC LOẠI PHÒNG";
            // 
            // dgvDmLoaiPhong
            // 
            dgvDmLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDmLoaiPhong.BackgroundColor = Color.White;
            dgvDmLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDmLoaiPhong.Location = new Point(0, 118);
            dgvDmLoaiPhong.MultiSelect = false;
            dgvDmLoaiPhong.Name = "dgvDmLoaiPhong";
            dgvDmLoaiPhong.RowHeadersWidth = 51;
            dgvDmLoaiPhong.RowTemplate.Height = 29;
            dgvDmLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDmLoaiPhong.Size = new Size(1087, 345);
            dgvDmLoaiPhong.TabIndex = 1;
            dgvDmLoaiPhong.CellClick += dgvDmLoaiPhong_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 69);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên loại phòng:";
            label2.Click += label2_Click;
            // 
            // txtTenLoaiPhong
            // 
            txtTenLoaiPhong.Location = new Point(177, 66);
            txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            txtTenLoaiPhong.Size = new Size(229, 27);
            txtTenLoaiPhong.TabIndex = 3;
            txtTenLoaiPhong.TextChanged += txtTenLoaiPhong_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(434, 69);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá:";
            label3.Click += label2_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(505, 66);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(161, 27);
            txtDonGia.TabIndex = 3;
            txtDonGia.Text = "0";
            txtDonGia.TextAlign = HorizontalAlignment.Center;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(690, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(790, 65);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(890, 64);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // FormLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 226, 255);
            ClientSize = new Size(1087, 463);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenLoaiPhong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDmLoaiPhong);
            Controls.Add(label1);
            Name = "FormLoaiPhong";
            Text = "FormLoaiPhong";
            Load += FormLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDmLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDmLoaiPhong;
        private Label label2;
        private TextBox txtTenLoaiPhong;
        private Label label3;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}