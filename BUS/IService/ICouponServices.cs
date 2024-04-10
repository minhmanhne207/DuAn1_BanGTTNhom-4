using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ICouponServices
    {
        public string AddCPs(Coupon cp);
        public string UpdateCP(Coupon cp);
        public List<Coupon> GetCP(string find);
    }
}
