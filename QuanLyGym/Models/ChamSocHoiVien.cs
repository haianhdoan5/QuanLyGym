using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class ChamSocHoiVien
    {
        public string MaHv { get; set; }
        public string MaNv { get; set; }
        public DateTime NgayCs { get; set; }
        public string NoiDung { get; set; }
        public string KetQua { get; set; }

        public virtual HoiVien MaHvNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
