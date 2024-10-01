-- Tạo CSDL
CREATE DATABASE QLNV_23TH2525;

-- Sử dụng CSDL vừa tạo
USE QLNV_23TH2525;

-- Tạo bảng Phòng Ban
CREATE TABLE PhongBan (
    MaPB INT PRIMARY KEY,
    TenPB NVARCHAR(100)
);

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    HoNV NVARCHAR(50),
    TenNV NVARCHAR(50),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    Luong DECIMAL(10,2),
    AnhNV NVARCHAR(MAX),
    DiaChi NVARCHAR(255),
    MaPB INT,
    FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB)
);
-- Thêm dữ liệu vào bảng PhongBan
INSERT INTO PhongBan (MaPB, TenPB)
VALUES 
(1, 'Phòng Kế toán'),
(2, 'Phòng Nhân sự'),
(3, 'Phòng IT');
-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, HoNV, TenNV, GioiTinh, NgaySinh, Luong, AnhNV, DiaChi, MaPB)
VALUES 
(1, 'Nguyễn', 'Văn A', 'Nam', '1990-01-15', 15000000, 'anhA.jpg', 'Hà Nội', 1),
(2, 'Trần', 'Thị B', 'Nữ', '1992-03-22', 12000000, 'anhB.jpg', 'Đà Nẵng', 2),
(3, 'Lê', 'Minh C', 'Nam', '1988-07-10', 20000000, 'anhC.jpg', 'TP. HCM', 3);
