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
            panel1 = new Panel();
            lblTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPDC).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSSP
            // 
            dgvDSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSP.Location = new Point(135, 58);
            dgvDSSP.Name = "dgvDSSP";
            dgvDSSP.RowHeadersWidth = 51;
            dgvDSSP.Size = new Size(522, 188);
            dgvDSSP.TabIndex = 0;
            // 
            // lblDSSP
            // 
            lblDSSP.AutoSize = true;
            lblDSSP.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDSSP.Location = new Point(223, 9);
            lblDSSP.Name = "lblDSSP";
            lblDSSP.Size = new Size(344, 46);
            lblDSSP.TabIndex = 1;
            lblDSSP.Text = "Danh sách sản phẩm";
            // 
            // dgvSPDC
            // 
            dgvSPDC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSPDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPDC.Location = new Point(135, 252);
            dgvSPDC.Name = "dgvSPDC";
            dgvSPDC.RowHeadersWidth = 51;
            dgvSPDC.Size = new Size(522, 188);
            dgvSPDC.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(221, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(419, 0);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(100, 30);
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
            lblTotalQuantity.Location = new Point(135, 455);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(0, 31);
            lblTotalQuantity.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThanhToan);
            panel1.Location = new Point(135, 489);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 35);
            panel1.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(400, 450);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 31);
            lblTotalPrice.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(lblTotalPrice);
            Controls.Add(panel1);
            Controls.Add(lblTotalQuantity);
            Controls.Add(dgvSPDC);
            Controls.Add(lblDSSP);
            Controls.Add(dgvDSSP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPDC).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Label lblTotalPrice;
    }
}