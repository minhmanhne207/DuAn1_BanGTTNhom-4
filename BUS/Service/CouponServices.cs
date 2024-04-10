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
    public class CouponServices : ICouponServices
    {
        private CouponRepositories _repos;
        public CouponServices()
        {
            _repos = new CouponRepositories();
        }

        public string AddCPs(Coupon cp)
        {
            if (_repos.AddCP(cp) == true)
            {
                return ("Thêm thành công");
            }
            else
            {
                return ("Thêm thất bại");
            }
        }

        public List<Coupon> GetCP(string find)
        {
            if (find == null)
            {
                return _repos.GetCP();
            }
            return _repos.GetCP().Where(x => x.MaCoupon.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public string UpdateCP(Coupon cp)
        {
            var clone = _repos.GetCP().FirstOrDefault(x => x.MaCoupon == cp.MaCoupon);
            clone.MaCoupon = cp.MaCoupon;
            clone.TenCoupon = cp.TenCoupon;
            clone.GiaTri = cp.GiaTri;
            clone.MoTa = cp.MoTa;
            clone.DieuKien = cp.DieuKien;
            clone.NgayBatDau = cp.NgayBatDau;
            clone.NgayKetThuc = cp.NgayKetThuc;
            if (_repos.Update(cp) == true)
            {
                return " sửa thành công";
            }
            else
            {
                return " sửa thất bại";
            }
        }
    }
}
