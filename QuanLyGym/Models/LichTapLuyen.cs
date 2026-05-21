using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class LichTapLuyen
    {
        public string MaLt { get; set; }
        public DateTime? NgayTap { get; set; }
        public TimeSpan? GioTap { get; set; }
        public string TrangThai { get; set; }
        public string MaHv { get; set; }
        public string MaNv { get; set; }

        public virtual HoiVien MaHvNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
