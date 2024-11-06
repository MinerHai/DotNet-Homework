namespace _6_11_2024
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
            groupBox1 = new GroupBox();
            txtPrice = new TextBox();
            label5 = new Label();
            txtDetails = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableSanPham = new DataGridView();
            groupBox3 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSanPham).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDetails);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(98, 240);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(249, 29);
            txtPrice.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(32, 243);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 6;
            label5.Text = "Price:";
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 12F);
            txtDetails.Location = new Point(98, 168);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(249, 44);
            txtDetails.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(32, 171);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 4;
            label4.Text = "Details:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(99, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(249, 29);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(99, 65);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(249, 29);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 68);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 0;
            label2.Text = "ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableSanPham);
            groupBox2.Location = new Point(419, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 348);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // tableSanPham
            // 
            tableSanPham.AllowUserToAddRows = false;
            tableSanPham.AllowUserToDeleteRows = false;
            tableSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSanPham.Location = new Point(6, 22);
            tableSanPham.Name = "tableSanPham";
            tableSanPham.ReadOnly = true;
            tableSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableSanPham.Size = new Size(414, 320);
            tableSanPham.TabIndex = 0;
            tableSanPham.CellContentClick += tableSanPham_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(12, 421);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(833, 80);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSua.Location = new Point(599, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 39);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(327, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 39);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(69, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 513);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableSanPham).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView tableSanPham;
        private GroupBox groupBox3;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtDetails;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
