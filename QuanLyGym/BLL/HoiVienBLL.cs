using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class HoiVienBLL
    {
        private GymDbContext db = new GymDbContext();

        public List<HoiVien> GetAll()
        {
            using (var context = new GymDbContext())
            {
                return context.HoiVien.ToList();
            }
        }

        // Lấy theo ID
        public HoiVien GetById(string maHV) => db.HoiVien.FirstOrDefault(h => h.MaHv == maHV);

        // Thêm mới
        public bool Insert(HoiVien hv)
        {
            db.HoiVien.Add(hv);
            return db.SaveChanges() > 0;
        }

        // Cập nhật
        public bool Update(HoiVien hvMoi)
        {
            var hvCu = db.HoiVien.FirstOrDefault(h => h.MaHv == hvMoi.MaHv);
            if (hvCu != null)
            {
                hvCu.TenHv = hvMoi.TenHv;
                hvCu.GioiTinh = hvMoi.GioiTinh;
                hvCu.Sdt = hvMoi.Sdt;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        // Xóa
        public bool Delete(string maHV)
        {
            var hv = db.HoiVien.FirstOrDefault(h => h.MaHv == maHV);
            if (hv != null)
            {
                db.HoiVien.Remove(hv);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public string GetNextMaHV()
        {
            using (var context = new GymDbContext())
            {
                var maxId = context.HoiVien.ToList()
                    .Where(h => h.MaHv.StartsWith("HV"))
                    .Select(h => int.Parse(h.MaHv.Substring(2)))
                    .DefaultIfEmpty(0)
                    .Max();

                return "HV" + (maxId + 1).ToString("D2");
            }
        }
    }
}