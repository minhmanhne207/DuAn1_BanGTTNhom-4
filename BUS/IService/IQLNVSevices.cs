using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IQLNVSevices
    {
        public string Add(NhanVien nv);

        public string Remove(NhanVien nv);
        public string Update(NhanVien nv);

        public List<NhanVien> GetNVs(string find);

        public List<ChucVu> GetChucVus();

        public List<CaLamViec> GetCaLams();
    }

}