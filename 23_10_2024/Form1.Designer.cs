namespace QLSP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            panel3 = new Panel();
            btnTimKiem = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            cbcLoaiSp = new ComboBox();
            label7 = new Label();
            txtMotachitiet = new TextBox();
            label6 = new Label();
            txtMotangan = new TextBox();
            txtImg = new TextBox();
            txtDongia = new TextBox();
            txtTenSP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMasp = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 527);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(btnThem);
            panel4.Controls.Add(btnLamMoi);
            panel4.Location = new Point(11, 460);
            panel4.Name = "panel4";
            panel4.Size = new Size(342, 62);
            panel4.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(177, 18);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(89, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(8, 18);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dataGridView);
            panel3.Location = new Point(375, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 506);
            panel3.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(334, 13);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 16);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 1;
            label8.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 52);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(406, 386);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbcLoaiSp);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMotachitiet);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtMotangan);
            panel2.Controls.Add(txtImg);
            panel2.Controls.Add(txtDongia);
            panel2.Controls.Add(txtTenSP);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtMasp);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(11, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 443);
            panel2.TabIndex = 0;
            // 
            // cbcLoaiSp
            // 
            cbcLoaiSp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcLoaiSp.FormattingEnabled = true;
            cbcLoaiSp.Location = new Point(112, 314);
            cbcLoaiSp.Name = "cbcLoaiSp";
            cbcLoaiSp.Size = new Size(212, 23);
            cbcLoaiSp.TabIndex = 13;
            cbcLoaiSp.SelectedIndexChanged += cbcLoaiSp_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 317);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Loại SP:";
            // 
            // txtMotachitiet
            // 
            txtMotachitiet.Location = new Point(113, 211);
            txtMotachitiet.Multiline = true;
            txtMotachitiet.Name = "txtMotachitiet";
            txtMotachitiet.Size = new Size(211, 76);
            txtMotachitiet.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 210);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "Mô tả chi tiết:";
            // 
            // txtMotangan
            // 
            txtMotangan.Location = new Point(112, 170);
            txtMotangan.Name = "txtMotangan";
            txtMotangan.Size = new Size(212, 23);
            txtMotangan.TabIndex = 9;
            // 
            // txtImg
            // 
            txtImg.Location = new Point(112, 129);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(212, 23);
            txtImg.TabIndex = 8;
            // 
            // txtDongia
            // 
            txtDongia.Location = new Point(112, 93);
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(212, 23);
            txtDongia.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(112, 55);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(212, 23);
            txtTenSP.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 169);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Mô tả ngắn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Hình ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 57);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên SP:";
            // 
            // txtMasp
            // 
            txtMasp.Location = new Point(112, 18);
            txtMasp.Name = "txtMasp";
            txtMasp.Size = new Size(100, 23);
            txtMasp.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(578, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SP:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox txtMotangan;
        private TextBox txtImg;
        private TextBox txtDongia;
        private TextBox txtTenSP;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMasp;
        private TextBox textBox1;
        private Panel panel4;
        private ComboBox cbcLoaiSp;
        private Label label7;
        private TextBox txtMotachitiet;
        private Label label6;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox textBox3;
        private Label label8;
        private DataGridView dataGridView;
    }
}
