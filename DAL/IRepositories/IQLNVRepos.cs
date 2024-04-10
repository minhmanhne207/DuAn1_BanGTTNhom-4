using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IQLNVRepos
    {
        public bool AddNV(NhanVien nv);

        public bool RemoveNV(string id);

        public bool UpdateNV(NhanVien nv);

        public List<NhanVien> GetAllNV();

        public List<ChucVu> GetChucVus();

        public List<CaLamViec> GetCaLams();

    }

}