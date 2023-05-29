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
    public class DAL_Khoa:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getKhoa()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Khoa", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMaKhoa()
        {
            _con.Open();
            da = new SqlDataAdapter("select maKhoa from Khoa", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from Khoa where maKhoa='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themKhoa(Khoa khoa )
        {
            string sql = "insert into Khoa values('"+khoa.MaKhoa+"',N'"+khoa.TenKhoa+"')";
            thucthisql(sql);
            return true;
            
        }

        public bool suaKhoa(Khoa khoa)
        {
            string sql = "Update  Khoa set tenKhoa=N'" + khoa.TenKhoa + "'where maKhoa='" + khoa.MaKhoa + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaKhoa(string ma)
        {
            string sql = "Delete from Khoa where maKhoa='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
