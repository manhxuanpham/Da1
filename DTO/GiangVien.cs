using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public string maGV { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string noiSinh { get; set; }
        public string gioiTinh { get; set; }
        public string    soDienThoai { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }

        public GiangVien(string maGV, string hoTen, DateTime ngaySinh, string noiSinh, string gioiTinh, string soDienThoai, string email, string diaChi)
        {
            this.maGV = maGV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }
    }
}
