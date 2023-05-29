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

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_BaoCao : Form
    {
        BUS_BaoCao BUS_BaoCao = new BUS_BaoCao();
        public GUI_BaoCao()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnTKHL_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTKHB_Click(object sender, EventArgs e)
        {
            dtgvBaoCao.DataSource = BUS_BaoCao.GetSVHocLai();
        }

        private void cbbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahk = cbbHocKy.SelectedValue.ToString();
            if (cbbLoaiBaoCao.SelectedIndex == 0)
            {
                dtgvBaoCao.DataSource = BUS_BaoCao.getSVHocBong(mahk);
                dtgvBaoCao.Columns[0].HeaderText = "Mã Lớp";
                dtgvBaoCao.Columns[1].HeaderText = "Mã Sinh Viên";
                dtgvBaoCao.Columns[2].HeaderText = "Họ Tên";
                dtgvBaoCao.Columns[3].HeaderText = "Điểm XLTK";
            }
            if (cbbLoaiBaoCao.SelectedIndex == 1)
            {
                dtgvBaoCao.DataSource = BUS_BaoCao.GetSVHocLai();
                dtgvBaoCao.Columns[0].HeaderText = "Mã Lớp";
                dtgvBaoCao.Columns[1].HeaderText = "Mã Sinh Viên";
                dtgvBaoCao.Columns[2].HeaderText = "Họ Tên";
                dtgvBaoCao.Columns[3].HeaderText = "Mã Học Phần";
                dtgvBaoCao.Columns[4].HeaderText = "Số Tín Chỉ";
                dtgvBaoCao.Columns[5].HeaderText = "Tên Học Phần";
                dtgvBaoCao.Columns[6].HeaderText = "Mã Học Kỳ";


            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = wb.Sheets["Sheet1"];
            worksheet = wb.ActiveSheet;
            app.Visible = true;

            if (cbbLoaiBaoCao.SelectedIndex == 0)
            {
                worksheet.Cells[1, 1] = "Báo Cáo Thống Kê Sinh Viên Nhận Học Bổng";
                //worksheet.Cells[3, 2] = "Mã SV:";
                //worksheet.Cells[4, 2] = "Họ Tên:";
                //worksheet.Cells[3, 8] = "Trung Bình Toàn Khoá:";
                //worksheet.Cells[4, 8] = "Xếp Loại Toàn Khoá:";
                worksheet.Cells[5, 1] = "STT";
                worksheet.Cells[5, 2] = "Mã Lớp";
                worksheet.Cells[5, 3] = "Mã Sinh Viên";
                worksheet.Cells[5, 4] = "Họ Tên";
                worksheet.Cells[5, 5] = "Điểm XLTK";





                for (int i = 0; i < dtgvBaoCao.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgvBaoCao.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 6, 1] = i + 1;// STT
                        worksheet.Cells[i + 6, j + 2] = dtgvBaoCao.Rows[i].Cells[j].Value;
                    }
                }
                //Định Dạng Trang
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                worksheet.PageSetup.LeftMargin = 0;
                worksheet.PageSetup.RightMargin = 0;
                worksheet.PageSetup.TopMargin = 0;
                worksheet.PageSetup.BottomMargin = 0;
                //for (int i = 0; i < dtgvBaoCao.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dtgvBaoCao.Columns.Count; j++)
                //    {
                //        worksheet.Cells[i + 1, j + 1] = dtgvBaoCao.Rows[i].Cells[j].Value.ToString();
                //    }
                //}
                worksheet.Range["A5"].ColumnWidth = 8;
                worksheet.Range["B5"].ColumnWidth = 10;
                worksheet.Range["C5"].ColumnWidth = 12;
                worksheet.Range["D5"].ColumnWidth = 16;
                worksheet.Range["E5"].ColumnWidth = 10;
                worksheet.Range["A1","G100"].Font.Name = "Times New Roman";
                worksheet.Range["A1","G1"].Font.Size = 14;
                worksheet.Range["A1", "G1"].MergeCells = true;
                worksheet.Range["A1", "G1"].Font.Bold = true;
                worksheet.Range["A5", "E5"].Font.Bold = true;

                worksheet.Range["A1"].HorizontalAlignment = 3;

                worksheet.Range["A5", "E5"].HorizontalAlignment = 3;
                worksheet.Range["A5", "A20"].HorizontalAlignment = 3;
                worksheet.Range["B5", "B20"].HorizontalAlignment = 3;
                worksheet.Range["C5", "C20"].HorizontalAlignment = 3;
                worksheet.Range["D5", "D20"].HorizontalAlignment = 3;
                worksheet.Range["E5", "E20"].HorizontalAlignment = 3;

            }
            if (cbbLoaiBaoCao.SelectedIndex == 1)
            {
                worksheet.Cells[1, 1] = "Báo Cáo Thống Kê Sinh Viên Học Lại";

                worksheet.Cells[5, 1] = "STT";
                worksheet.Cells[5, 2] = "Mã Sinh Viên";
                worksheet.Cells[5, 3] = "Họ Tên";
                worksheet.Cells[5, 4] = "Mã Lớp";
                worksheet.Cells[5, 5] = "Mã Học Phần";
                worksheet.Cells[5, 6] = "Số Tín Chỉ";
                worksheet.Cells[5, 7] = "Tên Học Phần";
                worksheet.Cells[5, 8] = "Điểm Thi";
                worksheet.Cells[5, 9] = "Mã Học Kỳ";




                for (int i = 0; i < dtgvBaoCao.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgvBaoCao.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 6, 1] = i + 1;// STT
                        worksheet.Cells[i + 6, j + 2] = dtgvBaoCao.Rows[i].Cells[j].Value;
                    }
                }
                //Định Dạng Trang
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                worksheet.PageSetup.LeftMargin = 0;
                worksheet.PageSetup.RightMargin = 0;
                worksheet.PageSetup.TopMargin = 0;
                worksheet.PageSetup.BottomMargin = 0;

                // Định Dạng Cột
                worksheet.Range["A5"].ColumnWidth = 8.25;
                worksheet.Range["B5"].ColumnWidth = 11.25;
                worksheet.Range["C5"].ColumnWidth = 28.25;
                worksheet.Range["D5"].ColumnWidth = 10;
                worksheet.Range["E5"].ColumnWidth = 18;
                worksheet.Range["F5"].ColumnWidth = 18;
                worksheet.Range["G5"].ColumnWidth = 28;
                worksheet.Range["H5"].ColumnWidth = 12;
                worksheet.Range["I5"].ColumnWidth = 12;


                worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
                worksheet.Range["A1", "I1"].Font.Size = 14;
                worksheet.Range["A1", "I1"].MergeCells = true;
                worksheet.Range["A1", "I1"].Font.Bold = true;
                worksheet.Range["A5", "I5"].Font.Bold = true;

                worksheet.Range["A1"].HorizontalAlignment = 3;

                worksheet.Range["A5", "I5"].HorizontalAlignment = 3;
                worksheet.Range["A5", "A20"].HorizontalAlignment = 3;
                worksheet.Range["B5", "B20"].HorizontalAlignment = 3;
                worksheet.Range["C5", "C20"].HorizontalAlignment = 3;
                worksheet.Range["D5", "D20"].HorizontalAlignment = 3;
                worksheet.Range["E5", "D20"].HorizontalAlignment = 3;
                worksheet.Range["F5", "F20"].HorizontalAlignment = 3;
                worksheet.Range["G5", "G20"].HorizontalAlignment = 3;
                worksheet.Range["H5", "H20"].HorizontalAlignment = 3;
                worksheet.Range["I5", "I20"].HorizontalAlignment = 3;
                




            }

        }

        private void GUI_BaoCao_Load(object sender, EventArgs e)
        {
            cbbHocKy.DataSource = BUS_BaoCao.getHocKy();
            cbbHocKy.DisplayMember = "maHocKy";
            cbbHocKy.ValueMember = "maHocKy";


            btnXuat.TextAlign = ContentAlignment.MiddleCenter;

        }
    }
}
