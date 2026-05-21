using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HopDong = new HashSet<HopDong>();
        }

        public string MaHoaDon { get; set; }
        public DateTime? NgayThu { get; set; }
        public decimal? SoTienThu { get; set; }
        public string HinhThucThanhToan { get; set; }

        public virtual ICollection<HopDong> HopDong { get; set; }
    }
}
