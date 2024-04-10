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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class frmQuanLyHD : Form
    {
        HoaDonServices _hoaDonServices;
        string _idWhenclick;
        string _idclickChiTiet;
        public frmQuanLyHD()
        {
            _hoaDonServices = new HoaDonServices();
            InitializeComponent();
        }

        private void btnHIenthi_Click(object sender, EventArgs e)
        {
            LoadDataHD(null);
            LoadDataHDCT();
        }
        private void LoadDataHD(string find)
        {

            dtgvHoaDon.ColumnCount = 8;
            int stt = 1;
            dtgvHoaDon.Columns[0].Name = "STT";
            dtgvHoaDon.Columns[1].Name = "Mã HD";
            dtgvHoaDon.Columns[2].Name = "Ngày tạo";
            dtgvHoaDon.Columns[3].Name = "Trạng thái";
            dtgvHoaDon.Columns[4].Name = "Tổng tiền";
            dtgvHoaDon.Columns[5].Name = "Mã NV";
            dtgvHoaDon.Columns[5].Visible = false;
            dtgvHoaDon.Columns[6].Name = "Tên nhân viên";
            dtgvHoaDon.Columns[7].Name = "Mã KH";
            dtgvHoaDon.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDon(find))
            {
                var queryNhanVien = _hoaDonServices.GetNhanViens().FirstOrDefault(i => i.MaNv == i.MaNv);
                dtgvHoaDon.Rows.Add(stt++, i.MaHd, i.NgayTao, i.TrangThai, i.TongTien, i.MaNv, queryNhanVien.TenNhanVien, i.MaKh);
            }
        }
        private void LoadDataHDCT()
        {

            dtgvHDCT.ColumnCount = 10;
            int stt = 1;
            dtgvHDCT.Columns[0].Name = "STT";
            dtgvHDCT.Columns[1].Name = "Mã HDCT";
            // dtgvHDCT.Columns[1].Visible = false;
            dtgvHDCT.Columns[2].Name = "Mã sản phẩm";
            dtgvHDCT.Columns[2].Visible = false;
            dtgvHDCT.Columns[3].Name = "Tên sản phẩm";
            dtgvHDCT.Columns[4].Name = "Số Lượng";
            dtgvHDCT.Columns[5].Name = "Đơn Giá ";
            dtgvHDCT.Columns[6].Name = "Tiền sau Voucher";
            dtgvHDCT.Columns[7].Name = "Mã VC";
            dtgvHDCT.Columns[7].Visible = false;
            dtgvHDCT.Columns[8].Name = "Mô tả voucher";
            dtgvHDCT.Columns[9].Name = "Mã HD";
            dtgvHDCT.Rows.Clear();
            foreach (var i in _hoaDonServices.GetHoaDonChiTiets(txtsearch.Text))
            {

                var queryVC = _hoaDonServices.GetVouchers().FirstOrDefault(i => i.MaVoucher == i.MaVoucher);
                var querySanPham = _hoaDonServices.GetSanPhams().FirstOrDefault(i => i.MaSp == i.MaSp);
                dtgvHDCT.Rows.Add(stt++, i.MaHdct, i.MaSp, querySanPham.TenSanPham, i.SoLuong, i.DonGia, i.TongTienSauVoucher, i.MaVoucher, queryVC.MoTa, i.MaHd);
            }
        }
        private void dtgvHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idclickChiTiet = dtgvHoaDon.Rows[indexof].Cells[1].Value.ToString();
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexof = e.RowIndex; if (indexof < 0) return;

            _idWhenclick = dtgvHDCT.Rows[indexof].Cells[1].Value.ToString();
        }



        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim().Length < 0 || txtsearch.Text == null)
            {
                LoadDataHD(null);
            }
            else
            {
                LoadDataHDCT();
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
            hoaDonChiTiet.MaHdct = _idclickChiTiet;
            _hoaDonServices.DeletesHDCT(hoaDonChiTiet);
            LoadDataHDCT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            HoaDon hoaDonChiTiet = new HoaDon();
            hoaDonChiTiet.MaHd = _idWhenclick;
            _hoaDonServices.DeletesHD(hoaDonChiTiet);
            LoadDataHD(null);
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                frmMenuAd kh = new frmMenuAd(null);
                kh.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi sảy ra" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
