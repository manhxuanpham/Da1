using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_NhapDiemHP:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public bool NhapDiem(DiemHP diemHP)
        {
            string sql = "Update  DiemHP set DiemTP=N'" + diemHP.DiemThanhPhan + "',DiemThi=N'" + diemHP.DiemThi + "' where MaSV='" + diemHP.MaSV + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable GetDiem()
        {
            DataTable dt = new DataTable();
            _con.Open();
            da = new SqlDataAdapter("select s.maSv, s.hoTen, h.tenHocPhan,d.diemTP,d.diemThi,diemTP2,diemThi2 from SinhVien s left join DiemHP d on s.maSv = d.maSV left join HocPhan h on h.maHocPhan = d.maHocPhan", _con);
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
        public DataTable getHocKyTheoNamHoc(string MaNamHoc)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from HocKy where MaNamHoc='"+MaNamHoc+"' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getMonHocTheoHocKy(string MaHocKy)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from LopHocPhan where MaHocKy='" + MaHocKy + "' ", _con);
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
        public DataTable getMalop(string malop)
        {
            _con.Open();
            da = new SqlDataAdapter("select masv,hoten from SinhVien where malop ='" + malop+"' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSinhVien( )
        {
            _con.Open();
            da = new SqlDataAdapter("select * from SinhVien ", _con);
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
        public DataTable getHocKy()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from Hocky", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getLopHocTheoMon(string mahp)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from LopHocPhan where maHocPhan = '"+mahp+"'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSVtheoLopvaMHP(string malop,string mahp)
        {
            _con.Open();
            da = new SqlDataAdapter("select s.maSv, s.hoTen, d.maHocPhan,d.diemTP,d.diemThi,d.diemTP2,d.diemThi2 from SinhVien s left join DiemHP d on s.maSv = d.maSV where s.maLop = '"+malop+"' and d.maHocPhan='"+ mahp + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable GetDiemHP()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from DiemHP" , _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public int DuyetDiemHP(string maMon,string maSV)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from DiemHP where maSv='" + maSV.Trim() + "' and maHocPhan='" + maMon + "'" ;
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool CapNhatDiemHP(string maHocPhan, string masv)
        {

            string sql = "insert into DiemHP(maSV,maHocPhan) values('" + masv + "','" + maHocPhan + "') ";
            thucthisql(sql);
            return true;
        }
        public bool CapNhatDiemTB()
        {
            string sql = "UPDATE DiemHP SET diemTB = diemTP * 0.5 + diemThi * 0.5  ";
            thucthisql(sql);
            return true;
        }
        public bool CapNhatDiemTB2()
        {
            string sql = "UPDATE DiemHP SET diemTB2 = diemTP2 * 0.5 + diemThi2 * 0.5  ";
            thucthisql(sql);
            return true;
        }
        public DataTable LocSinhVienTheoHP(string ma)
        {

            _con.Open();
            da = new SqlDataAdapter("select s.maSv, s.hoTen, h.tenHocPhan,d.diemTP,d.diemThi from SinhVien s left join DiemHP d on s.maSv = d.maSV  left join HocPhan h on h.maHocPhan = d.maHocPhan where d.maHocPhan = '" + ma + "' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public bool NhapDiemTP(string maHocPhan, string masv,float diemTP)
        {

            string sql = "update  diemHP set diemTP ='"+diemTP+ "'   where maSV = '" + masv+"' and mahocphan = '"+maHocPhan+"' ";
            thucthisql(sql);
            return true;
        }
        public bool NhapDiemThi(string maHocPhan, string masv, float diemThi)
        {

            string sql = "update  diemHP set diemThi ='" + diemThi + "'   where maSV = '" + masv + "' and mahocphan = '" + maHocPhan + "' ";
            thucthisql(sql);
            return true;
        }
        public bool NhapDiemTP2(string maHocPhan, string masv, float diemTP2)
        {

            string sql = "update  diemHP set diemTP2 ='" + diemTP2 + "'   where maSV = '" + masv + "' and mahocphan = '" + maHocPhan + "' ";
            thucthisql(sql);
            return true;
        }
        public bool NhapDiemThi2(string maHocPhan, string masv, float diemThi2)
        {

            string sql = "update  diemHP set diemThi2 ='" + diemThi2 + "'   where maSV = '" + masv + "' and mahocphan = '" + maHocPhan + "' ";
            thucthisql(sql);
            return true;
        }
    }
}
