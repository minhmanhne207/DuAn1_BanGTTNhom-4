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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRL.View
{
    public partial class frmCoupon : Form
    {
        private CouponServices _service;
        string _cellclick;
        string userName;
        bool isExitApplication = false;
        public frmCoupon()
        {
            InitializeComponent();
            _service = new CouponServices();
            LoadData(null);
            // this.userName = userName;
        }
        private void LoadData(string find)
        {
            Type type = typeof(Coupon);
            dgvCoupon.Rows.Clear();
            dgvCoupon.ColumnCount = 9;
            int stt = 1;
            dgvCoupon.Columns[1].Name = "STT";
            dgvCoupon.Columns[2].Name = "Mã Coupon";
            dgvCoupon.Columns[3].Name = "Tên Coupon";
            dgvCoupon.Columns[4].Name = "Giá Trị";
            dgvCoupon.Columns[5].Name = "Mô Tả";
            dgvCoupon.Columns[6].Name = "Điều Kiện";
            dgvCoupon.Columns[7].Name = "Ngày Bắt Đầu";
            dgvCoupon.Columns[8].Name = "Ngày Kết Thúc";
            foreach (var cp in _service.GetCP(find))
            {
                dgvCoupon.Rows.Add(stt, stt++, cp.MaCoupon, cp.TenCoupon, cp.GiaTri, cp.MoTa, cp.DieuKien, cp.NgayBatDau, cp.NgayKetThuc);
            }
        }

        private void dgvCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _cellclick = dgvCoupon.Rows[index].Cells[1].Value.ToString();
            txtboxMaCoupon.Text = dgvCoupon.Rows[index].Cells[2].Value.ToString();
            txtboxTenCoupon.Text = dgvCoupon.Rows[index].Cells[3].Value.ToString();
            txtboxGiaTriCoupon.Text = dgvCoupon.Rows[index].Cells[4].Value.ToString();
            txtboxMoTaCoupon.Text = dgvCoupon.Rows[index].Cells[5].Value.ToString();
            txtboxDKCoupon.Text = dgvCoupon.Rows[index].Cells[6].Value.ToString();
            dtpNgayBatDauCoupon.Text = dgvCoupon.Rows[index].Cells[7].Value.ToString();
            dtpNgayKetThucCoupon.Text = dgvCoupon.Rows[index].Cells[8].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxTenCoupon.Text != string.Empty && txtboxGiaTriCoupon.Text != string.Empty && txtboxMoTaCoupon.Text != string.Empty
                && txtboxDKCoupon.Text != string.Empty && dtpNgayBatDauCoupon.Text != string.Empty && dtpNgayKetThucCoupon.Text != string.Empty)
                {
                    Coupon cp = new Coupon();
                    cp.MaCoupon = txtboxMaCoupon.Text;
                    cp.TenCoupon = txtboxTenCoupon.Text;
                    cp.GiaTri = Convert.ToInt32(txtboxGiaTriCoupon.Text);
                    cp.MoTa = txtboxMoTaCoupon.Text;
                    cp.DieuKien = txtboxDKCoupon.Text;
                    cp.NgayBatDau = Convert.ToDateTime(dtpNgayBatDauCoupon.Text);
                    cp.NgayKetThuc = Convert.ToDateTime(dtpNgayKetThucCoupon.Text);
                    _service.AddCPs(cp);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
                    txtboxMaCoupon.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cp = new Coupon();

            cp.MaCoupon = txtboxMaCoupon.Text;
            cp.TenCoupon = txtboxTenCoupon.Text;
            cp.GiaTri = Convert.ToInt32(txtboxGiaTriCoupon.Text);
            cp.MoTa = txtboxMoTaCoupon.Text;
            cp.DieuKien = txtboxDKCoupon.Text;
            cp.NgayBatDau = dtpNgayBatDauCoupon.Value;
            cp.NgayKetThuc = dtpNgayKetThucCoupon.Value;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.UpdateCP(cp));

            }
            else
            {

                return;
            }
            LoadData(null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxMaCoupon.Text = "";
            txtboxTenCoupon.Text = "";
            txtboxGiaTriCoupon.Text = "";
            txtboxMoTaCoupon.Text = "";
            txtboxDKCoupon.Text = "";
            dtpNgayBatDauCoupon.Text = "";
            dtpNgayKetThucCoupon.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void quảnLýKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmThongKe thongKe = new frmThongKe();
                thongKe.ShowDialog();
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

        private void quảnLýCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtboxGiaTriCoupon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự này được nhập vào
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
    }
}
