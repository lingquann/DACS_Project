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
    public partial class frmTraPhong : Form
    {
        public frmTraPhong(string idHopDong)
        {
            this.idHopDong = idHopDong;
            InitializeComponent();

        }
        string idHopDong;
        private Database db = new Database();

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            var ls = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = idHopDong
                }
            };
            var dt = db.SelectData("ChotHopDong", ls);
            txtSoNo.Text = dt.Rows[0]["no"].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền mà khách đã thanh toán!");
                return; //k chạy tiếp các lệnh dưới
            }
            var stn = int.Parse(txtSoNo.Text);
            var stt = int.Parse(txtTra.Text);
            var ok = true;

            if (stt < stn && MessageBox.Show("Bạn vẫn tiếp tục thao tác trả phòng?",
                "Số tiền khách thanh toán chưa đủ so với số nợ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                ok = false;
            }
            if (ok)
            {
                var ls = new List<CustomParameter> {
                    new CustomParameter
                    {
                        key = "@idHopDong",
                        value = idHopDong
                    },
                   new CustomParameter
                    {
                        key = "@soTienTra",
                        value = string.Format("{0}", stt > stn ? stn : stt)
                   }
                };
                if (db.ExeCute("ThanhToanVaTraPhong", ls) >= 1)
                {
                    MessageBox.Show("Thanh toán hợp đồng và trả phòng thành công!", "SuccesFully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }
    }
}


