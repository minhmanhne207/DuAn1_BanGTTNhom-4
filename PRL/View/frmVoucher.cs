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
    public partial class frmVoucher : Form
    {
        private VoucherServices _service;
        string _cellclick;
        public frmVoucher()
        {
            InitializeComponent();
            _service = new VoucherServices();
            LoadData(null);
        }
        private void LoadData(string find)
        {
            Type type = typeof(Voucher);
            dgvVoucher.Rows.Clear();
            dgvVoucher.ColumnCount = 9;
            int stt = 1;
            dgvVoucher.Columns[1].Name = "STT";
            dgvVoucher.Columns[2].Name = "Mã Coupon";
            dgvVoucher.Columns[3].Name = "Tên Coupon";
            dgvVoucher.Columns[4].Name = "Giá Trị";
            dgvVoucher.Columns[5].Name = "Mô Tả";
            dgvVoucher.Columns[6].Name = "Điều Kiện";
            dgvVoucher.Columns[7].Name = "Ngày Bắt Đầu";
            dgvVoucher.Columns[8].Name = "Ngày Kết Thúc";
            foreach (var vc in _service.GetVC(find))
            {
                dgvVoucher.Rows.Add(stt, stt++, vc.MaVoucher, vc.TenVoucher, vc.GiaTri, vc.MoTa, vc.DieuKien, vc.NgayBatDau, vc.NgayKetThuc);
            }
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _cellclick = dgvVoucher.Rows[index].Cells[1].Value.ToString();
            txtboxMaVoucher.Text = dgvVoucher.Rows[index].Cells[2].Value.ToString();
            txtboxTenVoucher.Text = dgvVoucher.Rows[index].Cells[3].Value.ToString();
            txtboxGiaTriVoucher.Text = dgvVoucher.Rows[index].Cells[4].Value.ToString();
            txtboxMoTaVoucher.Text = dgvVoucher.Rows[index].Cells[5].Value.ToString();
            txtboxDKVoucher.Text = dgvVoucher.Rows[index].Cells[6].Value.ToString();
            dtpNgayBatDauVoucher.Text = dgvVoucher.Rows[index].Cells[7].Value.ToString();
            dtpNgayKetThucVoucher.Text = dgvVoucher.Rows[index].Cells[8].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxTenVoucher.Text != string.Empty && txtboxGiaTriVoucher.Text != string.Empty && txtboxMoTaVoucher.Text != string.Empty
                && txtboxDKVoucher.Text != string.Empty && dtpNgayBatDauVoucher.Text != string.Empty && dtpNgayKetThucVoucher.Text != string.Empty)
                {
                    Voucher vc = new Voucher();
                    vc.MaVoucher = txtboxMaVoucher.Text;
                    vc.TenVoucher = txtboxTenVoucher.Text;
                    vc.GiaTri = Convert.ToInt32(txtboxGiaTriVoucher.Text);
                    vc.MoTa = txtboxMoTaVoucher.Text;
                    vc.DieuKien = txtboxDKVoucher.Text;
                    vc.NgayBatDau = dtpNgayBatDauVoucher.Value;
                    vc.NgayKetThuc = dtpNgayKetThucVoucher.Value;
                    _service.AddVC(vc);
                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
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
            var vc = new Voucher();

            vc.MaVoucher = txtboxMaVoucher.Text;
            vc.TenVoucher = txtboxTenVoucher.Text;
            vc.GiaTri = Convert.ToInt32(txtboxGiaTriVoucher.Text);
            vc.MoTa = txtboxMoTaVoucher.Text;
            vc.DieuKien = txtboxDKVoucher.Text;
            vc.NgayBatDau = dtpNgayBatDauVoucher.Value;
            vc.NgayKetThuc = dtpNgayKetThucVoucher.Value;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.UpdateVC(vc));

            }
            else
            {

                return;
            }
            LoadData(null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxMaVoucher.Text = "";
            txtboxTenVoucher.Text = "";
            txtboxGiaTriVoucher.Text = "";
            txtboxMoTaVoucher.Text = "";
            txtboxDKVoucher.Text = "";
            dtpNgayBatDauVoucher.Text = "";
            dtpNgayKetThucVoucher.Text = "";
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
                frmHoaDon hoaDon = new frmHoaDon();
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

        private void txtboxGiaTriVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự này được nhập vào
            }
        }

        private void menuDànhChoQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
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
