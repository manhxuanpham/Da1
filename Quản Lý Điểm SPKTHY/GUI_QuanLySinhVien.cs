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
using DTO;
using BUS;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_QuanLySinhVien : Form
    {
        BUS_SinhVien bussv = new BUS_SinhVien();
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        public GUI_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void GUI_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            dtgvDSSV.DataSource = bussv.getSinhVien();
            // Đổ tên lớp ra cbb danh sách lớp
            cbbDSLop.DataSource = busLopHoc.getLopHoc();
            cbbDSLop.DisplayMember = "maLop";
            cbbDSLop.ValueMember = "maLop";
            //Đổ mã lớp ra cbb mã Lớp
            cbbMaLop.DataSource = busLopHoc.getLopHoc();
            cbbMaLop.DisplayMember = "maLop";
            cbbMaLop.ValueMember = "maLop";




            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;
            btnTimKiem.TextAlign = ContentAlignment.MiddleCenter;





        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            if (bussv.xoaSV(masv) == true)
            {
                MessageBox.Show("xoá Thành Công");
                dtgvDSSV.DataSource = bussv.getSinhVien();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string noiSinh = txtNoiSinh.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string email = txtEmail.Text;
            string maLop = cbbMaLop.SelectedValue.ToString();
            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, noiSinh, gioiTinh, diachi, soDienThoai, email,maLop);

            if (bussv.kiemtramatrung(maSV) == 1)
            {
                MessageBox.Show("Mã sinh viên bị trùng");

            }
            else
            {
                if (bussv.themSV(sv) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dtgvDSSV.DataSource = bussv.getSinhVien();
                }
            }
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
           

            int hang = e.RowIndex;
            if (dtgvDSSV.CurrentCell == null || dtgvDSSV.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMaSV.Text = dtgvDSSV[0, hang].Value.ToString();
                txtHoTen.Text = dtgvDSSV[1, hang].Value.ToString();
                dtpNgaySinh.Text = dtgvDSSV[2, hang].Value.ToString();
                txtNoiSinh.Text = dtgvDSSV[3, hang].Value.ToString();
                txtGioiTinh.Text = dtgvDSSV[4, hang].Value.ToString();
                txtDiaChi.Text = dtgvDSSV[5, hang].Value.ToString();
                txtSDT.Text = dtgvDSSV[6, hang].Value.ToString();
                txtEmail.Text = dtgvDSSV[7, hang].Value.ToString();
                cbbMaLop.Text = dtgvDSSV[8, hang].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string noiSinh = txtNoiSinh.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string email = txtEmail.Text;
            string maLop = cbbMaLop.SelectedValue.ToString();

            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, noiSinh, gioiTinh, diachi, soDienThoai, email,maLop);

            if (bussv.suaSV(sv) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                dtgvDSSV.DataSource = bussv.getSinhVien();
            }
        }

      

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //var dr = bussv.LocSinhVienTheoLop1(cbbDSLop.Text.ToString().Trim());
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dr.Close();
            //dtgvDSSV.DataSource = dt;
        }

      
        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            //    var dr = bussv.LocSinhVienTheoLop1("125217");
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    dr.Close();
            //    dtgvDSSV.DataSource = dt;
            

        }

        private void cbbDSLop_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void cbbDSLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string ma = cbbDSLop.SelectedValue.ToString().Trim();
            dtgvDSSV.DataSource = bussv.Locsinhvien(ma);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            
            
            dtgvDSSV.DataSource=bussv.timKiemSV(ten);
        }

        private void dtgvDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtMaSV.Text.Length >= 8)
            {
                e.Handled = true; // Loại bỏ ký tự nhập vào
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtSDT.Text.Length >= 10)
            {
                e.Handled = true; // Loại bỏ ký tự nhập vào

            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
