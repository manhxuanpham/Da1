using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_SinhVien:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable getSinhVien()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from SinhVien", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable LocSinhVienTheoLop1(string ma)
        {

            _con.Open();
            da = new SqlDataAdapter("select * from SinhVien where maLop='"+ma+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
     
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from SinhVien where maSv='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themSV(SinhVien sv)
        {
            string ngay = string.Format("{0}/{1}/{2}", sv.ngaySinh.Year, sv.ngaySinh.Month, sv.ngaySinh.Day);
            string sql = "Insert into SinhVien values('" + sv.maSV + "',N'" + sv.hoTen + "','" + ngay + "',N'" + sv.noiSinh + "',N'" + sv.gioiTinh + "',N'" + sv.diaChi + "','" + sv.soDienThoai + "','" + sv.email + "','" + sv.maLop + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaSV(SinhVien sv)
        {
            string ngay = string.Format("{0}/{1}/{2}", sv.ngaySinh.Year, sv.ngaySinh.Month, sv.ngaySinh.Day);
            string sql = "Update SinhVien set hoTen=N'" + sv.hoTen + "', ngaySinh='" + ngay + "', noiSinh=N'" + sv.noiSinh + "', gioiTinh=N'" + sv.gioiTinh + "', diaChi=N'" + sv.diaChi + "', soDienThoai='" + sv.soDienThoai + "', email='" + sv.email + "', maLop='" + sv.maLop + "' where maSv='" + sv.maSV + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaSV(string ma)
        {
            string sql = "Delete from SinhVien where MaSv='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        //public bool timKiemSV(string ma)
        //{
        //    string sql = "Select * from SinhVien where MaSv='"+ma+"'";
        //    thucthisql(sql);
        //    return true;
        //}
        public DataTable LocSinhVienTheoLop(string ma)
        {
            
            _con.Open();
            da = new SqlDataAdapter("Select * from SinhVien where maLop='" + ma + "' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable TimKiemSinhVien ( string ten)
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from SinhVien where maSv='" + ten + "'or hoTen like N'%"+ten+"%' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        
    }
}
