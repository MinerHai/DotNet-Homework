using System.Diagnostics;
using System.Xml.Linq;

namespace _6_11_2024
{
    public partial class Form1 : Form
    {
        private SanPhamController spcontrol;
        public Form1()
        {
            InitializeComponent();
            spcontrol = new SanPhamController();
            loadData();
        }
        void loadData()
        {
            tableSanPham.DataSource = null;
            tableSanPham.DataSource = spcontrol.getData();
        }
        void ClearTxt()
        {
            txtDetails.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string desc = txtDetails.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            spcontrol.ThemSP(new SanPham(name, desc, price));
            ClearTxt();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm có id {id} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                spcontrol.XoaSP(id);
                ClearTxt();
                loadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string desc = txtDetails.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa sản phẩm có id {id} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                spcontrol.SuaSP(new SanPham(id, name, desc, price));
                ClearTxt();
                loadData();
            }
        }

        private void tableSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableSanPham.Rows[e.RowIndex];

                txtID.Text = row.Cells["MaSP"].Value.ToString();
                txtName.Text = row.Cells["TenSP"].Value.ToString();
                txtPrice.Text = row.Cells["GiaSP"].Value.ToString();
                txtDetails.Text = row.Cells["MotaSP"].Value.ToString();
            }
        }
    }
}
