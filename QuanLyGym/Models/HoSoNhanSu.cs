using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class HoSoNhanSu
    {
        public string MaHs { get; set; }
        public string TenNv { get; set; }
        public string ChungChi { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public string KhenThuong { get; set; }
        public string MaNv { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
