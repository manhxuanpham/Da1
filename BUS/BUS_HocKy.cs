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
    public class BUS_HocKy
    {
        DAL_HocKy dalhocky = new DAL_HocKy();
        
        public DataTable getHocKy()
        {
            return dalhocky.getHocKy();
        }
        public int kiemtramatrung(string ma)
        {
            return dalhocky.kiemtramatrung(ma);
        }
        public bool themHocKy(HocKy hocKy)
        {
            return dalhocky.themHocKy(hocKy);
        }
        public bool suaHocKy(HocKy hocky)
        {
            return dalhocky.suaHocKy(hocky);
        }
        public bool xoaHocKy(string ma)
        {
            return dalhocky.xoaHocKy(ma);
        }
        public DataTable getNamHoc()
        {
            return dalhocky.getNamHoc();
        }
    }
}
