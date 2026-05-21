using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class Lam
    {
        public string MaNv { get; set; }
        public string MaCa { get; set; }
        public DateTime NgayLam { get; set; }
        public double? GioLam { get; set; }

        public virtual CaLamViec MaCaNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
