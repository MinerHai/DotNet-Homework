namespace QLKH_DV
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
            tableKhachHang = new DataGridView();
            groupBox2 = new GroupBox();
            tableDichVu = new DataGridView();
            columnCheckDV = new DataGridViewCheckBoxColumn();
            groupBox3 = new GroupBox();
            btnHD = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            label5 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableKhachHang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDichVu).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 21);
            label1.Name = "label1";
            label1.Size = new Size(386, 37);
            label1.TabIndex = 1;
            label1.Text = "Quản lý khách hàng & hóa đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableKhachHang);
            groupBox1.Location = new Point(345, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 355);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // tableKhachHang
            // 
            tableKhachHang.AllowUserToAddRows = false;
            tableKhachHang.AllowUserToDeleteRows = false;
            tableKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableKhachHang.Location = new Point(0, 16);
            tableKhachHang.MultiSelect = false;
            tableKhachHang.Name = "tableKhachHang";
            tableKhachHang.ReadOnly = true;
            tableKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableKhachHang.Size = new Size(444, 333);
            tableKhachHang.TabIndex = 0;
            tableKhachHang.CellContentClick += tableKhachHang_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableDichVu);
            groupBox2.Location = new Point(799, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 355);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách dịch vụ";
            // 
            // tableDichVu
            // 
            tableDichVu.AllowUserToAddRows = false;
            tableDichVu.AllowUserToDeleteRows = false;
            tableDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDichVu.Columns.AddRange(new DataGridViewColumn[] { columnCheckDV });
            tableDichVu.Location = new Point(6, 22);
            tableDichVu.MultiSelect = false;
            tableDichVu.Name = "tableDichVu";
            tableDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDichVu.Size = new Size(411, 327);
            tableDichVu.TabIndex = 1;
            tableDichVu.CellContentClick += tableDichVu_CellContentClick;
            // 
            // columnCheckDV
            // 
            columnCheckDV.HeaderText = "Checked";
            columnCheckDV.Name = "columnCheckDV";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnHD);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(345, 447);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(871, 81);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnHD
            // 
            btnHD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHD.Location = new Point(620, 30);
            btnHD.Name = "btnHD";
            btnHD.Size = new Size(127, 29);
            btnHD.TabIndex = 3;
            btnHD.Text = "Tạo hóa đơn";
            btnHD.UseVisualStyleBackColor = true;
            btnHD.Click += btnHD_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(298, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(165, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(33, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(txtDiaChi);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtName);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtID);
            groupBox4.Location = new Point(12, 86);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(327, 442);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 223);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 8;
            label5.Text = "SĐT:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(90, 220);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(217, 29);
            txtSDT.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 168);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(90, 165);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(217, 29);
            txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(90, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 29);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(90, 55);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(217, 29);
            txtID.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 531);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableKhachHang).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableDichVu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView tableKhachHang;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnHD;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label5;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtDiaChi;
        private DataGridView tableDichVu;
        private DataGridViewCheckBoxColumn columnCheckDV;
    }
}
