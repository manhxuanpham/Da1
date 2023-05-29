using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_DiemHP
    {
        DAL_NhapDiemHP dalDiemHP = new DAL_NhapDiemHP();
        public DataTable getDiemHP( )
        {
            return dalDiemHP.GetDiem();
        }
        public DataTable getNamHoc()
        {
            return dalDiemHP.getNamHoc();
        }
        public DataTable getHocKyTheoNamHoc(string MaNamHoc)
        {
            return dalDiemHP.getHocKyTheoNamHoc(MaNamHoc);
        }
        public DataTable getMonHocTheoHocKy(string MaHocKy)
        {
            return dalDiemHP.getMonHocTheoHocKy(MaHocKy);
        }
        public DataTable getHocPhan()
        {
            return dalDiemHP.getHocPhan();
        }
        public DataTable getHocKy()
        {
            return dalDiemHP.getHocKy();    
        }
        public DataTable getLopHoc()
        {
            return dalDiemHP.getLopHoc();
        }
        public DataTable getMaLop(string ma)
        {
            return dalDiemHP.getMalop(ma);
        }
        public DataTable getSinhVien()
        {
            return dalDiemHP.getSinhVien();
        }
        public DataTable getMonHocPhan()
        {
            return dalDiemHP.getHocPhan();
        }
        public DataTable GetDiemHP()
        {
            return dalDiemHP.GetDiemHP();
        }
        
        public DataTable getSVtheoLop(string malop,string mahp)
        {
            return dalDiemHP.getSVtheoLopvaMHP(malop,mahp) ;
        }
        public DataTable getLopHocTheoMon(string mahp)
        {
            return dalDiemHP.getLopHocTheoMon(mahp);
        }
        public int DuyetDiemHP(string maMon, string maSV)
        {
            return dalDiemHP.DuyetDiemHP(maMon,maSV);
        }
        public bool CapNhatDiemHP(string maMon,string maSV)
        {
            return dalDiemHP.CapNhatDiemHP(maMon,maSV);
        }
        public bool CapNhatDiemTB()
        {
            return dalDiemHP.CapNhatDiemTB();
        }
        public bool CapNhatDiemTB2()
        {
            return dalDiemHP.CapNhatDiemTB2();
        }

        public DataTable LocSinhVienTheoHP(string ma)
        {
            return dalDiemHP.LocSinhVienTheoHP(ma);
        }
        public bool NhapDiemTP(string maMonHocPhan,string maSV,float DiemTP)
        {
            return dalDiemHP.NhapDiemTP(maMonHocPhan, maSV, DiemTP);
        }
        public bool NhapDiemThi(string maMonHocPhan, string maSV, float diemThi)
        {
            return dalDiemHP.NhapDiemThi(maMonHocPhan, maSV, diemThi);
        }
        public bool NhapDiemTP2(string maMonHocPhan, string maSV, float DiemTP2)
        {
            return dalDiemHP.NhapDiemTP2(maMonHocPhan, maSV, DiemTP2);
        }
        public bool NhapDiemThi2(string maMonHocPhan, string maSV, float diemThi2)
        {
            return dalDiemHP.NhapDiemThi2(maMonHocPhan, maSV, diemThi2);
        }


    }
}
