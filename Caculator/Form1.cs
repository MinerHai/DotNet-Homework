namespace Caculator
{
    public partial class Caculator : Form
    {
        public static double oldNum { set; get; }
        public static double curNum { set; get; }
        public static bool isoldNum { set; get; }
        public static string? PhepTinh { set; get; }
        public Caculator()
        {
            InitializeComponent();
            isoldNum = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtNum.Text = "7";
            if (isoldNum) oldNum = 7;
            else curNum = 7;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum.Text = "1";
            if (isoldNum) oldNum = 1;
            else curNum = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum.Text = "2";
            if (isoldNum) oldNum = 2;
            else curNum = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNum.Text = "3";
            if (isoldNum) oldNum = 3;
            else curNum = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNum.Text = "4";
            if (isoldNum) oldNum = 4;
            else curNum = 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNum.Text = "5";
            if (isoldNum) oldNum = 5;
            else curNum = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNum.Text = "6";
            if (isoldNum) oldNum = 6;
            else curNum = 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtNum.Text = "8";
            if (isoldNum) oldNum = 8;
            else curNum = 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtNum.Text = "9";
            if (isoldNum) oldNum = 9;
            else curNum = 9;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            oldNum = 0;
            curNum = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        { 
                PhepTinh = "Cong";
                isoldNum = false;
                txtNum.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            PhepTinh = "Tru";
            isoldNum = false;
            txtNum.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            PhepTinh = "Nhan";
            isoldNum = false;
            txtNum.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PhepTinh = "Chia";
            isoldNum = false;
            txtNum.Text = "";
        }

        private void btnChiaDu_Click(object sender, EventArgs e) // btnZeRo
        {
            txtNum.Text = "0";
            if (isoldNum) oldNum = 0;
            else curNum = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (PhepTinh)
            {
                case "Cong":
                    oldNum = (oldNum + curNum);
                    break;
                case "Tru":
                    oldNum = (oldNum - curNum);
                    break;
                case "Nhan":
                    oldNum = (oldNum * curNum);
                    break;
                case "Chia":
                    oldNum = (oldNum / curNum);
                    break;
                case "ChiaDu":
                    oldNum = (oldNum % curNum);
                    break;
                default:
                    break;
            }
            txtNum.Text = oldNum.ToString();
            isoldNum = true;
        }
    }
}
