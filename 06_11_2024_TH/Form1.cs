using QLKH_DV.Controller;
using QLKH_DV.Model;
using System.Windows.Forms;

namespace QLKH_DV
{
    public partial class Form1 : Form
    {
        private KhachHangController khController;
        private DichVuController dvController;
        public Form1()
        {
            InitializeComponent();
            khController = new KhachHangController();
            dvController = new DichVuController();
            LoadData_KH();
            LoadData_DichVu();
        }
        public void LoadData_KH()
        {
            tableKhachHang.DataSource = null;
            tableKhachHang.DataSource = khController.ds;
        }
        public void LoadData_DichVu()
        {
            tableDichVu.DataSource = dvController.ds;
        }
        public void clearTxt()
        {
            txtDiaChi.Clear();
            txtName.Clear();
            txtSDT.Clear();
            txtID.Clear();
        }
        private void tableDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            khController.AddKhachHang(name, sdt, diachi);
            clearTxt();
            LoadData_KH();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            khController.RemoveKhachHang(id);
            clearTxt();
            LoadData_KH();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            khController.EditKhachHang(id, name, sdt, diachi);
            clearTxt();
            LoadData_KH();
        }
        private void tableKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableKhachHang.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            float tongtien = 0.0f;
            string msg;
            string id = txtID.Text;
            string name = txtName.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            List<DichVu> ds = new List<DichVu>();
            msg = @"ID:" + id + "\n" +
                  "Tên khách hàng: " + name + "\n" +
                  "Số điện thoại: " + sdt + "\n" +
                  "Địa chỉ: " + diachi + "\n"+
            "=========================\n";
            msg += "Danh sách dịch vụ:\n";
            foreach (DataGridViewRow row in tableDichVu.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value))
                {
                    int ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    string? Name = row.Cells["Name"].Value.ToString();
                    float Price = (float)Convert.ToDouble(row.Cells["Price"].Value.ToString());
                    tongtien += Price;
                    ds.Add(new DichVu(ID, Name, Price));
                    msg += $"ID: {ID}, Tên: {Name}, Giá: {Price}\n";
                }
            }
           
            
            msg += "=========================\n";
            msg += "Tổng tiền: " + $"{tongtien}";
            MessageBox.Show(msg, "Thông tin hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
