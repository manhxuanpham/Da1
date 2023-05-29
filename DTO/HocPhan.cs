using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocPhan
    {
        public string maHocPhan { get; set; }
        public string tenHocPhan { get; set; }
        public int soTinChi { get; set; }
        public string maHocKy { get; set; }
        public HocPhan(string maHocPhan,string tenHocPhan,int soTinChi,string maHocKy)
        {
            this.maHocPhan = maHocPhan;
            this.tenHocPhan = tenHocPhan;
            this.soTinChi = soTinChi;
            this.maHocKy = maHocKy;
        }
    }
}
