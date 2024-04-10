using BUS.IService;
using DAL.DomainClass;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class HoaDonServices : IHoaDonServices
    {
        HoaDonReps _repos;
        public HoaDonServices()
        {
            _repos = new HoaDonReps();
        }

        public string AddsHD(HoaDon hd)
        {
            if (_repos.AddHDs(hd)== true)
            {
                return "Thêm thành công";

            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string AddsHDCT(HoaDonChiTiet hdct)
        {
            if (_repos.AddHDCT(hdct) == true)
            {
                return "thêm thành công";

            }
            else
            {
                return "thêm thất bại";
            }
        }

        public bool DeletesHD(HoaDon id)
        {
           HoaDon del = GetHoaDon(null).FirstOrDefault(x => x.MaHd == id.MaHd);
            if (del != null)
            {
                return _repos.DeleteHD(del);
            }
            return false;
        }

        public bool DeletesHDCT(HoaDonChiTiet hdct)
        {
            var del =  GetHoaDonChiTiets(null).FirstOrDefault(x=>x.MaHdct == hdct.MaHdct);
            if (del != null)
            {
               return _repos.DeleteHDCT(del);
            }
            return false;
        }

      
        

        public List<HoaDon> GetHoaDon(string find)
        {
            if (find == null)
            {
                return _repos.GetHoaDons();
            }

                return _repos.GetHoaDons().Where(x => x.MaHd.Contains(find.Trim().ToLower())).ToList();
            
          
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets(string search)
        {
          
            if (search == null)
            {
                return _repos.GetHoaDonChiTiets();
            }
            
                return _repos.GetHoaDonChiTiets().Where(x => x.MaHdct.Contains(search)).ToList();
            
        }

        public Voucher GetIDVouchers(string MaVC)
        {
            return _repos.GetIDVoucher(MaVC);
        }

        public List<KhachHang> GetKhachHang()
        {
            return _repos.GetKhachHang();
        }

        public List<NhanVien> GetNhanViens()
        {
          return _repos.GetNhanViens();
        }

        public List<SanPham> GetSanPhamById()
        {
            return _repos.GetSanPhamById();
        }

        public List<SanPham> GetSanPhams()
        {
            return _repos.GetSanPhams();
        }

        public List<Voucher> GetVouchers()
        {
            return _repos.GetVouchers();
        }

        public bool UpdatesHD(HoaDon hd)
        {
            HoaDon update = GetHoaDon(null).FirstOrDefault(x=>x.MaHd== hd.MaHd);
            update.TrangThai = hd.TrangThai;
            update.MaKh = hd.MaKh;
            update.NgayTao = hd.NgayTao;
            update.MaNv = hd.MaNv;
            return _repos.UpdateHD(update);
        }

        public bool UpdatesHDCT(HoaDonChiTiet hdct)
        {
            var clone = _repos.GetHoaDonChiTiets().FirstOrDefault(s => s.MaHdct == hdct.MaHdct);
            clone.SoLuong = hdct.SoLuong;
            clone.MaSp = hdct.MaSp;
         //   clone.MaVoucher = hdct.MaVoucher;
            clone.MaHd = hdct.MaHd;
            return _repos.UpdateHDCT(clone);
        }

        public bool UpdateSoLuongSanPham(string id)
        {
            return _repos.UpdateSoLuongSanPham(id);
        }
    }
}
