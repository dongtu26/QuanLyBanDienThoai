-- Tạo database
CREATE DATABASE QuanLyBanDienThoai;
go
-- Bảng DienThoai
CREATE TABLE DienThoai (
    MaDT INT IDENTITY(1,1) PRIMARY KEY,
    TenDT NVARCHAR(100),
    HangSX NVARCHAR(50),
    CauHinh NVARCHAR(255),
    SoLuong INT,
    GiaBan DECIMAL(18, 2)
);
-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100),
    SDT VARCHAR(15),
    DiaChi NVARCHAR(255)
);
-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100),
    SDT VARCHAR(15),
    ChucVu NVARCHAR(50)
);
-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATE,
    MaKH INT,
    MaNV INT,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
-- Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD INT,
    MaDT INT,
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    PRIMARY KEY (MaHD, MaDT),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaDT) REFERENCES DienThoai(MaDT)
);
CREATE TABLE PhieuBaoHanh (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT,
    MaDT INT,
    NgayBH DATE,
    HanBH INT, -- số tháng bảo hành
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaDT) REFERENCES DienThoai(MaDT)
);
CREATE TABLE BaoHanh (
    MaBH INT IDENTITY(1,1) PRIMARY KEY,
    MaDT INT, -- mã điện thoại
    Serial VARCHAR(50),
    NgayMua DATE,
    HanBaoHanh INT, -- số tháng
    FOREIGN KEY (MaDT) REFERENCES DienThoai(MaDT)
);
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(50),
    Quyen NVARCHAR(20) -- Ví dụ: Admin, NhanVien
);
go
INSERT INTO DienThoai (TenDT, HangSX, CauHinh, SoLuong, GiaBan)
VALUES
(N'iPhone 14 Pro Max', N'Apple', N'A16 Bionic, 6GB RAM, 256GB', 10, 32990000),
(N'Galaxy S23 Ultra', N'Samsung', N'Snapdragon 8 Gen 2, 8GB RAM, 256GB', 8, 29990000),
(N'Xiaomi 13 Pro', N'Xiaomi', N'SD8 Gen2, 12GB RAM, 256GB', 15, 21990000),
(N'OPPO Reno10', N'OPPO', N'MediaTek Dimensity, 8GB RAM, 128GB', 20, 10990000),
(N'Vivo V27e', N'Vivo', N'Helio G99, 8GB RAM, 128GB', 25, 8490000);
go
INSERT INTO KhachHang (TenKH, SDT, DiaChi)
VALUES
(N'Nguyễn Văn A', '0912345678', N'Hà Nội'),
(N'Trần Thị B', '0987654321', N'Hải Phòng'),
(N'Lê Văn C', '0909090909', N'Đà Nẵng'),
(N'Phạm Thị D', '0933221144', N'TP Hồ Chí Minh'),
(N'Bùi Minh E', '0922334455', N'Nghệ An');
go
INSERT INTO NhanVien (TenNV, SDT, ChucVu)
VALUES
(N'Ngô Văn Tùng', '0911222333', N'Bán hàng'),
(N'Hoàng Thị Mai', '0944556677', N'Bán hàng'),
(N'Phạm Văn An', '0977889900', N'Admin'),
(N'Lê Thị Hòa', '0966554433', N'Quản lý'),
(N'Vũ Đức Cường', '0955667788', N'Bán hàng');
go
INSERT INTO HoaDon (NgayLap, MaKH, MaNV)
VALUES
('2025-05-01', 1, 1),
('2025-05-01', 2, 2),
('2025-05-02', 3, 3),
('2025-05-02', 4, 1),
('2025-05-03', 5, 2);
go
INSERT INTO ChiTietHoaDon (MaHD, MaDT, SoLuong, DonGia)
VALUES
(1, 1, 1, 32990000),
(2, 2, 1, 29990000),
(3, 3, 2, 21990000),
(4, 5, 3, 8490000),
(5, 4, 1, 10990000);
go
-- Thêm tài khoản mẫu
INSERT INTO TaiKhoan VALUES ('admin', '123', N'Admin');
INSERT INTO TaiKhoan VALUES ('nhanvien', '456', N'NhanVien');

