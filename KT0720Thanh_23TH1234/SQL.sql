CREATE DATABASE KT0720_23TH1234
GO
USE KT0720_23TH1234
GO
CREATE TABLE Lop
(
	MaLop nvarchar (10) PRIMARY KEY,
	TenLop nvarchar(50)
)
GO
CREATE TABLE SinhVien
(
	MaSV char(8) PRIMARY KEY,
	HoSV nvarchar (40),
	TenSV nvarchar(10),
	NgaySinh date,
	GioiTinh bit,
	AnhSV nvarchar(50),
	DiaChi nvarchar(70),
	MaLop nvarchar(10) FOREIGN KEY REFERENCES Lop(MaLop)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
INSERT INTO Lop VALUES('66.CNTT-1',N'CNTT khóa 66'),('66.TTQL-1',N'Hệ thống thông tin quản lý khóa 66')
GO
INSERT INTO SinhVien VALUES('66130123',N'Bùi Chí',N'Thành','12/11/1979',1,'661301234.png',N'Nha Trang, Khánh Hòa','66.CNTT-1'),
('66130124',N'Nguyễn Lê',N'Mai','12/11/2006',1,'661301235.png',N'Nha Trang, Khánh Hòa','66.TTQL-1')