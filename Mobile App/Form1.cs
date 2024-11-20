using Mobile_App.controllers;

namespace Mobile_App
{
    public partial class Form1 : Form
    {
        private UserController userController;
        public Form1()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (userController.login(username, password))
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
