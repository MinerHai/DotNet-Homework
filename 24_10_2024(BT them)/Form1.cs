using _24_10_2024_BT_them_.models;

namespace _24_10_2024_BT_them_
{
    public partial class Form1 : Form
    {
        private QuanLySV qlsv;
        public Form1()
        {
            InitializeComponent();
            qlsv = new QuanLySV();
            cmbKhoa.DataSource = qlsv.ds;
            cmbGioiTinh.SelectedIndex = 0;
            cmbKhoa.DisplayMember = "TenKhoa";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellClick += dataGridView_CellContentClick;
            dataGridView.MultiSelect = false;
        }
        public void ClearTxt()
        {
            txtMSV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtTenSV.Clear();
            txtDiaChi.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedItem is Khoa k)
            {
                dataGridView.DataSource = k.dssv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cmbKhoa.SelectedItem is Khoa k)
            {
                string? id = txtMSV.Text;
                string? ten = txtTenSV.Text;
                DateTime ngaysinh = txtDate.Value;
                string? sdt = txtSDT.Text;
                string? email = txtEmail.Text;
                string? diachi = txtDiaChi.Text;
                string? gioitinh = cmbGioiTinh.SelectedItem.ToString();
                if (String.IsNullOrEmpty(id) || String.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    SinhVien sv = new SinhVien(id, ten, ngaysinh, diachi, email, sdt, k.TenKhoa, gioitinh);
                    qlsv.ThemSinhVien(k.TenKhoa, sv);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = k.dssv;
                    ClearTxt();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                ClearTxt();


                txtMSV.Text = row.Cells["id"].Value?.ToString();
                txtTenSV.Text = row.Cells["name"].Value?.ToString();
                txtDate.Value = (DateTime)row.Cells["ngaysinh"].Value;
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiaChi.Text = row.Cells["Diachi"].Value?.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();
                cmbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedItem is Khoa k)
            {

                String id_sv = txtMSV.Text;
                String tenKhoa = k.TenKhoa;
                if (String.IsNullOrEmpty(id_sv))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ!!");
                }
                else
                {
                    qlsv.XoaSinhVien(tenKhoa, id_sv);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = k.dssv;
                    ClearTxt();

                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTxt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedItem is Khoa k)
            {
                string? id = txtMSV.Text;
                string? ten = txtTenSV.Text;
                DateTime ngaysinh = txtDate.Value;
                string? sdt = txtSDT.Text;
                string? email = txtEmail.Text;
                string? diachi = txtDiaChi.Text;
                string? gioitinh = cmbGioiTinh.SelectedItem.ToString();
                if (String.IsNullOrEmpty(id) || String.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    SinhVien sv = new SinhVien(id, ten, ngaysinh, diachi, email, sdt, k.TenKhoa, gioitinh);
                    qlsv.SuaSinhVien(k.TenKhoa, sv);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = k.dssv;
                    ClearTxt();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa");
            }
        }
    }
}
