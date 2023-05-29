using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemHP
    {
        public string MaSV { get; set; }
        public string MaGV { get; set; }
        public string MaHocPhan { get; set; } 
        public float DiemThanhPhan { get; set; }
        public float DiemThi { get; set; }

        public string MaHocKy { get; set; }
        public DiemHP(string MaSV,string MaGV,string MaHocPhan, float DiemThanhPhan,float DiemThi,string MaHocKy)
        {
            this.MaSV = MaSV;
            this.MaGV = MaGV;  
            this.MaHocPhan = MaHocPhan;
            this.DiemThanhPhan = DiemThanhPhan;
            this.DiemThi = DiemThi;
            this.MaHocKy = MaHocKy;
        }
    }
}
