using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepoistories
{
    public interface INhanVienRepositories
    {
        public bool Add(NhanVien nv);

        public bool Update(NhanVien nv);
        public bool Delete(string code);
        public bool UpdatePassWord(string userName, string passWord);

        public IEnumerable<NhanVien> getList(string text);
        public NhanVien GetDetail(string code);
        public bool CheckExists(string userName, string passWord);
        public bool CheckExists(string userName);

        public int GetCount(string text);
        public IEnumerable<NhanVien> GetList(string text);
        public NhanVien GetNhanVienByUserNameAndPassword(string userName, string password);


    }
}
