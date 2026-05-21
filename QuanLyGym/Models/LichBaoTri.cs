using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class LichBaoTri
    {
        public string MaBt { get; set; }
        public DateTime? NgayBt { get; set; }
        public string MaTb { get; set; }
        public string MaNv { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ThietBiGym MaTbNavigation { get; set; }
    }
}
