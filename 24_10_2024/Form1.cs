namespace DkiDnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String? tk = txtTK.Text;
            String? mk = txtMK.Text;
            if (tk == null || mk == null){
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
            }
            if (tk == "admin" && mk == "1234")
            {
                MessageBox.Show("Bạn đã đăng nhập thành công");
            }
            else
                MessageBox.Show("Đăng nhập thất bại");

        }
    }
}
