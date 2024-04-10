namespace PRL
{
    partial class frmDoi
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
            txtDoiSp = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtLyDo = new TextBox();
            ptkNgayDoi = new DateTimePicker();
            cbTrangThai = new ComboBox();
            txtMaDoi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgView = new DataGridView();
            btnThoat = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDoiSp);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtLyDo);
            groupBox1.Controls.Add(ptkNgayDoi);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(txtMaDoi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(50, 102);
            groupBox1.Margin = new Padding(5, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 5, 5, 5);
            groupBox1.Size = new Size(1170, 405);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // txtDoiSp
            // 
            txtDoiSp.Location = new Point(262, 307);
            txtDoiSp.Margin = new Padding(5, 5, 5, 5);
            txtDoiSp.Name = "txtDoiSp";
            txtDoiSp.Size = new Size(404, 39);
            txtDoiSp.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 312);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(209, 32);
            label6.TabIndex = 14;
            label6.Text = "Đổi qua sản phẩm";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(830, 230);
            btnClear.Margin = new Padding(5, 5, 5, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(174, 69);
            btnClear.TabIndex = 13;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(830, 144);
            btnXoa.Margin = new Padding(5, 5, 5, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(174, 69);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(830, 46);
            btnThem.Margin = new Padding(5, 5, 5, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(174, 69);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(262, 243);
            txtLyDo.Margin = new Padding(5, 5, 5, 5);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(404, 39);
            txtLyDo.TabIndex = 8;
            // 
            // ptkNgayDoi
            // 
            ptkNgayDoi.CustomFormat = "MM/dd/yyyy";
            ptkNgayDoi.Format = DateTimePickerFormat.Custom;
            ptkNgayDoi.Location = new Point(262, 181);
            ptkNgayDoi.Margin = new Padding(5, 5, 5, 5);
            ptkNgayDoi.Name = "ptkNgayDoi";
            ptkNgayDoi.Size = new Size(404, 39);
            ptkNgayDoi.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(262, 101);
            cbTrangThai.Margin = new Padding(5, 5, 5, 5);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(404, 40);
            cbTrangThai.TabIndex = 6;
            // 
            // txtMaDoi
            // 
            txtMaDoi.Location = new Point(262, 35);
            txtMaDoi.Margin = new Padding(5, 5, 5, 5);
            txtMaDoi.Name = "txtMaDoi";
            txtMaDoi.ReadOnly = true;
            txtMaDoi.Size = new Size(404, 39);
            txtMaDoi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 248);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Lý do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 181);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Ngày đổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 114);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 46);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã đổi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgView);
            groupBox2.Location = new Point(50, 517);
            groupBox2.Margin = new Padding(5, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 5, 5, 5);
            groupBox2.Size = new Size(1170, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(37, 59);
            dtgView.Margin = new Padding(5, 5, 5, 5);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(1108, 333);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(830, 307);
            btnThoat.Margin = new Padding(5, 5, 5, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(171, 80);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Quay lại";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(487, 36);
            label5.Name = "label5";
            label5.Size = new Size(229, 61);
            label5.TabIndex = 3;
            label5.Text = "Đổi hàng";
            // 
            // frmDoi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1300, 1080);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmDoi";
            Text = "frmDoi";
            Load += frmDoi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtLyDo;
        private DateTimePicker ptkNgayDoi;
        private ComboBox cbTrangThai;
        private TextBox txtMaDoi;
        private Label label4;
        private Label label3;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dtgView;
        private Button btnThoat;
        private Button btnClear;
        private TextBox txtDoiSp;
        private Label label6;
        private Label label5;
    }
}