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
    public partial class frmMenuNV : Form
    {
        string userName;
        bool isExitApplication;
        public frmMenuNV(string username)
        {
            InitializeComponent();
           this.userName = username;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP frmQLSP = new frmQLSP();
                frmQLSP.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.ShowDialog();
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
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không không!", "Thông báo", MessageBoxButtons.YesNo);
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

        private void btnDoiTra_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmDoi doiTra = new frmDoi();
                doiTra.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frmMenuNV_Load(object sender, EventArgs e)
        {
            userToolStripMenuItem.Text = "User: " + userName;
        }
    }
}
