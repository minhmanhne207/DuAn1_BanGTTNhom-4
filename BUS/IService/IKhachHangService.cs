using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IKhachHangService
    {
        public string AddKH(KhachHang kh);
        public string UpdateKH(KhachHang kh);
        public List<KhachHang> GetKH( string find, string search);
        public List<Rank> GetRanks();
    }
}
