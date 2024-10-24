namespace _24_10_2024_BT_them_
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmbGioiTinh = new ComboBox();
            cmbKhoa = new ComboBox();
            txtDate = new DateTimePicker();
            txtSDT = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtTenSV = new TextBox();
            label3 = new Label();
            txtMSV = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            groupBox3 = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(377, 50);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbGioiTinh);
            groupBox1.Controls.Add(cmbKhoa);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 353);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 279);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 15;
            label9.Text = "Giới tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 250);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 14;
            label8.Text = "Khoa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 124);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 13;
            label7.Text = "Ngày sinh:";
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioiTinh.Location = new Point(109, 271);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(218, 23);
            cmbGioiTinh.TabIndex = 12;
            // 
            // cmbKhoa
            // 
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoa.FormattingEnabled = true;
            cmbKhoa.Location = new Point(111, 242);
            cmbKhoa.Name = "cmbKhoa";
            cmbKhoa.Size = new Size(218, 23);
            cmbKhoa.TabIndex = 11;
            cmbKhoa.SelectedIndexChanged += cmbKhoa_SelectedIndexChanged;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(111, 118);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(216, 23);
            txtDate.TabIndex = 10;
            txtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(111, 213);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(216, 23);
            txtSDT.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 221);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 8;
            label6.Text = "Điện thoại:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 189);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(111, 152);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(216, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 155);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ:";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(111, 89);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(216, 23);
            txtTenSV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 92);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên sinh viên";
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(111, 49);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(216, 23);
            txtMSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 52);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(412, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 417);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 36);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(370, 375);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(12, 421);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 58);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(274, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(193, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(109, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(28, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "QLSV";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMSV;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DateTimePicker txtDate;
        private TextBox txtSDT;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtTenSV;
        private Label label3;
        private ComboBox cmbGioiTinh;
        private ComboBox cmbKhoa;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
