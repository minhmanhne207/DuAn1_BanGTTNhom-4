using BUS.IService;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ThongKeSerVices : IThongKeServiecs
    {
        ThongKeReps _repsThongKe;
        public ThongKeSerVices()
        {
            _repsThongKe = new ThongKeReps();   
        }
        public List<HoaDon> GetHoaDons()
        {
           return _repsThongKe.GetHoaDons();
        }


        public List<NhanVien> GetNhanVien()
        {
           return _repsThongKe.GetNhanViens();
        }

        public List<Thongke> GetThongkes(DateTime? Start, DateTime? End)
        {
            if (Start == null || End == null)
            {
                return _repsThongKe.GetThongkes(Start, End);
            }
            return 
                _repsThongKe.GetThongkes(Start.Value, End.Value);
        }
    }
}
