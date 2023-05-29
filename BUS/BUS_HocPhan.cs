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
    public class BUS_HocPhan
    {
        DAL_HocPhan dalhocphan = new DAL_HocPhan();
        public DataTable getHocPhan()
        {
            return dalhocphan.getHocPhan();
        }
        public DataTable getHocKy()
        {
            return dalhocphan.getHocKy();
        }
        public int kiemtramatrung(string ma)
        {
            return dalhocphan.kiemtramatrung(ma);
        }
        public bool themHocPhan(HocPhan hocphan)
        {
            return dalhocphan.themHocPhan(hocphan);
        }
        public bool suaHocPhan(HocPhan hocphan)
        {
            return dalhocphan.suaHocPhan(hocphan);
        }
        public bool xoaHocPhan(string ma)
        {
            return dalhocphan.xoaHocPhan(ma);
        }
    }
}
