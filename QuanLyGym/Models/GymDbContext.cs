using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyGym.Models
{
    public partial class GymDbContext : DbContext
    {
        public GymDbContext()
        {
        }

        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoCaoHongHoc> BaoCaoHongHoc { get; set; }
        public virtual DbSet<CaLamViec> CaLamViec { get; set; }
        public virtual DbSet<ChamSocHoiVien> ChamSocHoiVien { get; set; }
        public virtual DbSet<ChiSoInbody> ChiSoInbody { get; set; }
        public virtual DbSet<DoanhThu> DoanhThu { get; set; }
        public virtual DbSet<GoiTapGym> GoiTapGym { get; set; }
        public virtual DbSet<HoSoNhanSu> HoSoNhanSu { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HoiVien> HoiVien { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<Lam> Lam { get; set; }
        public virtual DbSet<LichBaoTri> LichBaoTri { get; set; }
        public virtual DbSet<LichTapLuyen> LichTapLuyen { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhieuBaoLuu> PhieuBaoLuu { get; set; }
        public virtual DbSet<PhieuChuyenNhuong> PhieuChuyenNhuong { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThietBiGym> ThietBiGym { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=nhuhai;Database=GymManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoHongHoc>(entity =>
            {
                entity.HasKey(e => new { e.MaTb, e.MaNv, e.NgayBao })
                    .HasName("PK__BaoCaoHo__3207CA78F19845FB");

                entity.Property(e => e.MaTb)
                    .HasColumnName("MaTB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBao).HasColumnType("datetime");

                entity.Property(e => e.DonViThucHien).HasMaxLength(100);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.BaoCaoHongHoc)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BaoCaoHong__MaNV__09A971A2");

                entity.HasOne(d => d.MaTbNavigation)
                    .WithMany(p => p.BaoCaoHongHoc)
                    .HasForeignKey(d => d.MaTb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BaoCaoHong__MaTB__08B54D69");
            });

            modelBuilder.Entity<CaLamViec>(entity =>
            {
                entity.HasKey(e => e.MaCa)
                    .HasName("PK__CaLamVie__27258E7B34E41097");

                entity.Property(e => e.MaCa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.TenCa).HasMaxLength(50);
            });

            modelBuilder.Entity<ChamSocHoiVien>(entity =>
            {
                entity.HasKey(e => new { e.MaHv, e.MaNv, e.NgayCs })
                    .HasName("PK__ChamSocH__0BEA5A9E10EEBC44");

                entity.Property(e => e.MaHv)
                    .HasColumnName("MaHV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCs)
                    .HasColumnName("NgayCS")
                    .HasColumnType("datetime");

                entity.Property(e => e.KetQua).HasMaxLength(255);

                entity.HasOne(d => d.MaHvNavigation)
                    .WithMany(p => p.ChamSocHoiVien)
                    .HasForeignKey(d => d.MaHv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChamSocHoi__MaHV__04E4BC85");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.ChamSocHoiVien)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChamSocHoi__MaNV__05D8E0BE");
            });

            modelBuilder.Entity<ChiSoInbody>(entity =>
            {
                entity.HasKey(e => e.MaInbody)
                    .HasName("PK__ChiSoInb__E816E4A55A83E3A3");

                entity.Property(e => e.MaInbody)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHv)
                    .HasColumnName("MaHV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHvNavigation)
                    .WithMany(p => p.ChiSoInbody)
                    .HasForeignKey(d => d.MaHv)
                    .HasConstraintName("FK__ChiSoInbod__MaHV__5EBF139D");
            });

            modelBuilder.Entity<DoanhThu>(entity =>
            {
                entity.HasKey(e => e.MaDt)
                    .HasName("PK__DoanhThu__27258655ECC34EBA");

                entity.Property(e => e.MaDt)
                    .HasColumnName("MaDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.DoanhThu)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__DoanhThu__MaHD__72C60C4A");
            });

            modelBuilder.Entity<GoiTapGym>(entity =>
            {
                entity.HasKey(e => e.MaGoi)
                    .HasName("PK__GoiTapGy__3CD30F691750B5C0");

                entity.Property(e => e.MaGoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaKm)
                    .HasColumnName("MaKM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenGoi).HasMaxLength(100);

                entity.HasOne(d => d.MaKmNavigation)
                    .WithMany(p => p.GoiTapGym)
                    .HasForeignKey(d => d.MaKm)
                    .HasConstraintName("FK__GoiTapGym__MaKM__5BE2A6F2");
            });

            modelBuilder.Entity<HoSoNhanSu>(entity =>
            {
                entity.HasKey(e => e.MaHs)
                    .HasName("PK__HoSoNhan__2725A6EF10240D09");

                entity.Property(e => e.MaHs)
                    .HasColumnName("MaHS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChungChi).HasMaxLength(255);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayVaoLam).HasColumnType("date");

                entity.Property(e => e.TenNv)
                    .HasColumnName("TenNV")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoSoNhanSu)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__HoSoNhanSu__MaNV__619B8048");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13BFAFFE7D9");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);

                entity.Property(e => e.NgayThu)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoTienThu).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HoiVien>(entity =>
            {
                entity.HasKey(e => e.MaHv)
                    .HasName("PK__HoiVien__2725A6D23E731A36");

                entity.Property(e => e.MaHv)
                    .HasColumnName("MaHV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenHv)
                    .IsRequired()
                    .HasColumnName("TenHV")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HopDong__2725A6E0D0DCD8F6");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaGoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHv)
                    .HasColumnName("MaHV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLap)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaGoiNavigation)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.MaGoi)
                    .HasConstraintName("FK__HopDong__MaGoi__6EF57B66");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.MaHoaDon)
                    .HasConstraintName("FK__HopDong__MaHoaDo__6FE99F9F");

                entity.HasOne(d => d.MaHvNavigation)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.MaHv)
                    .HasConstraintName("FK__HopDong__MaHV__6D0D32F4");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HopDong)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__HopDong__MaNV__6E01572D");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKm)
                    .HasName("PK__KhuyenMa__2725CF1555C33A60");

                entity.Property(e => e.MaKm)
                    .HasColumnName("MaKM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Lam>(entity =>
            {
                entity.HasKey(e => new { e.MaNv, e.MaCa, e.NgayLam })
                    .HasName("PK__Lam__303260358B7C6ABF");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaCa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLam).HasColumnType("date");

                entity.HasOne(d => d.MaCaNavigation)
                    .WithMany(p => p.Lam)
                    .HasForeignKey(d => d.MaCa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lam__MaCa__693CA210");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Lam)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lam__MaNV__68487DD7");
            });

            modelBuilder.Entity<LichBaoTri>(entity =>
            {
                entity.HasKey(e => e.MaBt)
                    .HasName("PK__LichBaoT__27247597840DB96D");

                entity.Property(e => e.MaBt)
                    .HasColumnName("MaBT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaTb)
                    .HasColumnName("MaTB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBt)
                    .HasColumnName("NgayBT")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.LichBaoTri)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__LichBaoTri__MaNV__0D7A0286");

                entity.HasOne(d => d.MaTbNavigation)
                    .WithMany(p => p.LichBaoTri)
                    .HasForeignKey(d => d.MaTb)
                    .HasConstraintName("FK__LichBaoTri__MaTB__0C85DE4D");
            });

            modelBuilder.Entity<LichTapLuyen>(entity =>
            {
                entity.HasKey(e => e.MaLt)
                    .HasName("PK__LichTapL__2725C773548DBE4C");

                entity.Property(e => e.MaLt)
                    .HasColumnName("MaLT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHv)
                    .HasColumnName("MaHV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayTap).HasColumnType("date");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaHvNavigation)
                    .WithMany(p => p.LichTapLuyen)
                    .HasForeignKey(d => d.MaHv)
                    .HasConstraintName("FK__LichTapLuy__MaHV__01142BA1");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.LichTapLuyen)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__LichTapLuy__MaNV__02084FDA");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70AAB689E66");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenNv)
                    .IsRequired()
                    .HasColumnName("TenNV")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PhieuBaoLuu>(entity =>
            {
                entity.HasKey(e => e.MaPbl)
                    .HasName("PK__PhieuBao__3AE0790197BCEC63");

                entity.Property(e => e.MaPbl)
                    .HasColumnName("MaPBL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBaoLuu)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoiDung).HasMaxLength(255);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.PhieuBaoLuu)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__PhieuBaoLu__MaHD__7D439ABD");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuBaoLuu)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__PhieuBaoLu__MaNV__7E37BEF6");
            });

            modelBuilder.Entity<PhieuChuyenNhuong>(entity =>
            {
                entity.HasKey(e => e.MaPcn)
                    .HasName("PK__PhieuChu__3AE071223990B602");

                entity.Property(e => e.MaPcn)
                    .HasColumnName("MaPCN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHv1)
                    .HasColumnName("MaHV1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHv2)
                    .HasColumnName("MaHV2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThucHien)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhiDichVu).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.PhieuChuyenNhuong)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__PhieuChuye__MaHD__797309D9");

                entity.HasOne(d => d.MaHv1Navigation)
                    .WithMany(p => p.PhieuChuyenNhuongMaHv1Navigation)
                    .HasForeignKey(d => d.MaHv1)
                    .HasConstraintName("FK__PhieuChuy__MaHV1__76969D2E");

                entity.HasOne(d => d.MaHv2Navigation)
                    .WithMany(p => p.PhieuChuyenNhuongMaHv2Navigation)
                    .HasForeignKey(d => d.MaHv2)
                    .HasConstraintName("FK__PhieuChuy__MaHV2__778AC167");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.PhieuChuyenNhuong)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__PhieuChuye__MaNV__787EE5A0");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK__TaiKhoan__55F68FC1CE4171A4");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuyenHan).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__TaiKhoan__MaNV__656C112C");
            });

            modelBuilder.Entity<ThietBiGym>(entity =>
            {
                entity.HasKey(e => e.MaTb)
                    .HasName("PK__ThietBiG__2725006F93031EC5");

                entity.Property(e => e.MaTb)
                    .HasColumnName("MaTB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoaiThietBi).HasMaxLength(50);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayMua).HasColumnType("date");

                entity.Property(e => e.TenTb)
                    .HasColumnName("TenTB")
                    .HasMaxLength(100);

                entity.Property(e => e.TinhTrang).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
