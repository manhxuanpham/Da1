using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_QuanLyTaiKhoan : Form
    {
        BUS_QuanLyTaiKhoan bUS_QuanLyTaiKhoan = new BUS_QuanLyTaiKhoan();
        public GUI_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string quyen = cbbQuyenDN.Text.ToString();
            DangNhap dangNhap = new DangNhap(taiKhoan, matKhau, quyen);

            if (bUS_QuanLyTaiKhoan.kiemtramatrung(taiKhoan) == 1)
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại");
            }
            else

            if (bUS_QuanLyTaiKhoan.themTaiKhoan(dangNhap) == true)
            {
                dtgvDSTK.DataSource = bUS_QuanLyTaiKhoan.getTaiKhoan();

            }



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string quyen = cbbQuyenDN.Text.ToString();
            DangNhap dangNhap = new DangNhap(taiKhoan, matKhau, quyen);
            if (bUS_QuanLyTaiKhoan.doiMatKhau(dangNhap) == true)
            {
                dtgvDSTK.DataSource = bUS_QuanLyTaiKhoan.getTaiKhoan();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            if (bUS_QuanLyTaiKhoan.xoaTaiKhoan(taiKhoan) == true)
            {
                dtgvDSTK.DataSource = bUS_QuanLyTaiKhoan.getTaiKhoan();

            }
        }
    }
}
