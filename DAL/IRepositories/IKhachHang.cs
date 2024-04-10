using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IKhachHang
    {
        public bool Add(KhachHang kh);
        public bool UpdateKHs(KhachHang kh);
        public List<KhachHang> GetKH();
        public List<Rank> GetRanks();
    }
}
