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
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }
        private Database db;
        private int maLoaiPhong = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text.Trim();
            var donGia = int.Parse(txtDonGia.Text);

            //Rang buoc du lieu
            if (String.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }
            if (donGia == null)
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }
            if (donGia < 50000)
            {
                MessageBox.Show("Đơn giá quá nhỏ, bạn đã nhập sai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }
            var prList = new List<CustomParameter>();
            prList.Add(new CustomParameter()
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });
            prList.Add(new CustomParameter()
            {
                key = "@donGia",
                value = donGia.ToString()
            });
            var rs = db.ExeCute("themLoaiPhong", prList);
            if (rs == 1)
            {
                MessageBox.Show("Thêm thành công!", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiPhong();
                txtDonGia.Text = null;
                txtTenLoaiPhong.Text = null;
            }
        }

        private void LoadDsLoaiPhong()
        {

            dgvDmLoaiPhong.DataSource = db.SelectData("LoadDsLoaiPhong");
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new Database();

            LoadDsLoaiPhong();
            dgvDmLoaiPhong.Columns[0].Width = 100;//set chieeuf roongj cho coojt id loai phong
            dgvDmLoaiPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDmLoaiPhong.Columns[0].HeaderText = "Mã";

            dgvDmLoaiPhong.Columns[2].Width = 200;
            dgvDmLoaiPhong.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDmLoaiPhong.Columns[2].HeaderText = "Đơn giá";

            dgvDmLoaiPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDmLoaiPhong.Columns[1].HeaderText = "Tên loại phòng";
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDmLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiPhong = int.Parse(dgvDmLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTenLoaiPhong.Text = dgvDmLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDmLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txtTenLoaiPhong.Text.Trim();
            var donGia = int.Parse(txtDonGia.Text);

            //Rang buoc du lieu
            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }
            if (String.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }

            if (donGia < 50000)
            {
                MessageBox.Show("Đơn giá quá nhỏ, bạn đã nhập sai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//dừng chương trình ngay đây
            }
            var prList = new List<CustomParameter>();
            prList.Add(new CustomParameter
            {
                key = "@idLoaiPhong",
                value = maLoaiPhong.ToString()
            });
            prList.Add(new CustomParameter()
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });
            prList.Add(new CustomParameter()
            {
                key = "@donGia",
                value = donGia.ToString()
            });
            var rs = db.ExeCute("capNhatLoaiPhong", prList);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thành công!", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiPhong();
                txtDonGia.Text = null;
                txtTenLoaiPhong.Text = null;
                maLoaiPhong = 0;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = maLoaiPhong.ToString()
                    }
                };
                var rs = db.ExeCute("xoaLoaiPhong", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa loại phòng thành công", "Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsLoaiPhong();
                    maLoaiPhong = 0; //reset ma loai phong sau khi xoa
                }
            }
        }
    }
}
