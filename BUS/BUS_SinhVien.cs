using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien dalsv = new DAL_SinhVien();

        public DataTable getSinhVien()
        {
            return dalsv.getSinhVien();
        }
        public DataTable Locsinhvien(string ma)
        {
            return dalsv.LocSinhVienTheoLop1(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalsv.kiemtramatrung(ma);
        }
        public bool themSV(SinhVien sv)
        {
            return dalsv.themSV(sv);
        }
        public bool suaSV(SinhVien sv)
        {
            return dalsv.suaSV(sv);
        }
        public bool xoaSV(string maSV)
        {
            return dalsv.xoaSV(maSV);
        }
        public DataTable timKiemSV(string ten)
        {
            return dalsv.TimKiemSinhVien(ten);
        }
      
    }
}
