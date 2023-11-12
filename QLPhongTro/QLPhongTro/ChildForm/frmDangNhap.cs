using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QLPhongTro.ChildForm
{
    public partial class frmDangNhap : Form
    {
        private Database db;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            db = new Database();
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*new frmMain().ShowDialog();*/
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();


            if(tk == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                
            }
            else if (mk == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!");
                
            }
            else
            {
                string query = "Select *from tblQuanLy where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                if(modify.taiKhoanDNs(query).Count() > 0) 
                {
                    /*MessageBox.Show("Đăng nhập thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    this.Hide();
                    frmMain main = new frmMain();
                    main.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
