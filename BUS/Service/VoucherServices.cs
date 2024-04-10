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
    public class VoucherServices : IVoucherServices
    {
        private VoucherRepositories _repos;
        public VoucherServices()
        {
            _repos = new VoucherRepositories();
        }
        public string AddVC(Voucher vc)
        {
            if (_repos.Add(vc) == true)
            {
                return ("Thêm thành công");
            }
            else
            {
                return ("Thêm thất bại");
            }
        }

        public List<Voucher> GetVC(string find)
        {
            if (find == null)
            {
                return _repos.GetVC();
            }
            return _repos.GetVC().Where(x => x.MaVoucher.Trim().ToLower().Contains(find.ToLower())).ToList();
        }

        public string UpdateVC(Voucher vc)
        {
            var clone = _repos.GetVC().FirstOrDefault(x => x.MaVoucher == vc.MaVoucher);
            clone.MaVoucher = vc.MaVoucher;
            clone.TenVoucher = vc.TenVoucher;
            clone.GiaTri = vc.GiaTri;
            clone.MoTa = vc.MoTa;
            clone.DieuKien = vc.DieuKien;
            clone.NgayBatDau = vc.NgayBatDau;
            clone.NgayKetThuc = vc.NgayKetThuc;
            if (_repos.Update(vc) == true)
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
