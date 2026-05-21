using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class ChiSoInbody
    {
        public string MaInbody { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? TyLeCo { get; set; }
        public double? TyLeMo { get; set; }
        public string MaHv { get; set; }

        public virtual HoiVien MaHvNavigation { get; set; }
    }
}
