using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class DoanhThu
    {
        public string MaDt { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string MaHd { get; set; }

        public virtual HopDong MaHdNavigation { get; set; }
    }
}
