using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_DangNhap : Form
    {
        BUS_DangNhap bus_DangNhap = new BUS_DangNhap();
        private string maSV;
        
        public GUI_DangNhap(string maSV)
        {
            this.maSV = maSV;
                       
        }


        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            btnDangNhap.TextAlign = ContentAlignment.MiddleCenter;
           

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string Quyen = cbbQuyenDN.Text.ToString();

            if(bus_DangNhap.KiemTraTK(taiKhoan, matKhau,Quyen).Rows.Count > 0 )
            {
                if (Quyen == "Admin")
                {
                    MessageBox.Show("Đăng Nhập Thành Công Với Quyền Admin");
                    this.Hide();
                    GUI_ChucNang f = new GUI_ChucNang();
                    f.Show();
                }
                if (Quyen == "Sinh Viên")
                {
                    MessageBox.Show("Đăng Nhập Thành Công Với Quyền Sinh Viên");
                    this.Hide();
                    GUI_ChucNangSV f = new GUI_ChucNangSV(taiKhoan);
                    f.Show();
                    
                }
                if (Quyen == "Giảng Viên")
                {
                    MessageBox.Show("Đăng Nhập Thành Công Với Quyền Giảng Viên");
                    this.Hide();
                    GUI_ChucNangGV f = new GUI_ChucNangGV();
                    f.Show();
                }

            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác");
            }

            


        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
