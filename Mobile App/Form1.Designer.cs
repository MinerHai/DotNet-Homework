namespace Mobile_App
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
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            btnDangNhap = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(178, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(297, 29);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(73, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(73, 174);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(178, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(297, 29);
            txtPassword.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 12F);
            btnDangNhap.Location = new Point(178, 225);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(101, 28);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 12F);
            btnQuit.Location = new Point(384, 225);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(91, 28);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 339);
            Controls.Add(btnQuit);
            Controls.Add(btnDangNhap);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "Form1";
            Text = "Login";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button btnDangNhap;
        private Button btnQuit;
    }
}
