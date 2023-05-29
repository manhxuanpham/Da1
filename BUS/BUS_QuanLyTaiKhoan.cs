using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_QuanLyTaiKhoan
    {
        DAL_QuanLyTaiKhoan dAL_QuanLyTaiKhoan = new DAL_QuanLyTaiKhoan();
        public DataTable getTaiKhoan()
        {
            return dAL_QuanLyTaiKhoan.getTaiKhoan();
        }
        public int kiemtramatrung(string ma)
        {
            return dAL_QuanLyTaiKhoan.kiemtramatrung(ma);
        }
        public bool themTaiKhoan(DangNhap dangNhap)
        {
            return dAL_QuanLyTaiKhoan.themTaiKhoan(dangNhap);
        }
        public bool doiMatKhau(DangNhap dangNhap)
        {
            return dAL_QuanLyTaiKhoan.doiMatKhau(dangNhap);
        }
        public bool xoaTaiKhoan(string taiKhoan)
        {
            return dAL_QuanLyTaiKhoan.xoaTaiKhoan(taiKhoan);
        }
        
    }
}
