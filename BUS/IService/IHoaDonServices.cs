using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IHoaDonServices
    {
        public List<HoaDon> GetHoaDon(string find);
        public List<HoaDonChiTiet> GetHoaDonChiTiets(string search);
        public List <NhanVien > GetNhanViens();
        public List<SanPham> GetSanPhams();
        public List<KhachHang> GetKhachHang();
        public List<SanPham> GetSanPhamById();
        public bool UpdateSoLuongSanPham(string id);
        public bool UpdatesHD(HoaDon hd);
        public bool DeletesHD(HoaDon hd);
        public string AddsHD(HoaDon hd);
        public bool UpdatesHDCT(HoaDonChiTiet hdct);
        public bool DeletesHDCT(HoaDonChiTiet hdct);
        public string AddsHDCT(HoaDonChiTiet hdct);
        public List<Voucher> GetVouchers();
        public Voucher GetIDVouchers(string MaVC);
       

    }
}
