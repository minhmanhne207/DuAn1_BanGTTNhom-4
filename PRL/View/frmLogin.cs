using BUS.Services;
using DAL.DomainClass;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
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
    public partial class frmLogin : Form
    {
        private NhanVienServices _service;
        private string userName, passWord;
        private bool isExitApplication = false;
        public frmLogin()
        {
            _service = new NhanVienServices();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginNv();
            }
            catch (Exception)
            {

                MessageBox.Show("Đăng nhập  thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void LoginNv()
        {
            bool result = checkAccount();
            if (!result) { return; }
            try
            {

                NhanVien nhanVien = _service.GetNhanVienByUserNameAndPasswords(userName, passWord);
                if (nhanVien != null)


                {
                    // Kiểm tra mã chức vụ của nhân viên
                    if (nhanVien.MaChucVu == "CV001")
                    {
                        // Mở màn hình quản lý
                        frmMenuAd quanLyForm = new frmMenuAd(nhanVien.MaNv);
                        // Gắn sự kiện đăng xuất
                        this.Hide();
                        quanLyForm.ShowDialog();
                        if (quanLyForm.DialogResult == DialogResult.Yes)
                        {
                            isExitApplication = true;
                            this.Close();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        frmMenuNV login = new frmMenuNV(nhanVien.MaNv);
                        this.Hide();
                        login.ShowDialog();
                        if (login.DialogResult == DialogResult.Yes)
                        {
                            isExitApplication = true;
                            this.Close();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool checkAccount()
        {
            bool rs = check();
            var checkAD = _service.CheckExistsNV(userName, passWord);

            if (!checkAD)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return false;
            }
            else

            {
                return true;
            }
        }
        private bool check()
        {
            userName = txtUser.Text.Trim();
            passWord = txtPassWord.Text.Trim();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return false;
            }
            return true;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thoát chương trình không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    isExitApplication = true;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = !ckbShowPass.Checked;
        }
    }
}
