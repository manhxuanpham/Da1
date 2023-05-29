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
using Microsoft.Office.Interop.Excel;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_ChiTietBangDiem : Form
    {
        BUS_DiemHP bussDiemHP = new BUS_DiemHP();
        BUS_XuLyDiem BUS_XuLyDiem = new BUS_XuLyDiem();
        public GUI_ChiTietBangDiem()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_ChiTietBangDiem_Load(object sender, EventArgs e)
        {
            cbbDSLop.DisplayMember = "maLop";
            cbbDSLop.ValueMember = "maLop";
            cbbDSLop.DataSource = bussDiemHP.getLopHoc();

            //dtgvDSDiem.DataSource = BUS_XuLyDiem.getXuLyDiem();
            btnXuatExcel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void cbbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeViewDSSV.Nodes.Clear();

            string ma = cbbDSLop.SelectedValue.ToString();
            foreach (DataRow r in bussDiemHP.getMaLop(ma).Rows)
            {
                TreeNode root = new TreeNode();
                root.Name = r["maSV"].ToString();
                root.Text = r["hoTen"].ToString();
                TreeViewDSSV.Nodes.Add(root);

            }
        }

        private void dtgvDSDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TreeViewDSSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string maSV = selectedNode.Name;
          
        

        }

        private void TreeViewDSSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string maSV = selectedNode.Name;
            foreach (DataRow r in BUS_XuLyDiem.getSinhVien(maSV).Rows)
            {
                string masv = r["maSV"].ToString();
                string hoten = r["hoTen"].ToString();
                lblsv.Text = masv;
                lblHoTen.Text = hoten;

            }
            dtgvDSDiem.DataSource = BUS_XuLyDiem.getXuLyDiem(maSV);

            float diemTBTK10 = BUS_XuLyDiem.getXuLyDiemToanKhoa(maSV);
            double diemTBTK4 = Math.Round((diemTBTK10 * 4 / 10),2);
            lblTBCH10.Text = diemTBTK10.ToString();
            lblTBTKH4.Text = diemTBTK4.ToString();

        }

        private void TreeViewDSSV_Click(object sender, EventArgs e)
        {

        }
       
       

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();   
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = wb.Sheets["Sheet1"];
            worksheet = wb.ActiveSheet;
            app.Visible = true;
            worksheet.Cells[1, 1] = "BẢNG ĐIỂM SINH VIÊN";
            worksheet.Cells[3, 2] = "Mã SV:" + lblsv.Text;
            worksheet.Cells[4, 2] = "Họ Tên:" + lblHoTen.Text;
            worksheet.Cells[3, 8] = "Trung Bình Toàn Khoá:" + lblTBCH10.Text;
            worksheet.Cells[4, 8] = "Xếp Loại Toàn Khoá:" + lblTBTKH4.Text;
            worksheet.Cells[5, 1] = "STT";
            worksheet.Cells[5, 2] = "Mã môn";
            worksheet.Cells[5, 3] = "Số Tín Chỉ";
            worksheet.Cells[5, 4] = "Điểm TP";
            worksheet.Cells[5, 5] = "Điểm Thi";
            worksheet.Cells[5, 6] = "Điểm TB";
            worksheet.Cells[5, 7] = "Điểm TP2";
            worksheet.Cells[5, 8] = "Điểm Thi 2";
            worksheet.Cells[5, 9] = "Điểm TB 2";
            worksheet.Cells[5, 10] = "Điểm Chữ";




            for (int i = 0; i < dtgvDSDiem.Rows.Count -1; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    worksheet.Cells[i + 6, 1] = i + 1;// STT
                    worksheet.Cells[i + 6, j + 2] = dtgvDSDiem.Rows[i].Cells[j].Value;
                }
            }
            //Định Dạng Trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
        }

        private void lblsv_Click(object sender, EventArgs e)
        {

        }
    }
}
