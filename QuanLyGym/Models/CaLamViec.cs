using System;
using System.Collections.Generic;



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
