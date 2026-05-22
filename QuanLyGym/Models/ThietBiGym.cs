using System;
using System.Collections.Generic;

namespace QuanLyGym.Models
{
    public partial class ThietBiGym
    {
        public ThietBiGym()
        {
            BaoCaoHongHoc = new HashSet<BaoCaoHongHoc>();
            LichBaoTri = new HashSet<LichBaoTri>();
        }

        public string MaTb { get; set; }
        public string TenTb { get; set; }
        public string LoaiThietBi { get; set; }
        public DateTime? NgayMua { get; set; }
        public string TinhTrang { get; set; }

        public virtual ICollection<BaoCaoHongHoc> BaoCaoHongHoc { get; set; }
        public virtual ICollection<LichBaoTri> LichBaoTri { get; set; }
    }
}
