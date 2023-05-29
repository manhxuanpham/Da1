using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class BUS_BaoCao
    {
        DAL_BaoCao dAL_BaoCao = new DAL_BaoCao();
        public DataTable GetSVHocLai()
        {
            return dAL_BaoCao.getSVHocLai();
        }
        public DataTable getSVHocBong(string mahk)
        {
            return dAL_BaoCao.getSVHocBong(mahk);
        }
        public DataTable getHocKy()
        {
            return dAL_BaoCao.getHocKy();
        }
    }
}
