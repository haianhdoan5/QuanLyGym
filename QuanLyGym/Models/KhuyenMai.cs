using System;
using System.Collections.Generic;

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
