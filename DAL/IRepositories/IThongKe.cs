using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IThongKe
    {
        public List<Thongke> GetThongkes(DateTime? star, DateTime? end);
        public List<NhanVien> GetNhanViens();
        public List<HoaDon> GetHoaDons();
    }
}
