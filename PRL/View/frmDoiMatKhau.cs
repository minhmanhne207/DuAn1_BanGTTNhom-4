using BUS.Services;
using DAL.DomainClass;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmDoiMatKhau : Form
    {
        private NhanVienServices _service;
        private bool isExitApplication = false;
        public frmDoiMatKhau()
        {
            _service = new NhanVienServices();
            InitializeComponent();
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception)
            {

                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Save()
        {
            var User = txtUser.Text.Trim();
            var passOld = txtPassCu.Text.Trim();
            var passNew = txtPassMoi.Text.Trim();
            var passConfirm = txtPassXacNhan.Text.Trim();
            var checkPass = new NhanVienServices().CheckExistsNV(User, passOld);
            if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(passOld) || string.IsNullOrEmpty(passNew) || string.IsNullOrEmpty(passConfirm))
            {
                // Hiển thị thông báo lỗi nếu có trường nào đó bị bỏ trống
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passNew != passConfirm)
            {
                // Hiển thị thông báo lỗi nếu mật khẩu mới và xác nhận mật khẩu không khớp nhau
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool rs = new NhanVienServices().UpdatePassWordNV(User, passConfirm);
            if (!rs)
            {
                MessageBox.Show("Không thể thay đổi mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Mật khẩu đã được đổi thành công!", "Thông Báo", MessageBoxButtons.OK);
            }

            this.Close();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn quay lại  không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    isExitApplication = true;
                    frmHoaDon frmHoaDon = new frmHoaDon();
                    this.Hide();
                    frmHoaDon.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbHienThiMk_CheckedChanged(object sender, EventArgs e)
        {
            txtPassCu.UseSystemPasswordChar = txtPassMoi.UseSystemPasswordChar = txtPassXacNhan.UseSystemPasswordChar = !cbHienThiMk.Checked;
        }
    }
}
