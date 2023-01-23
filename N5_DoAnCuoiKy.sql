-- 0: Giới tính Nam, 1: Giới tính nữ 

USE master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyKyTucXaDB')
    DROP DATABASE QuanLyKyTucXaDB
GO

CREATE DATABASE QuanLyKyTucXaDB
GO

USE QuanLyKyTucXaDB
GO

-- [CREATE] [TABLEs]
-- [NhanVien]
CREATE TABLE [dbo].[NhanVien]
(
	[ma_nhan_vien] CHAR(10) NOT NULL PRIMARY KEY, 
    [ho_ten] NVARCHAR(50) NOT NULL, 
    [gioi_tinh] BIT NOT NULL, -- 0: Giới tính Nam, 1: Giới tính nữ 
    [dia_chi] NVARCHAR(50) NOT NULL, 
    [so_dien_thoai] CHAR(10) NOT NULL, 
    [chuc_vu] NVARCHAR(50) NOT NULL
)
GO

-- [Account]
CREATE TABLE [TaiKhoan] (
	[ma_tai_khoan] CHAR(10) PRIMARY KEY,
	[ma_nhan_vien] CHAR(10) NOT NULL,
	[ten_dang_nhap] CHAR(255) NOT NULL UNIQUE,
	[mat_khau] CHAR(255) NOT NULL,
	[role] CHAR(50),
	CONSTRAINT [FK_NhanVienCoTaiKhoan] FOREIGN KEY ([ma_nhan_vien]) REFERENCES [NhanVien]([ma_nhan_vien])
	ON UPDATE CASCADE 
	ON DELETE SET NULL
)
GO

-- Insert NhanVien
INSERT INTO NhanVien 
VALUES ('NV0001',N'NGUYỄN THỊ TÂM', 1, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Nhân viên')
INSERT INTO NhanVien 
VALUES ('NV0002',N'NGUYỄN THỊ QUỲNH NHƯ', 1, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Nhân viên')
INSERT INTO NhanVien 
VALUES ('NV0003',N'NGUYỄN THANH TÂN', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Nhân viên')
INSERT INTO NhanVien 
VALUES ('NV0004',N'TRẦN THANH QUÝ', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Nhân viên')
INSERT INTO NhanVien 
VALUES ('NV0005',N'TRẦN VĂN CA', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Bảo vệ')
INSERT INTO NhanVien 
VALUES ('NV0006',N'LÊ THỊ THANH', 1, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Bảo vệ')
INSERT INTO NhanVien 
VALUES ('NV0007',N'LÊ DUY THIỆN', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Bảo vệ')
INSERT INTO NhanVien 
VALUES ('NV0008',N'PHẠM YẾN', 1, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Quản lý')
INSERT INTO NhanVien 
VALUES ('NV0009',N'PHAN TIẾN', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Phó giám đốc')
INSERT INTO NhanVien 
VALUES ('NV0010',N'MAI TIẾN DŨNG', 0, N'SỐ 10/14 ĐƯỜNG LÊ VĂN VIỆT', '0936123876', N'Giám đốc')
GO

INSERT INTO TaiKhoan
VALUES('TK001','NV0001', 'admin', '1', 'Admin')
INSERT INTO TaiKhoan
VALUES('TK002','NV0002', 'manager', '1', 'Quanly')
INSERT INTO TaiKhoan
VALUES('TK003','NV0003', 'employee', '1', 'NhanVien')
--INSERT INTO TaiKhoan
--VALUES('TK004','NV0004', 'employee1', '1', 'NhanVien')
--GO

-- Insert Loai Phong
CREATE TABLE [dbo].[LoaiPhong] 
(
	[ma_loai_phong] CHAR(10) NOT NULL PRIMARY KEY,
	[loai_phong] BIT NOT NULL,
	[so_luong_thanh_vien] SMALLINT NOT NULL
)
GO

-- Insert Loai Phong
INSERT INTO [LoaiPhong] VALUES('LP0001', 0, 4)
INSERT INTO [LoaiPhong] VALUES('LP0002', 0, 8)
INSERT INTO [LoaiPhong] VALUES('LP0003', 1, 4)
INSERT INTO [LoaiPhong] VALUES('LP0004', 1, 8)
GO

-- Insert Phong
CREATE TABLE [dbo].[Phong]
(
	[ma_phong] CHAR(10) NOT NULL PRIMARY KEY, 
    [ma_nhan_vien] CHAR(10), 
    [tinh_trang_phong] NVARCHAR(50) NOT NULL, 
    [so_luong_sinh_vien_hien_tai] SMALLINT NOT NULL DEFAULT(0), 
    [ma_loai_phong] CHAR(10), 
    CONSTRAINT [FK_NhanVienQuanLyPhong] FOREIGN KEY ([ma_nhan_vien]) REFERENCES [NhanVien]([ma_nhan_vien])
	ON UPDATE CASCADE 
	ON DELETE SET NULL,
	 
    CONSTRAINT [FK_LoaiPhong] FOREIGN KEY ([ma_loai_phong]) REFERENCES [LoaiPhong]([ma_loai_phong])
	ON UPDATE CASCADE 
	ON DELETE SET NULL
)
GO

-- Insert Phong
INSERT INTO [dbo].[Phong] VALUES ('P101', 'NV0001', N'Tốt', 0, N'LP0003')
INSERT INTO [dbo].[Phong] VALUES ('P102', 'NV0001', N'Tốt', 0, N'LP0003')
INSERT INTO [dbo].[Phong] VALUES ('P103', 'NV0001', N'Tốt', 0, N'LP0003')
INSERT INTO [dbo].[Phong] VALUES ('P201', 'NV0002', N'Tốt', 0, N'LP0004')
INSERT INTO [dbo].[Phong] VALUES ('P202', 'NV0002', N'Tốt', 0, N'LP0004')
INSERT INTO [dbo].[Phong] VALUES ('P203', 'NV0002', N'Tốt', 0, N'LP0004')
INSERT INTO [dbo].[Phong] VALUES ('P301', 'NV0003', N'Tốt', 0, N'LP0001')
INSERT INTO [dbo].[Phong] VALUES ('P302', 'NV0003', N'Tốt', 0, N'LP0001')
INSERT INTO [dbo].[Phong] VALUES ('P303', 'NV0003', N'Tốt', 0, N'LP0002')
INSERT INTO [dbo].[Phong] VALUES ('P401', 'NV0004', N'Tốt', 0, N'LP0002')
GO

-- Sinh Vien
CREATE TABLE [dbo].[SinhVien]
(
	[ma_sinh_vien] CHAR(10) NOT NULL PRIMARY KEY, 
	[ma_phong] CHAR(10) NULL, 
    [ho_ten] NVARCHAR(50) NOT NULL, 
    [gioi_tinh] BIT NOT NULL, 
    [dia_chi] NVARCHAR(50) NOT NULL, 
    [cmnd] CHAR(12) NOT NULL UNIQUE, 
	[nien_khoa] SMALLINT NOT NULL,
    CONSTRAINT [FK_SinhVienThuocPhong] FOREIGN KEY ([ma_phong]) REFERENCES [Phong]([ma_phong])
	ON UPDATE CASCADE
	ON DELETE SET NULL
)
GO

-- [CREATE] [TRIGGER] (1)
/*
	- Khi insert sinh viên thì sẽ kiểm tra chỉ cho sinh viên nam ở phòng nam, sinh viên nữ
	ở phòng của nữ và số lượng sinh viên ở trong phòng thì phải nhỏ hơn số lượng tối đa của phòng đó 
	thì mới cho sinh viên đó vào ở phòng đó.
*/
CREATE TRIGGER tg_InsertSinhVien ON dbo.SinhVien FOR INSERT AS
	DECLARE 
		@ma_phong CHAR(10),
		@ma_loai_phong CHAR(10),
		@gioi_tinh BIT,
		@loai_phong BIT,
		@max_sinh_vien SMALLINT,
		@so_luong_sinh_vien_hien_tai SMALLINT

		-- Get ma phong
		SELECT 
			@ma_phong = ins.ma_phong,
			@gioi_tinh = ins.gioi_tinh 
		FROM inserted as ins

		-- Get so luong sinh vien hien tai, ma loai phong
		SELECT 
			@so_luong_sinh_vien_hien_tai = P.so_luong_sinh_vien_hien_tai,
			@ma_loai_phong = P.ma_loai_phong
		FROM Phong AS P WHERE P.ma_phong = @ma_phong

		SELECT 
			@max_sinh_vien = LP.so_luong_thanh_vien,
			@loai_phong = LP.loai_phong
		FROM LoaiPhong AS LP WHERE LP.ma_loai_phong = @ma_loai_phong

		SET IMPLICIT_TRANSACTIONS ON
		-- Handle
			IF (@gioi_tinh = @loai_phong AND @so_luong_sinh_vien_hien_tai < @max_sinh_vien)
				UPDATE Phong SET so_luong_sinh_vien_hien_tai = so_luong_sinh_vien_hien_tai + 1
				WHERE ma_phong = @ma_phong
			ELSE
				ROLLBACK
		--COMMIT TRANSACTION
GO

-- Insert Sinh Vien
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110001', 'P102', N'ĐOÀN THỊ ÁNH',1, N'SỐ 1 ĐƯỜNG LÊ VĂN VIỆT', '077203000478', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110010', 'P303', N'NGHUYỄN NGỌC TƯ', 0, N'SỐ 14/35 ĐƯỜNG NGUYỄN DUY TRINH', '077203000490', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110100', 'P303', N'NGUYỄN NGỌC THUẦN', 0, N'SỐ 20/268 ĐƯỜNG LÊ VĂN VIỆT', '077203000511', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110011', 'P301', N'NGUYỄN NHẬT ÁNH', 0, N'SỐ 13/160 ĐƯỜNG LÃ XUÂN OAI', '077203000744', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110110', 'P301', N'HUY CẬN', 0, N'SỐ 11 ĐƯỜNG VÕ VĂN NGÂN', '077203000345', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110111', 'P201', N'XUÂN QUỲNH', 1, N'SỐ 1/20 ĐƯỜNG ĐẶNG VĂN BI', '077203001012', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110002', 'P401', N'HÀN MẶC TỬ', 0, N'SỐ 12/6/160 ĐƯỜNG LÒ LU', '077203000110', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110020', 'P401', N'XUÂN DIỆU', 0, N'SỐ 33/1/6 ĐƯỜNG ĐÌNH PHONG PHÚ', '077203000332', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110200', 'P103', N'VŨ THỊ LIÊN', 1, N'SỐ 45/7 ĐƯỜNG NGUYỄN XIỂN', '077203001234', 2020)
INSERT INTO [dbo].[SinhVien] 
VALUES ('20110022', 'P401', N'THẾ LỮ', 0, N'SỐ 1/5/6 ĐƯỜNG TĂNG NHƠN PHÚ', '077203000466', 2020)
GO

CREATE TABLE [dbo].[HopDong]
(
	[ma_hop_dong] CHAR(10) NOT NULL PRIMARY KEY, 
    [ma_nhan_vien] CHAR(10) NULL, 
    [ma_sinh_vien] CHAR(10) NULL, 
    [ngay_dang_ky] DATE NOT NULL, 
    [ngay_bat_dau] DATE NOT NULL, 
    [ngay_ket_thuc] DATE NOT NULL, 
    CONSTRAINT [FK_NhanVienQuanLyHopDong] FOREIGN KEY ([ma_nhan_vien]) REFERENCES [NhanVien]([ma_nhan_vien])
	ON UPDATE CASCADE
	ON DELETE SET NULL, 
    CONSTRAINT [FK_SinhVienCoHopDong] FOREIGN KEY ([ma_sinh_vien]) REFERENCES [SinhVien]([ma_sinh_vien])
	ON DELETE SET NULL
)
GO

-- Insert Hop Dong
INSERT INTO [dbo].[HopDong] VALUES ('HD0001', 'NV0001', '20110001', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0002', 'NV0001', '20110200', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0003', 'NV0002', '20110111', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0004', 'NV0003', '20110010', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0005', 'NV0003', '20110100', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0006', 'NV0003', '20110011', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0007', 'NV0003', '20110110', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0008', 'NV0004', '20110002', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0009', 'NV0004', '20110020', '2020-08-10', '2020-08-26', '2021-06-30')
INSERT INTO [dbo].[HopDong] VALUES ('HD0010', 'NV0004', '20110022', '2020-08-10', '2020-08-26', '2021-06-30')
GO

-- Table Hoa Don => Hóa đơn hàng tháng khi sinh viên sử dụng điện, nước.
CREATE TABLE [dbo].[HoaDon]
(
	[ma_hoa_don] CHAR(10) NOT NULL PRIMARY KEY, 
    [ma_nhan_vien] CHAR(10) NULL, 
    [ma_phong] CHAR(10) NULL, 
    [so_m3_nuoc] REAL NOT NULL, 
    [so_cong_to_dien] REAL NOT NULL, 
    [thang_ghi_so] SMALLINT NOT NULL, 
    [tong_tien] REAL NOT NULL,
	CONSTRAINT [FK_NhanVienTaoHoaDon] FOREIGN KEY ([ma_nhan_vien]) REFERENCES [NhanVien]([ma_nhan_vien])
	ON UPDATE CASCADE
	ON DELETE SET NULL, 
    CONSTRAINT [FK_HoaDonThuocPhong] FOREIGN KEY ([ma_phong]) REFERENCES [Phong]([ma_phong])
	-- ON UPDATE CASCADE
	ON DELETE SET NULL
)
GO

-- [INSERT] [HoaDon]
INSERT INTO [dbo].[HoaDon] VALUES ('HD0001', 'NV0001', 'P102', 105, 130, 10, 0)
INSERT INTO [dbo].[HoaDon] VALUES ('HD0002', 'NV0002', 'P203', 104, 131, 10, 0)
INSERT INTO [dbo].[HoaDon] VALUES ('HD0003', 'NV0003', 'P303', 103, 132, 10, 0)
INSERT INTO [dbo].[HoaDon] VALUES ('HD0004', 'NV0004', 'P401', 102, 132, 10, 0)
GO

-- TABLE Bien Lai => Bien lai của sinh viên khi đăng ký KTX
CREATE TABLE [dbo].[BienLai]
(
	[ma_bien_lai] CHAR(10) NOT NULL PRIMARY KEY, 
    [ma_nhan_vien] CHAR(10) NULL, 
    [ma_phong] CHAR(10) NULL, 
    [nam_hoc] CHAR(50) NOT NULL, 
    [so_tien] REAL NOT NULL, 
    [ngay_thu] DATE NOT NULL, 
    [ma_sinh_vien] CHAR(10) NULL,
	CONSTRAINT [FK_NhanVienQuanLyBienLai] FOREIGN KEY ([ma_nhan_vien]) REFERENCES [NhanVien]([ma_nhan_vien])
	ON UPDATE CASCADE
	ON DELETE SET NULL, 
    CONSTRAINT [FK_SinhVienCoBienLai] FOREIGN KEY ([ma_sinh_vien]) REFERENCES [SinhVien]([ma_sinh_vien])
	-- ON UPDATE CASCADE
	ON DELETE SET NULL
	-- (3) [CREATE][TRIGGER] (Cần tạo trigger vì liên quan tới nhiều bảng, 
	-- Không thể SET UPDATE và SET DELETE)
	, 
    CONSTRAINT [FK_BienLaiThuocPhong] FOREIGN KEY ([ma_phong]) REFERENCES [Phong]([ma_phong])
	-- ON UPDATE CASCADE
	ON DELETE SET NULL
	-- (4) [CREATE][TRIGGER] (Cần tạo trigger vì liên quan tới nhiều bảng, 
	-- Không thể SET UPDATE và SET DELETE)
)
GO

-- Insert Bien Lai
INSERT INTO [dbo].[BienLai] VALUES ('BL0001', 'NV0001', 'P102', '2020', 0, '2020-08-15', '20110002')
INSERT INTO [dbo].[BienLai] VALUES ('BL0002', 'NV0001', 'P103', '2020', 0, '2020-08-15', '20110200')
INSERT INTO [dbo].[BienLai] VALUES ('BL0003', 'NV0002', 'P201', '2020', 0, '2020-08-15', '20110111')
INSERT INTO [dbo].[BienLai] VALUES ('BL0004', 'NV0003', 'P301', '2020', 0, '2020-08-15', '20110011')
GO

-- [CREATE][TRIGGERs]
/*
	(2): Trigger Khi INSERT [Phong] thì cần check xem số lượng sinh viên hiện tại < 
	số lương thành viên hay không. Nếu vi phạm thì rollback.
*/

CREATE TRIGGER tg_InsertPhongCoLoaiPhong ON [dbo].[Phong]
AFTER INSERT, UPDATE AS
	DECLARE 
		@so_luong_sinh_vien_hien_tai SMALLINT, 
		@ma_loai_phong CHAR(10),
		@so_luong_sv_max SMALLINT
	
	SELECT 
		@so_luong_sinh_vien_hien_tai = ins.so_luong_sinh_vien_hien_tai, 
		@ma_loai_phong = ins.ma_loai_phong 
	FROM inserted as ins

	SELECT 
		@so_luong_sv_max = so_luong_thanh_vien 
	FROM LoaiPhong AS LP WHERE LP.ma_loai_phong = @ma_loai_phong

	BEGIN TRAN INSERTPHONG
	IF(@so_luong_sinh_vien_hien_tai > @so_luong_sv_max)
		ROLLBACK
	COMMIT TRAN INSERTPHONG
GO

--(3)
-- Khi DELETE [SinhVien] thì cập nhật so_luong_sinh_vien_hien_tai ở Phong
CREATE TRIGGER tg_DeleteSinhVien ON dbo.SinhVien FOR DELETE AS
BEGIN
	DECLARE @maP CHAR(10), @so_luong_sv_hien_tai SMALLINT

	SELECT @maP = del.ma_phong FROM deleted as del
	SELECT @so_luong_sv_hien_tai = P.so_luong_sinh_vien_hien_tai FROM Phong AS P

	SET IMPLICIT_TRANSACTIONS ON
		IF(@so_luong_sv_hien_tai > 0)
			UPDATE dbo.Phong
			SET so_luong_sinh_vien_hien_tai = so_luong_sinh_vien_hien_tai - 1
			WHERE ma_phong = @maP
	--COMMIT TRAN
END
GO

--(4)
/*
Khi SinhVien chuyển phòng thì cập nhật lại so_luong_sinh_vien_hien_tai ở Phong cũ và phòng mới
*/
CREATE TRIGGER tg_UpdateSinhVien ON dbo.SinhVien FOR UPDATE AS
	DECLARE
		@ma_phong_cu CHAR(10),
		@ma_phong_moi CHAR(10),
		@gioi_tinh_sinh_vien_moi BIT,
		@gioi_tinh_sinh_vien_cu BIT,
		@loai_phong_moi BIT,
		@loai_phong_cu BIT,
		@ma_loai_phong_cu CHAR(10),
		@ma_loai_phong_moi CHAR(10),
		@max_sinh_vien_cu SMALLINT,
		@max_sinh_vien_moi SMALLINT,
		@so_luong_sinh_vien_hien_tai_o_phong_moi SMALLINT

	-- Get ma phong, gioi tinh
	SELECT 
		@ma_phong_moi = ins.ma_phong,
		@gioi_tinh_sinh_vien_moi = ins.gioi_tinh
	FROM inserted as ins 
	SELECT 
		@ma_phong_cu = del.ma_phong, 
		@gioi_tinh_sinh_vien_cu = del.gioi_tinh 
	FROM deleted AS del

	-- Get so luong thanh vien cu cua phong do
	SELECT 
		@max_sinh_vien_cu = LP.so_luong_thanh_vien
	FROM LoaiPhong AS LP 
	WHERE LP.ma_loai_phong = (SELECT DISTINCT ma_loai_phong FROM Phong AS P WHERE P.ma_phong = @ma_phong_cu)

	-- Get ma loai phong moi, so luong sinh vien hien tai
	SELECT 
		@ma_loai_phong_moi = P.ma_loai_phong,
		@so_luong_sinh_vien_hien_tai_o_phong_moi = P.so_luong_sinh_vien_hien_tai
	FROM Phong AS P WHERE P.ma_phong = @ma_phong_moi

	-- Get max so luong sinh vien cua phong do va lay ra phong do danh cho nam hay cho nu
	SELECT 
		@max_sinh_vien_moi = LP.so_luong_thanh_vien,
		@loai_phong_moi = LP.loai_phong
	FROM LoaiPhong AS LP WHERE LP.ma_loai_phong = @ma_loai_phong_moi

	-- Lấy mã loại phòng cũ
	SELECT 
		@ma_loai_phong_cu = P.ma_loai_phong
	FROM Phong AS P WHERE P.ma_phong = @ma_phong_cu

	-- Chỉ thay đổi giới tính phù hợp với loại phòng
	BEGIN TRAN
		IF ( @loai_phong_moi != @loai_phong_cu or @gioi_tinh_sinh_vien_moi != @loai_phong_moi or @max_sinh_vien_cu != @max_sinh_vien_moi )
			ROLLBACK
		ELSE 
			IF(@so_luong_sinh_vien_hien_tai_o_phong_moi < @max_sinh_vien_moi)
				BEGIN
					-- Update phong moi: So luong sinh vien se tang len 1
					UPDATE PHONG SET so_luong_sinh_vien_hien_tai = so_luong_sinh_vien_hien_tai + 1
					WHERE ma_phong = @ma_phong_moi
					-- Update phong cu: So luong sinh vien se bi giam xuong 1
					UPDATE PHONG SET so_luong_sinh_vien_hien_tai = so_luong_sinh_vien_hien_tai - 1
					WHERE ma_phong = @ma_phong_cu
				END
	COMMIT TRAN
GO

--(5)
-- Tính tổng tiền điện nước khi insert, update HoaDon
CREATE TRIGGER tg_CalcBill ON dbo.HoaDon AFTER INSERT, UPDATE AS
BEGIN
	DECLARE 
		@mahd CHAR(10), 
		@tong_tien REAL, 
		@so_m3_nuoc REAL,
		@so_cong_to_dien REAL
	SELECT 
		@mahd = ins.ma_hoa_don, 
		@so_m3_nuoc = ins.so_m3_nuoc,
		@so_cong_to_dien = ins.so_cong_to_dien
	FROM inserted as ins

	PRINT(@mahd)
	
	SET @tong_tien = @so_m3_nuoc * 4000 + @so_cong_to_dien * 3000

	SET IMPLICIT_TRANSACTIONS ON
		UPDATE dbo.HoaDon
		SET tong_tien = @tong_tien
		WHERE ma_hoa_don = @mahd
	--COMMIT TRAN
END
GO

-- [PROCEDUREs]
-- [INSERT][NhanVien]
CREATE PROC sp_InsertNhanVien 
	@ma_nv CHAR(10),
	@hoten_nv NVARCHAR(50),
	@gioitinh BIT,
	@diachi NVARCHAR(50),
	@sodienthoai CHAR(10),
	@chucvu NVARCHAR(50)
AS
BEGIN
	-- Thêm dữ liệu
    INSERT INTO dbo.NhanVien VALUES (@ma_nv, @hoten_nv, @gioitinh, @diachi, @sodienthoai, @chucvu)
END
GO

--[UPDATE]
CREATE PROC sp_UpdateNhanVien
	@ma_nv CHAR(10),
	@hoten_nv NVARCHAR(50),
	@gioitinh BIT,
	@diachi NVARCHAR(50),
	@sodienthoai CHAR(10),
	@chucvu NVARCHAR(50)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.NhanVien WHERE ma_nhan_vien = @ma_nv)
		RETURN 0
	--cập nhật dữ liệu
    UPDATE dbo.NhanVien
	SET
		ho_ten = @hoten_nv,
		gioi_tinh = @gioitinh,
		dia_chi = @diachi, 
		so_dien_thoai = @sodienthoai,
		chuc_vu = @chucvu
	WHERE ma_nhan_vien = @ma_nv
END
GO

-- [DELETE]
CREATE PROC sp_DeleteNhanVien
	@ma_nv CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.NhanVien WHERE ma_nhan_vien = @ma_nv)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.NhanVien 
	WHERE ma_nhan_vien = @ma_nv
END
GO

-- [Phong]
-- [INSERT]
--Bảng Phong
CREATE PROC sp_InsertPhong
	@ma_phong CHAR(10),
	@ma_nv CHAR(10),
	@tinhtrang_phong NVARCHAR(50),
	@soluongsinhvienhientai SMALLINT,
	@ma_loai_phong char(10)
AS
BEGIN
	-- Thêm dữ liệu
    INSERT INTO dbo.Phong 
	VALUES (@ma_phong, @ma_nv, @tinhtrang_phong, @soluongsinhvienhientai, @ma_loai_phong)
END
GO

-- [UPDATE]
CREATE PROC sp_UpdatePhong
	@ma_phong CHAR(10),
	@ma_nv CHAR(10),
	@tinhtrang_phong NVARCHAR(50),
	@soluongsinhvienhientai SMALLINT,
	@ma_loai_phong char(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.Phong WHERE ma_phong = @ma_phong)
		RETURN 0
	--cập nhật dữ liệu
    UPDATE dbo.Phong
	SET
		ma_nhan_vien = @ma_nv,
		tinh_trang_phong = @tinhtrang_phong,
		so_luong_sinh_vien_hien_tai = @soluongsinhvienhientai,
		ma_loai_phong = @ma_loai_phong
	WHERE ma_phong = @ma_phong
END
GO

-- [DELETE]
CREATE PROC sp_DeletePhong
	@ma_phong CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.Phong WHERE ma_phong = @ma_phong)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.Phong
	WHERE ma_phong = @ma_phong
END
GO
--[GetRoom]
Create proc prc_GetRoomById @ma_phong nvarchar(10)
as
	select ma_phong, ho_ten, tinh_trang_phong, ma_loai_phong from Phong, NhanVien
	where ma_phong = @ma_phong and Phong.ma_nhan_vien = NhanVien.ma_nhan_vien
Go
-- [SinhVien]
CREATE PROC sp_InsertSinhVien
	@ma_sv CHAR(10),
	@ma_phong CHAR(10),
	@hoten_sv NVARCHAR(50),
	@gioitinh BIT,
	@diachi NVARCHAR(50),
	@cccd CHAR(12),
	@nienkhoa SMALLINT
AS
BEGIN
	-- Thêm dữ liệu
    INSERT INTO dbo.SinhVien VALUES (@ma_sv, @ma_phong, @hoten_sv, @gioitinh, @diachi, @cccd, @nienkhoa)
END
GO

-- [UPDATE]
CREATE PROC sp_UpdateSinhVien
	@ma_sv CHAR(10),
	@ma_phong CHAR(10),
	@hoten_sv NVARCHAR(50),
	@gioitinh BIT,
	@diachi NVARCHAR(50),
	@cccd CHAR(12),
	@nienkhoa SMALLINT
AS
BEGIN
	-- Kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.SinhVien WHERE ma_sinh_vien = @ma_sv)
		RETURN 0
	-- Cập nhật dữ liệu
    UPDATE dbo.SinhVien
	SET 
		ma_phong = @ma_phong,
		ho_ten = @hoten_sv,
		gioi_tinh = @gioitinh,
		dia_chi = @diachi,
		cmnd = @cccd,
		nien_khoa = @nienkhoa
	WHERE ma_sinh_vien = @ma_sv
END
GO

-- [DELETE]
CREATE PROC sp_DeleteSinhVien
	@ma_sv CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.SinhVien WHERE ma_sinh_vien = @ma_sv)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.SinhVien
	WHERE ma_sinh_vien = @ma_sv
END
GO

-- [HopDong]
-- [INSERT]
CREATE PROC sp_InsertHopDong
	@ma_hd CHAR(10),
	@ma_nv CHAR(10),
	@ma_sv CHAR(10),
	@ngay_dangky DATE,
	@ngay_batdau DATE,
	@ngay_ketthuc DATE
AS
BEGIN
	-- Kiểm tra khoá chính đã tồn tại chưa
	IF EXISTS (SELECT * FROM dbo.HopDong WHERE ma_hop_dong = @ma_hd)
		RETURN 0
	-- Thêm dữ liệu
    INSERT INTO dbo.HopDong 
	VALUES (@ma_hd, @ma_nv, @ma_sv, @ngay_dangky, @ngay_batdau, @ngay_ketthuc)
END
GO

-- [UPDATE]
CREATE PROC sp_UpdateHopDong
	@ma_hd CHAR(10),
	@ma_nv CHAR(10),
	@ma_sv CHAR(10),
	@ngay_dangky DATE,
	@ngay_batdau DATE,
	@ngay_ketthuc DATE
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.HopDong WHERE ma_hop_dong = @ma_hd)
		RETURN 0
	--cập nhật dữ liệu
    UPDATE dbo.HopDong
	SET 
		ma_nhan_vien = @ma_nv,
		ma_sinh_vien = @ma_sv,
		ngay_dang_ky = @ngay_dangky,
		ngay_bat_dau = @ngay_batdau,
		ngay_ket_thuc = @ngay_ketthuc
	WHERE ma_hop_dong = @ma_hd
END
GO

-- [DELETE]
CREATE PROC sp_DeleteHopDong
	@ma_hd CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.HopDong WHERE ma_hop_dong = @ma_hd)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.HopDong
	WHERE ma_hop_dong = @ma_hd
END
GO


-- (9): Hoa Don, tinh tong tien hoa don
/*
	1 m^3 nước = 4000 VND
	1 kg điện = 3000 VND
*/
CREATE FUNCTION fn_TongTienHoaDon(@soM3Nuoc REAL, @soKgDien REAL)
RETURNS REAL 
AS
BEGIN
	RETURN @soM3Nuoc * 4000 + 	@soKgDien * 3000
END
GO

-- [HoaDon]
CREATE PROC sp_InsertHoaDon
	@ma_hd CHAR(10),
	@ma_nv CHAR(10),
	@ma_phong CHAR(10),
	@som3nuoc REAL,
	@socongtodien REAL,
	@thang_ghiso SMALLINT
--	@tongtien REAL
AS
BEGIN
	DECLARE @tongtien REAL
	SET @tongtien = dbo.fn_TongTienHoaDon(@som3nuoc, @socongtodien)
	-- Thêm dữ liệu
    INSERT INTO dbo.HoaDon 
	VALUES (@ma_hd, @ma_nv, @ma_phong, @som3nuoc, @socongtodien, @thang_ghiso, @tongtien)
END
GO

--[UPDATE]
CREATE PROC sp_UpdateHoaDon
	@ma_hd CHAR(10),
	@ma_nv CHAR(10),
	@ma_phong CHAR(10),
	@som3nuoc REAL,
	@socongtodien REAL,
	@thang_ghiso SMALLINT
	--@tongtien REAL
AS
BEGIN
	DECLARE @tongtien REAL
	SET @tongtien = dbo.fn_TongTienHoaDon(@som3nuoc, @socongtodien)
	-- Kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.HoaDon WHERE ma_hoa_don = @ma_hd)
		RETURN 0
	--cập nhật dữ liệu
    UPDATE dbo.HoaDon
	SET
		ma_nhan_vien = @ma_nv,
		ma_phong = @ma_phong,
		so_m3_nuoc = @som3nuoc,
		so_cong_to_dien = @socongtodien,
		thang_ghi_so = @thang_ghiso,
		tong_tien = @tongtien
	WHERE ma_hoa_don = @ma_hd
END
GO

-- [DELETE]
CREATE PROC sp_DeleteHoaDon
	@ma_hd CHAR(10)
AS
BEGIN
	-- Kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.HoaDon WHERE ma_hoa_don = @ma_hd)
		RETURN 0
	-- Xoá dữ liệu
    DELETE FROM dbo.HoaDon
	WHERE ma_hoa_don = @ma_hd
END
GO
-- (10): Bien Lai, tinh tong tien bien lai
/*
	Phòng 8 người: 1 tháng = 290,000 VND và được ở 9 tháng
	Phòng 4 người: 1 tháng = 320,000 VND và được ở 9 tháng
*/
CREATE FUNCTION fn_TongTienBienLai(@loaiPhong REAL)
RETURNS REAL AS
BEGIN
	DECLARE @Tong REAL
	SET @Tong = 0
	IF(@loaiPhong = 4)
		SET @Tong =  290000 * 9
	IF(@loaiPhong = 8)
		SET @Tong = 320000 * 9
	RETURN @Tong	
END
GO

-- [BienLai]
-- [INSERT]
CREATE PROC sp_InsertBienLai
	@bienlai CHAR(10),
	@ma_nv CHAR(10),
	@ma_phong CHAR(10),
	@nam_hoc CHAR(50),
	-- @sotien REAL,
	@ngaythu DATE,
	@ma_sv CHAR(10)
AS
BEGIN
	DECLARE 
		@sotien REAL, 
		@maLoaiPhong CHAR(10), 
		@soLuongThanhVienToiDa SMALLINT
	
	-- Get ma phong
	SELECT @maLoaiPhong = P.ma_loai_phong 
	FROM dbo.Phong AS P WHERE P.ma_phong = @ma_phong

	-- Get so luong thanh vien
	SELECT @soLuongThanhVienToiDa = LP.so_luong_thanh_vien
	FROM LoaiPhong AS LP 
	WHERE LP.ma_loai_phong = @maLoaiPhong

	-- Tinh tong tien bien lai
	SET @sotien = dbo.fn_TongTienBienLai(@soLuongThanhVienToiDa)
	--thêm dữ liệu
    INSERT INTO dbo.BienLai 
	VALUES (@bienlai, @ma_nv, @ma_phong, @nam_hoc, @sotien, @ngaythu, @ma_sv)
END
GO

-- drop proc sp_InsertBienLai

-- [UPDATE]
CREATE PROC sp_UpdateBienLai
	@bienlai CHAR(10),
	@ma_nv CHAR(10),
	@ma_phong CHAR(10),
	@nam_hoc CHAR(50),
	-- @sotien REAL,
	@ngaythu DATE,
	@ma_sv CHAR(10)
AS
BEGIN
    --kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.BienLai WHERE ma_bien_lai = @bienlai)
		RETURN 0

	DECLARE 
		@sotien REAL, 
		@maLoaiPhong CHAR(10), 
		@soLuongThanhVienToiDa SMALLINT

		-- Get ma phong
	SELECT @maLoaiPhong = P.ma_loai_phong 
	FROM dbo.Phong AS P WHERE P.ma_phong = @ma_phong

	-- Get so luong thanh vien
	SELECT @soLuongThanhVienToiDa = LP.so_luong_thanh_vien
	FROM LoaiPhong AS LP 
	WHERE LP.ma_loai_phong = @maLoaiPhong

	-- Tinh tong tien bien lai
	SET @sotien = dbo.fn_TongTienBienLai(@soLuongThanhVienToiDa)

	--cập nhật dữ liệu
	UPDATE dbo.BienLai
	SET 
		ma_nhan_vien = @ma_nv,
		ma_phong = @ma_phong,
		nam_hoc = @nam_hoc,
		so_tien = @sotien,
		ngay_thu = @ngaythu,
		ma_sinh_vien = @ma_sv
	WHERE ma_bien_lai = @bienlai
END
GO

-- DROP PROC sp_UpdateBienLai

-- [DELETE]
CREATE PROC sp_DeleteBienLai
	@bienlai CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.BienLai WHERE ma_bien_lai = @bienlai)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.BienLai
	WHERE ma_bien_lai = @bienlai
END
GO

--[TaiKhoan]
--[INSERT]
CREATE PROC sp_InsertTaiKhoan
	@ma_tai_khoan CHAR(10),
	@ma_nhan_vien CHAR(10),
	@ten_dang_nhap CHAR(255),
	@mat_khau CHAR(255),
	@role CHAR(50)
AS
BEGIN
    --thêm dữ liệu
	INSERT INTO dbo.TaiKhoan 
	VALUES (@ma_tai_khoan, @ma_nhan_vien, @ten_dang_nhap, @mat_khau, @role)
END
GO

--[UPDATE]
CREATE PROC sp_UpdateTaiKhoan
	@ma_tai_khoan CHAR(10),
	@ma_nhan_vien CHAR(10),
	@ten_dang_nhap CHAR(255),
	@mat_khau CHAR(255),
	@role CHAR(50)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.TaiKhoan WHERE ma_tai_khoan = @ma_tai_khoan)
		RETURN 0
    --cập nhật dữ liệu
	UPDATE dbo.TaiKhoan
	SET 
		ma_tai_khoan = @ma_tai_khoan,
		ma_nhan_vien = @ma_nhan_vien,
		ten_dang_nhap = @ten_dang_nhap,
		mat_khau = @mat_khau,
		role = @role
	WHERE ma_tai_khoan = @ma_tai_khoan
END
GO

--[REMOVE]
CREATE PROC sp_DeleteTaiKhoan
	@ma_tai_khoan CHAR(10)
AS
BEGIN
	--kiểm tra khoá chính đã tồn tại chưa
	IF NOT EXISTS (SELECT * FROM dbo.TaiKhoan WHERE ma_tai_khoan = @ma_tai_khoan)
		RETURN 0
	--xoá dữ liệu
    DELETE FROM dbo.TaiKhoan
	WHERE ma_tai_khoan = @ma_tai_khoan
END
GO

-- [FUNCTIONs]
-- (1): Get Nhan Vien
CREATE FUNCTION fn_GetNhanVien() 
RETURNS TABLE AS
	RETURN (SELECT * FROM NhanVien)
GO

-- (2): Get Phong
CREATE FUNCTION fn_GetPhong()
RETURNS TABLE AS
	RETURN (
		SELECT  
			ma_phong, 
			tinh_trang_phong, 
			so_luong_sinh_vien_hien_tai, 
			loai_phong, 
			so_luong_thanh_vien as so_luong_sinh_vien_toi_da,
			ho_ten as ho_ten_nhan_vien,
			so_dien_thoai as so_dien_thoai_nhan_vien,
			chuc_vu
		FROM Phong AS P, LoaiPhong AS LP, NhanVien AS NV
		WHERE 
			P.ma_loai_phong = LP.ma_loai_phong
			AND P.ma_nhan_vien = NV.ma_nhan_vien
	)
GO
-- (3): Get SinhVien
CREATE FUNCTION fn_GetSinhVien()
RETURNS TABLE AS
	RETURN (SELECT 
				ma_sinh_vien,
				ho_ten AS ho_ten_sinh_vien,
				gioi_tinh,
				dia_chi,
				cmnd, 
				nien_khoa,
				SV.ma_phong,
				so_luong_sinh_vien_hien_tai AS so_luong_sinh_vien_trong_phong
			FROM SinhVien AS SV, Phong AS P
			WHERE 
				SV.ma_phong = P.ma_phong
	)
GO

-- (4): HopDong
CREATE FUNCTION fn_GetHopDong()
RETURNS TABLE AS
	RETURN (SELECT 
				ma_hop_dong,
				ngay_dang_ky,
				ngay_bat_dau,
				ngay_ket_thuc,
				NV.ho_ten AS ho_ten_nhan_vien_quan_ly,
				SV.ho_ten AS ho_ten_sinh_vien,
				sv.ma_phong
			FROM HopDong AS HDG, SinhVien AS SV, NhanVien AS NV
			WHERE 
				HDG.ma_sinh_vien = SV.ma_sinh_vien
				AND HDG.ma_nhan_vien = NV.ma_nhan_vien
	)
GO

-- (5): HoaDon
CREATE FUNCTION fn_GetHoaDon()
RETURNS TABLE AS
	RETURN (SELECT 
				ma_hoa_don,
				ma_phong,
				so_m3_nuoc,
				so_cong_to_dien,
				thang_ghi_so,
				NV.ho_ten AS nguoi_lap_hoa_don,
				tong_tien
			FROM HoaDon AS HD, NhanVien AS NV
			WHERE HD.ma_nhan_vien = NV.ma_nhan_vien
		)
GO

-- (6): BienLai
CREATE FUNCTION fn_GetBienLai()
RETURNS TABLE AS
	RETURN (SELECT 
				ma_bien_lai,
				BL.ma_phong AS so_phong,
				nam_hoc,
				NV.ho_ten AS nguoi_tao_bien_lai,
				sv.ma_sinh_vien,
				SV.ho_ten AS ho_ten_sinh_vien,
				ngay_thu,
				so_tien
			FROM BienLai AS BL, Phong AS P, SinhVien AS SV, NhanVien AS NV
			WHERE 
				BL.ma_nhan_vien = NV.ma_nhan_vien 
				AND BL.ma_sinh_vien = SV.ma_sinh_vien
				AND BL.ma_phong = P.ma_phong
			)
GO
-- (7) Loại Phòng
CREATE FUNCTION fn_GetKindOfRoom()
RETURNS TABLE 
AS
	RETURN(SELECT * FROM LoaiPhong)			
GO

--(8): TaiKhoan
CREATE FUNCTION fn_GetTaiKhoan()
RETURNS TABLE AS
	RETURN (SELECT * FROM dbo.TaiKhoan AS TK)
GO

/*
DROP FUNCTION fn_TongTienBienLai
DROP FUNCTION fn_TongTienHoaDon

PRINT dbo.fn_TongTienHoaDon(1, 2)
PRINT dbo.fn_TongTienBienLai(4)
*/

-- [CREATE] [VIEWs]
-- 1. HoaDonCuaPhongTaoBoiNhanVien (Khi vào quản lý hóa đơn)
CREATE VIEW HoaDonCuaPhongTaoBoiNhanVien AS
	SELECT 
		NV.ma_nhan_vien,
		NV.ho_ten,
		NV.gioi_tinh,
		NV.dia_chi,
		NV.so_dien_thoai,
		NV.chuc_vu,
		HD.ma_hoa_don,
		HD.so_m3_nuoc,
		HD.so_cong_to_dien,
		HD.thang_ghi_so,
		HD.tong_tien,
		P.ma_phong
	FROM 
		[dbo].[NhanVien] AS NV,
		[dbo].[HoaDon] AS HD,
		[dbo].[Phong] AS P
	WHERE
		NV.ma_nhan_vien = HD.ma_nhan_vien
	AND
		HD.ma_phong = P.ma_phong
GO

-- 2. HopDongCuaSinhVienDuocTaoBoiNhanVien 
-- (Khi vào quản lý Hợp Đồng)
CREATE VIEW HopDongCuaSinhVienDuocTaoBoiNhanVien AS
	SELECT 
		HDG.ma_hop_dong,
		HDG.ngay_bat_dau,
		HDG.ngay_dang_ky,
		HDG.ngay_ket_thuc,
		SV.ma_sinh_vien,
		SV.ho_ten as ho_ten_SV,
		SV.nien_khoa,
		SV.gioi_tinh,
		NV.ma_nhan_vien,
		NV.ho_ten as ho_ten_NV,
		NV.so_dien_thoai
	FROM 
		[dbo].HopDong AS HDG,
		[dbo].[SinhVien] AS SV,
		[dbo].[NhanVien] AS NV
	WHERE
		HDG.ma_nhan_vien = NV.ma_nhan_vien
	AND
		HDG.ma_sinh_vien = SV.ma_sinh_vien
GO

-- 3. BienLaiOPhongCuaSinhVienDuocTaoBoiNhanVien 
-- (Khi vào quản lý biên lai)
CREATE VIEW BienLaiOPhongCuaSinhVienDuocTaoBoiNhanVien AS
	SELECT 
		BL.ma_bien_lai,
		BL.nam_hoc,
		BL.ngay_thu,
		BL.so_tien,
		NV.ho_ten as ho_ten_NV,
		P.ma_phong,
		SV.ho_ten as ho_ten_SV
	FROM
		[dbo].[BienLai] AS BL,
		[dbo].[Phong] AS P,
		[dbo].[SinhVien] AS SV,
		[dbo].[NhanVien] AS NV
	WHERE
		BL.ma_nhan_vien = NV.ma_nhan_vien
	AND
		BL.ma_phong = P.ma_phong
	AND
		BL.ma_sinh_vien = SV.ma_sinh_vien
GO

-- 4. PhongDuocTaoBoiNhanVien 
-- (Khi vào quản lý phòng)
CREATE VIEW PhongDuocTaoBoiNhanVien AS
	SELECT 
		P.ma_phong,
		LP.loai_phong AS loai_phong_danh_cho,
		LP.so_luong_thanh_vien AS so_luong_sinh_vien_toi_da,
		P.so_luong_sinh_vien_hien_tai,
		P.tinh_trang_phong,
		NV.ma_nhan_vien,
		NV.ho_ten,
		NV.chuc_vu,
		NV.so_dien_thoai
	FROM 
		[dbo].[Phong] AS P,
		[dbo].[NhanVien] AS NV,
		LoaiPhong AS LP
	WHERE
		P.ma_nhan_vien = NV.ma_nhan_vien
		AND P.ma_loai_phong = LP.ma_loai_phong
GO

-- Mỹ sửa lại thêm max số SV trong phòng
-- 5. SinhVienOPhong 
-- (Khi vào quản lý Sinh Viên)
CREATE VIEW SinhVienOPhong AS
	SELECT 
		SV.ma_sinh_vien,
		SV.ho_ten,
		SV.cmnd,
		SV.dia_chi,
		SV.gioi_tinh,
		SV.nien_khoa,
		P.ma_phong,
		P.so_luong_sinh_vien_hien_tai,
		LP.so_luong_thanh_vien AS so_luong_sinh_vien_toi_da
	FROM 
		[dbo].[Phong] as P,
		[dbo].[SinhVien] AS SV,
		[dbo].[LoaiPhong] AS LP

	WHERE
		SV.ma_phong = P.ma_phong and LP.ma_loai_phong = P.ma_loai_phong
GO

-- Phân Quyền
-- Tạo User Login
IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'admin')
BEGIN
    CREATE LOGIN [admin] WITH PASSWORD = N'1',
	DEFAULT_DATABASE = [QuanLyKyTucXaDB]
END
GO

-- Manager
IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'manager')
BEGIN
    CREATE LOGIN [manager] WITH PASSWORD = N'1',
	DEFAULT_DATABASE = [QuanLyKyTucXaDB]
END
GO

-- Employee
IF NOT EXISTS 
    (SELECT name  
     FROM master.sys.server_principals
     WHERE name = 'employee')
BEGIN
    CREATE LOGIN [employee] WITH PASSWORD = N'1',
	DEFAULT_DATABASE = [QuanLyKyTucXaDB]
END
GO

/*
CREATE LOGIN [admin] WITH PASSWORD ='1',
DEFAULT_DATABASE = [QuanLyKyTucXaDB]

CREATE LOGIN [manager] WITH PASSWORD ='1',
DEFAULT_DATABASE = [QuanLyKyTucXaDB]

CREATE LOGIN [employee] WITH PASSWORD ='1',
DEFAULT_DATABASE = [QuanLyKyTucXaDB]
Go
*/

-- Tạo User liên kết với User Login 
CREATE USER [admin] FOR LOGIN [admin]
GO

CREATE USER [manager] FOR LOGIN [manager]
GO

CREATE USER [employee] FOR LOGIN [employee]
GO

-- Tạo Role 
CREATE ROLE EmployeeFormRole
CREATE ROLE StudentFormRole
CREATE ROLE ContractFormRole
CREATE ROLE RoomFormRole
CREATE ROLE InvoiceFormRole
CREATE ROLE ReceiptFormRole
Go

-- Gắn Quyền Cho Role
--- Cấp quyền thêm xóa sửa Form Employee
GRANT EXEC ON [dbo].[sp_InsertNhanVien] to EmployeeFormRole
GRANT EXEC ON [dbo].[sp_UpdateNhanVien] to EmployeeFormRole
GRANT EXEC ON [dbo].[sp_DeleteNhanVien] to EmployeeFormRole
GO

--- Cấp thêm xóa sửa quyền Form Student
GRANT EXEC ON [dbo].[sp_InsertSinhVien] to StudentFormRole
GRANT EXEC ON [dbo].[sp_UpdateSinhVien] to StudentFormRole
GRANT EXEC ON [dbo].[sp_DeleteSinhVien] to StudentFormRole
GO

--- Cấp quyền thêm xóa sửa Form Contract
GRANT EXEC ON [dbo].[sp_InsertHopDong] to ContractFormRole
GRANT EXEC ON [dbo].[sp_UpdateHopDong] to ContractFormRole
GRANT EXEC ON [dbo].[sp_DeleteHopDong] to ContractFormRole
GO

--- Cấp quyền thêm xóa sữa Form Room
GRANT EXEC ON [dbo].[sp_InsertPhong] to RoomFormRole
GRANT EXEC ON [dbo].[sp_UpdatePhong] to RoomFormRole
GRANT EXEC ON [dbo].[sp_DeletePhong] to RoomFormRole
GO

--- Cấp quyền thêm xóa sửa Form Invoice
GRANT EXEC ON [dbo].[sp_InsertHoaDon] to InvoiceFormRole
GRANT EXEC ON [dbo].[sp_UpdateHoaDon] to InvoiceFormRole
GRANT EXEC ON [dbo].[sp_DeleteHoaDon] to InvoiceFormRole
Go

--- Cấp quyền thêm xóa sửa Form Receipt
GRANT EXEC ON [dbo].[sp_InsertBienLai] to ReceiptFormRole
GRANT EXEC ON [dbo].[sp_UpdateBienLai] to ReceiptFormRole
GRANT EXEC ON [dbo].[sp_DeleteBienLai] to ReceiptFormRole
Go

-- Cấp quyền truy cập bảng tài khoản cho 3 user
GRANT SELECT on [dbo].[fn_GetTaiKhoan] to [admin]
GRANT SELECT on [dbo].[fn_GetTaiKhoan] to [manager]
GRANT SELECT on [dbo].[fn_GetTaiKhoan] to [employee]
Go

-- Cấp quyền user admin với full quyền trên DB
exec sp_addrolemember [db_owner],'admin'
Go

-- Cấp quyền cho User manager có thể xem mọi form và được quyền chỉnh sửa form Employee
exec sp_addrolemember [db_datareader],'manager'
exec sp_addrolemember [EmployeeFormRole],'manager'
Go

-- Cấp quyền cho User employee có thể quyền xem tất cả form và chỉnh sửa tất cả form trừ form Employee
exec sp_addrolemember [db_datareader],'employee' 
exec sp_addrolemember [StudentFormRole],'employee'
exec sp_addrolemember [ContractFormRole],'employee'
exec sp_addrolemember [RoomFormRole],'employee'
exec sp_addrolemember [InvoiceFormRole],'employee'
exec sp_addrolemember [ReceiptFormRole],'employee'
GO
