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
    public partial class GUI_QuanLyNhapDiem : Form
    {
        BUS_DiemHP busdiemHP = new BUS_DiemHP();
        BUS_LopHocPhan busLopHP = new BUS_LopHocPhan();
        public GUI_QuanLyNhapDiem()
        {
            InitializeComponent();
        }

        private void GUI_QuanLyNhapDiem_Load(object sender, EventArgs e)
        {
            // Load dtgv nhập điểm
            //dtgvDiemHP.DataSource = busdiemHP.getDiemHP();

            cbbNamHoc.DataSource = busdiemHP.getNamHoc();
            cbbNamHoc.DisplayMember = "tenNamHoc";
            cbbNamHoc.ValueMember = "maNamHoc";
            cbbNamHoc.Text = "";
            ////load cbb học phần
            //cbbDSLop.DataSource = busdiemHP.getLopHoc();
            //cbbDSLop.DisplayMember = "tenLop";
            //cbbDSLop.ValueMember = "malop";

            //// load cbb học kì
            //cbbNamHoc.DataSource = busdiemHP.getHocKy();
            //cbbNamHoc.DisplayMember = "tenHocKy";
            //cbbNamHoc.ValueMember = "maHocKy";

            //// load cbb môn học phần
            //cbbMonHocPhan.DataSource = busdiemHP.getHocPhan();
            //cbbMonHocPhan.DisplayMember = "tenHocPhan";
            //cbbMonHocPhan.ValueMember = "maHocPhan";

            btnCapNhatDuLieu.TextAlign = ContentAlignment.MiddleCenter;

            // Đặt tên mới cho cột thứ nhất


            // Đặt tên mới cho cột có tên "tenCot"
            //dtgvDiemHP.Columns["tenCot"].HeaderText = "Tên cột mới";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            foreach (DataRow m in busLopHP.getLopHocPhan().Rows)
            {
                foreach (DataRow s in busdiemHP.getSinhVien().Rows)
                {
                    string masv = s["maSV"].ToString();
                    string sMaLop = s["maLop"].ToString().Trim();

                    string maHocPhan = m["maHocPhan"].ToString();
                    string lMaLop = m["maLop"].ToString().Trim();
                    if (busdiemHP.DuyetDiemHP(maHocPhan, masv) == 0 && sMaLop == lMaLop)
                    {

                        busdiemHP.CapNhatDiemHP(maHocPhan, masv);

                    }
                }
            }
            busdiemHP.CapNhatDiemTB();
            busdiemHP.CapNhatDiemTB2();

            MessageBox.Show("Cập Nhật Điểm Học Phần  Thành Công");

        }

        private void cbbMonHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbbMonHocPhan.SelectedValue.ToString().Trim();
            //dtgvDiemHP.DataSource = busdiemHP.LocSinhVienTheoHP(ma);
            cbbDSLop.DataSource = busdiemHP.getLopHocTheoMon(ma);
            cbbDSLop.DisplayMember = "maLop";
            cbbDSLop.ValueMember = "maLop";
            cbbDSLop.Text = "";


        }

        private void cbbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahp = cbbMonHocPhan.SelectedValue.ToString();
            string malop = cbbDSLop.SelectedValue.ToString();
            dtgvDiemHP.DataSource = busdiemHP.getSVtheoLop(malop, mahp);

            dtgvDiemHP.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgvDiemHP.Columns[1].HeaderText = "Họ Và Tên";
            dtgvDiemHP.Columns[2].HeaderText = "Mã Học Phần";
            dtgvDiemHP.Columns[3].HeaderText = "Điểm TP";
            dtgvDiemHP.Columns[4].HeaderText = "Điểm Thi";
            dtgvDiemHP.Columns[5].HeaderText = "Điểm TP 2";
            dtgvDiemHP.Columns[6].HeaderText = "Điểm Thi 2";

            dtgvDiemHP.Columns[1].Width = 200;




        }

        private void dtgvDiemHP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvDiemHP.CurrentCell.RowIndex;
            // string mahocphan = dtgvDiemHP.Rows[i].Cells["maHocPhan"].Value.ToString();
            string mahocphan = cbbMonHocPhan.SelectedValue.ToString();
            string masv = dtgvDiemHP.Rows[i].Cells["maSV"].Value.ToString();
            //float diemThi = Convert.ToSingle(dtgvDiemHP.Rows[i].Cells["diemThi"].Value);
            //float diemTP = Convert.ToSingle(dtgvDiemHP.Rows[i].Cells["diemTP"].Value);
            // Lấy giá trị từ ô "diemThi" tại hàng i
            object cellValue = dtgvDiemHP.Rows[i].Cells["diemTP"].Value;

            object cellValue2 = dtgvDiemHP.Rows[i].Cells["diemThi"].Value;

            object cellValue3 = dtgvDiemHP.Rows[i].Cells["diemTP2"].Value;

            object cellValue4 = dtgvDiemHP.Rows[i].Cells["diemThi2"].Value;

            float diemTP;
            if (float.TryParse(cellValue.ToString(), out diemTP))
            {
                
                // Giá trị đã được ép kiểu thành công
                // Sử dụng giá trị diemThi (kiểu float) ở đây
                busdiemHP.NhapDiemTP(mahocphan, masv, diemTP);

            }

            float diemThi;
            if (float.TryParse(cellValue2.ToString(), out diemThi))
            {
                // Giá trị đã được ép kiểu thành công
                // Sử dụng giá trị diemThi (kiểu float) ở đây
                busdiemHP.NhapDiemThi(mahocphan, masv, diemThi);
            }
            float diemTP2;
            if (float.TryParse(cellValue3.ToString(), out diemTP2))
            {

                // Giá trị đã được ép kiểu thành công
                // Sử dụng giá trị diemThi (kiểu float) ở đây
                busdiemHP.NhapDiemTP2(mahocphan, masv, diemTP2);

            }

            float diemThi2;
            if (float.TryParse(cellValue4.ToString(), out diemThi2))
            {
                // Giá trị đã được ép kiểu thành công
                // Sử dụng giá trị diemThi (kiểu float) ở đây
                busdiemHP.NhapDiemThi2(mahocphan, masv, diemThi2);
            }
        }

        private void dtgvDiemHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNamHoc = cbbNamHoc.SelectedValue.ToString();

            cbbHocKy.DataSource = busdiemHP.getHocKyTheoNamHoc(MaNamHoc);
            cbbHocKy.DisplayMember = "maHocKy";
            cbbHocKy.ValueMember = "maHocKy";
            cbbHocKy.Text = "";
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHocKy = cbbHocKy.SelectedValue.ToString();


            cbbMonHocPhan.DataSource = busdiemHP.getMonHocTheoHocKy(maHocKy);
            cbbMonHocPhan.DisplayMember = "TenHocPhan";
            cbbMonHocPhan.ValueMember = "maHocPhan";
            cbbMonHocPhan.Text = "";


        }

        private void dtgvDiemHP_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dtgvDiemHP.Columns[e.ColumnIndex].Name == "diemTP")
            {
                string inputValue = e.FormattedValue.ToString();
                float diem;

                if (!float.TryParse(inputValue, out diem)) // Kiểm tra giá trị có thể chuyển đổi thành số thực không
                {

                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");
                    //dtgvDiemHP.Rows[e.RowIndex].ErrorText = "Vui lòng nhập giá trị số từ 0 đến 10.";
                    //errorProvider.SetError(dtgvDiemHP.EditingControl, "Vui lòng nhập giá trị số từ 0 đến 10.");
                }
                else if (diem < 0 || diem > 10) // Kiểm tra giá trị nằm trong khoảng từ 0 đến 10
                {
                    //dtgvDiemHP.Rows[e.RowIndex].ErrorText = "Vui lòng nhập giá trị số từ 0 đến 10.";
                    //errorProvider.SetError(dtgvDiemHP.EditingControl, "Vui lòng nhập giá trị số từ 0 đến 10.");
                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                    e.Cancel = true;
                }
                else
                {
                    // Xóa thông báo lỗi nếu giá trị hợp lệ
                    dtgvDiemHP.Rows[e.RowIndex].ErrorText = string.Empty;
                    errorProvider.SetError(dtgvDiemHP.EditingControl, string.Empty);
                }

            }
            if (dtgvDiemHP.Columns[e.ColumnIndex].Name == "diemThi") // Thay "diemColumn" bằng tên cột chứa điểm
            {
                string inputValue = e.FormattedValue.ToString();
                float diem;

                if (!float.TryParse(inputValue, out diem)) // Kiểm tra giá trị có thể chuyển đổi thành số thực không
                {

                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                }
                else if (diem < 0 || diem > 10) // Kiểm tra giá trị nằm trong khoảng từ 0 đến 10
                {


                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                    e.Cancel = true;
                }


            }
            if (dtgvDiemHP.Columns[e.ColumnIndex].Name == "diemTP2") // Thay "diemColumn" bằng tên cột chứa điểm
            {
                string inputValue = e.FormattedValue.ToString();
                float diem;

                if (!float.TryParse(inputValue, out diem)) // Kiểm tra giá trị có thể chuyển đổi thành số thực không
                {

                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                }
                else if (diem < 0 || diem > 10) // Kiểm tra giá trị nằm trong khoảng từ 0 đến 10
                {


                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                    e.Cancel = true;
                }


            }
            if (dtgvDiemHP.Columns[e.ColumnIndex].Name == "diemThi2") // Thay "diemColumn" bằng tên cột chứa điểm
            {
                string inputValue = e.FormattedValue.ToString();
                float diem;

                if (!float.TryParse(inputValue, out diem)) // Kiểm tra giá trị có thể chuyển đổi thành số thực không
                {

                    e.Cancel = true;
                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                }
                else if (diem < 0 || diem > 10) // Kiểm tra giá trị nằm trong khoảng từ 0 đến 10
                {


                    MessageBox.Show("Vui lòng nhập giá trị số từ 0 đến 10.");

                    e.Cancel = true;
                }


            }




        }


    }
}
