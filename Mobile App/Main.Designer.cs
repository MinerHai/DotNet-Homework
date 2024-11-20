namespace Mobile_App
{
    partial class Main
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
            groupBox1 = new GroupBox();
            tableSP = new DataGridView();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableDonHang = new DataGridView();
            groupBox3 = new GroupBox();
            tableKH = new DataGridView();
            groupBox4 = new GroupBox();
            btnDoanhThu = new Button();
            btnQuit = new Button();
            btnDangXuat = new Button();
            btnRefesh = new Button();
            btnQuanLy = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDonHang).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableKH).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableSP);
            groupBox1.Location = new Point(32, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // tableSP
            // 
            tableSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSP.Location = new Point(6, 22);
            tableSP.Name = "tableSP";
            tableSP.ReadOnly = true;
            tableSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableSP.Size = new Size(269, 291);
            tableSP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 45);
            label1.TabIndex = 1;
            label1.Text = "Main";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableDonHang);
            groupBox2.Location = new Point(329, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 319);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách đơn hàng";
            // 
            // tableDonHang
            // 
            tableDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDonHang.Location = new Point(5, 22);
            tableDonHang.Name = "tableDonHang";
            tableDonHang.ReadOnly = true;
            tableDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDonHang.Size = new Size(271, 291);
            tableDonHang.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableKH);
            groupBox3.Location = new Point(630, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 319);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            // 
            // tableKH
            // 
            tableKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableKH.Location = new Point(6, 22);
            tableKH.Name = "tableKH";
            tableKH.ReadOnly = true;
            tableKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableKH.Size = new Size(256, 291);
            tableKH.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDoanhThu);
            groupBox4.Controls.Add(btnQuit);
            groupBox4.Controls.Add(btnDangXuat);
            groupBox4.Controls.Add(btnRefesh);
            groupBox4.Controls.Add(btnQuanLy);
            groupBox4.Location = new Point(38, 386);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(860, 69);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Options";
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Location = new Point(340, 35);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(75, 23);
            btnDoanhThu.TabIndex = 5;
            btnDoanhThu.Text = "Doanh Thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(598, 35);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(461, 35);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(75, 23);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(200, 35);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 1;
            btnRefesh.Text = "Làm mới";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // btnQuanLy
            // 
            btnQuanLy.Location = new Point(60, 35);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(75, 23);
            btnQuanLy.TabIndex = 0;
            btnQuanLy.Text = "Quản lý ";
            btnQuanLy.UseVisualStyleBackColor = true;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 456);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Main";
            FormClosed += Main_FormClosed;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableSP).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableDonHang).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableKH).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView tableSP;
        private DataGridView tableDonHang;
        private GroupBox groupBox3;
        private DataGridView tableKH;
        private GroupBox groupBox4;
        private Button btnRefesh;
        private Button btnQuanLy;
        private Button btnQuit;
        private Button btnDangXuat;
        private Button btnDoanhThu;
    }
}