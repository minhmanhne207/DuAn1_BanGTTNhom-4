using BUS.IService;
using DAL.Context;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class SanPhamServices : ISanPhamServices
    {
        private SanPhamRepositories _repos;
        public SanPhamServices()
        {
            _repos = new SanPhamRepositories();
        }
        public string AddSP(SanPham sp)
        {
            if (_repos.AddsSP(sp) == true)
            {
                return ("Thêm thành công");
            }
            else
            {
                return ("Thêm thất bại");
            }
        }

        public List<SanPham> GetAll(string find)
        {
            if (find == null)
            {
                return _repos.GetAll();
            }
            return _repos.GetAll().Where(x => x.MaSp.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public List<ChatLieu> GetChatLieu()
        {
            return _repos.GetChatLieu();
        }



        public List<HoaDon> GetHoaDon()
        {
            return _repos.GetHoaDon();
        }

        public List<MauSac> GetMauSac()
        {
            return _repos.GetMauSac();
        }

        public List<Size> GetSize()
        {
            return _repos.GetSize();
        }

        public List<ThuongHieu> GetThuongHieu()
        {
            return _repos.GetThuongHieu();
        }

        public string UpdateSP(SanPham sp)
        {
            var sanpham = _repos.GetAll().FirstOrDefault(i => i.MaSp == sp.MaSp);
            sanpham.TenSanPham = sp.TenSanPham;
            sanpham.NgayNhap = sp.NgayNhap;
            sanpham.SoLuong = sp.SoLuong;
            sanpham.Gia = sp.Gia;
            sanpham.TrangThai = sp.TrangThai;
            sanpham.MaMau = sp.MaMau;
            sanpham.MaSize = sp.MaSize;
            sanpham.MaChatLieu = sp.MaChatLieu;
            sanpham.MaTh = sp.MaTh;

                if (_repos.UpdatesSP(sanpham) == true)
                {
                    return "sửa thành công";
                }
                else
                {
                    return "sửa thất bại";
                }
           
        }
    }
}
