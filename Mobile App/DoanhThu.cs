using Mobile_App.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_App
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int month = dtpNgay.Value.Month;  
            int year = dtpNgay.Value.Year;    

            DonHangController controller = new DonHangController();
            tableDoanhThu.DataSource = controller.GetDoanhThuTheoThang(month, year);
        }
    }
}
