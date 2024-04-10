using BUS.IService;
using BUS.Service;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class frmQLNV : Form
    {
        private QLNVSevice sevice;
        string _idClick;
        public frmQLNV()
        {
            InitializeComponent();
            sevice = new QLNVSevice();

            LoadCBO();

        }

        public void LoadData(string find)
        {

            Type type = typeof(NhanVien);
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.ColumnCount = type.GetProperties().Length + 1;
            int stt = 1;
            dgvNhanVien.Columns[0].Name = "STT";
            dgvNhanVien.Columns[1].Name = "ID";
            dgvNhanVien.Columns[2].Name = "Mã nhân viên";
            dgvNhanVien.Columns[3].Name = "Tên";
            dgvNhanVien.Columns[4].Name = "Địa chỉ";
            dgvNhanVien.Columns[5].Name = "SDT";
            dgvNhanVien.Columns[6].Name = "Email";
            dgvNhanVien.Columns[7].Name = "Giới tính";
            dgvNhanVien.Columns[8].Name = "Trạng thái";
            dgvNhanVien.Columns[9].Name = "Ngày sinh";
            dgvNhanVien.Columns[10].Name = "Ca làm";
            dgvNhanVien.Columns[11].Name = "Chức vụ";
            dgvNhanVien.Columns[12].Name = "Mật khẩu";
            dgvNhanVien.Columns[1].Visible = false;
            foreach (var nv in sevice.GetNVs(find))
            {
                var item = sevice.GetChucVus().FirstOrDefault(x => x.MaCv == nv.MaChucVu);
                var e = sevice.GetCaLams().FirstOrDefault(x => x.MaCa == nv.MaCa);
                dgvNhanVien.Rows.Add(stt++, nv.MaNv, nv.MaNv, nv.TenNhanVien, nv.DiaChi,
                    nv.SoDienThoai, nv.Email, nv.GioiTinh, nv.TrangThai, nv.NgaySinh, e.MaCa, item.MaCv, nv.MatKhau);
            }


        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idClick = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtPasswork.Text = dgvNhanVien.Rows[index].Cells[12].Value.ToString();
            cboChucVu.Text = dgvNhanVien.Rows[index].Cells[11].Value.ToString();
            cboCaLam.Text = dgvNhanVien.Rows[index].Cells[10].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[index].Cells[9].Value.ToString();
            if (dgvNhanVien.Rows[index].Cells[8].Value.Equals("Hoạt Động"))
            {
                radioButtonHD.Checked = true;
            }
            else
            {
                radioButtonKHD.Checked = true;
            }

            if (dgvNhanVien.Rows[index].Cells[7].Value.Equals("Nam"))
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            txtEmail.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtMa.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
        }


        public void LoadCBO()
        {
            List<CaLamViec> CaLam = sevice.GetCaLams();
            cboCaLam.DataSource = CaLam;
            cboCaLam.DisplayMember = "MaCa";
            cboCaLam.SelectedIndex = -1;

            List<ChucVu> ChucVu = sevice.GetChucVus();
            cboChucVu.DataSource = ChucVu;
            cboChucVu.DisplayMember = "MaCv";
            cboChucVu.SelectedIndex = -1;
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSDT.Text) &&
                    (radioButtonNam.Checked || radioButtonNu.Checked) &&
                    (radioButtonHD.Checked || radioButtonKHD.Checked) &&
                    !string.IsNullOrEmpty(dtpNgaySinh.Text) && !string.IsNullOrEmpty(cboChucVu.Text) &&
                    !string.IsNullOrEmpty(cboCaLam.Text) && !string.IsNullOrEmpty(txtPasswork.Text))
                {
                    // Kiểm tra địa chỉ email có đúng định dạng không
                    if (!IsEmailValid(txtEmail.Text))
                    {
                        MessageBox.Show("Địa chỉ email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    NhanVien nv = new NhanVien();
                    nv.TenNhanVien = txtTen.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.SoDienThoai = txtSDT.Text;
                    nv.Email = txtEmail.Text;
                    nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                    nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
                    nv.NgaySinh = dtpNgaySinh.Value;
                    nv.MaChucVu = cboChucVu.Text;
                    nv.MaCa = cboCaLam.Text;
                    nv.MatKhau = txtPasswork.Text;

                    // Thêm nhân viên vào danh sách
                    sevice.Add(nv);

                    MessageBox.Show("Thêm thành công");
                    LoadData(null);
                    txtMa.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmailValid(string email)
        {
            // Biểu thức chính quy kiểm tra email có đúng định dạng hay không
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra sự khớp của email với biểu thức chính quy
            return Regex.IsMatch(email, pattern);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien();

            nv.MaNv = txtMa.Text;
            nv.TenNhanVien = txtTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoDienThoai = txtSDT.Text;
            nv.Email = txtEmail.Text;
            nv.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            nv.TrangThai = radioButtonHD.Checked ? "Hoạt Động" : "Không Hoạt Động";
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.MaChucVu = cboChucVu.Text;
            nv.MaCa = cboCaLam.Text;
            nv.MatKhau = txtPasswork.Text;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(sevice.Update(nv));

            }
            else
            {

                return;
            }
            LoadData(null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            radioButtonHD.Checked = false;
            radioButtonNam.Checked = false;
            dtpNgaySinh.Text = "";
            cboCaLam.Text = "";
            cboChucVu.Text = "";
            txtPasswork.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData(null);
            LoadCBO();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
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

        private void quảnLýThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmKhachHang thongKe = new frmKhachHang();
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự này được nhập vào
            }
            // Kiểm tra xem có tối đa 10 chữ số được nhập vào

            if (txtSDT.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn thêm ký tự khi đã đạt đến giới hạn 10 chữ số
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                return;
            }

            // Kiểm tra xem ký tự đầu tiên có phải là số không (0) không
            if (txtSDT.Text[0] != '0')
            {
                MessageBox.Show("Vui lòng nhập số 0 đầu tiên.");
                txtSDT.Text = ""; // Xoá nội dung nếu ký tự đầu tiên không phải là số 0
            }
        }

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmCoupon thongKe = new frmCoupon();
                thongKe.ShowDialog();
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
    }

}