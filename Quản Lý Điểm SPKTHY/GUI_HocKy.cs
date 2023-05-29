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
using System.Data.SqlClient;
using System.Data;


namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_HocKy : Form
    {
        BUS_HocKy bushocky = new BUS_HocKy();
        public GUI_HocKy()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHocKy = txtMaHocKy.Text;
            string TenHocKy = txtTenHocKy.Text;
            string MaNamHoc = cbbNamHoc.SelectedValue.ToString();
            HocKy hocky = new HocKy(MaHocKy, TenHocKy,MaNamHoc);
            if(bushocky.kiemtramatrung(MaHocKy)==1)
            {
                MessageBox.Show("mã trùng");
            } 
            else
            {
                if(bushocky.themHocKy(hocky)==true)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dtgvDSHocKy.DataSource = bushocky.getHocKy();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaHocKy = txtMaHocKy.Text;
            string TenHocKy = txtTenHocKy.Text;
            string MaNamHoc = cbbNamHoc.SelectedValue.ToString();

            HocKy hocky = new HocKy(MaHocKy, TenHocKy,MaNamHoc);

            if(bushocky.suaHocKy(hocky)==true)
            {
                MessageBox.Show("Sủa Thành Công");
                dtgvDSHocKy.DataSource = bushocky.getHocKy();
            }
        }

        private void dtgvDSHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (dtgvDSHocKy.CurrentCell == null || dtgvDSHocKy.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMaHocKy.Text = dtgvDSHocKy[0, hang].Value.ToString().Trim();
                txtTenHocKy.Text = dtgvDSHocKy[1, hang].Value.ToString().Trim();

            }
        }

        private void dtgvDSHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHocKy.Text;
            if(bushocky.xoaHocKy(ma)==true)
            {
                MessageBox.Show("Xoá Thành Công");

                dtgvDSHocKy.DataSource = bushocky.getHocKy();
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_HocKy_Load(object sender, EventArgs e)
        {
            dtgvDSHocKy.DataSource = bushocky.getHocKy();

            cbbNamHoc.DataSource = bushocky.getNamHoc();
            cbbNamHoc.DisplayMember = "tenNamHoc";
            cbbNamHoc.ValueMember = "maNamHoc";



            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
