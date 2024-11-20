using Microsoft.IdentityModel.Tokens;
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
    public partial class QuanLyDonHang : Form
    {
        private DonHangController donhangController;
        public QuanLyDonHang()
        {
            InitializeComponent();
            donhangController = new DonHangController();
            loadData();
        }
        void loadData()
        {
            tableDH.DataSource = donhangController.GetDonHangData();
        }
        void loadData(int? id)
        {
            tableDH.DataSource = donhangController.SearchDonHang(id);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int khachHangId = int.Parse(txtKhachHangId.Text);
            int sanPhamId = int.Parse(txtSanPhamId.Text);
            int soLuong = (int)txtSoLuong.Value;

            bool success = donhangController.AddDonHang(khachHangId, sanPhamId, soLuong);

            if (success)
            {
                MessageBox.Show("Thêm đơn hàng thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đơn hàng.");
            }
        }

        private void tableDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableDH.Rows[e.RowIndex];

                txtID_DH.Text = row.Cells["Id"].Value.ToString();
                txtKhachHangId.Text = row.Cells["KhachHangId"].Value.ToString();
                txtSanPhamId.Text = row.Cells["SanPhamId"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID_DH.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!!");
                return;
            }
            int id = int.Parse(txtID_DH.Text);

            DonHangController controller = new DonHangController();
            bool success = controller.DeleteDonHang(id);

            if (success)
            {
                MessageBox.Show("Xóa đơn hàng thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa đơn hàng.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID_DH.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn đơn hàng!!");
                return;
            }
            int id = int.Parse(txtID_DH.Text);
            int khachHangId = int.Parse(txtKhachHangId.Text);
            int sanPhamId = int.Parse(txtSanPhamId.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            bool success = donhangController.UpdateDonHang(id, khachHangId, sanPhamId, soLuong);

            if (success)
            {
                MessageBox.Show("Cập nhật đơn hàng thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật đơn hàng.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.IsNullOrEmpty())
            {
                loadData();
            }
            else
            {
                if (int.TryParse(txtTimKiem.Text, out int parsedId))
                {
                    int id = parsedId; 
                    loadData(id);   
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ để tìm kiếm.");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
