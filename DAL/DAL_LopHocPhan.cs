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
    public class DAL_LopHocPhan:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable getLopHocPhan()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from LopHocPhan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getHocPhan()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from HocPhan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getGiangVien()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from GiangVien", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getLopHoc()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Lop", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool themLopHocPhan(LopHocPhan hocPhan)
        {
            string sql = "insert into LopHocPhan values('" + hocPhan.maLop + "','" + hocPhan.maHocPhan + "','" + hocPhan.maGV + "')";
            thucthisql(sql);
            return true;

        }

        public bool suaLopHocPhan(LopHocPhan hocPhan)
        {
            string sql = "Update  LopHocPhan set maGV=N'" + hocPhan.maGV + "',maHocPhan=N'" + hocPhan.maHocPhan + "' where maLop='" + hocPhan.maLop + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaLopHocPhan(string ma)
        {
            string sql = "Delete from LopHocPhan where maLop='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
