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
    public class CouponRepositories : ICouponRepositories
    {
        private MyContext _db;
        public CouponRepositories()
        {
            _db = new MyContext();
        }

        public bool AddCP(Coupon cp)
        {
            
            _db.Coupons.Add(cp);
            _db.SaveChanges();
            return true;
        }

        public List<Coupon> GetCP()
        {
            return _db.Coupons.ToList();
        }

        public bool Update(Coupon cp)
        {
            try
            {
                if (cp == null) return false;
                var e = _db.Coupons.FirstOrDefault(x => x.MaCoupon == cp.MaCoupon);
                if (e == null) return false;
                e.TenCoupon = cp.TenCoupon;
                e.GiaTri = cp.GiaTri;
                e.MoTa = cp.MoTa;
                e.DieuKien = cp.DieuKien;
                e.NgayBatDau = cp.NgayBatDau;
                e.NgayKetThuc = cp.NgayKetThuc;
                _db.Coupons.Update(e);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
