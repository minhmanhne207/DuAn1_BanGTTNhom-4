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
    public class KhachHangService : IKhachHangService
    {
        private KhachHangReps _repo;

        public KhachHangService()
        {
                _repo = new KhachHangReps();
        }
        public string AddKH(KhachHang kh)
        {
            if (_repo.Add(kh) == true)
            {
                return " Thêm khách hàng thành công ";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<KhachHang> GetKH(string find, string search)
        {
            if (find == null)
            {
                return _repo.GetKH();
            }
            else
            {
                return _repo.GetKH().Where(x => x.Sdt.Contains(find) || x.MaRank.Contains(search)).ToList();
            }
            
        }

        public List<Rank> GetRanks()
        {
                return _repo.GetRanks();
        }

        public string UpdateKH(KhachHang kh)
        {
            var fake = _repo.GetKH().FirstOrDefault(a => a.MaKh == kh.MaKh);
            fake.Sdt = kh.Sdt;
            fake.Diem = kh.Diem;
            fake.MaRank = kh.MaRank;
            if (_repo.UpdateKHs(fake) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return " Thêm thất bại ";
            }
        }
    }
}
