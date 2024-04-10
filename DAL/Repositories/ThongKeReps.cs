using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ThongKeReps : IThongKe
    {
        MyContext _dbcontext;
        public ThongKeReps()
        {
            _dbcontext = new MyContext();
        }
        public List<HoaDon> GetHoaDons()
        {
           return _dbcontext.HoaDons.ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _dbcontext.NhanViens.ToList();
        }

        public List<Thongke> GetThongkes(DateTime? star, DateTime? end)
        {
            var query = from tk in _dbcontext.Thongkes
                        join hd in _dbcontext.HoaDons on tk.MaHd equals hd.MaHd
                        group tk by new { tk.MaThongKe, tk.TongDoanhThu, tk.MaNv, tk.MaHd, tk.NgayThongKe, tk.SoLuong } into g
                        select new Thongke
                        {
                            MaThongKe = g.Key.MaThongKe,
                            MaHd = g.Key.MaHd,
                            TongDoanhThu = g.Key.TongDoanhThu,
                            MaNv = g.Key.MaNv,
                            NgayThongKe = g.Key.NgayThongKe,
                            SoLuong = g.Key.SoLuong,

                        };
            if (star.HasValue && end.HasValue)
            {
                return query.Where(x => x.NgayThongKe >= star && x.NgayThongKe <= end).ToList();
            }
            return query.ToList();
        }
    }
}
