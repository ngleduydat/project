CREATE DATABASE DB_QuanLyHoatDong
GO
--s? d?ng DB
USE DB_QuanLyHoatDong
GO

--t?o b?ng
CREATE TABLE PhongBan 
(
	MaPhongBan				INT				NOT NULL PRIMARY KEY,
	TenPhongBan				NVARCHAR(50)	NOT NULL,
	SoluongNhanVien			INT				NOT NULL
)
GO

CREATE TABLE ChucVu
(
	MaCV					INT				NOT NULL PRIMARY KEY,
	TenCV					NVARCHAR(50)	NOT NULL
)
GO

CREATE TABLE QuyDinh
(
	MaQD					INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TenQD					NVARCHAR(50)	NOT NULL,
	NoidungQD				TEXT			NOT NULL,
	NgayCapNhat				DATE			
)
GO

CREATE TABLE LinhVuc
(
	MaLinhVuc				INT				NOT NULL PRIMARY KEY,
	TenLinhVuc				NVARCHAR(50)	NOT NULL
)
GO

CREATE TABLE ToChuc
(
	MaToChuc				CHAR(5) 		NOT NULL PRIMARY KEY,
	TenToChuc				NVARCHAR(50)	NOT NULL,
)
GO

CREATE TABLE NhanVien
(
	id_nhanvien				INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MSNV					INT				NOT NULL,
	HoTen					NVARCHAR(100)	NOT NULL,
	GioiTinh				NVARCHAR(10)	NOT NULL,
	NgaySinh				DATE			NOT NULL,
	DanToc					NVARCHAR(15)	NOT NULL,
	TonGiao					NVARCHAR(15)	NOT NULL,
	SoDienThoai				CHAR(10)		NOT NULL,
	Email					CHAR(100)		NOT NULL,
	CCCD					CHAR(12)		NOT NULL,
	NgayLamViec				DATE			NOT NULL,
	MaPhongBan				INT				NOT NULL FOREIGN KEY REFERENCES dbo.PhongBan (MaPhongBan),
	MaCV					INT				NOT NULL FOREIGN KEY REFERENCES dbo.ChucVu (MaCV),
)
GO

CREATE TABLE SinhVien
(
	id_sinhvien				INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MSSV					INT				NOT NULL,
	HoTen					NVARCHAR(100)	NOT NULL,
	GioiTinh				NVARCHAR(10)	NOT NULL,
	NgaySinh				DATE			NOT NULL,
	DanToc					NVARCHAR(15)	NOT NULL,
	TonGiao					NVARCHAR(15)	NOT NULL,
	SoDienThoai				CHAR(10)		NOT NULL,
	Email					CHAR(100)		NOT NULL,
	CCCD					CHAR(12)		NOT NULL,
	NganhHoc				NVARCHAR(50)	NOT NULL,
	Lop						CHAR(10)		NOT NULL,
	Khoahoc					INT				NOT NULL
)
GO


CREATE TABLE BanToChuc
(
	id_bantochuc			INT					IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MaBTC					INT					NOT NULL,
	TenBTC					NVARCHAR(50)		NOT NULL,
	EmailBTC				CHAR(100)			NOT NULL,
	-- M? L?NH V?C KHÓA NGO?I
	MaToChuc				CHAR(5)				NOT NULL FOREIGN KEY REFERENCES dbo.ToChuc (MaToChuc)

)
GO

CREATE TABLE DonViQuanLy
(
	id_dvql					INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MaDVQL					INT				NOT NULL,
	TenDVQL					NVARCHAR(50)	NOT NULL,
	--M? T? CH?C KHÓA NGO?I
	MaToChuc				CHAR(5)			NOT NULL FOREIGN KEY REFERENCES dbo.ToChuc(MaToChuc)
)
GO

CREATE TABLE TaiKhoan
(
	MaTK					INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TenDangNhap				Char (50)		NOT NULL,
	MatKhau					Char (30)		NOT NULL,
	LoaiTK					Nvarchar (50)	NOT NULL,
	MSSV					Int				FOREIGN KEY (MSSV) REFERENCES dbo.SinhVien(id_sinhvien),
	MaBTC					INT				FOREIGN KEY (MaBTC) REFERENCES dbo.BanToChuc(id_bantochuc),
	MaDVQL					INT				FOREIGN KEY (MaDVQL) REFERENCES dbo.DonViQuanLy(id_dvql),
	MSNV					Int				FOREIGN KEY (MSNV) REFERENCES dbo.NhanVien(id_nhanvien)
)
GO

CREATE TABLE HoatDong
(
	id_hoatdong				INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	MaHD					INT				NOT NULL,
	TenHD					NVARCHAR(50)	NOT NULL,
	SoLuongSVmax			Int				NOT NULL,
	SoluongSV				Int				NOT NULL,
	NgayBD					Date			NOT NULL, 
	NgayKT					Date			NOT NULL,
	DiaDiem					NVARCHAR(15)	NOT NULL,
	LePhi					DECIMAL(19,4)	NOT NULL,
	MaLinhVuc				INT				NOT NULL FOREIGN KEY REFERENCES dbo.LinhVuc (MaLinhVuc),
	MaBTC					INT		NOT NULL FOREIGN KEY (MaBTC) REFERENCES dbo.BanToChuc(id_bantochuc)
	)
GO

CREATE TABLE PhieuDangKyThamGiaHoatDong
(
	MaPDKTGHD				INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TenPDKTGHD				NVARCHAR(50)	NOT NULL,
	MSSV					INT				NOT NULL FOREIGN KEY (MSSV) REFERENCES dbo.SinhVien(id_sinhvien),
)
GO

CREATE TABLE PhieuDangKyToChucHoatDong
(
	MaPDKTCHD				INT				IDENTITY(1,1) NOT NULL PRIMARY KEY,
	SoHDHienTai				Int				NOT NULL,
	SoHDDangKy				Int				NOT NULL,
	MaBTC					INT				NOT NULL FOREIGN KEY (MaBTC) REFERENCES dbo.BanToChuc(id_bantochuc)
)
GO



-- Thêm dữ liệu vào SQL
--Bảng Sinh viên
INSERT INTO dbo.SinhVien ([MSSV], [HoTen], [GioiTinh], [NgaySinh], [DanToc], [TonGiao], [SoDienThoai], [Email], [CCCD], [NganhHoc], [Lop], [Khoahoc]) VALUES
('100001',N'Trương Thị Hạnh',N'Nữ','20020413',N'Kinh',N'Thiên Chúa Giáo','0948674965','hanhtruong.100001@ueh.edu.vn','138564123456',N'Quản trị kinh doanh	','	AD001',46),
('100002',N'Lê Đức Minh',N'Nam','20030109',N'Kinh',N'Phật Giáo ','0374562931','minhle.100002@ueh.edu.vn','134567821344',N'Tài chính','FN001',47),
('100003',N'Huỳnh Thị Hương',N'Nữ','20040503',N'Kinh',N'Không	','0583946274','huonghuynh.100003@ueh.edu.vn','132464738382',N'Công nghệ phần mềm','ST001',48),
('100004',N'Văn Bang',N'Nam','20050305',N'Kinh',N'Không','0989876594','bangvan.100004@ueh.edu.vn','137584930798',N'Khoa học dữ liệu','DA001',49);
--Bảng Chức vụ
INSERT INTO dbo.ChucVu ([MaCV], [TenCV]) VALUES
(001, N'Nhân viên kỹ thuật')
--Bảng Phòng ban
INSERT INTO dbo.PhongBan([MaPhongBan],[TenPhongBan],[SoluongNhanVien]) VALUES
(01,N'Phòng Công nghệ thông tin',10)
--Bảng Nhân viên
INSERT INTO dbo.NhanVien
([MSNV],[HoTen],[GioiTinh],[NgaySinh],[DanToc],[TonGiao],[SoDienThoai],[Email],[CCCD],[NgayLamViec],[MaPhongBan],[MaCV]) VALUES
(200001, N'Võ Văn',N'Nam','19800101',N'Kinh',N'Không','0958765978','vanvo@it.ueh.edu.vn','193847563012','20050912',01,001)
--Bảng Tổ chức
INSERT INTO dbo.ToChuc ([MaToChuc],[TenToChuc]) VALUES
('D',N'Đoàn'),
('H',N'Hội Sinh Viên')
--Bảng Ban Tổ chức
INSERT INTO  dbo.BanToChuc ([MaBTC],[TenBTC],[EmailBTC],[MaToChuc]) VALUES
('300001',N'CLB Chuyện To Nhỏ','chuyentonho@ueh.edu.vn','D'),
('300002',N'Đội Công Tác Xã Hội','ctxh@ueh.edu.vn','D'),
('300003',N'Nhóm Hỗ Trợ Sinh Viên','ssg@ueh.edu.vn','D'),
('300004',N'KTX 43-45','ktx4345@ueh.edu.vn','H'),
('300005',N'KTX 135A','ktx135a@ueh.edu.vn','H')
--Bảng Đơn vị quản lý
INSERT INTO dbo.DonViQuanLy ([MaDVQL],[TenDVQL],[MaToChuc]) VALUES
('400001',N'Đoàn Thanh Niên','D'),
('400002',N'Hội Sinh Viên','H'),
('400003',N'Phòng Chăm Sóc và Hỗ trợ người học','D'),
('400004',N'Phòng Đào Tạo','D')

--Bảng Tài khoản
INSERT INTO dbo.TaiKhoan ([TenDangNhap],[MatKhau],[LoaiTK],[MSSV],[MaBTC],[MaDVQL],[MSNV]) VALUES
('sinhvien01','123456',N'Sinh Viên',1,NULL,NULL,NULL),
('admin01','123456',N'Admin',NULL,NULL,NULL,1),
('doanthanhnien','123456',N'Đơn Vị Quản Lý',NULL,NULL,1,NULL),
('chuyentonho@ueh.edu.vn','123456',N'Ban Tổ Chức',NULL,1,NULL,NULL)

