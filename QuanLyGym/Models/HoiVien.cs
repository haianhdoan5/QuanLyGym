using System;
using System.Collections.Generic;

namespace QuanLyGym.Models
{
    public partial class HoiVien
    {
        public HoiVien()
        {
            ChamSocHoiVien = new HashSet<ChamSocHoiVien>();
            ChiSoInbody = new HashSet<ChiSoInbody>();
            HopDong = new HashSet<HopDong>();
            LichTapLuyen = new HashSet<LichTapLuyen>();
            PhieuChuyenNhuongMaHv1Navigation = new HashSet<PhieuChuyenNhuong>();
            PhieuChuyenNhuongMaHv2Navigation = new HashSet<PhieuChuyenNhuong>();
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public string MaHv { get; set; }
        public string TenHv { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }

        public virtual ICollection<ChamSocHoiVien> ChamSocHoiVien { get; set; }
        public virtual ICollection<ChiSoInbody> ChiSoInbody { get; set; }
        public virtual ICollection<HopDong> HopDong { get; set; }
        public virtual ICollection<LichTapLuyen> LichTapLuyen { get; set; }
        public virtual ICollection<PhieuChuyenNhuong> PhieuChuyenNhuongMaHv1Navigation { get; set; }
        public virtual ICollection<PhieuChuyenNhuong> PhieuChuyenNhuongMaHv2Navigation { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
