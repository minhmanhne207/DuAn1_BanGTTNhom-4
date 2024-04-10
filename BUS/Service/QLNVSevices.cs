using BUS.IService;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class QLNVSevice : IQLNVSevices
    {
        private QLNVRepos _repos;

        public QLNVSevice()
        {
            _repos = new QLNVRepos();
        }

        public string Add(NhanVien nv)
        {
            if (_repos.AddNV(nv) == true)
            {
                return "thêm thành công";

            }
            else
            {
                return "thêm thất bại";
            }
        }

        public List<NhanVien> GetNVs(string find)
        {
            if (find == null)
            {
                return _repos.GetAllNV();
            }
            return _repos.GetAllNV().Where(x => x.MaNv.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public string Remove(NhanVien nv)
        {
            var clone = _repos.GetAllNV().FirstOrDefault(s => s.MaNv == nv.MaNv);

            if (_repos.RemoveNV(clone.MaNv) == true)
            {
                return " xóa thành công";
            }
            else
            {
                return " xóa thất bại";
            }
        }

        public string Update(NhanVien nv)
        {
            var clone = _repos.GetAllNV().FirstOrDefault(s => s.MaNv == nv.MaNv);
            clone.MaNv = nv.MaNv;
            clone.TenNhanVien = nv.TenNhanVien;
            clone.SoDienThoai = nv.SoDienThoai;
            clone.Email = nv.Email;
            clone.NgaySinh = nv.NgaySinh;
            clone.DiaChi = nv.DiaChi;
            clone.MaChucVu = nv.MaChucVu;
            clone.GioiTinh = nv.GioiTinh;
            clone.MaCa = nv.MaCa;
            clone.MaChucVu = nv.MaChucVu;
            clone.MatKhau = nv.MatKhau;

            if (_repos.UpdateNV(nv) == true)
            {
                return " sửa thành công";
            }
            else
            {
                return " sửa thất bại";
            }
        }

        public List<ChucVu> GetChucVus()
        {
            return _repos.GetChucVus();
        }

        public List<CaLamViec> GetCaLams()
        {
            return _repos.GetCaLams();
        }



    }

}