using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangReps : IKhachHang
    {
        private MyContext _db;
        public KhachHangReps()
        {
            _db = new MyContext();
        }

        public bool Add(KhachHang kh)
        {
            if (GetKH().Count != 0)
            {
                var maxid = _db.KhachHangs.Max(x => x.MaKh);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                kh.MaKh = "KH" + nextid.ToString("D3");
            }
            else
            {
                kh.MaKh = "KH001";
            }
            _db.Add(kh);
            _db.SaveChanges();
            return true;
        }
        public List<KhachHang> GetKH()
        {
            return _db.KhachHangs.ToList();
        }

        public List<Rank> GetRanks()
        {
            return _db.Ranks.ToList();
        }

        public bool UpdateKHs(KhachHang kh)
        {
                _db.KhachHangs.Update(kh);
                _db.SaveChanges();
                return true;
           
        }
    }
}
