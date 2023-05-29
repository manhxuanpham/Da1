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
    public class BUS_DangNhap
    {
        DAL_DangNhap dAL_DangNhap = new DAL_DangNhap(); 
        public DataTable KiemTraTK(string taiKhoan,string matKhau,string Quyen)
        {
            return dAL_DangNhap.KiemTraTK(taiKhoan,matKhau,Quyen);
        }
    }
}
