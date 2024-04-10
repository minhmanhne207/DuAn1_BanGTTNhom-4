using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IVoucherRepositories
    {
        public bool Add(Voucher vc);
        public bool Update(Voucher vc);
        public List<Voucher> GetVC();
    }
}
