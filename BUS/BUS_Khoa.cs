using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Khoa
    {
        DAL_Khoa dalkhoa = new DAL_Khoa();
        public DataTable getMaKhoa()
        {
            return dalkhoa.getMaKhoa();
        }
        public DataTable getKhoa()
        {
            return dalkhoa.getKhoa();
        }
        public int kiemtramatrung(string ma)
        {
          return  dalkhoa.kiemtramatrung(ma);
        }
        public bool themKhoa(Khoa khoa)
        {
            return dalkhoa.themKhoa(khoa);
        }
        public bool suaKhoa(Khoa khoa)
        {
            return dalkhoa.suaKhoa(khoa);
        }
        public bool xoaKhoa(string ma)
        {
            return dalkhoa.xoaKhoa(ma);
        }
    }
}
