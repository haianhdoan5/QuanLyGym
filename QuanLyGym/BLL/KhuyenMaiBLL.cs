using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyGym.Models;

namespace QuanLyGym.BLL
{
    public class KhuyenMaiBLL
    {
        private GymDbContext db = new GymDbContext();

        // Lấy mã khuyến mãi tiếp theo (auto-increment)
        public string GetNextMaKm()
        {
            var maxId = db.KhuyenMai.ToList()
                .Where(km => km.MaKm.StartsWith("KM"))
                .Select(km => int.Parse(km.MaKm.Substring(2)))
                .DefaultIfEmpty(0)
                .Max();
            return "KM" + (maxId + 1).ToString("D2");
        }

        // Lấy danh sách toàn bộ khuyến mãi
        public List<KhuyenMai> GetAll()
        {
            return db.KhuyenMai.ToList();
        }

        // Thêm khuyến mãi mới
        public string Insert(KhuyenMai km)
        {
            try
            {
                // Kiểm tra trùng mã khuyến mãi
                var check = db.KhuyenMai.Find(km.MaKm);
                if (check != null)
                {
                    return "Mã khuyến mãi này đã tồn tại!";
                }

                // Kiểm tra phần trăm giảm hợp lệ (0-100)
                if (km.PhanTramGiam < 0 || km.PhanTramGiam > 100)
                {
                    return "Phần trăm giảm phải từ 0 đến 100!";
                }

                db.KhuyenMai.Add(km);
                db.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm: " + ex.Message;
            }
        }

        // Cập nhật thông tin khuyến mãi
        public string Update(KhuyenMai km)
        {
            try
            {
                var kmUpdate = db.KhuyenMai.Find(km.MaKm);
                if (kmUpdate == null)
                {
                    return "Khuyến mãi không tồn tại!";
                }

                // Kiểm tra phần trăm giảm hợp lệ (0-100)
                if (km.PhanTramGiam < 0 || km.PhanTramGiam > 100)
                {
                    return "Phần trăm giảm phải từ 0 đến 100!";
                }

                kmUpdate.PhanTramGiam = km.PhanTramGiam;

                db.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật: " + ex.Message;
            }
        }

        // Xóa khuyến mãi
        public string Delete(string maKm)
        {
            try
            {
                var km = db.KhuyenMai.Find(maKm);
                if (km == null)
                {
                    return "Khuyến mãi không tồn tại!";
                }

                db.KhuyenMai.Remove(km);
                db.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa: " + ex.Message;
            }
        }

        // Tìm khuyến mãi theo mã
        public KhuyenMai GetByMaKm(string maKm)
        {
            return db.KhuyenMai.Find(maKm);
        }
    }
}
