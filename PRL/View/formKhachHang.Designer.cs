namespace PRL.View
{
    partial class formKhachHang
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
            groupBox2 = new GroupBox();
            btnHienthi = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            menustripQLNV = new ToolStripMenuItem();
            MNSTripQLSP = new ToolStripMenuItem();
            mnStripQLTK = new ToolStripMenuItem();
            mnstripQLHD = new ToolStripMenuItem();
            mnstripQLVC = new ToolStripMenuItem();
            mnstripQLCP = new ToolStripMenuItem();
            menustripMenu = new ToolStripMenuItem();
            hóaĐơnThanhToánToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cbbMotaRanks = new ComboBox();
            label3 = new Label();
            txtboxRank = new TextBox();
            txtboxDiem = new TextBox();
            txtboxSDT = new TextBox();
            txtboxMaKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbbSearchRank = new ComboBox();
            txtboxSearchSDT = new TextBox();
            label9 = new Label();
            dgvKhachHang = new DataGridView();
            label8 = new Label();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHienthi);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(1442, 199);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(262, 452);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnHienthi
            // 
            btnHienthi.Location = new Point(11, 267);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(213, 65);
            btnHienthi.TabIndex = 3;
            btnHienthi.Text = "Hiển thị";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += btnHienthi_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(11, 358);
            btnDelete.Margin = new Padding(5, 4, 5, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(213, 63);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Clear";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(11, 145);
            btnUpdate.Margin = new Padding(5, 4, 5, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(213, 63);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 39);
            btnAdd.Margin = new Padding(5, 4, 5, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(213, 63);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 2, 0, 2);
            menuStrip1.Size = new Size(1734, 36);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menustripQLNV, MNSTripQLSP, mnStripQLTK, mnstripQLHD, mnstripQLVC, mnstripQLCP, menustripMenu, hóaĐơnThanhToánToolStripMenuItem });
            quảnLýToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(111, 32);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // menustripQLNV
            // 
            menustripQLNV.Name = "menustripQLNV";
            menustripQLNV.Size = new Size(344, 44);
            menustripQLNV.Text = "Quản lý nhân viên";
            menustripQLNV.Click += menustripQLNV_Click;
            // 
            // MNSTripQLSP
            // 
            MNSTripQLSP.Name = "MNSTripQLSP";
            MNSTripQLSP.Size = new Size(344, 44);
            MNSTripQLSP.Text = "Quản lý sản phẩm";
            MNSTripQLSP.Click += MNSTripQLSP_Click;
            // 
            // mnStripQLTK
            // 
            mnStripQLTK.Name = "mnStripQLTK";
            mnStripQLTK.Size = new Size(344, 44);
            mnStripQLTK.Text = "Quản lý thống kê";
            mnStripQLTK.Click += mnStripQLTK_Click;
            // 
            // mnstripQLHD
            // 
            mnstripQLHD.Name = "mnstripQLHD";
            mnstripQLHD.Size = new Size(344, 44);
            mnstripQLHD.Text = "Quản lý hóa đơn";
            mnstripQLHD.Click += mnstripQLHD_Click;
            // 
            // mnstripQLVC
            // 
            mnstripQLVC.Name = "mnstripQLVC";
            mnstripQLVC.Size = new Size(344, 44);
            mnstripQLVC.Text = "Quản lý voucher";
            mnstripQLVC.Click += mnstripQLVC_Click;
            // 
            // mnstripQLCP
            // 
            mnstripQLCP.Name = "mnstripQLCP";
            mnstripQLCP.Size = new Size(344, 44);
            mnstripQLCP.Text = "Quản lý Coupon";
            mnstripQLCP.Click += mnstripQLCP_Click;
            // 
            // menustripMenu
            // 
            menustripMenu.Name = "menustripMenu";
            menustripMenu.Size = new Size(344, 44);
            menustripMenu.Text = "Menu chính";
            menustripMenu.Click += menustripMenu_Click;
            // 
            // hóaĐơnThanhToánToolStripMenuItem
            // 
            hóaĐơnThanhToánToolStripMenuItem.Name = "hóaĐơnThanhToánToolStripMenuItem";
            hóaĐơnThanhToánToolStripMenuItem.Size = new Size(344, 44);
            hóaĐơnThanhToánToolStripMenuItem.Text = "Hóa đơn thanh toán";
            hóaĐơnThanhToánToolStripMenuItem.Click += hóaĐơnThanhToánToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(88, 32);
            userToolStripMenuItem.Text = "User:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbMotaRanks);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtboxRank);
            groupBox1.Controls.Add(txtboxDiem);
            groupBox1.Controls.Add(txtboxSDT);
            groupBox1.Controls.Add(txtboxMaKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 199);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1381, 320);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // cbbMotaRanks
            // 
            cbbMotaRanks.FormattingEnabled = true;
            cbbMotaRanks.Location = new Point(259, 201);
            cbbMotaRanks.Name = "cbbMotaRanks";
            cbbMotaRanks.Size = new Size(431, 35);
            cbbMotaRanks.TabIndex = 11;
            cbbMotaRanks.SelectedIndexChanged += cbbMotaRanks_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 134);
            label3.Name = "label3";
            label3.Size = new Size(109, 27);
            label3.TabIndex = 10;
            label3.Text = "Mã Ranks";
            // 
            // txtboxRank
            // 
            txtboxRank.Location = new Point(261, 130);
            txtboxRank.Margin = new Padding(5, 4, 5, 4);
            txtboxRank.Name = "txtboxRank";
            txtboxRank.ReadOnly = true;
            txtboxRank.Size = new Size(429, 35);
            txtboxRank.TabIndex = 9;
            // 
            // txtboxDiem
            // 
            txtboxDiem.Location = new Point(928, 194);
            txtboxDiem.Margin = new Padding(5, 4, 5, 4);
            txtboxDiem.Name = "txtboxDiem";
            txtboxDiem.Size = new Size(429, 35);
            txtboxDiem.TabIndex = 8;
            // 
            // txtboxSDT
            // 
            txtboxSDT.Location = new Point(928, 69);
            txtboxSDT.Margin = new Padding(5, 4, 5, 4);
            txtboxSDT.Name = "txtboxSDT";
            txtboxSDT.Size = new Size(429, 35);
            txtboxSDT.TabIndex = 7;
            txtboxSDT.KeyPress += txtboxSDT_KeyPress;
            // 
            // txtboxMaKH
            // 
            txtboxMaKH.Location = new Point(261, 67);
            txtboxMaKH.Margin = new Padding(5, 4, 5, 4);
            txtboxMaKH.Name = "txtboxMaKH";
            txtboxMaKH.ReadOnly = true;
            txtboxMaKH.Size = new Size(429, 35);
            txtboxMaKH.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 201);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(109, 27);
            label6.TabIndex = 4;
            label6.Text = "Xếp Hạng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(841, 200);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 3;
            label5.Text = "Điểm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(741, 75);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 27);
            label4.TabIndex = 2;
            label4.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 73);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 27);
            label2.TabIndex = 0;
            label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(588, 130);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(591, 67);
            label1.TabIndex = 11;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // cbbSearchRank
            // 
            cbbSearchRank.FormattingEnabled = true;
            cbbSearchRank.Location = new Point(879, 89);
            cbbSearchRank.Margin = new Padding(5, 4, 5, 4);
            cbbSearchRank.Name = "cbbSearchRank";
            cbbSearchRank.Size = new Size(478, 35);
            cbbSearchRank.TabIndex = 6;
            cbbSearchRank.SelectedIndexChanged += cbbSearchRank_SelectedIndexChanged;
            // 
            // txtboxSearchSDT
            // 
            txtboxSearchSDT.Location = new Point(73, 89);
            txtboxSearchSDT.Margin = new Padding(5, 4, 5, 4);
            txtboxSearchSDT.Name = "txtboxSearchSDT";
            txtboxSearchSDT.Size = new Size(478, 35);
            txtboxSearchSDT.TabIndex = 5;
            txtboxSearchSDT.TextChanged += txtboxSearchSDT_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(881, 49);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(206, 27);
            label9.TabIndex = 3;
            label9.Text = "Tìm Theo Xếp Hạng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(11, 141);
            dgvKhachHang.Margin = new Padding(5, 4, 5, 4);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(1370, 294);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 49);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(151, 27);
            label8.TabIndex = 2;
            label8.Text = "Tìm Theo SDT";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbSearchRank);
            groupBox3.Controls.Add(txtboxSearchSDT);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dgvKhachHang);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(22, 527);
            groupBox3.Margin = new Padding(5, 4, 5, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 4, 5, 4);
            groupBox3.Size = new Size(1381, 442);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu Khách Hàng";
            // 
            // formKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 1001);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Name = "formKhachHang";
            Text = "formKhachHang";
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnHienthi;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem menustripQLNV;
        private ToolStripMenuItem MNSTripQLSP;
        private ToolStripMenuItem mnStripQLTK;
        private ToolStripMenuItem mnstripQLHD;
        private ToolStripMenuItem mnstripQLVC;
        private ToolStripMenuItem mnstripQLCP;
        private ToolStripMenuItem menustripMenu;
        private ToolStripMenuItem hóaĐơnThanhToánToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox cbbMotaRanks;
        private Label label3;
        private TextBox txtboxRank;
        private TextBox txtboxDiem;
        private TextBox txtboxSDT;
        private TextBox txtboxMaKH;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cbbSearchRank;
        private TextBox txtboxSearchSDT;
        private Label label9;
        private DataGridView dgvKhachHang;
        private Label label8;
        private GroupBox groupBox3;
    }
}