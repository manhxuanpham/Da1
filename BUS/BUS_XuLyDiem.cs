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
    public class BUS_XuLyDiem
    {
        DAL_XuLyDiem dAL_XuLyDiem = new DAL_XuLyDiem();
        public DataTable getXuLyDiem(string masv)
        {
            return dAL_XuLyDiem.GetXulyDiem(masv);
        }
        public DataTable getSinhVien(string masv)
        {
            return dAL_XuLyDiem.getSinhVien(masv);
        }
        public float getXuLyDiemToanKhoa(string masv)
        {
            return dAL_XuLyDiem.getXuLyDiemToanKhoa(masv);
        }
    }
}
