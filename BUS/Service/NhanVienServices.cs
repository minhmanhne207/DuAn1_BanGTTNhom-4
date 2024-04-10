using BUS.IServiecs;
using DAL.Context;
using DAL.DomainClass;
using DAL.Repoistories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices : INhanVienSevices
    {
        private NhanVienRepositories repo;

        public NhanVienServices()
        {
            repo = new NhanVienRepositories();
        }
        public NhanVien GetNhanVienByUserNameAndPasswords(string userName, string password)
        {
            return repo.GetNhanVienByUserNameAndPassword(userName, password);
        }
        public bool AddNV(NhanVien nv)
        {
            return repo.Add(nv);
        }

        public bool CheckExistsNV(string userName, string passWord)
        {
            return repo.CheckExists(userName, passWord);
        }

        public bool CheckExistsNv(string userName)
        {
            return repo.CheckExists(userName);
        }

        public bool DeleteNV(string code)
        {
            return repo.Delete(code);
        }

        public int GetCountNV(string text)
        {
            return repo.GetCount(text);
        }

        public NhanVien GetDetailNV(string code)
        {
            return repo.GetDetail(code);
        }

        public IEnumerable<NhanVien> getListNV(string text)
        {
            return repo.getList(text);
        }

        public IEnumerable<NhanVien> GetListNV(string text)
        {
            return repo.GetList(text);
        }

        public bool UpdateNV(NhanVien nv)
        {
            return repo.Update(nv);
        }

        public bool UpdatePassWordNV(string userName, string passWord)
        {
            return repo.UpdatePassWord(userName, passWord);
        }
    }
}
