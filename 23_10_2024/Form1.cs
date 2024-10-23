using QLSP.models;
using System.Drawing;

namespace QLSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<LoaiSanPham> dsloaisp = new() {
                new LoaiSanPham
                {
                    TenLoai = "Nông nghiệp",
                    danhsachsp = new List<SanPham> {
                        new SanPham(1, "Lúa", 10000, "hinhluapath", "Mô tả ngắn lúa", "Mô tả chi tiết lúa"),
                        new SanPham(2, "Gạo", 15000, "hinhgaopath", "Mô tả ngắn gạo", "Mô tả chi tiết gạo")
                    }
                },
                new LoaiSanPham
                {
                    TenLoai = "Công nghiệp",
                    danhsachsp = new List<SanPham> {
                    new SanPham(3, "Thép", 20000, "hinhthepath", "Mô tả ngắn thép", "Mô tả chi tiết thép"),
                    new SanPham(4, "Nhựa", 25000, "hinhnhuapath", "Mô tả ngắn nhựa", "Mô tả chi tiết nhựa")
                    }
                }
            };
            cbcLoaiSp.DataSource = dsloaisp;
            cbcLoaiSp.DisplayMember = "TenLoai";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.CellClick += dataGridView_CellClick;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMasp.Clear();
            txtDongia.Clear();
            txtImg.Clear();
            txtMotangan.Clear();
            txtMotachitiet.Clear();
            txtTenSP.Clear();
            if (cbcLoaiSp.SelectedItem is LoaiSanPham loaiSanPham)
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = loaiSanPham.danhsachsp;
            }
        }

        private void cbcLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcLoaiSp.SelectedItem is LoaiSanPham loaiSanPham)
            {
                dataGridView.DataSource = loaiSanPham.danhsachsp;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int MaSP = Convert.ToInt32(txtMasp.Text);
                string TenSP = txtTenSP.Text;
                string HinhAnh = txtImg.Text;
                decimal DonGia = Convert.ToDecimal(txtDongia.Text);
                string Motangan = txtMotangan.Text;
                string Motachitiet = txtMotachitiet.Text;
                if (cbcLoaiSp.SelectedItem is LoaiSanPham loaisp)
                {
                    loaisp.danhsachsp.Add(new SanPham(MaSP, TenSP, DonGia, HinhAnh, Motangan, Motachitiet));
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = loaisp.danhsachsp;
                }
            }
            catch
            {

            }

        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtMasp.Clear();
                txtDongia.Clear();
                txtImg.Clear();
                txtMotangan.Clear();
                txtMotachitiet.Clear();
                txtTenSP.Clear();

                txtMasp.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txtImg.Text = row.Cells["HinhAnh"].Value?.ToString();
                txtDongia.Text = row.Cells["DonGia"].Value?.ToString();
                txtMotangan.Text = row.Cells["Motangan"].Value?.ToString();
                txtMotachitiet.Text = row.Cells["Motachitiet"].Value?.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {


                int _masp = Convert.ToInt32(txtMasp.Text);
                if (cbcLoaiSp.SelectedItem is LoaiSanPham loaisp)
                {
                    loaisp.danhsachsp.Remove(loaisp.danhsachsp.Where(p => p.MaSP == _masp).FirstOrDefault());
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = loaisp.danhsachsp;
                    txtMasp.Clear();
                    txtDongia.Clear();
                    txtImg.Clear();
                    txtMotangan.Clear();
                    txtMotachitiet.Clear();
                    txtTenSP.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int MaSP = Convert.ToInt32(txtMasp.Text);
                string TenSP = txtTenSP.Text;
                string HinhAnh = txtImg.Text;
                decimal DonGia = Convert.ToDecimal(txtDongia.Text);
                string Motangan = txtMotangan.Text;
                string Motachitiet = txtMotachitiet.Text;
                if (cbcLoaiSp.SelectedItem is LoaiSanPham loaisp)
                {
                    SanPham sp = loaisp.danhsachsp.Where(p => p.MaSP == MaSP).FirstOrDefault();
                    sp.MaSP = MaSP;
                    sp.TenSP = TenSP;
                    sp.HinhAnh = HinhAnh;
                    sp.DonGia = DonGia;
                    sp.Motangan = Motangan;
                    sp.Motachitiet = Motachitiet;
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = loaisp.danhsachsp;
                    txtMasp.Clear();
                    txtDongia.Clear();
                    txtImg.Clear();
                    txtMotangan.Clear();
                    txtMotachitiet.Clear();
                    txtTenSP.Clear();
                }
            }catch (Exception ex) { }
        }
    }
}
