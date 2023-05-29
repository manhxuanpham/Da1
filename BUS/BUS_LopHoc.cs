using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace BUS
{
    public class BUS_LopHoc
    {
        DAL_LopHoc dallop = new DAL_LopHoc();

        public DataTable getLopHoc()
        {
            return dallop.getLopHoc();
        }
        public int kiemtramatrung(string ma)
        {
            return dallop.kiemtramatrung(ma);
        }
        public bool themLop(LopHoc lop)
        {
            return dallop.themLop(lop);
        }
        public bool suaLop(LopHoc lop)
        {
            return dallop.suaLop(lop);
        }
        public bool xoaLop(string ma)
        {
            return dallop.xoaLop(ma);
        }
    }
}
