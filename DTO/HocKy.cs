using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocKy
    {
        public string maHocKy { get; set; }
        public string tenHocKy { get; set; }
        public string maNamHoc { get; set; }

        public HocKy(string maHocKy,string tenHocKy,string maNamHoc)
        {
            this.maHocKy = maHocKy;
            this.tenHocKy = tenHocKy;
            this.maNamHoc = maNamHoc;
        }
    }
}
