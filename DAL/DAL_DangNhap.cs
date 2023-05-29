using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_DangNhap:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable KiemTraTK(string taiKhoan,string matKhau,string Quyen)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from DangNhap where taiKhoan = '"+taiKhoan+"' and matKhau = '"+matKhau+ "' and Quyen = N'" + Quyen + "' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;

        }
        

    }
}
