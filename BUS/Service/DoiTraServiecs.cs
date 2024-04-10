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
    public class DoiTraServiecs : IDoiTraServieces
    {
        DoiTraReps _doiTraReps;
        public DoiTraServiecs()
        {
            _doiTraReps = new DoiTraReps();
        }

        public Doi CreateDoi(Doi doi)
        {
          return _doiTraReps.CreateDoi(doi);

        }



        public bool DeleteDoi(string id)
        {
            if (_doiTraReps.DeleteDoi(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public List<Doi> GetDois(string find)
        {
            if (find == null)
            {
                return _doiTraReps.GetDois();
            }
            return _doiTraReps.GetDois().Where(x => x.MaDoi.Contains(find.Trim().ToLower())).ToList();
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiet()
        {
            return _doiTraReps.GetHoaDonChiTiets();
        }

        public List<HoaDon> GetHoaDons(string find)
        {
            if (find == null)
            {
                return _doiTraReps.GetHoaDons();
            }
          

                return _doiTraReps.GetHoaDons().Where(x=>x.MaHd.Contains(find.ToLower().Trim())).ToList();
            
        }

        public List<NhanVien> GetNhanViens()
        {
            return _doiTraReps.GetNhanViens();
        }

        public List<SanPham> GetSanPhams()
        {
            return _doiTraReps.GetSanPhams();
        }


    }
}
