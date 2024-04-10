using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IDoiTraReps
    {
        public List<Doi> GetDois();
       
        public List<SanPham> GetSanPhams();
        public List<NhanVien> GetNhanViens();
        public Doi CreateDoi(Doi doi);

        public List<HoaDon> GetHoaDons();
        public List<HoaDonChiTiet>GetHoaDonChiTiets();
        public bool DeleteDoi(string id);
       
    }
}
