using BUS.Service;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class frmThongKe : Form
    {
        ThongKeSerVices _thongKeServices;
        public frmThongKe()
        {
            InitializeComponent();
            _thongKeServices = new ThongKeSerVices();

        }
        public void Loadata(DateTime? Start, DateTime? End)
        {
            int Stt = 1;
            Type type = typeof(Thongke);
            dataGridView1.ColumnCount = type.GetProperties().Length + 1;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Thống Kê";
            dataGridView1.Columns[2].Name = "Ngày Thống Kê";
            dataGridView1.Columns[3].Name = "Doanh Thu";
            dataGridView1.Columns[4].Name = "Số Lượng";
            dataGridView1.Columns[5].Name = "Mã Nhân Viên";
            dataGridView1.Columns[6].Name = "Mã Hóa Đơn";
            foreach (var tk in _thongKeServices.GetThongkes(Start, End))
            {
                var queryNV = _thongKeServices.GetNhanVien().FirstOrDefault(x => x.MaNv == tk.MaNv);
                var queryHD = _thongKeServices.GetHoaDons().FirstOrDefault(x => x.MaHd == tk.MaHd);
                dataGridView1.Rows.Add(Stt++, tk.MaThongKe, tk.NgayThongKe, tk.TongDoanhThu, tk.SoLuong, queryNV.MaNv, queryHD.MaHd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadata(dateTimeTKStart.Value, dateTimeTKEnd.Value);
        }

        private void tHêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP sanPham = new frmQLSP();
                sanPham.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLNV nhanVien = new frmQLNV();
                nhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKhuyếnMạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmVoucher voucher = new frmVoucher();
                voucher.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQuanLyHD hoaDon = new frmQuanLyHD();
                hoaDon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmCoupon coupon = new frmCoupon();
                coupon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
                doiMatKhau.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenuAd menu = new frmMenuAd(null);
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void menuDànhChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMenuNV menu = new frmMenuNV(null);
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void hóaĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon nhanVien = new frmHoaDon();
            nhanVien.ShowDialog();
        }
    }
}
