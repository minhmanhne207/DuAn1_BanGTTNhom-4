namespace PRL.View
{
    partial class frmVoucher
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
            couponToolStripMenuItem = new ToolStripMenuItem();
            dtpNgayKetThucVoucher = new DateTimePicker();
            dtpNgayBatDauVoucher = new DateTimePicker();
            txtboxMoTaVoucher = new TextBox();
            txtboxTenVoucher = new TextBox();
            txtboxMaVoucher = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dgvVoucher = new DataGridView();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtboxDKVoucher = new TextBox();
            txtboxGiaTriVoucher = new TextBox();
            label8 = new Label();
            label3 = new Label();
            menuDànhChoQuảnLýToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1711, 44);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(86, 38);
            userToolStripMenuItem.Text = "User:";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(285, 44);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(285, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýNhânViênToolStripMenuItem, quảnLýKhuyếnMãiToolStripMenuItem, quảnLýHóaĐơnToolStripMenuItem, thốngKêToolStripMenuItem, couponToolStripMenuItem, menuDànhChoQuảnLýToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(119, 38);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(379, 44);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(379, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýKhuyếnMãiToolStripMenuItem
            // 
            quảnLýKhuyếnMãiToolStripMenuItem.Name = "quảnLýKhuyếnMãiToolStripMenuItem";
            quảnLýKhuyếnMãiToolStripMenuItem.Size = new Size(379, 44);
            quảnLýKhuyếnMãiToolStripMenuItem.Text = "Quản Lý Voucher";
            quảnLýKhuyếnMãiToolStripMenuItem.Click += quảnLýKhuyếnMãiToolStripMenuItem_Click;
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(379, 44);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            quảnLýHóaĐơnToolStripMenuItem.Click += quảnLýHóaĐơnToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(379, 44);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // couponToolStripMenuItem
            // 
            couponToolStripMenuItem.Name = "couponToolStripMenuItem";
            couponToolStripMenuItem.Size = new Size(379, 44);
            couponToolStripMenuItem.Text = "Coupon";
            couponToolStripMenuItem.Click += couponToolStripMenuItem_Click;
            // 
            // dtpNgayKetThucVoucher
            // 
            dtpNgayKetThucVoucher.Format = DateTimePickerFormat.Short;
            dtpNgayKetThucVoucher.Location = new Point(918, 512);
            dtpNgayKetThucVoucher.Margin = new Padding(5);
            dtpNgayKetThucVoucher.Name = "dtpNgayKetThucVoucher";
            dtpNgayKetThucVoucher.Size = new Size(435, 35);
            dtpNgayKetThucVoucher.TabIndex = 12;
            // 
            // dtpNgayBatDauVoucher
            // 
            dtpNgayBatDauVoucher.Format = DateTimePickerFormat.Short;
            dtpNgayBatDauVoucher.Location = new Point(213, 512);
            dtpNgayBatDauVoucher.Margin = new Padding(5);
            dtpNgayBatDauVoucher.Name = "dtpNgayBatDauVoucher";
            dtpNgayBatDauVoucher.Size = new Size(435, 35);
            dtpNgayBatDauVoucher.TabIndex = 11;
            // 
            // txtboxMoTaVoucher
            // 
            txtboxMoTaVoucher.Location = new Point(918, 318);
            txtboxMoTaVoucher.Margin = new Padding(5);
            txtboxMoTaVoucher.Name = "txtboxMoTaVoucher";
            txtboxMoTaVoucher.Size = new Size(435, 35);
            txtboxMoTaVoucher.TabIndex = 8;
            // 
            // txtboxTenVoucher
            // 
            txtboxTenVoucher.Location = new Point(918, 117);
            txtboxTenVoucher.Margin = new Padding(5);
            txtboxTenVoucher.Name = "txtboxTenVoucher";
            txtboxTenVoucher.Size = new Size(435, 35);
            txtboxTenVoucher.TabIndex = 7;
            // 
            // txtboxMaVoucher
            // 
            txtboxMaVoucher.Location = new Point(213, 117);
            txtboxMaVoucher.Margin = new Padding(5);
            txtboxMaVoucher.Name = "txtboxMaVoucher";
            txtboxMaVoucher.Size = new Size(435, 35);
            txtboxMaVoucher.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(738, 518);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 5;
            label7.Text = "Ngày Kết Thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 520);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 4;
            label6.Text = "Ngày Bắt Đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 254);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 122);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Voucher";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvVoucher);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(20, 771);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(1674, 478);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Voucher";
            // 
            // dgvVoucher
            // 
            dgvVoucher.AllowUserToAddRows = false;
            dgvVoucher.AllowUserToDeleteRows = false;
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Location = new Point(-174, 42);
            dgvVoucher.Margin = new Padding(5);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.ReadOnly = true;
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(1838, 427);
            dgvVoucher.TabIndex = 0;
            dgvVoucher.CellClick += dgvVoucher_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(1394, 147);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(299, 614);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(642, 59);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(425, 61);
            label1.TabIndex = 12;
            label1.Text = "Quản Lý Voucher";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtboxDKVoucher);
            groupBox1.Controls.Add(txtboxGiaTriVoucher);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayKetThucVoucher);
            groupBox1.Controls.Add(dtpNgayBatDauVoucher);
            groupBox1.Controls.Add(txtboxMoTaVoucher);
            groupBox1.Controls.Add(txtboxTenVoucher);
            groupBox1.Controls.Add(txtboxMaVoucher);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 147);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1365, 614);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // txtboxDKVoucher
            // 
            txtboxDKVoucher.Location = new Point(213, 382);
            txtboxDKVoucher.Margin = new Padding(5);
            txtboxDKVoucher.Name = "txtboxDKVoucher";
            txtboxDKVoucher.Size = new Size(435, 35);
            txtboxDKVoucher.TabIndex = 15;
            // 
            // txtboxGiaTriVoucher
            // 
            txtboxGiaTriVoucher.Location = new Point(213, 250);
            txtboxGiaTriVoucher.Margin = new Padding(5);
            txtboxGiaTriVoucher.Name = "txtboxGiaTriVoucher";
            txtboxGiaTriVoucher.Size = new Size(435, 35);
            txtboxGiaTriVoucher.TabIndex = 14;
            txtboxGiaTriVoucher.KeyPress += txtboxGiaTriVoucher_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 387);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 13;
            label8.Text = "Điều Kiện";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(764, 128);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên Voucher";
            // 
            // menuDànhChoQuảnLýToolStripMenuItem
            // 
            menuDànhChoQuảnLýToolStripMenuItem.Name = "menuDànhChoQuảnLýToolStripMenuItem";
            menuDànhChoQuảnLýToolStripMenuItem.Size = new Size(379, 44);
            menuDànhChoQuảnLýToolStripMenuItem.Text = "Menu dành cho quản lý";
            menuDànhChoQuảnLýToolStripMenuItem.Click += menuDànhChoQuảnLýToolStripMenuItem_Click;
            // 
            // frmVoucher
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1254);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "frmVoucher";
            Text = "frmQLVoucher";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DateTimePicker dtpNgayKetThucVoucher;
        private DateTimePicker dtpNgayBatDauVoucher;
        private TextBox txtboxMoTaVoucher;
        private TextBox txtboxTenVoucher;
        private TextBox txtboxMaVoucher;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dgvVoucher;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label8;
        private TextBox txtboxDKVoucher;
        private TextBox txtboxGiaTriVoucher;
        private ToolStripMenuItem couponToolStripMenuItem;
        private ToolStripMenuItem menuDànhChoQuảnLýToolStripMenuItem;
    }
}