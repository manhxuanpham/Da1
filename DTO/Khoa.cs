using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Khoa(string MaKhoa,string TenKhoa)
        {
            this.MaKhoa = MaKhoa;
            this.TenKhoa = TenKhoa;
        }
    }
}
   