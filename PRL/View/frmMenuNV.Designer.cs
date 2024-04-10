namespace PRL.View
{
    partial class frmMenuNV
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
            groupBox1 = new GroupBox();
            btnDoiTra = new Button();
            btnHoaDon = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1063, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            userToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userToolStripMenuItem.Margin = new Padding(0, 0, 170, 0);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(88, 30);
            userToolStripMenuItem.Text = "User:";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(291, 44);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(291, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiTra);
            groupBox1.Controls.Add(btnHoaDon);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 50);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(309, 523);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnDoiTra
            // 
            btnDoiTra.Image = Properties.Resources.Task_list;
            btnDoiTra.ImageAlign = ContentAlignment.MiddleRight;
            btnDoiTra.Location = new Point(10, 252);
            btnDoiTra.Margin = new Padding(5);
            btnDoiTra.Name = "btnDoiTra";
            btnDoiTra.Size = new Size(289, 85);
            btnDoiTra.TabIndex = 2;
            btnDoiTra.Text = "Đổi Trả";
            btnDoiTra.UseVisualStyleBackColor = true;
            btnDoiTra.Click += btnDoiTra_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Image = Properties.Resources.Price_list;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleRight;
            btnHoaDon.Location = new Point(10, 89);
            btnHoaDon.Margin = new Padding(5);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(289, 85);
            btnHoaDon.TabIndex = 1;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ronaldocamgiay;
            pictureBox1.Location = new Point(338, 59);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(705, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuNV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 592);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "frmMenuNV";
            Text = "Menu dành cho nhân viên";
            Load += frmMenuNV_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnHoaDon;
        private PictureBox pictureBox1;
        private Button btnDoiTra;
    }
}