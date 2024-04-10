using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaLamViec> CaLamViecs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<Doi> Dois { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thongke> Thongkes { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-U4IT320\\SQLEXPRESS;Initial Catalog=QLBanGiayTheThao_DuAn1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLamViec>(entity =>
        {
            entity.HasKey(e => e.MaCa).HasName("PK__CaLamVie__27258E7BE56C71B9");
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BC5A53678C");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaCv).HasName("PK__ChucVu__27258E7662F837F4");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.MaCoupon).HasName("PK__Coupon__44DC861CFF4C5E2C");
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.MaDoi).HasName("PK__Doi__3D89F553A82D160F");

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__625A9A57");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0A646428C");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKH__5AB9788F");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__59C55456");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHdct).HasName("PK__HoaDonCh__1419C129067DBD75");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__5F7E2DAC");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaSp__5D95E53A");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaVou__5E8A0973");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E34FCD149");

            entity.HasOne(d => d.MaRankNavigation).WithMany(p => p.KhachHangs).HasConstraintName("FK__KhachHang__MaRan__56E8E7AB");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.MaMau).HasName("PK__MauSac__3A5BBB7DE9112DD8");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A1974FC97");

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__40F9A68C");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__40058253");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.MaRank).HasName("PK__RANKS__7AE118773D0E4582");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C71FF4C4A");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaChatL__4D5F7D71");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaMau__4B7734FF");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaSize__4C6B5938");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaTH__4E53A1AA");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__Size__A787E7ED49F15BE9");
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__THONGKE__60E521F4A2F2FC5E");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__65370702");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__662B2B3B");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaTh).HasName("PK__ThuongHi__27250075C13E4EC4");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B1111806D33");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
