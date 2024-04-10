namespace PRL.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPassWord = new TextBox();
            ckbShowPass = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(229, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveCaption;
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(490, 324);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(170, 46);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 23);
            label1.Name = "label1";
            label1.Size = new Size(285, 61);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(143, 33);
            label2.TabIndex = 3;
            label2.Text = "Tài khoản :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 208);
            label3.Name = "label3";
            label3.Size = new Size(151, 36);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu :";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(215, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(500, 44);
            txtUser.TabIndex = 5;
            // 
            // txtPassWord
            // 
            txtPassWord.Cursor = Cursors.IBeam;
            txtPassWord.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(215, 203);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(489, 41);
            txtPassWord.TabIndex = 6;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ckbShowPass.Location = new Point(219, 267);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(203, 28);
            ckbShowPass.TabIndex = 8;
            ckbShowPass.Text = "Hiển thị mật khẩu";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(ckbShowPass);
            Controls.Add(txtPassWord);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassWord;
        private CheckBox ckbShowPass;
    }
}