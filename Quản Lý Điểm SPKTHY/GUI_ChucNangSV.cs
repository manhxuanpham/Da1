using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_ChucNangSV : Form
    {
        BUS_DiemHP BUS_DiemHP = new BUS_DiemHP();
        BUS_XuLyDiem BUS_XuLyDiem = new BUS_XuLyDiem();

        public string masv;
       
        public GUI_ChucNangSV(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }

        private void formchildForm_Click(object sender, EventArgs e)
        {

        }

     

        
        private void GUI_ChucNangSV_Load(object sender, EventArgs e)
        {
            dtgvDSDiem.DataSource = BUS_XuLyDiem.getXuLyDiem(masv);
            float diemTBTK10 = BUS_XuLyDiem.getXuLyDiemToanKhoa(masv);
            double diemTBTK4 = Math.Round((diemTBTK10 * 4 / 10), 2);
            lblTBCH10.Text = diemTBTK10.ToString();
            lblTBTKH4.Text = diemTBTK4.ToString();
            lblsv.Text = masv;
        }
    }
   
}
