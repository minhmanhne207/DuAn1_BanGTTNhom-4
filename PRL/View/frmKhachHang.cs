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
    public partial class frmKhachHang : Form
    {
        private KhachHangService _service;
        string _idWhenclick;
        public frmKhachHang()
        {
            InitializeComponent();
            _service = new KhachHangService();
           
            LoadCombobox();
            loadSearkRanks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxSDT.Text != string.Empty && txtboxDiem.Text != string.Empty && txtboxRank.Text != string.Empty)

                {
                    KhachHang kh = new KhachHang();
                    kh.MaRank = txtboxMaKH.Text;
                    kh.Sdt = txtboxSDT.Text;
                    kh.MaRank = txtboxRank.Text;
                    kh.Diem = Convert.ToDouble(txtboxDiem.Text);

                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thêm không", "Xác nhận ", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show(_service.AddKH(kh));
                    }
                    else
                    {
                        return;
                    }

                    LoadData();
                    LoadCombobox();

                }
                else
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgvKhachHang.ColumnCount = 6;
            dgvKhachHang.Columns[0].Name = "Stt";
            dgvKhachHang.Columns[1].Name = "Mã Khách hàng";

            dgvKhachHang.Columns[2].Name = "Số điện thoại";
            dgvKhachHang.Columns[3].Name = "Điểm";
            dgvKhachHang.Columns[4].Name = "Ranks";
            dgvKhachHang.Columns[4].Visible = false;
            dgvKhachHang.Columns[5].Name = "Xếp loại";
            dgvKhachHang.Rows.Clear();
            foreach (var i in _service.GetKH((txtboxSearchSDT.Text).ToString(), (cbbSearchRank.Text)))
            {
                var ranks = _service.GetRanks().FirstOrDefault(ia => ia.MaRank == i.MaRank);
                dgvKhachHang.Rows.Add(stt++, i.MaKh, i.Sdt, i.Diem, i.MaRank, ranks.MoTa);
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; if (index < 0) return;

            _idWhenclick = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txtboxMaKH.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
            txtboxSDT.Text = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
            txtboxDiem.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
            txtboxRank.Text = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
            cbbMotaRanks.Text = dgvKhachHang.Rows[index].Cells[5].Value.ToString();
        }

        private void cbbMotaRanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxRank.Text = "";
            if (cbbMotaRanks.SelectedItem != null)
            {
                var ranks = (Rank)cbbMotaRanks.SelectedItem;
                txtboxRank.Text = ranks.MaRank;

            }
        }
        private void LoadCombobox()
        {
            List<Rank> ms = _service.GetRanks();
            cbbMotaRanks.DataSource = null;
            cbbMotaRanks.DataSource = ms;
            cbbMotaRanks.DisplayMember = "MoTa";
            cbbMotaRanks.SelectedIndex = -1;

        }
        private void loadSearkRanks()
        {
            List<Rank> ms = _service.GetRanks();
            cbbSearchRank.DataSource = null;
            cbbSearchRank.DataSource = ms;
            cbbSearchRank.DisplayMember = "MoTa";
            cbbSearchRank.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();

                kh.MaKh = _idWhenclick;
                kh.Sdt = txtboxSDT.Text.ToString();
                kh.MaRank = txtboxRank.Text;
                kh.Diem = Convert.ToDouble(txtboxDiem.Text);
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn Sửa không", "Xác nhận ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateKH(kh));
                }
                else
                {
                    return;
                }


                LoadData();
                LoadCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtboxMaKH.Text = "";
            txtboxRank.Text = "";
            txtboxDiem.Text = "";
            txtboxSDT.Text = "";
            cbbMotaRanks.Text = "";
            cbbSearchRank.Text = "";
            txtboxSearchSDT.Text = "";

        }

        private void txtboxSearchSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbSearchRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            loadSearkRanks();

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void txtboxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự này được nhập vào
            }
        }

        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLNV menu = new frmQLNV();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void menustripMenu_Click(object sender, EventArgs e)
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

        private void mnstripQLCP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmCoupon menu = new frmCoupon();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void mnstripQLVC_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmVoucher menu = new frmVoucher();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void mnstripQLHD_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQuanLyHD menu = new frmQuanLyHD();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void mnStripQLTK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmThongKe menu = new frmThongKe();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void MNSTripQLSP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmQLSP menu = new frmQLSP();
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
