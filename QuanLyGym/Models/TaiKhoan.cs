using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool? TrangThai { get; set; }
        public string QuyenHan { get; set; }
        public string MaNv { get; set; }
        public string MaHv { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual HoiVien MaHvNavigation { get; set; }
    }
}
