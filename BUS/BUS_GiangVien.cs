using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_GiangVien
    {
       DAL_GiangVien dalgv = new DAL_GiangVien();

        public DataTable getGiangVIen()
        {
            return dalgv.getGiangVien();
        }
       
        public int kiemtramatrung(string ma)
        {
            return dalgv.kiemtramatrung(ma);
        }
        public bool themGV(GiangVien gv)
        {
            return dalgv.themGV(gv);
        }
        public bool suaGV(GiangVien gv)
        {
            return dalgv.suagv(gv);
        }
        public bool xoaGV(string maGV)
        {
            return dalgv.xoagv(maGV);
        }
        public DataTable timKiemGV(string ten)
        {
            return dalgv.TimKiemGiangVien(ten);
        }
    }
}
