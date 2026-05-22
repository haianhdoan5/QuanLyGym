using System;
using System.Collections.Generic;

namespace QuanLyGym.Models
{
    public partial class GoiTapGym
    {
        public GoiTapGym()
        {
            HopDong = new HashSet<HopDong>();
        }

        public string MaGoi { get; set; }
        public string TenGoi { get; set; }
        public decimal? DonGia { get; set; }
        public int? ThoiHan { get; set; }
        public string MaKm { get; set; }

        public virtual KhuyenMai MaKmNavigation { get; set; }
        public virtual ICollection<HopDong> HopDong { get; set; }
    }
}
