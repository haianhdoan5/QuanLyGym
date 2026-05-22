using QuanLyGym.Models;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class TaiKhoanBLL
    {
        private GymDbContext db = new GymDbContext();

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
    }
}