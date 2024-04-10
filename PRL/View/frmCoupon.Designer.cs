namespace PRL.View
{
    partial class frmCoupon
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
            dgvCoupon = new DataGridView();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dtpNgayKetThucCoupon = new DateTimePicker();
            dtpNgayBatDauCoupon = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtboxDKCoupon = new TextBox();
            txtboxGiaTriCoupon = new TextBox();
            label8 = new Label();
            txtboxMoTaCoupon = new TextBox();
            txtboxTenCoupon = new TextBox();
            txtboxMaCoupon = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhuyếnMãiToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            quảnLýCouponToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();
            btnThoat = new Button();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCoupon).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCoupon
            // 
            dgvCoupon.AllowUserToAddRows = false;
            dgvCoupon.AllowUserToDeleteRows = false;
            dgvCoupon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupon.Location = new Point(10, 51);
            dgvCoupon.Margin = new Padding(5);
            dgvCoupon.Name = "dgvCoupon";
            dgvCoupon.ReadOnly = true;
            dgvCoupon.RowHeadersWidth = 51;
            dgvCoupon.RowTemplate.Height = 29;
            dgvCoupon.Size = new Size(1632, 418);
            dgvCoupon.TabIndex = 0;
            dgvCoupon.CellClick += dgvCoupon_CellClick;
            // 
            // btnClear
            // 
            btnClear.Image = Properties.Resources.Delete;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(10, 520);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(280, 85);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.Refresh;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(10, 294);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(280, 85);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(10, 69);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 85);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCoupon);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(20, 766);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(1674, 493);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Voucher";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(1394, 142);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(299, 614);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(642, 54);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 61);
            label1.TabIndex = 7;
            label1.Text = "Quản Lý Coupon";
            // 
            // dtpNgayKetThucCoupon
            // 
            dtpNgayKetThucCoupon.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThucCoupon.Location = new Point(918, 512);
            dtpNgayKetThucCoupon.Margin = new Padding(5);
            dtpNgayKetThucCoupon.Name = "dtpNgayKetThucCoupon";
            dtpNgayKetThucCoupon.Size = new Size(435, 35);
            dtpNgayKetThucCoupon.TabIndex = 12;
            // 
            // dtpNgayBatDauCoupon
            // 
            dtpNgayBatDauCoupon.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDauCoupon.Location = new Point(213, 512);
            dtpNgayBatDauCoupon.Margin = new Padding(5);
            dtpNgayBatDauCoupon.Name = "dtpNgayBatDauCoupon";
            dtpNgayBatDauCoupon.Size = new Size(435, 35);
            dtpNgayBatDauCoupon.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtboxDKCoupon);
            groupBox1.Controls.Add(txtboxGiaTriCoupon);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayKetThucCoupon);
            groupBox1.Controls.Add(dtpNgayBatDauCoupon);
            groupBox1.Controls.Add(txtboxMoTaCoupon);
            groupBox1.Controls.Add(txtboxTenCoupon);
            groupBox1.Controls.Add(txtboxMaCoupon);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 142);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1365, 614);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtboxDKCoupon
            // 
            txtboxDKCoupon.Location = new Point(213, 382);
            txtboxDKCoupon.Margin = new Padding(5);
            txtboxDKCoupon.Name = "txtboxDKCoupon";
            txtboxDKCoupon.Size = new Size(435, 35);
            txtboxDKCoupon.TabIndex = 15;
            // 
            // txtboxGiaTriCoupon
            // 
            txtboxGiaTriCoupon.Location = new Point(213, 250);
            txtboxGiaTriCoupon.Margin = new Padding(5);
            txtboxGiaTriCoupon.Name = "txtboxGiaTriCoupon";
            txtboxGiaTriCoupon.Size = new Size(435, 35);
            txtboxGiaTriCoupon.TabIndex = 14;
            txtboxGiaTriCoupon.KeyPress += txtboxGiaTriCoupon_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 387);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 13;
            label8.Text = "Điều Kiện";
            // 
            // txtboxMoTaCoupon
            // 
            txtboxMoTaCoupon.Location = new Point(918, 318);
            txtboxMoTaCoupon.Margin = new Padding(5);
            txtboxMoTaCoupon.Name = "txtboxMoTaCoupon";
            txtboxMoTaCoupon.Size = new Size(435, 35);
            txtboxMoTaCoupon.TabIndex = 8;
            // 
            // txtboxTenCoupon
            // 
            txtboxTenCoupon.Location = new Point(918, 117);
            txtboxTenCoupon.Margin = new Padding(5);
            txtboxTenCoupon.Name = "txtboxTenCoupon";
            txtboxTenCoupon.Size = new Size(435, 35);
            txtboxTenCoupon.TabIndex = 7;
            // 
            // txtboxMaCoupon
            // 
            txtboxMaCoupon.Location = new Point(213, 117);
            txtboxMaCoupon.Margin = new Padding(5);
            txtboxMaCoupon.Name = "txtboxMaCoupon";
            txtboxMaCoupon.Size = new Size(435, 35);
            txtboxMaCoupon.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(736, 520);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 5;
            label7.Text = "Ngày Kết Thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 520);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 4;
            label6.Text = "Ngày Bắt Đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 254);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 3;
            label5.Text = "Giá Trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(826, 323);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 2;
            label4.Text = "Mô Tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 128);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên Coupon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 122);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Coupon";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, quảnLýToolStripMenuItem, thêmNhânViênToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1711, 44);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(88, 38);
            userToolStripMenuItem.Text = "User:";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(359, 44);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(359, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, quảnLýKhuyếnMãiToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem, quảnLýCouponToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, menuToolStripMenuItem });
            quảnLýToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(123, 38);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(359, 44);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(359, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMãiToolStripMenuItem
            // 
            quảnLýKhuyếnMãiToolStripMenuItem.Name = "quảnLýKhuyếnMãiToolStripMenuItem";
            quảnLýKhuyếnMãiToolStripMenuItem.Size = new Size(359, 44);
            quảnLýKhuyếnMãiToolStripMenuItem.Text = "Quản Lý Voucher";
            quảnLýKhuyếnMãiToolStripMenuItem.Click += quảnLýKhuyếnMãiToolStripMenuItem_Click;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(359, 44);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(359, 44);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // quảnLýCouponToolStripMenuItem
            // 
            quảnLýCouponToolStripMenuItem.Name = "quảnLýCouponToolStripMenuItem";
            quảnLýCouponToolStripMenuItem.Size = new Size(359, 44);
            quảnLýCouponToolStripMenuItem.Text = "Coupon";
            quảnLýCouponToolStripMenuItem.Click += quảnLýCouponToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(359, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(204, 38);
            thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ImageAlign = ContentAlignment.MiddleRight;
            btnThoat.Location = new Point(1451, 1286);
            btnThoat.Margin = new Padding(5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(210, 75);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(359, 44);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // frmCoupon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1381);
            Controls.Add(btnThoat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Margin = new Padding(5);
            Name = "frmCoupon";
            Text = "frmQLCoupon";
            ((System.ComponentModel.ISupportInitialize)dgvCoupon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoupon;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dtpNgayKetThucCoupon;
        private DateTimePicker dtpNgayBatDauCoupon;
        private GroupBox groupBox1;
        private TextBox txtboxMoTaCoupon;
        private TextBox txtboxTenCoupon;
        private TextBox txtboxMaCoupon;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhuyếnMãiToolStripMenuItem;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private Label label8;
        private TextBox txtboxDKCoupon;
        private TextBox txtboxGiaTriCoupon;
        private Button btnThoat;
        private ToolStripMenuItem quảnLýCouponToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}