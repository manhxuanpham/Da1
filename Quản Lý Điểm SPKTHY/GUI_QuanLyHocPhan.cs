using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using BUS;
using DTO;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_QuanLyHocPhan : Form
    {
        BUS_HocPhan bushocphan = new BUS_HocPhan();
        public GUI_QuanLyHocPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHocPHan = txtMaHocPhan.Text;
            string TenHocPhan = txtTenHocPhan.Text;
            int SoTinChi = int.Parse(txtSoTinChi.Text);
            string maHocKy = cbbHocKy.SelectedValue.ToString();
            HocPhan hocphan = new HocPhan(MaHocPHan, TenHocPhan, SoTinChi, maHocKy);

            if (bushocphan.kiemtramatrung(MaHocPHan) == 1)
            {
                MessageBox.Show("Mã Trùng");
            }
            else
            {
                try
                {
                    if (bushocphan.themHocPhan(hocphan) == true)
                    {
                        dtgvDSHocPhan.DataSource = bushocphan.getHocPhan();
                    }
                }
                catch { }
                
            }
        }

        private void dtgvDSHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;




            if (dtgvDSHocPhan.CurrentCell == null || dtgvDSHocPhan.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                txtMaHocPhan.Text = dtgvDSHocPhan[0, hang].Value.ToString().Trim();
                txtTenHocPhan.Text = dtgvDSHocPhan[1, hang].Value.ToString().Trim();
                txtSoTinChi.Text = dtgvDSHocPhan[2, hang].Value.ToString().Trim();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string MaHocPHan = txtMaHocPhan.Text;
            string TenHocPhan = txtTenHocPhan.Text;
            int SoTinChi = int.Parse(txtSoTinChi.Text);
            string maHocKy = cbbHocKy.SelectedValue.ToString();

            HocPhan hocphan = new HocPhan(MaHocPHan, TenHocPhan, SoTinChi, maHocKy);
            try
            {
                if (bushocphan.suaHocPhan(hocphan) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    dtgvDSHocPhan.DataSource = bushocphan.getHocPhan();
                }
            }
            catch (Exception ex)
            {
                throw;
            }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string MaHocPhan = txtMaHocPhan.Text;
            DialogResult logxoa = MessageBox.Show("Bạn Có chắc chắn muốn xoá không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logxoa == DialogResult.Yes)
            {
                if (bushocphan.xoaHocPhan(MaHocPhan) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    dtgvDSHocPhan.DataSource = bushocphan.getHocPhan();


                }
            }
           
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_QuanLyHocPhan_Load(object sender, EventArgs e)
        {
            dtgvDSHocPhan.DataSource = bushocphan.getHocPhan();
            cbbHocKy.DataSource = bushocphan.getHocKy();
            cbbHocKy.DisplayMember = "tenHocKy";
            cbbHocKy.ValueMember = "maHocKy";


            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtgvDSHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
