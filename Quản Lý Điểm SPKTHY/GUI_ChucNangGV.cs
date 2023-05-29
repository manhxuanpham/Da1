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

namespace Quản_Lý_Điểm_SPKTHY
{
    public partial class GUI_ChucNangGV : Form
    {
        public GUI_ChucNangGV()
        {
            InitializeComponent();
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
        private void formchildForm_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_QuanLyNhapDiem());
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new GUI_ChiTietBangDiem());
        }
    }
}
