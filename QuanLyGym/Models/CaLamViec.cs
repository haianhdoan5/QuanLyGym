using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class CaLamViec
    {
        public CaLamViec()
        {
            Lam = new HashSet<Lam>();
        }

        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Lam> Lam { get; set; }
    }
}
