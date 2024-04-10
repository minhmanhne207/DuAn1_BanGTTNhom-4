using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface ICouponRepositories
    {
        public bool AddCP(Coupon cp);
        public bool Update(Coupon cp);
        public List<Coupon> GetCP();
    }
}
