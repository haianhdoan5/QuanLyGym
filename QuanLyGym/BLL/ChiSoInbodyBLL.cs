using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class ChiSoInbodyBLL
    {
        private GymDbContext db = new GymDbContext();

        public List<ChiSoInbody> GetAll()
        {
            return db.ChiSoInbody.ToList();
        }

        public List<ChiSoInbody> GetByHoiVien(string maHv)
        {
            return db.ChiSoInbody
                .Where(c => c.MaHv == maHv)
                .OrderByDescending(c => c.MaInbody)
                .ToList();
        }

        public ChiSoInbody GetById(string maInbody)
        {
            return db.ChiSoInbody.FirstOrDefault(c => c.MaInbody == maInbody);
        }

        public bool Add(ChiSoInbody chiSo)
        {
            try
            {
                db.ChiSoInbody.Add(chiSo);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(ChiSoInbody chiSo)
        {
            try
            {
                db.ChiSoInbody.Update(chiSo);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string maInbody)
        {
            try
            {
                var chiSo = db.ChiSoInbody.FirstOrDefault(c => c.MaInbody == maInbody);
                if (chiSo != null)
                {
                    db.ChiSoInbody.Remove(chiSo);
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
