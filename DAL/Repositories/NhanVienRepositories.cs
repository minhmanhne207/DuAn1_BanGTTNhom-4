using DAL.IRepoistories;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using DAL.DomainClass;

namespace DAL.Repoistories
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        private Context.MyContext _dbContext;
        public NhanVienRepositories()
        {
            _dbContext = new MyContext();
        }

        public bool Add(NhanVien nv)
        {
            try
            {
                if (nv == null) return false;
                _dbContext.NhanViens.Add(nv);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public NhanVien GetNhanVienByUserNameAndPassword(string userName, string password)
        {
            return _dbContext.NhanViens.FirstOrDefault(nv => nv.MaNv == userName && nv.MatKhau == password);
        }
        public bool CheckExists(string userName, string passWord)
        {
            return _dbContext.NhanViens.Any(i => i.MaNv == userName && i.MatKhau == passWord);
        }

        public bool CheckExists(string userName)
        {
            return _dbContext.NhanViens.Any(i => i.MaNv == userName);
        }

        public bool Delete(string code)
        {
            try
            {
                if (string.IsNullOrEmpty(code)) return false;

                var d = _dbContext.NhanViens.FirstOrDefault(i => i.MaNv == code);
                if (d == null) return false;
                _dbContext.NhanViens.Remove(d);
                _dbContext.SaveChanges();
                return true;


            }
            catch (Exception)
            {

                return false;
            }
        }

        public int GetCount(string text)
        {
            try
            {
                return getList(text).Count();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public NhanVien GetDetail(string code)
        {
            return _dbContext.NhanViens.FirstOrDefault(i => i.MaNv == code);
        }

        public IEnumerable<NhanVien> GetList(string text)
        {
            try
            {
                return getList(text);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<NhanVien> getList(string text)
        {
            return string.IsNullOrEmpty(text) ? _dbContext.NhanViens : _dbContext.NhanViens.Where(d => d.MaNv.Contains(text) ||
                                                                                     d.TenNhanVien.ToLower().Contains(text.ToLower()) ||
                                                                                     d.SoDienThoai.Contains(text) ||
                                                                                     d.Email.ToLower().Contains(text.ToLower()) ||
                                                                                     d.GioiTinh.ToLower().Contains(text.ToLower()) ||
                                                                                     d.GioiTinh.StartsWith(text.ToLower()) ||
                                                                                     d.DiaChi.ToLower().Contains(text.ToLower()) ||
                                                                                     d.MatKhau.ToLower().Contains(text.ToLower()) ||
                                                                                     d.TrangThai.ToString().Contains(text.ToLower()) ||
                                                                                     d.MaChucVu.ToString().Contains(text.ToLower()) ||
                                                                                     d.MaCa.ToString().Contains(text.ToLower()));





        }



        public bool Update(NhanVien nv)
        {
            try
            {
                if (nv == null) return false;
                var d = _dbContext.NhanViens.FirstOrDefault(i => i.MaNv == nv.MaNv);
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
                _dbContext.NhanViens.Update(nv);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdatePassWord(string userName, string passWord)
        {
            try
            {
                var d = _dbContext.NhanViens.FirstOrDefault(i => i.MaNv == userName);
                if (d == null) return false;

                d.MatKhau = passWord;
                _dbContext.NhanViens.Update(d);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
