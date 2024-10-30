namespace KtraApp
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
            dgvDSSP = new DataGridView();
            lblDSSP = new Label();
            dgvSPDC = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            lblTotalQuantity = new Label();
            lblTotalPrice = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPDC).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSSP
            // 
            dgvDSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSP.Location = new Point(413, 67);
            dgvDSSP.Margin = new Padding(3, 2, 3, 2);
            dgvDSSP.Name = "dgvDSSP";
            dgvDSSP.RowHeadersWidth = 51;
            dgvDSSP.Size = new Size(375, 299);
            dgvDSSP.TabIndex = 0;
            // 
            // lblDSSP
            // 
            lblDSSP.AutoSize = true;
            lblDSSP.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDSSP.Location = new Point(234, 5);
            lblDSSP.Name = "lblDSSP";
            lblDSSP.Size = new Size(277, 37);
            lblDSSP.TabIndex = 1;
            lblDSSP.Text = "Danh sách sản phẩm";
            // 
            // dgvSPDC
            // 
            dgvSPDC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSPDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPDC.Location = new Point(8, 67);
            dgvSPDC.Margin = new Padding(3, 2, 3, 2);
            dgvSPDC.Name = "dgvSPDC";
            dgvSPDC.RowHeadersWidth = 51;
            dgvSPDC.Size = new Size(369, 296);
            dgvSPDC.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F);
            btnThem.Location = new Point(125, 21);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 31);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F);
            btnXoa.Location = new Point(315, 21);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 31);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 12F);
            btnThanhToan.Location = new Point(489, 19);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(111, 31);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalQuantity.ForeColor = Color.Red;
            lblTotalQuantity.Location = new Point(118, 341);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(0, 25);
            lblTotalQuantity.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(350, 338);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 25);
            lblTotalPrice.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Location = new Point(8, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 72);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 496);
            Controls.Add(groupBox2);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalQuantity);
            Controls.Add(dgvSPDC);
            Controls.Add(lblDSSP);
            Controls.Add(dgvDSSP);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPDC).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSSP;
        private Label lblDSSP;
        private DataGridView dgvSPDC;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThanhToan;
        private Label lblTotalQuantity;
        private Label lblTotalPrice;
        private GroupBox groupBox2;
    }
}
