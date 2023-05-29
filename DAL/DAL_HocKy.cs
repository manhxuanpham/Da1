using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_HocKy:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHocKy()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from HocKy", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getNamHoc()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from NamHoc", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from HocKy where maHocKy='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHocKy(HocKy hocky)
        {
            string sql = "insert into HocKy values('" +hocky.maHocKy  + "',N'" + hocky.tenHocKy+ "',N'" + hocky.maNamHoc + "')";
            thucthisql(sql);
            return true;

        }

        public bool suaHocKy(HocKy hocky)
        {
            string sql = "Update  HocKy set tenHocKy=N'" + hocky.tenHocKy + "' , maNamHoc=N'" + hocky.maNamHoc + "' where maHocKy='" + hocky.maHocKy + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHocKy(string ma)
        {
            string sql = "Delete from HocKy where maHocKy='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
