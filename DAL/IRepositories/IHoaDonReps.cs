using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHoaDonReps
    {
        public List<HoaDon> GetHoaDons();
        public List<HoaDonChiTiet> GetHoaDonChiTiets();
        public List<NhanVien> GetNhanViens();
        public List<SanPham> GetSanPhams();
        public List<SanPham> GetSanPhamById();
        public bool UpdateSoLuongSanPham( string id);
        public List<KhachHang> GetKhachHang();
        public bool UpdateHD(HoaDon hd);
        public bool DeleteHD(HoaDon id);
        public bool AddHD(HoaDon hd , KhachHang kh);
        public bool AddHDs(HoaDon hd);
        public bool UpdateHDCT(HoaDonChiTiet hdct);
        public bool DeleteHDCT(HoaDonChiTiet hdct);
        public bool AddHDCT(HoaDonChiTiet hdct);
       public List<Voucher> GetVouchers( );
        public Voucher GetIDVoucher( string MaVC);

    }
}
