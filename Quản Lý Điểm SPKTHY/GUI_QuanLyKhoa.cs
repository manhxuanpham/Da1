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
    public partial class GUI_QuanLyKhoa : Form
    {
        BUS_Khoa buskhoa = new BUS_Khoa();
        public GUI_QuanLyKhoa()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_QuanLyKhoa_Load(object sender, EventArgs e)
        {
           dtgvDSKhoa.DataSource = buskhoa.getKhoa();

            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;

            Khoa khoa = new Khoa(maKhoa, tenKhoa);

            if(buskhoa.kiemtramatrung(maKhoa) == 1) // Kiểm tra mã trùng 
            {
                MessageBox.Show("Mã Khoa Bị Trùng");
            }
            else
            {
                if(buskhoa.themKhoa(khoa)== true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dtgvDSKhoa.DataSource=buskhoa.getKhoa(); 
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;

            Khoa khoa = new Khoa(maKhoa, tenKhoa);

            if(buskhoa.suaKhoa(khoa)== true)
            {
                MessageBox.Show("Sửa Thành công");
                dtgvDSKhoa.DataSource = buskhoa.getKhoa();
            }
        }

        private void dtgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            
            
            if (dtgvDSKhoa.CurrentCell == null || dtgvDSKhoa.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMaKhoa.Text = dtgvDSKhoa[0, hang].Value.ToString().Trim();
                txtTenKhoa.Text = dtgvDSKhoa[1, hang].Value.ToString().Trim();
               
            }
        }

        private void dtgvDSKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            if(buskhoa.xoaKhoa(ma)== true)
            {
                MessageBox.Show("Xoá Thành Công");
                dtgvDSKhoa.DataSource=buskhoa.getKhoa();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
