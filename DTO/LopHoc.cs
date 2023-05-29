using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoa { get; set; }
        public LopHoc(string MaLop,string TenLop,string MaKhoa)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
            this.MaKhoa = MaKhoa;
        }
    }
}
