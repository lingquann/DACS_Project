using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro
{
    class TaiKhoanDN
    {
        private string taiKhoan;
        private string matKhau;

        public TaiKhoanDN()
        {
        }

        public TaiKhoanDN(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
