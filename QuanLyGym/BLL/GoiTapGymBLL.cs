using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyGym.Models;

namespace QuanLyGym.BLL
{
    public class GoiTapGymBLL
    {
        private GymDbContext db = new GymDbContext();

        public List<GoiTapGym> GetAllGoiTap()
        {
            return db.GoiTapGym.ToList();
        }

        // Thêm gói tập mới
        public bool AddGoiTap(GoiTapGym goiTap)
        {
            try
            {
                var check = db.GoiTapGym.Find(goiTap.MaGoi);
                if (check != null) return false;

                db.GoiTapGym.Add(goiTap);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Cập nhật thông tin gói tập
        public bool UpdateGoiTap(GoiTapGym goiTap)
        {
            try
            {
                var gtUpdate = db.GoiTapGym.Find(goiTap.MaGoi);
                if (gtUpdate == null) return false;

                gtUpdate.TenGoi = goiTap.TenGoi;
                gtUpdate.DonGia = goiTap.DonGia;
                gtUpdate.ThoiHan = goiTap.ThoiHan;
                gtUpdate.MaKm = goiTap.MaKm;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa gói tập
        public bool DeleteGoiTap(string maGoi)
        {
            try
            {
                var gt = db.GoiTapGym.Find(maGoi);
                if (gt == null) return false;

                db.GoiTapGym.Remove(gt);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }
    }
}