using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string noiSinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string maLop { get; set; }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string noiSinh, string gioiTinh, string diaChi, string soDienThoai, string email,string maLop)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.noiSinh = noiSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.maLop = maLop;
        }



    }
}
