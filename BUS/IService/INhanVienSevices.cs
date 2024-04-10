using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServiecs
{
    public interface INhanVienSevices
    {
        public bool AddNV(NhanVien nv);

        public bool UpdateNV(NhanVien nv);
        public bool DeleteNV(string code);
        public bool UpdatePassWordNV(string userName, string passWord);

        public IEnumerable<NhanVien> getListNV(string text);
        public NhanVien GetDetailNV(string code);
        public bool CheckExistsNV(string userName, string passWord);
        public bool CheckExistsNv(string userName);

        public int GetCountNV(string text);
        public IEnumerable<NhanVien> GetListNV(string text);
        public NhanVien GetNhanVienByUserNameAndPasswords(string userName, string password);
    }
}
