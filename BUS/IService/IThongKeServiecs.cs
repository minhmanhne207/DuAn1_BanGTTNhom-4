using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IThongKeServiecs
    {
        public List<Thongke> GetThongkes(DateTime? Start, DateTime? End);
        public List<HoaDon> GetHoaDons();
        public List<NhanVien> GetNhanVien();
    }
}
