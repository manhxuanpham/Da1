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
    public class DAL_GiangVien:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable getGiangVien()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from GiangVien", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
     
        public SqlDataReader thucthisql2(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            SqlDataReader dr = cmd.ExecuteReader();
            _con.Close();
            return dr;
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from GiangVien where maGV='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themGV(GiangVien gv)
        {
            string ngay = string.Format("{0}/{1}/{2}", gv.ngaySinh.Year, gv.ngaySinh.Month, gv.ngaySinh.Day);
            string sql = "Insert into GiangVien values('" + gv.maGV + "',N'" + gv.hoTen + "','" + ngay + "',N'" + gv.noiSinh + "',N'" + gv.gioiTinh + "',N'" + gv.diaChi + "','" + gv.soDienThoai + "','" + gv.email + "')";

            thucthisql(sql);
            return true;
        }
        public bool suagv(GiangVien gv)
        {
            string ngay = string.Format("{0}/{1}/{2}", gv.ngaySinh.Year, gv.ngaySinh.Month, gv.ngaySinh.Day);
            string sql = "Update GiangVien set hoTen=N'" + gv.hoTen + "', ngaySinh='" + ngay + "', noiSinh=N'" + gv.noiSinh + "', gioiTinh=N'" + gv.gioiTinh + "', diaChi=N'" + gv.diaChi + "', soDienThoai='" + gv.soDienThoai + "', email='" + gv.email + "' where magv='" + gv.maGV + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoagv(string ma)
        {
            string sql = "Delete from GiangVien where maGV='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemGiangVien(string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from GiangVien where maGV='" + ten + "'or hoTen like N'%" + ten + "%' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
