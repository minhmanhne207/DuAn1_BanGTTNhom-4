using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IDoiTraServieces
    {
        public List<Doi> GetDois(string find);
      
        public List<NhanVien> GetNhanViens();
        public List<SanPham> GetSanPhams();
        public Doi CreateDoi(Doi doi);
    
       public List<HoaDon>GetHoaDons(string find);
        public List<HoaDonChiTiet> GetHoaDonChiTiet();
        public bool DeleteDoi(string id);
      
    }
}
