using QuanLyGym.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class TaiKhoanBLL
    {
        private GymDbContext db = new GymDbContext();

        public List<TaiKhoan> GetAll()
        {
            using (var context = new GymDbContext())
            {
                return context.TaiKhoan.ToList();
            }
        }

        public bool Add(TaiKhoan taiKhoan)
        {
            try
            {
                var check = db.TaiKhoan.FirstOrDefault(tk => tk.TenDangNhap == taiKhoan.TenDangNhap);
                if (check != null) return false;

                db.TaiKhoan.Add(taiKhoan);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public TaiKhoan KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            // LINQ tự động sinh câu lệnh SQL an toàn chống SQL Injection
            return db.TaiKhoan.FirstOrDefault(tk =>
                tk.TenDangNhap == tenDangNhap &&
                tk.MatKhau == matKhau &&
                tk.TrangThai == true);
        }

        public TaiKhoan KiemTraDangNhapHoiVien(string tenDangNhap, string matKhau)
        {
            // Kiểm tra đăng nhập cho hội viên - phải có MaHv
            return db.TaiKhoan.FirstOrDefault(tk =>
                tk.TenDangNhap == tenDangNhap &&
                tk.MatKhau == matKhau &&
                tk.TrangThai == true &&
                !string.IsNullOrEmpty(tk.MaHv) &&
                string.IsNullOrEmpty(tk.MaNv)); // Chỉ hội viên, không phải nhân viên
        }

        public TaiKhoan Delete(string tenDangNhap)
        {
            try
            {
                var taiKhoan = db.TaiKhoan.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap);
                if (taiKhoan != null)
                {
                    db.TaiKhoan.Remove(taiKhoan);
                    db.SaveChanges();
                    return taiKhoan;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}