using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class PhieuChuyenNhuong
    {
        public string MaPcn { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public decimal? PhiDichVu { get; set; }
        public string MaHv1 { get; set; }
        public string MaHv2 { get; set; }
        public string MaNv { get; set; }
        public string MaHd { get; set; }

        public virtual HopDong MaHdNavigation { get; set; }
        public virtual HoiVien MaHv1Navigation { get; set; }
        public virtual HoiVien MaHv2Navigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
