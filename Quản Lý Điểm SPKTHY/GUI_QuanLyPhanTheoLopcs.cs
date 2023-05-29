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
    public partial class GUI_QuanLyPhanTheoLopcs : Form
    {
        BUS_LopHocPhan buslophp = new BUS_LopHocPhan();
        public GUI_QuanLyPhanTheoLopcs()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_QuanLyPhanTheoLopcs_Load(object sender, EventArgs e)
        {
            cbbDSLop.DataSource = buslophp.getLopHoc();
            cbbDSLop.DisplayMember = "maLop";
            cbbDSLop.ValueMember = "maLop";

            cbbGiangVien.DataSource = buslophp.getGiangVien();
            cbbGiangVien.DisplayMember = "maGV";
            cbbGiangVien.ValueMember = "maGV";

            cbbMonHocPhan.DataSource = buslophp.getHocPhan();
            cbbMonHocPhan.DisplayMember = "maHocPhan";
            cbbMonHocPhan.ValueMember = "maHocPhan";

            DTGVLopHP.DataSource = buslophp.getLopHocPhan();
            btnThem.TextAlign = ContentAlignment.MiddleCenter;
            btnSua.TextAlign = ContentAlignment.MiddleCenter;
            btnXoa.TextAlign = ContentAlignment.MiddleCenter;



        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = cbbDSLop.SelectedValue.ToString();
            string magv = cbbGiangVien.SelectedValue.ToString();
            string mahp = cbbMonHocPhan.SelectedValue.ToString();

            LopHocPhan lopHocPhan = new LopHocPhan(malop, mahp, magv);

            if(buslophp.themLopHocPhan(lopHocPhan) == true)
            {
                
                MessageBox.Show("Thêm Thành Công");
                DTGVLopHP.DataSource = buslophp.getLopHocPhan();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malop = cbbDSLop.SelectedValue.ToString();
            string magv = cbbGiangVien.SelectedValue.ToString();
            string mahp = cbbMonHocPhan.SelectedValue.ToString();
            LopHocPhan lopHocPhan = new LopHocPhan(malop, mahp,magv);
            if (buslophp.suaLopHocPhan(lopHocPhan) == true)
            {
                MessageBox.Show("Sửa  Thành Công");
                DTGVLopHP.DataSource = buslophp.getLopHocPhan();

            }
        }

        private void DTGVLopHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTGVLopHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;




            if (DTGVLopHP.CurrentCell == null || DTGVLopHP.CurrentCell.Value == null)
            {
                hang = -1;
            }
            if (hang != -1)
            {
                cbbDSLop.Text = DTGVLopHP[0, hang].Value.ToString().Trim();
                cbbMonHocPhan.Text = DTGVLopHP[1, hang].Value.ToString().Trim();
                cbbGiangVien.Text = DTGVLopHP[2, hang].Value.ToString().Trim();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           string ma = cbbDSLop.SelectedValue.ToString();
            if(buslophp.xoaLopHocPhan(ma)==true)
            {
                MessageBox.Show("Xoá Thành Công");
                DTGVLopHP.DataSource = buslophp.getLopHocPhan();
            }
        }
    }
}
