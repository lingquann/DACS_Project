using QLyPhongTro.FormCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyPhongTro
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var db = new Database();*/
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //Hàm add form
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            var f = new FormWellcome();
            AddForm(f);
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormLoaiPhong();
            AddForm(f);
        }

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormWellcome();
            AddForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormPhong();
            AddForm(f);
        }
    }
}