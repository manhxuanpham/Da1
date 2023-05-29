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
    public class BUS_LopHocPhan
    {
        DAL_LopHocPhan dAL_LopHocPhan = new DAL_LopHocPhan();
        
        public DataTable getLopHocPhan()
        {
            return dAL_LopHocPhan.getLopHocPhan();
        }
        public DataTable getLopHoc()
        {
            return dAL_LopHocPhan.getLopHoc();
        }
        public DataTable getHocPhan()
        {
            return dAL_LopHocPhan.getHocPhan();
        }
        public DataTable getGiangVien()
        {
            return dAL_LopHocPhan.getGiangVien();
        }

        public bool themLopHocPhan(LopHocPhan lopHocPhan)
        {
            return dAL_LopHocPhan.themLopHocPhan(lopHocPhan);
        }
        public bool suaLopHocPhan(LopHocPhan lopHocPhan)
        {
            return dAL_LopHocPhan.suaLopHocPhan(lopHocPhan);
        }
        public bool xoaLopHocPhan(string ma)
        {
            return dAL_LopHocPhan.xoaLopHocPhan(ma);
        }
    }
}
