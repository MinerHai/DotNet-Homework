namespace Mobile_App
{
    partial class DoanhThu
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
            tableDoanhThu = new DataGridView();
            dtpNgay = new DateTimePicker();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)tableDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 50);
            label1.TabIndex = 0;
            label1.Text = "Doanh Thu";
            // 
            // tableDoanhThu
            // 
            tableDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDoanhThu.Location = new Point(313, 90);
            tableDoanhThu.Name = "tableDoanhThu";
            tableDoanhThu.Size = new Size(451, 273);
            tableDoanhThu.TabIndex = 1;
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(49, 90);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(200, 23);
            dtpNgay.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(101, 340);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTim);
            Controls.Add(dtpNgay);
            Controls.Add(tableDoanhThu);
            Controls.Add(label1);
            Name = "DoanhThu";
            Text = "DoanhThu";
            ((System.ComponentModel.ISupportInitialize)tableDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tableDoanhThu;
        private DateTimePicker dtpNgay;
        private Button btnTim;
    }
}