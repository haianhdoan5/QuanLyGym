using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyGym.Models;

namespace QuanLyGym.BLL
{
    public class ThietBiGymBLL
    {
        private GymDbContext db = new GymDbContext();

        // Lấy danh sách toàn bộ thiết bị
        public List<ThietBiGym> GetAllThietBi()
        {
            return db.ThietBiGym.ToList();
        }

        // Tìm kiếm thiết bị theo tên hoặc mã
        public List<ThietBiGym> SearchThietBi(string keyword)
        {
            return db.ThietBiGym.Where(tb => tb.MaTb.Contains(keyword) || tb.TenTb.Contains(keyword)).ToList();
        }

        // Thêm thiết bị mới
        public bool AddThietBi(ThietBiGym thietBi)
        {
            try
            {
                // Kiểm tra trùng mã
                var check = db.ThietBiGym.Find(thietBi.MaTb);
                if (check != null) return false;

                db.ThietBiGym.Add(thietBi);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        // Cập nhật thông tin thiết bị
        public bool UpdateThietBi(ThietBiGym thietBi)
        {
            try
            {
                var tbUpdate = db.ThietBiGym.Find(thietBi.MaTb);
                if (tbUpdate == null) return false;

                tbUpdate.TenTb = thietBi.TenTb;
                tbUpdate.LoaiThietBi = thietBi.LoaiThietBi;
                tbUpdate.NgayMua = thietBi.NgayMua;
                tbUpdate.TinhTrang = thietBi.TinhTrang;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa thiết bị (Xóa vật lý hoặc cập nhật tình trạng thành 'Đã thanh lý')
        public bool DeleteThietBi(string maTB)
        {
            try
            {
                var tb = db.ThietBiGym.Find(maTB);
                if (tb == null) return false;

                // Tuân thủ No Delete Policy: Thay vì xóa, cập nhật tình trạng
                tb.TinhTrang = "Đã thanh lý";
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