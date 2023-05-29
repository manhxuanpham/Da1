using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_HocPhan:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHocPhan()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from HocPhan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getHocKy()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from HocKy", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from HocPhan where maHocPhan='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHocPhan(HocPhan hocphan)
        {
            string sql = "insert into HocPhan values('" + hocphan.maHocPhan + "',N'" + hocphan.tenHocPhan + "','" + hocphan.soTinChi + "','" + hocphan.maHocKy + "')";
            thucthisql(sql);
            return true;

        }

        public bool suaHocPhan(HocPhan hocphan)
        {
            string sql = "Update  HocPhan set tenHocPhan=N'" + hocphan.tenHocPhan + "',soTinChi='" + hocphan.soTinChi + "',maHocKy='" + hocphan.maHocKy + "' where maHocPhan='" + hocphan.maHocPhan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHocPhan(string ma)
        {
            
            string sql = "Delete from HocPhan where maHocPhan='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
