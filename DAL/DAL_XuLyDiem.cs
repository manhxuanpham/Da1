using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_XuLyDiem : DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        public DataTable GetXulyDiem(string maSV)
        {
            _con.Open();
            string sql = "SELECT d.maHocPhan [Mã Học Phần],sotinchi [Số Tín Chỉ], diemTP [Điểm Thành Phần],    diemThi [Điểm Thi],	round(diemTB,1) [Điểm Trung Bình],	diemTP2 [Điểm Thành Phần 2],    diemThi2 [Điểm Thi 2],    CASE        WHEN diemTB >= 9.5 THEN 'A+'        WHEN diemTB >= 8.5 AND diemTB < 9.5 THEN 'A'        WHEN diemTB >= 8.0 AND diemTB < 8.5 THEN 'B+'        WHEN diemTB >= 7.0 AND diemTB < 8.0 THEN 'B'        WHEN diemTB >= 6.5 AND diemTB < 7.0 THEN 'C+'        WHEN diemTB >= 5.5 AND diemTB < 6.5 THEN 'C'        WHEN diemTB >= 5.0 AND diemTB < 5.5 THEN 'D+'        WHEN diemTB >= 4.0 AND diemTB < 5.0 THEN 'D'  ELSE 'F'    END AS [Điểm Chữ]  FROM SinhVien s left join DiemHP d on s.maSv = d.maSV left join HocPhan h on h.maHocPhan = d.maHocPhan where s.maSV = '" + maSV + "'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSinhVien(string masv)
        {
            _con.Open();
            da = new SqlDataAdapter("select * from SinhVien where masv= '" + masv + "' ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public float getXuLyDiemToanKhoa(string masv)
        {

            _con.Open();
            float i = 0 ;
            string sql = "SELECT round(SUM(diemTB * h.soTinChi) / SUM(soTinChi),2) AS diemXepLoaiToanKhoa FROM SinhVien s left join DiemHP d on s.maSv = d.maSV left join HocPhan h on h.maHocPhan = d.maHocPhan where s.maSV = '" + masv + "'";
            cmd = new SqlCommand(sql, _con);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                i = Convert.ToSingle(result);
            }
            _con.Close();
            return i;

        }

    }
}
