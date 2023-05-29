using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_QuanLyTaiKhoan:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTaiKhoan()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from DangNhap", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from DangNhap where taiKhoan='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themTaiKhoan(DangNhap dangNhap)
        {
            string sql = "insert into DangNhap values('" + dangNhap.taiKhoan + "','" + dangNhap.matKhau + "',N'" + dangNhap.Quyen + "')";
            thucthisql(sql);
            return true;

        }

        public bool doiMatKhau(DangNhap dangNhap)
        {
            string sql = "Update  DangNhap set matKhau=N'" + dangNhap.matKhau + "'where taiKhoan='" + dangNhap.taiKhoan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaTaiKhoan(string taiKhoan)
        {

            string sql = "Delete from DangNhap where taiKhoan='" + taiKhoan + "'";
            thucthisql(sql);
            return true;
        }
    }
}
