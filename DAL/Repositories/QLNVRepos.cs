using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QLNVRepos : IQLNVRepos
    {
        private MyContext _dbcontext;

        public QLNVRepos()
        {
            _dbcontext = new MyContext();
        }
        public bool AddNV(NhanVien nv)
        {
            if (GetAllNV().Count != 0)
            {
                var maxid = _dbcontext.NhanViens.Max(x => x.MaNv);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                nv.MaNv = "NV" + nextid.ToString("D3");
            }
            else
            {
                nv.MaNv = "NV001";
            }
            _dbcontext.NhanViens.Add(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNV()
        {
            return _dbcontext.NhanViens.ToList();
        }

        public bool RemoveNV(string id)
        {
            var results = _dbcontext.NhanViens.FirstOrDefault(x => x.MaNv == id);
            if (results != null)
            {
                _dbcontext.NhanViens.Remove(results);
            }

            _dbcontext.Remove(id);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien nv)
        {
            try
            {
                if (nv == null) return false;
                var d = _dbcontext.NhanViens.FirstOrDefault(i => i.MaNv == nv.MaNv);
                if (d == null) return false;
                d.TenNhanVien = nv.TenNhanVien;
                d.SoDienThoai = nv.SoDienThoai;
                d.Email = nv.Email;
                d.GioiTinh = nv.GioiTinh;
                d.NgaySinh = nv.NgaySinh;
                d.DiaChi = nv.DiaChi;
                d.MatKhau = nv.MatKhau;
                d.TrangThai = nv.TrangThai;
                d.MaChucVu = nv.MaChucVu;
                d.MaCa = nv.MaCa;
                _dbcontext.NhanViens.Update(d);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<ChucVu> GetChucVus()
        {
            return _dbcontext.ChucVus.ToList();
        }

        public List<CaLamViec> GetCaLams()
        {
            return _dbcontext.CaLamViecs.ToList();
        }

    }

}