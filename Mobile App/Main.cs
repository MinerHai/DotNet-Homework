using Mobile_App.controllers;
using Mobile_App.models;
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
    public partial class Main : Form
    {
        private DonHangController donhangController;
        private KhachHangController khachhangController;
        private SanPhamController sanphamController;
        public Main()
        {
            InitializeComponent();
            donhangController = new();
            khachhangController = new();
            sanphamController = new();
            loadData();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void loadData()
        {
            tableDonHang.DataSource = donhangController.GetDonHangData();
            tableKH.DataSource = khachhangController.GetKhachHangData();
            tableSP.DataSource = sanphamController.GetSanPhamData();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            new QuanLyDonHang().Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            new DoanhThu().Show();
        }
    }
}
