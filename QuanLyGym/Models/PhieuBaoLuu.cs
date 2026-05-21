using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class PhieuBaoLuu
    {
        public string MaPbl { get; set; }
        public DateTime? NgayBaoLuu { get; set; }
        public string NoiDung { get; set; }
        public string MaHd { get; set; }
        public string MaNv { get; set; }

        public virtual HopDong MaHdNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
