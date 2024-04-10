	CREATE DATABASE QLBanGiayTheThao_DuAn1
	USE QLBanGiayTheThao_DuAn1
	go
	CREATE TABLE ChucVu
	(
		MaCV varchar(10) primary key,
		TenChucVu nvarchar(50),
	)

	go
	CREATE TABLE CaLamViec
	(
		MaCa varchar(10) primary key,
		ThoiGian datetime,
		TrangThai nvarchar(30),
	)

	CREATE TABLE NhanVien
	(
		MaNV varchar(10) primary key, 
		TenNhanVien nvarchar(50),
		SoDienThoai varchar(15),
		Email nvarchar(50),
		GioiTinh varchar(10),
		NgaySinh date,
		DiaChi nvarchar(250),
		MatKhau nvarchar(30),
		TrangThai nvarchar(30),
		MaChucVu varchar(10) foreign key references ChucVu(MaCV),
		MaCa varchar(10) foreign key references CaLamViec(MaCa)
	)
	

	CREATE TABLE MauSac
	(
		MaMau varchar(10) primary key,
		TenMau nvarchar(50),
		TrangThai nvarchar(30)
	)

	CREATE TABLE Size
	(
		MaSize varchar(10) primary key,
		KichThuoc nvarchar(50),
		TrangThai nvarchar(30)
	)


	CREATE TABLE ChatLieu
	(
		MaChatLieu varchar(10) primary key,
		LoaiChatLieu nvarchar(50),
		TrangThai nvarchar(30)
	)

	CREATE TABLE ThuongHieu
	(
		MaTH varchar(10) primary key,
		TenThuongHieu nvarchar(50),
		TrangThai nvarchar(30),
	)

	CREATE TABLE SanPham
	(
		MaSP varchar(10) primary key,
		TenSanPham nvarchar(250),
		NgayNhap date,
		SoLuong int,
		Gia float ,
		TrangThai nvarchar(30),
		MaMau varchar(10) foreign key references MauSac(MaMau),
		MaSize varchar(10) foreign key references Size(MaSize),
		MaChatLieu varchar(10) foreign key references ChatLieu(MaChatLieu),
		MaTH varchar(10) foreign key references ThuongHieu(MaTH)
	); 
	CREATE TABLE Voucher
	(
		MaVoucher varchar(10) primary key,
		TenVoucher nvarchar(50) ,
		GiaTri float,
		MoTa nvarchar(250) ,
		DieuKien varchar(30) ,
		NgayBatDau date ,
		NgayKetThuc date ,

	)
	CREATE TABLE Coupon
	(
		MaCoupon varchar(10) primary key,
		TenCoupon nvarchar(50) ,
		GiaTri float,
		MoTa nvarchar(250) ,
		DieuKien varchar(30) ,
		NgayBatDau date ,
		NgayKetThuc date ,

	)
	 

	CREATE TABLE RANKS
	(
		MaRank varchar(10) primary key ,
		DieuKien nvarchar(100) ,
		MucUuDai varchar(100) ,
		TrangThai nvarchar(30) ,
		MoTa nvarchar(250) ,
	)

	CREATE TABLE KhachHang
	(
		MaKH varchar(10) primary key,
		SDT varchar(10),
		Diem float,
		MaRank varchar(10) foreign key references RANKS(MaRank),
	)

	create TABLE HoaDon
	(
		MaHD varchar(10) primary key,
		NgayTao date ,
		TrangThai nvarchar(30) ,
		TongTien float ,		
		MaNV varchar(10) foreign key references NhanVien(MaNV),
		MaKH varchar(10) foreign key references KhachHang(MaKH)
	)

	CREATE TABLE HoaDonChiTiet
	(
		MaHDCT varchar(10) primary key,
		SoLuong int ,
		DonGia float ,
		TongTienSauVoucher float ,
		MaSp varchar(10) foreign key references SanPham(MaSP),		
		MaVoucher varchar(10) foreign key references VouCher(MaVoucher),
		MaHD varchar(10) foreign key references HoaDon(MaHD)
	)


	CREATE TABLE Doi
	(	 
		MaDoi varchar(10) primary key,
		TrangThai nvarchar(10) ,
		NgayDoi date ,
		LyDo nvarchar(250) ,
		DoiSangSp nvarchar(100) ,
		MaHDCT varchar(10) foreign key references HoaDonChiTiet(MaHDCT)
	)

	Create table Tra
	(	
		MaTra varchar(10) primary key,
		TrangThai nvarchar(10) ,
		NgayDoi date ,
		LyDo nvarchar(250) ,
		MaHDCT varchar(10) foreign key references HoaDonChiTiet(MaHDCT)
	)
	Create TABLE THONGKE
	(
		MaThongKe varchar(10) primary key,
		NgayThongKe date , 
		TongDoanhThu nvarchar(40) ,
		SoLuong int ,
		MaHD varchar(10) foreign key references HoaDon(MaHD),
		MaNv varchar(10) foreign key references NhanVien(MaNV)
	)

	-- Insert data into ChucVu table
INSERT INTO ChucVu (MaCV, TenChucVu)
VALUES
    ('CV001', N'Quản lý'),
    ('CV002', N'Nhân viên bán hàng');
    

-- Display data from ChucVu table
SELECT * FROM ChucVu;

-- Insert data into CaLamViec table
INSERT INTO CaLamViec (MaCa, ThoiGian, TrangThai)
VALUES
    ('Ca001', '2023-12-05 08:00:00', N'Đang làm việc'),
    ('Ca002', '2023-12-05 14:00:00', N'Nghỉ');

-- Insert data into NhanVien table
INSERT INTO NhanVien (MaNV, TenNhanVien, SoDienThoai, Email, GioiTinh, NgaySinh, DiaChi, MatKhau, TrangThai, MaChucVu, MaCa)
VALUES
    ('NV001', N'Nguyen Van A', '123456789', 'nv.a@example.com', N'Nam', '1990-01-01', N'123 ABC Street', 'password123', N'Đang làm việc', 'CV001', 'Ca001'),
    ('NV002', N'Tran Thi B', '987654321', 'nv.b@example.com', N'Nữ', '1995-05-05', N'456 XYZ Street', 'password456', N'Đang làm việc', 'CV002', 'Ca002'),
	('admin', N'Nguyen Van Trọng', '03334583920', 'vantrongvt1310@gmail.com', N'Nam', '2004-10-13', N'123 ABC Street', '123', N'Đang làm việc', 'CV001', 'Ca001'),
    ('nhanvien', N'Nguyen Van Trong', '987654321', 'nv.b@example.com', N'Nữ', '1995-05-05', N'456 XYZ Street', '123', N'Đang làm việc', 'CV002', 'Ca002');
-- Insert data into MauSac table
INSERT INTO MauSac (MaMau, TenMau, TrangThai)
VALUES
    ('MS001', N'Đen', N'Hoạt động'),
    ('MS002', N'Trắng', N'Hoạt động'),
	('MS003', N'Đỏ', N'Hoạt động'),
    ('MS004', N'Xanh', N'Hoạt động'),
    ('MS005', N'Vàng', N'Hoạt động');

-- Insert data into Size table
INSERT INTO Size (MaSize, KichThuoc, TrangThai)
VALUES
    ('Size001', N'L', N'Hoạt động'),
    ('Size002', N'M', N'Hoạt động'),
    ('Size003', N'S', N'Hoạt động'),
    ('Size004', N'XL', N'Hoạt động'),
    ('Size005', N'XXL', N'Hoạt động');

-- Insert data into ChatLieu table
INSERT INTO ChatLieu (MaChatLieu, LoaiChatLieu, TrangThai)
VALUES
    ('CL001', N'Da', N'Hoạt động'),
    ('CL002', N'Vải', N'Hoạt động'),
    ('CL003', N'Nylon', N'Hoạt động'),
    ('CL004', N'Mesh', N'Hoạt động'),
    ('CL005', N'Đế cao su', N'Hoạt động');

-- Insert data into ThuongHieu table
INSERT INTO ThuongHieu (MaTH, TenThuongHieu, TrangThai)
VALUES
    ('TH001', N'Nike', N'Hoạt động'),
     ('TH002', N'Adidas', N'Hoạt động'),
    ('TH003', N'Puma', N'Hoạt động'),
    ('TH004', N'Under Armour', N'Hoạt động'),
    ('TH005', N'Reebok', N'Hoạt động');

-- Insert data into SanPham table
INSERT INTO SanPham (MaSP, TenSanPham, NgayNhap, SoLuong, Gia, TrangThai, MaMau, MaSize, MaChatLieu, MaTH)
VALUES
    ('SP001', N'Giày thể thao Nike Air Max', '2023-12-05', 50, 15000000, N'Hoạt động', 'MS001', 'Size001', 'CL001', 'TH001'),
    ('SP002', N'Giày thể thao Adidas Ultra Boost', '2023-12-05', 30, 12000000, N'Hoạt động', 'MS002', 'Size002', 'CL002', 'TH002'),
    ('SP003', N'Giày thể thao Puma RS-X', '2023-12-06', 25, 11000000, N'Hoạt động', 'MS003', 'Size003', 'CL003', 'TH003'),
    ('SP004', N'Under Armour HOVR Sonic', '2023-12-06', 40, 13500000, N'Hoạt động', 'MS004', 'Size004', 'CL004', 'TH004'),
    ('SP005', N'Reebok Classic Leather', '2023-12-07', 35, 8000000, N'Hoạt động', 'MS005', 'Size005', 'CL005', 'TH005');
-- Insert data into Voucher table
INSERT INTO Voucher (MaVoucher, TenVoucher, GiaTri, MoTa, DieuKien, NgayBatDau, NgayKetThuc)
VALUES
    ('Voucher001', N'Giảm giá 20%', 0.2, N'Áp dụng cho sản phẩm Nike', 'Đơn hàng trên 200.000 VND', '2023-12-01', '2023-12-31'),
    ('Voucher002', N'Giảm giá 15%', 0.15, N'Áp dụng cho sản phẩm Adidas', 'Đơn hàng trên 150.000 VND', '2023-12-01', '2023-12-31'),
    ('Voucher003', N'Giảm giá 25%', 0.25, N'Áp dụng cho sản phẩm Puma', 'Đơn hàng trên 250.000 VND', '2023-12-01', '2023-12-31'),
    ('Voucher004', N'Giảm giá 10%', 0.1, N'Áp dụng cho sản phẩm Under Armour', 'Đơn hàng trên 100.000 VND', '2023-12-01', '2023-12-31'),
    ('Voucher005', N'Giảm giá 30%', 0.3, N'Áp dụng cho sản phẩm Reebok', 'Đơn hàng trên 300.000 VND', '2023-12-01', '2023-12-31');
-- Insert data into Coupon table
INSERT INTO Coupon (MaCoupon, TenCoupon, GiaTri, MoTa, DieuKien, NgayBatDau, NgayKetThuc)
VALUES
    ('Coupon001', N'Giảm 30%', 0.3, N'Áp dụng cho mọi sản phẩm', 'Không có', '2023-12-01', '2023-12-31'),
    ('Coupon002', N'Giảm 10%', 0.1, N'Áp dụng cho đơn hàng trên 100.000 VND', 'Đơn hàng trên 100.000 VND', '2023-12-01', '2023-12-31');

-- Insert data into RANKS table
INSERT INTO RANKS (MaRank, DieuKien, MucUuDai, TrangThai, MoTa)
VALUES
    ('R001', N'100 điểm', N'Giảm giá 10%', N'Hoạt động', N'Khách hàng thân thiết'),
    ('R002', N'50 điểm', N'Giảm giá 5%', N'Hoạt động', N'Khách hàng thường xuyên');

-- Insert data into KhachHang table
INSERT INTO KhachHang (MaKH, SDT, Diem, MaRank)
VALUES
    ('KH001', '0123456789', 100.00, 'R001'),
    ('KH002', '0987654321', 50.00, 'R002'),
    ('KH003', '0909090909', 75.00, 'R001'),
    ('KH004', '0888777666', 120.00, 'R002'),
    ('KH005', '0777666555', 90.00, 'R001'),
    ('KH006', '0666555444', 60.00, 'R002'),
    ('KH007', '0555444333', 80.00, 'R002'),
    ('KH008', '0444333222', 110.00, 'R001'),
    ('KH009', '0333222111', 70.00, 'R002'),
    ('KH010', '0222111000', 95.00, 'R002');

		-- Insert data into HoaDon table
		select * from Hoadon

INSERT INTO HoaDon(MaHD, NgayTao,TrangThai,TongTien,MaNV,MaKH) 
values('HD001','2023-12-05', N'Hoàn thành', 3000000,  'NV001','KH001'),
   ('HD002', '2023-12-06', N'Hoàn thành ', 2500000, 'NV002', 'KH002')

   INSERT INTO HoaDon(MaHD, NgayTao,TrangThai,TongTien,MaNV,MaKH) 
values ('HD003', '2023-12-07', N'Đang xử lý', 1800000, 'NV001', 'KH003'),
    ('HD004', '2023-12-08', N'Hoàn thành', 4000000, 'NV002', 'KH004'),
    ('HD005', '2023-12-09', N'Chưa xác nhận', 220.0000, 'NV001', 'KH005');

-- Insert data into HoaDonChiTiet table
INSERT INTO HoaDonChiTiet(MaHDCT,MaSP,SoLuong,DonGia,TongTienSauVoucher,MaVoucher,MaHD)
values ('HDCT001', 'SP001', 2, 1500000, 2500000, 'Voucher001', 'HD001'),
	('HDCT002', 'SP002', 2, 1250000, 2000000,  'Voucher002','HD002')

    INSERT INTO HoaDonChiTiet(MaHDCT,MaSP,SoLuong,DonGia,TongTienSauVoucher,MaVoucher,MaHD)
values ('HDCT003', 'SP003', 3, 1800000, 2700000, 'Voucher003', 'HD003'),
    ('HDCT004', 'SP004', 2, 2000000, 3600000, 'Voucher004', 'HD004'),
    ('HDCT005', 'SP005', 1, 1200000, 900000, 'Voucher005', 'HD005');
   
   select* from HoaDon

-- In
INSERT INTO Doi (MaDoi, TrangThai, NgayDoi, LyDo, DoiSangSp, MaHDCT)
VALUES
    ('Doi001', N'Đang xử lý', '2023-12-06', N'Sản phẩm không vừa', 'SP001', 'HDCT001');

-- Insert data into Tra table

-- Insert data into THONGKE table
INSERT INTO THONGKE (MaThongKe, NgayThongKe, TongDoanhThu, SoLuong, MaHD, MaNv)
VALUES
    ('TK001', '2023-12-08', N'500.000 VND', 3, 'HD001', 'NV001'),
    ('TK002', '2023-12-08', N'360.000 VND', 2, 'HD002', 'NV002');


delete from THONGKE
delete from Tra
delete from Doi
delete from HoaDonChiTiet
delete from HoaDon
delete from RANKS
delete from KhachHang
delete from Voucher
delete from Coupon
delete from ThuongHieu
delete from ChatLieu
delete from Size
delete from MauSac
delete from SanPham
delete from NhanVien
delete from CaLamViec
delete from ChucVu
DROP TABLE IF EXISTS Doi, Tra, THONGKE, HoaDonChiTiet, HoaDon, RANKS, KhachHang, Voucher, Coupon, ThuongHieu, ChatLieu, Size, MauSac, SanPham, NhanVien, CaLamViec, ChucVu;
DROP TABLE IF EXISTS ChatLieu,Size,MauSac,RANKS,ThuongHieu;



select* from THONGKE
select *from Tra
select *from Doi
select* from HoaDonChiTiet
select *from HoaDon
select *from RANKS
select *from KhachHang
select *from Voucher
select *from ThuongHieu
select *from ChatLieu
select *from Size
select *from MauSac
select *from SanPham
select *from NhanVien
select *from CaLamViec
select *from ChucVu