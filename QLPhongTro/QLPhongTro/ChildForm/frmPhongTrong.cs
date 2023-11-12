using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmPhongTrong : Form
    {
        private Database db;
        public frmPhongTrong()
        {
            InitializeComponent();
        }
        private void LoadDsPhongTrong()
        {

            dgvPhongTrong.DataSource = db.SelectData("LoadDsPhongTrong");
        }
        private void frmPhongTrong_Load(object sender, EventArgs e)
        {
            db = new Database();

            LoadDsPhongTrong();
            dgvPhongTrong.Columns["TenLoaiPhong"].HeaderText = "Loại phòng";
            dgvPhongTrong.Columns["TenPhong"].HeaderText = "Phòng";
            dgvPhongTrong.Columns["DonGia"].HeaderText = "Đơn giá";




            dgvPhongTrong.Columns["ID"].Width = 100;
            dgvPhongTrong.Columns["TenLoaiPhong"].Width = 200;
            dgvPhongTrong.Columns["DonGia"].Width = 200;


            dgvPhongTrong.Columns["TenPhong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvPhongTrong.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPhongTrong.Columns["DonGia"].DefaultCellStyle.Format = "N0";
        }
    }
}
