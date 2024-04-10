using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Duan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaLamViec",
                columns: table => new
                {
                    MaCa = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CaLamVie__27258E7BE56C71B9", x => x.MaCa);
                });

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    MaChatLieu = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LoaiChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChatLieu__453995BC5A53678C", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__27258E7662F837F4", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    MaCoupon = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenCoupon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaTri = table.Column<double>(type: "float", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DieuKien = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "date", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Coupon__44DC861CFF4C5E2C", x => x.MaCoupon);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    MaMau = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MauSac__3A5BBB7DE9112DD8", x => x.MaMau);
                });

            migrationBuilder.CreateTable(
                name: "RANKS",
                columns: table => new
                {
                    MaRank = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DieuKien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MucUuDai = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RANKS__7AE118773D0E4582", x => x.MaRank);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    MaSize = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Size__A787E7ED49F15BE9", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    MaTH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ThuongHi__27250075C13E4EC4", x => x.MaTH);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    MaVoucher = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenVoucher = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaTri = table.Column<double>(type: "float", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DieuKien = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "date", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Voucher__0AAC5B1111806D33", x => x.MaVoucher);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioiTinh = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MaChucVu = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaCa = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__2725D70A1974FC97", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK__NhanVien__MaCa__40F9A68C",
                        column: x => x.MaCa,
                        principalTable: "CaLamViec",
                        principalColumn: "MaCa");
                    table.ForeignKey(
                        name: "FK__NhanVien__MaChuc__40058253",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Diem = table.Column<double>(type: "float", nullable: true),
                    MaRank = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__2725CF1E34FCD149", x => x.MaKH);
                    table.ForeignKey(
                        name: "FK__KhachHang__MaRan__56E8E7AB",
                        column: x => x.MaRank,
                        principalTable: "RANKS",
                        principalColumn: "MaRank");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "date", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MaMau = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaSize = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaChatLieu = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaTH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__2725081C71FF4C4A", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK__SanPham__MaChatL__4D5F7D71",
                        column: x => x.MaChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "MaChatLieu");
                    table.ForeignKey(
                        name: "FK__SanPham__MaMau__4B7734FF",
                        column: x => x.MaMau,
                        principalTable: "MauSac",
                        principalColumn: "MaMau");
                    table.ForeignKey(
                        name: "FK__SanPham__MaSize__4C6B5938",
                        column: x => x.MaSize,
                        principalTable: "Size",
                        principalColumn: "MaSize");
                    table.ForeignKey(
                        name: "FK__SanPham__MaTH__4E53A1AA",
                        column: x => x.MaTH,
                        principalTable: "ThuongHieu",
                        principalColumn: "MaTH");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TongTien = table.Column<double>(type: "float", nullable: true),
                    MaNV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__2725A6E0A646428C", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK__HoaDon__MaKH__5AB9788F",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK__HoaDon__MaNV__59C55456",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHDCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<double>(type: "float", nullable: true),
                    TongTienSauVoucher = table.Column<double>(type: "float", nullable: true),
                    MaSp = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaVoucher = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDonCh__1419C129067DBD75", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK__HoaDonChiT__MaHD__5F7E2DAC",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD");
                    table.ForeignKey(
                        name: "FK__HoaDonChiT__MaSp__5D95E53A",
                        column: x => x.MaSp,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                    table.ForeignKey(
                        name: "FK__HoaDonChi__MaVou__5E8A0973",
                        column: x => x.MaVoucher,
                        principalTable: "Voucher",
                        principalColumn: "MaVoucher");
                });

            migrationBuilder.CreateTable(
                name: "THONGKE",
                columns: table => new
                {
                    MaThongKe = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NgayThongKe = table.Column<DateTime>(type: "date", nullable: true),
                    TongDoanhThu = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    MaHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MaNv = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THONGKE__60E521F4A2F2FC5E", x => x.MaThongKe);
                    table.ForeignKey(
                        name: "FK__THONGKE__MaHD__65370702",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD");
                    table.ForeignKey(
                        name: "FK__THONGKE__MaNv__662B2B3B",
                        column: x => x.MaNv,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "Doi",
                columns: table => new
                {
                    MaDoi = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayDoi = table.Column<DateTime>(type: "date", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DoiSangSp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaHDCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Doi__3D89F553A82D160F", x => x.MaDoi);
                    table.ForeignKey(
                        name: "FK__Doi__MaHDCT__625A9A57",
                        column: x => x.MaHDCT,
                        principalTable: "HoaDonChiTiet",
                        principalColumn: "MaHDCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doi_MaHDCT",
                table: "Doi",
                column: "MaHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaHD",
                table: "HoaDonChiTiet",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSp",
                table: "HoaDonChiTiet",
                column: "MaSp");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaVoucher",
                table: "HoaDonChiTiet",
                column: "MaVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaRank",
                table: "KhachHang",
                column: "MaRank");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaCa",
                table: "NhanVien",
                column: "MaCa");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaChatLieu",
                table: "SanPham",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaMau",
                table: "SanPham",
                column: "MaMau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaSize",
                table: "SanPham",
                column: "MaSize");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaTH",
                table: "SanPham",
                column: "MaTH");

            migrationBuilder.CreateIndex(
                name: "IX_THONGKE_MaHD",
                table: "THONGKE",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_THONGKE_MaNv",
                table: "THONGKE",
                column: "MaNv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "Doi");

            migrationBuilder.DropTable(
                name: "THONGKE");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "RANKS");

            migrationBuilder.DropTable(
                name: "CaLamViec");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
