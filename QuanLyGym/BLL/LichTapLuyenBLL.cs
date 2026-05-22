using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class LichTapLuyenBLL
    {
        private GymDbContext db = new GymDbContext();

        public List<LichTapLuyen> GetAll()
        {
            return db.LichTapLuyen.ToList();
        }

        public List<LichTapLuyen> GetByHoiVien(string maHv)
        {
            return db.LichTapLuyen
                .Where(l => l.MaHv == maHv)
                .OrderByDescending(l => l.NgayTap)
                .ToList();
        }

        public List<LichTapLuyen> GetByNhanVien(string maNv)
        {
            return db.LichTapLuyen
                .Where(l => l.MaNv == maNv)
                .OrderByDescending(l => l.NgayTap)
                .ToList();
        }

        public LichTapLuyen GetById(string maLt)
        {
            return db.LichTapLuyen.FirstOrDefault(l => l.MaLt == maLt);
        }

        public bool Add(LichTapLuyen lichTap)
        {
            try
            {
                db.LichTapLuyen.Add(lichTap);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(LichTapLuyen lichTap)
        {
            try
            {
                db.LichTapLuyen.Update(lichTap);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string maLt)
        {
            try
            {
                var lichTap = db.LichTapLuyen.FirstOrDefault(l => l.MaLt == maLt);
                if (lichTap != null)
                {
                    db.LichTapLuyen.Remove(lichTap);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
