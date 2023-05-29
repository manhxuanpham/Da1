using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{   
    
    public class DAL_BaoCao:DBconnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getSVHocLai()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT DISTINCT   s.maSV, s.hoTen, s.malop, d.maHocPhan, h.soTinChi, h.tenHocPhan, d.diemThi, lh.maHocKy FROM    SinhVien s    INNER JOIN DiemHP d ON s.maSV = d.maSV    inner join HocPhan h on h.maHocPhan = d.maHocPhan inner join LopHocPhan lh on lh.maHocPhan = d.maHocPhan inner join HocKy hk on hk.maHocKy = lh.maHocKy WHERE    d.diemThi < 5; ", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable getSVHocBong(string mahk)
        {
            _con.Open();
            da = new SqlDataAdapter("WITH DiemXepLoaiToanKhoa AS(SELECT s.maLop, s.maSV, s.hoTen, SUM(d.diemTB * h.soTinChi) / SUM(h.soTinChi) AS diemXepLoai FROM SinhVien s INNER JOIN DiemHP d ON s.maSV = d.maSV INNER JOIN HocPhan h ON h.maHocPhan = d.maHocPhan INNER JOIN LopHocPhan lh on lh.maHocPhan = h.maHocPhan INNER JOIN HocKy hk on hk.maHocKy = lh.maHocKy Where lh.maHocKy = '" + mahk+"' GROUP BY s.maLop, s.maSV, s.hoTen HAVING MIN(d.diemThi) >= 5.0 and SUM(h.sotinchi) > 10) SELECT t1.maLop, t1.maSV, t1.hoTen, round(t1.diemXepLoai, 2) FROM DiemXepLoaiToanKhoa t1 WHERE(SELECT COUNT(*) FROM DiemXepLoaiToanKhoa t2 WHERE t2.maLop = t1.maLop AND    t2.diemXepLoai > t1.diemXepLoai) < 2", _con);
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
    }
}
