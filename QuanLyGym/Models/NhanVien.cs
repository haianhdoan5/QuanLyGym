using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            BaoCaoHongHoc = new HashSet<BaoCaoHongHoc>();
            ChamSocHoiVien = new HashSet<ChamSocHoiVien>();
            HopDong = new HashSet<HopDong>();
            Lam = new HashSet<Lam>();
            LichBaoTri = new HashSet<LichBaoTri>();
            LichTapLuyen = new HashSet<LichTapLuyen>();
            PhieuBaoLuu = new HashSet<PhieuBaoLuu>();
            PhieuChuyenNhuong = new HashSet<PhieuChuyenNhuong>();
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string Sdt { get; set; }
        public string ChucVu { get; set; }

        public virtual ICollection<BaoCaoHongHoc> BaoCaoHongHoc { get; set; }
        public virtual ICollection<ChamSocHoiVien> ChamSocHoiVien { get; set; }
        public virtual ICollection<HopDong> HopDong { get; set; }
        public virtual ICollection<Lam> Lam { get; set; }
        public virtual ICollection<LichBaoTri> LichBaoTri { get; set; }
        public virtual ICollection<LichTapLuyen> LichTapLuyen { get; set; }
        public virtual ICollection<PhieuBaoLuu> PhieuBaoLuu { get; set; }
        public virtual ICollection<PhieuChuyenNhuong> PhieuChuyenNhuong { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
