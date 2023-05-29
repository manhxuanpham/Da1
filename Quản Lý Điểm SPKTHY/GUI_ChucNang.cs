using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_ChucNang : Form
    {
        public GUI_ChucNang()
        {
            InitializeComponent();
        }

        private void advTree1_Click(object sender, EventArgs e)
        {

        }

        private void explorerBar1_Click(object sender, EventArgs e)
        {

        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLySinhVien());
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formchildForm.Controls.Add(childForm);
            formchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnQuanLyGV_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyGiangVien());
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyLop());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyKhoa());
        }

        private void btnQuanLyHocPhan_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyHocPhan());
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_HocKy());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyNhapDiem());
        }

        private void GUI_ChucNang_Load(object sender, EventArgs e)
        {
            btnHocKy.TextAlign = ContentAlignment.MiddleCenter;
            btnKhoa.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLyDiem.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLyGV.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLyHocPhan.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLySV.TextAlign = ContentAlignment.MiddleCenter;
            btnTrangChu.TextAlign = ContentAlignment.MiddleCenter;
            btnThoat.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLyLopHoc.TextAlign = ContentAlignment.MiddleCenter;
            btnXemDiem.TextAlign = ContentAlignment.MiddleCenter;
            btnQuanLyLHP.TextAlign = ContentAlignment.MiddleCenter;
            btnQLTK.TextAlign = ContentAlignment.MiddleCenter;
            

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_ChiTietBangDiem());

        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLySinhVien());

        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyTaiKhoan());
        }

        private void btnQuanLyLHP_Click(object sender, EventArgs e)
        {
            openChildFormInPanel( new GUI_QuanLyPhanTheoLopcs());
        }
    }
}
