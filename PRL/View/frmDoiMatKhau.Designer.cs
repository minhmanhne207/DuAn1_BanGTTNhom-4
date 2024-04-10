namespace PRL.View
{
    partial class frmDoiMatKhau
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUser = new TextBox();
            txtPassCu = new TextBox();
            txtPassMoi = new TextBox();
            btnXacNhanDoiMK = new Button();
            btnBack = new Button();
            label5 = new Label();
            txtPassXacNhan = new TextBox();
            cbHienThiMk = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 24);
            label1.Name = "label1";
            label1.Size = new Size(329, 61);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 118);
            label2.Name = "label2";
            label2.Size = new Size(128, 33);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 199);
            label3.Name = "label3";
            label3.Size = new Size(177, 33);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu cũ : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 285);
            label4.Name = "label4";
            label4.Size = new Size(189, 33);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới :";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(344, 110);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(443, 41);
            txtUser.TabIndex = 4;
            // 
            // txtPassCu
            // 
            txtPassCu.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassCu.Location = new Point(345, 198);
            txtPassCu.Name = "txtPassCu";
            txtPassCu.Size = new Size(442, 41);
            txtPassCu.TabIndex = 5;
            txtPassCu.UseSystemPasswordChar = true;
            // 
            // txtPassMoi
            // 
            txtPassMoi.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassMoi.Location = new Point(347, 281);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(440, 41);
            txtPassMoi.TabIndex = 6;
            txtPassMoi.UseSystemPasswordChar = true;
            // 
            // btnXacNhanDoiMK
            // 
            btnXacNhanDoiMK.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhanDoiMK.Location = new Point(215, 478);
            btnXacNhanDoiMK.Name = "btnXacNhanDoiMK";
            btnXacNhanDoiMK.Size = new Size(150, 46);
            btnXacNhanDoiMK.TabIndex = 7;
            btnXacNhanDoiMK.Text = "Xác nhận";
            btnXacNhanDoiMK.UseVisualStyleBackColor = true;
            btnXacNhanDoiMK.Click += btnXacNhanDoiMK_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(505, 478);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 8;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 374);
            label5.Name = "label5";
            label5.Size = new Size(246, 33);
            label5.TabIndex = 9;
            label5.Text = "Xác nhận mật khẩu :";
            // 
            // txtPassXacNhan
            // 
            txtPassXacNhan.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassXacNhan.Location = new Point(351, 370);
            txtPassXacNhan.Name = "txtPassXacNhan";
            txtPassXacNhan.Size = new Size(436, 41);
            txtPassXacNhan.TabIndex = 10;
            txtPassXacNhan.UseSystemPasswordChar = true;
            // 
            // cbHienThiMk
            // 
            cbHienThiMk.AutoSize = true;
            cbHienThiMk.Font = new Font("Times New Roman", 7.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbHienThiMk.Location = new Point(347, 426);
            cbHienThiMk.Name = "cbHienThiMk";
            cbHienThiMk.Size = new Size(203, 28);
            cbHienThiMk.TabIndex = 11;
            cbHienThiMk.Text = "Hiển thị mật khẩu";
            cbHienThiMk.UseVisualStyleBackColor = true;
            cbHienThiMk.CheckedChanged += cbHienThiMk_CheckedChanged;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 564);
            Controls.Add(cbHienThiMk);
            Controls.Add(txtPassXacNhan);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnXacNhanDoiMK);
            Controls.Add(txtPassMoi);
            Controls.Add(txtPassCu);
            Controls.Add(txtUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUser;
        private TextBox txtPassCu;
        private TextBox txtPassMoi;
        private Button btnXacNhanDoiMK;
        private Button btnBack;
        private Label label5;
        private TextBox txtPassXacNhan;
        private CheckBox cbHienThiMk;
    }
}