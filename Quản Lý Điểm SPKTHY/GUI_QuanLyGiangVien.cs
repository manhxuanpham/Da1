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
    public partial class GUI_QuanLyGiangVien : Form
    {
        BUS_GiangVien busgv = new BUS_GiangVien();
        public GUI_QuanLyGiangVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            dtgvDSGV.DataSource = busgv.getGiangVIen();
            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;
            btnTimKiem.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string noiSinh = txtNoiSinh.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string email = txtEmail.Text;
            
            GiangVien gv = new GiangVien(maGV, hoTen, ngaySinh, noiSinh, gioiTinh, soDienThoai, email, diachi);

            if (busgv.kiemtramatrung(maGV) == 1)
            {
                MessageBox.Show("Mã sinh viên bị trùng");

            }
            else
            {
                try
                {
                    if (busgv.themGV(gv) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvDSGV.DataSource = busgv.getGiangVIen();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            string noiSinh = txtNoiSinh.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diachi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string email = txtEmail.Text;

            GiangVien gv = new GiangVien(maGV, hoTen, ngaySinh, noiSinh, gioiTinh, soDienThoai, email, diachi);
            try
            {
                if (busgv.suaGV(gv) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dtgvDSGV.DataSource = busgv.getGiangVIen();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaGV.Text;
            DialogResult logxoa = MessageBox.Show("Bạn Có chắc chắn muốn xoá không ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (logxoa == DialogResult.Yes)
            {
                if (busgv.xoaGV(ma) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    dtgvDSGV.DataSource = busgv.getGiangVIen();

                }
            }
           

        }

        private void dtgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int hang = e.RowIndex;
            if (dtgvDSGV.CurrentCell == null || dtgvDSGV.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMaGV.Text = dtgvDSGV[0, hang].Value.ToString();
                txtHoTen.Text = dtgvDSGV[1, hang].Value.ToString();
                dtpNgaySinh.Text = dtgvDSGV[2, hang].Value.ToString();
                txtNoiSinh.Text = dtgvDSGV[3, hang].Value.ToString();
                txtGioiTinh.Text = dtgvDSGV[4, hang].Value.ToString();
                txtSDT.Text = dtgvDSGV[5, hang].Value.ToString();
                txtEmail.Text = dtgvDSGV[6, hang].Value.ToString();
                txtDiaChi.Text = dtgvDSGV[7, hang].Value.ToString();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            busgv.timKiemGV(ten);
            dtgvDSGV.DataSource = busgv.timKiemGV(ten);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtSDT.Text.Length >= 10)
            {
                e.Handled = true; // Loại bỏ ký tự nhập vào
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10 || !IsNumeric(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Clear();
                txtSDT.Focus();
            }
        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
