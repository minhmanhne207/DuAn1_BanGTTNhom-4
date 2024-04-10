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
    public partial class frmMenuAd : Form
    {
        string Username;
        public frmMenuAd(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP sanPham = new frmQLSP();
                sanPham.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLNV nhanVien = new frmQLNV();
                nhanVien.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }



        private void btnQLHD_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQuanLyHD hoaDon = new frmQuanLyHD();
                hoaDon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnQLVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmVoucher voucher = new frmVoucher();
                voucher.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnQLCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmCoupon coupon = new frmCoupon();
                coupon.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmThongKe thongKe = new frmThongKe();
                thongKe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void frmMenuAd_Load(object sender, EventArgs e)
        {
            userToolStripMenuItem.Text = "User: " + Username;
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                formKhachHang login = new formKhachHang();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
