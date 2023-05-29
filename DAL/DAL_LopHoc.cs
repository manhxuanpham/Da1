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
    public class DAL_LopHoc:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getLopHoc()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Lop", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from Lop where maLop='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themLop(LopHoc lop)
        {
            string sql = "insert into Lop values('" + lop.MaLop + "',N'" + lop.TenLop + "',N'" + lop.MaKhoa + "')";
            thucthisql(sql);
            return true;

        }

        public bool suaLop(LopHoc lop)
        {
            string sql = "Update  Lop set tenLop=N'" + lop.TenLop + "',maKhoa=N'" + lop.MaKhoa + "' where maLop='" + lop.MaLop + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaLop(string ma)
        {
            string sql = "Delete from Lop where maLop='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
