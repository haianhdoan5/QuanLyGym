using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            GoiTapGym = new HashSet<GoiTapGym>();
        }

        public string MaKm { get; set; }
        public decimal? PhanTramGiam { get; set; }

        public virtual ICollection<GoiTapGym> GoiTapGym { get; set; }
    }
}
