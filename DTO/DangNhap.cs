using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap
    {
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }

        public string Quyen { get; set; }

        public DangNhap(string taiKhoan, string matKhau, string Quyen)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.Quyen = Quyen;
        }

    }
}
