namespace Mobile_App
{
    partial class QuanLyDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableDH = new DataGridView();
            label2 = new Label();
            txtID_DH = new TextBox();
            txtKhachHangId = new TextBox();
            label3 = new Label();
            txtSoLuong = new NumericUpDown();
            txtSanPhamId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tableDH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24.25F, FontStyle.Bold);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 45);
            label1.TabIndex = 0;
            label1.Text = "Quản lý đơn hàng";
            // 
            // tableDH
            // 
            tableDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDH.Location = new Point(460, 77);
            tableDH.MultiSelect = false;
            tableDH.Name = "tableDH";
            tableDH.ReadOnly = true;
            tableDH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDH.Size = new Size(408, 331);
            tableDH.TabIndex = 1;
            tableDH.CellClick += tableDH_CellContentClick;
            tableDH.CellContentClick += tableDH_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 143);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // txtID_DH
            // 
            txtID_DH.Location = new Point(176, 135);
            txtID_DH.Name = "txtID_DH";
            txtID_DH.ReadOnly = true;
            txtID_DH.Size = new Size(213, 23);
            txtID_DH.TabIndex = 3;
            // 
            // txtKhachHangId
            // 
            txtKhachHangId.Location = new Point(176, 177);
            txtKhachHangId.Name = "txtKhachHangId";
            txtKhachHangId.Size = new Size(213, 23);
            txtKhachHangId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 180);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "ID Khách hàng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(176, 266);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(120, 23);
            txtSoLuong.TabIndex = 6;
            // 
            // txtSanPhamId
            // 
            txtSanPhamId.Location = new Point(176, 221);
            txtSanPhamId.Name = "txtSanPhamId";
            txtSanPhamId.Size = new Size(213, 23);
            txtSanPhamId.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 224);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "ID Sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 274);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Số lượng:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(61, 454);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(176, 454);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(304, 454);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(460, 455);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(567, 454);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(301, 23);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // QuanLyDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 505);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(txtSanPhamId);
            Controls.Add(label4);
            Controls.Add(txtSoLuong);
            Controls.Add(txtKhachHangId);
            Controls.Add(label3);
            Controls.Add(txtID_DH);
            Controls.Add(label2);
            Controls.Add(tableDH);
            Controls.Add(label1);
            Name = "QuanLyDonHang";
            Text = "QuanLyDonHang";
            ((System.ComponentModel.ISupportInitialize)tableDH).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableDH;
        private Label label2;
        private TextBox txtID_DH;
        private TextBox txtKhachHangId;
        private Label label3;
        private NumericUpDown txtSoLuong;
        private TextBox txtSanPhamId;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}