using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    internal interface IVoucherServices
    {
        public string AddVC(Voucher vc);
        public string UpdateVC(Voucher vc);
        public List<Voucher> GetVC(string find);
    }
}
