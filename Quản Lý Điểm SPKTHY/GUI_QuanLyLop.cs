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
    public partial class GUI_QuanLyLop : Form
    {
        BUS_LopHoc buslophoc = new BUS_LopHoc();
        BUS_Khoa busKhoa = new BUS_Khoa();
        public GUI_QuanLyLop()
        {
            InitializeComponent();
        }
      
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_QuanLyLop_Load(object sender, EventArgs e)
        {
            dtgvDSLop.DataSource = buslophoc.getLopHoc();

            //---------
            cbbDSKhoa.DataSource = busKhoa.getKhoa();
            cbbDSKhoa.DisplayMember = "tenKhoa";
            cbbDSKhoa.ValueMember = "maKhoa";

            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;



        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaLop = txtMalop.Text;
            string TenLop = txtTenLop.Text;
            string MaKhoa = cbbDSKhoa.SelectedValue.ToString().Trim();
            LopHoc lh = new LopHoc(MaLop,TenLop,MaKhoa);
            if(buslophoc.kiemtramatrung(MaLop)==1)
            {
                MessageBox.Show("Mã Trùng");
            }
            else
            {
                if(buslophoc.themLop(lh) == true)
                {
                    dtgvDSLop.DataSource = buslophoc.getLopHoc();
                }
            }

        }

        private void cbbDSKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaLop = txtMalop.Text;
            string TenLop = txtTenLop.Text;
            string MaKhoa = cbbDSKhoa.SelectedValue.ToString().Trim();
            LopHoc lh = new LopHoc(MaLop, TenLop, MaKhoa);
            if(buslophoc.suaLop(lh) == true)
            {
                MessageBox.Show("Sửa Thành Công");
                dtgvDSLop.DataSource=buslophoc.getLopHoc();
            }
        }

        private void dtgvDSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
          
           


            if (dtgvDSLop.CurrentCell == null || dtgvDSLop.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMalop.Text = dtgvDSLop[0, hang].Value.ToString().Trim();
                txtTenLop.Text = dtgvDSLop[1, hang].Value.ToString().Trim();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMalop.Text.Trim();
            if (buslophoc.xoaLop(ma) == true)
            {
                MessageBox.Show("Xoá Thành Công");
                dtgvDSLop.DataSource = buslophoc.getLopHoc();
            }
        }

        private void dtgvDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
