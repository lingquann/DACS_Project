using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyPhongTro.FormCon
{
    public partial class FormThaoTacPhong : Form
    {
        private bool themMoi;
        private Database db;
        public FormThaoTacPhong(bool themMoi)
        {
            this.themMoi = themMoi;

            InitializeComponent();
        }

        private void FormThaoTacPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            loadDsLoaiPhong();
            if (themMoi)
            {
                lblTitle.Text = "Thêm phòng mới";
                labelMuc.Text = "THÊM PHÒNG MỚI";
            }
            else
            {
                lblTitle.Text = "Cập nhật phòng";
                labelMuc.Text = "CẬP NHẬT PHÒNG";
            }
        }

        private void loadDsLoaiPhong()
        {
            var dt = db.SelectData("loadDsLoaiPhong");
            cbbLoaiPhong.DataSource = dt;
            cbbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbbLoaiPhong.ValueMember = "ID";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();//đóng form
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose(); //đóng
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            var idLoaiPhong = cbbLoaiPhong.SelectedValue.ToString();
            var tenPhong = txtTenPhong.Text.Trim();
            var trangThai = ckbHoatDong.Checked ? 1 : 0;
            if (String.IsNullOrEmpty(idLoaiPhong) || String.IsNullOrEmpty(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;
            }
            if (this.themMoi)//th theem moi
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = idLoaiPhong

                    },
                    new CustomParameter()
                    {
                        key = "@tenPhong",
                        value = tenPhong
                    },
                    new CustomParameter()
                    {
                        key = "@trangThai",
                        value = trangThai.ToString()
                    }
                };
                var rs = db.ExeCute("[themMoiPhong]", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else//th cap nhat da ton tai
            {

            }
        }
    }
}
