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
    public partial class FormPhong : Form
    {
        private Database db;
        public FormPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThaoTacPhong(true).ShowDialog();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            loadDsPhong();
        }
        private void loadDsPhong()
        {
            db = new Database();
            var tinKiem = txtTimKiem.Text.Trim();
            var lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = tinKiem
                }
            };
            var dt = db.SelectData("loadDsPhong", lstPara);

            dgvPhong.DataSource = dt;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            new FormThaoTacPhong(false).ShowDialog();
        }
    }
}
