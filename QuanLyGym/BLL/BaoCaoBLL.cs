using QuanLyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyGym.BLL
{
    public class BaoCaoBLL
    {
        private GymDbContext db = new GymDbContext();

        public bool NopBaoCaoHongHoc(BaoCaoHongHoc bc)
        {
            try
            {
                if (string.IsNullOrEmpty(bc.MaTb) || string.IsNullOrEmpty(bc.MaNv))
                    return false;

                bc.NgayBao = DateTime.Now;
                db.BaoCaoHongHoc.Add(bc);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<BaoCaoHongHoc> LayDanhSachBaoCaoNhanVien()
        {
            try
            {
                return db.BaoCaoHongHoc
                    .OrderByDescending(x => x.NgayBao)
                    .ToList();
            }
            catch
            {
                return new List<BaoCaoHongHoc>();
            }
        }

        public Dictionary<int, decimal> ThongKeDoanhThuTheoThang()
        {
            try
            {
                var doanhThu = db.DoanhThu
                    .Where(x => x.ThoiGian.HasValue)
                    .GroupBy(x => x.ThoiGian.Value.Month)
                    .Select(g => new { Month = g.Key, Total = (decimal)g.Count() })
                    .OrderBy(x => x.Month)
                    .ToDictionary(x => x.Month, x => x.Total);

                return doanhThu;
            }
            catch
            {
                return new Dictionary<int, decimal>();
            }
        }

        public int DemTongHoiVien()
        {
            try
            {
                return db.HoiVien.Count();
            }
            catch
            {
                return 0;
            }
        }

        public decimal TinhDoanhThuThang(int thang, int nam)
        {
            try
            {
                return db.HopDong
                    .Where(x => x.NgayLap.HasValue && 
                           x.NgayLap.Value.Month == thang && 
                           x.NgayLap.Value.Year == nam)
                    .Count();
            }
            catch
            {
                return 0;
            }
        }

        public int DemBaoCaoThang(int thang, int nam)
        {
            try
            {
                return db.BaoCaoHongHoc
                    .Where(x => x.NgayBao.Month == thang && 
                           x.NgayBao.Year == nam)
                    .Count();
            }
            catch
            {
                return 0;
            }
        }

        public List<ThietBiGym> LayDanhSachThietBi()
        {
            try
            {
                return db.ThietBiGym.ToList();
            }
            catch
            {
                return new List<ThietBiGym>();
            }
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            try
            {
                return db.NhanVien.ToList();
            }
            catch
            {
                return new List<NhanVien>();
            }
        }

        public bool SuaBaoCaoHongHoc(BaoCaoHongHoc bc)
        {
            try
            {
                var existing = db.BaoCaoHongHoc.FirstOrDefault(x => x.MaTb == bc.MaTb && x.MaNv == bc.MaNv);
                if (existing == null)
                    return false;

                existing.MoTaSuCo = bc.MoTaSuCo;
                existing.DonViThucHien = bc.DonViThucHien;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaBaoCaoHongHoc(string maTb, string maNv)
        {
            try
            {
                var baoCao = db.BaoCaoHongHoc.FirstOrDefault(x => x.MaTb == maTb && x.MaNv == maNv);
                if (baoCao == null)
                    return false;

                db.BaoCaoHongHoc.Remove(baoCao);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public BaoCaoHongHoc LayChiTietBaoCao(string maTb, string maNv)
        {
            try
            {
                return db.BaoCaoHongHoc.FirstOrDefault(x => x.MaTb == maTb && x.MaNv == maNv);
            }
            catch
            {
                return null;
            }
        }
    }
}
