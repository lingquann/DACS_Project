namespace QLyPhongTro.FormCon
{
    partial class FormThaoTacPhong
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
            grbContent = new GroupBox();
            btnHuy = new Button();
            btnXacNhan = new Button();
            ckbHoatDong = new CheckBox();
            txtTenPhong = new TextBox();
            label3 = new Label();
            label2 = new Label();
            labelMuc = new Label();
            label1 = new Label();
            cbbLoaiPhong = new ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            grbContent.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbContent
            // 
            grbContent.BackColor = Color.FromArgb(198, 226, 255);
            grbContent.Controls.Add(btnHuy);
            grbContent.Controls.Add(btnXacNhan);
            grbContent.Controls.Add(ckbHoatDong);
            grbContent.Controls.Add(txtTenPhong);
            grbContent.Controls.Add(label3);
            grbContent.Controls.Add(label2);
            grbContent.Controls.Add(labelMuc);
            grbContent.Controls.Add(label1);
            grbContent.Controls.Add(cbbLoaiPhong);
            grbContent.Dock = DockStyle.Fill;
            grbContent.Location = new Point(10, 33);
            grbContent.Name = "grbContent";
            grbContent.Size = new Size(532, 341);
            grbContent.TabIndex = 5;
            grbContent.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(313, 237);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(119, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.White;
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.Black;
            btnXacNhan.Location = new Point(173, 237);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(117, 29);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // ckbHoatDong
            // 
            ckbHoatDong.AutoSize = true;
            ckbHoatDong.Location = new Point(173, 182);
            ckbHoatDong.Name = "ckbHoatDong";
            ckbHoatDong.Size = new Size(103, 24);
            ckbHoatDong.TabIndex = 3;
            ckbHoatDong.Text = "Hoạt động";
            ckbHoatDong.UseVisualStyleBackColor = true;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(173, 136);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(318, 27);
            txtTenPhong.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(67, 183);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 1;
            label3.Text = " Trạng thái: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(67, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên phòng: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMuc
            // 
            labelMuc.AutoSize = true;
            labelMuc.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMuc.ForeColor = Color.DarkSlateGray;
            labelMuc.Location = new Point(37, 23);
            labelMuc.Name = "labelMuc";
            labelMuc.Size = new Size(202, 28);
            labelMuc.TabIndex = 1;
            labelMuc.Text = "THÊM PHÒNG MỚI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(67, 92);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 1;
            label1.Text = "Loại phòng:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbLoaiPhong
            // 
            cbbLoaiPhong.FormattingEnabled = true;
            cbbLoaiPhong.Location = new Point(173, 89);
            cbbLoaiPhong.Name = "cbbLoaiPhong";
            cbbLoaiPhong.Size = new Size(318, 28);
            cbbLoaiPhong.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(542, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 351);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 341);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(542, 10);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTitle);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(552, 33);
            panel4.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(47, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Xử lý";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_x_48;
            pictureBox1.Location = new Point(506, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormThaoTacPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 384);
            Controls.Add(grbContent);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormThaoTacPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThaoTacPhong";
            Load += FormThaoTacPhong_Load;
            grbContent.ResumeLayout(false);
            grbContent.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbContent;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtTenPhong;
        private Label label1;
        private ComboBox cbbLoaiPhong;
        private Label label3;
        private Label label2;
        private Label labelMuc;
        private Button btnHuy;
        private Button btnXacNhan;
        private CheckBox ckbHoatDong;
    }
}