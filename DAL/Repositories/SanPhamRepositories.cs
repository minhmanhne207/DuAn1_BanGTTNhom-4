using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepositories : ISanPhamRepositories
    {
        private MyContext _db;
        public SanPhamRepositories()
        {
            _db = new MyContext();
        }
        public bool AddsSP(SanPham sp)
        {
            if (GetAll().Count != 0)
            {
                var maxid = _db.SanPhams.Max(x => x.MaSp);
                int nextid = Convert.ToInt32(maxid.Substring(2)) + 1;
                sp.MaSp = "SP" + nextid.ToString("D3");
            }
            else
            {
                sp.MaSp = "SP001";
            }
            _db.SanPhams.Add(sp);
            _db.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _db.SanPhams.ToList();
        }

        public List<ChatLieu> GetChatLieu()
        {
            return _db.ChatLieus.ToList();
        }

        public List<HoaDon> GetHoaDon()
        {
            return _db.HoaDons.ToList();
        }

        public List<MauSac> GetMauSac()
        {
            return _db.MauSacs.ToList();
        }

        public List<Size> GetSize()
        {
            return _db.Sizes.ToList();
        }

        public List<ThuongHieu> GetThuongHieu()
        {
            return _db.ThuongHieus.ToList();
        }

        public bool UpdatesSP(SanPham sp)
        {
            _db.SanPhams.Update(sp);
            _db.SaveChanges();
            return true;
        }
    }
}
