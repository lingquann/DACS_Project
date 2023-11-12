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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //hàm add form lên groupbox có tên là grbContent
        private void AddForm(Form f)
        {
            this.grbWellcome.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbWellcome.Controls.Add(f);
            f.Show();
        }
        private void grbWellcome_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmPhongTrong();
            AddForm(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            AddForm(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new frmDichVu();
            AddForm(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmThue().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            AddForm(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }
    }
}
