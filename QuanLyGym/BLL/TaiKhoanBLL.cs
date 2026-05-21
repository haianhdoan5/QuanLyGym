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
    }
}