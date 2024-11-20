-- Tạo bảng Sản phẩm
CREATE DATABASE MobileShop
CREATE TABLE SanPham (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenSP NVARCHAR(100) NOT NULL,
    Gia DECIMAL(18,2) NOT NULL,
    HangSX NVARCHAR(100)
);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    SDT NVARCHAR(15)
);

-- Tạo bảng Đơn hàng
CREATE TABLE DonHang (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KhachHangId INT NOT NULL,
    SanPhamId INT NOT NULL,
    SoLuong INT NOT NULL,
    NgayMua DATE NOT NULL,
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (KhachHangId) REFERENCES KhachHang(Id),
    CONSTRAINT FK_DonHang_SanPham FOREIGN KEY (SanPhamId) REFERENCES SanPham(Id)
);
ALTER TABLE DonHang
ADD CONSTRAINT DF_DonHang_NgayMua DEFAULT GETDATE() FOR NgayMua;


-- Tạo bảng Người dùng
CREATE TABLE NguoiDung (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL
);

INSERT INTO NguoiDung(TenDangNhap, MatKhau)
VALUES('admin','1234')

INSERT INTO KhachHang (TenKH, DiaChi, SDT)
VALUES 
('Nguyen Van A', '123 Đường ABC, Hà Nội', '0987654321'),
('Tran Thi B', '456 Đường DEF, Đà Nẵng', '0912345678'),
('Le Van C', '789 Đường GHI, TP.HCM', '0901234567'),
('Pham Thi D', '321 Đường JKL, Huế', '0934567890'),
('Nguyen Van E', '654 Đường MNO, Hải Phòng', '0967890123');

INSERT INTO SanPham (TenSP, Gia, HangSX)
VALUES 
('Laptop Dell XPS 13', 35000000, 'Dell'),
('iPhone 15 Pro Max', 45000000, 'Apple'),
('Samsung Galaxy S23 Ultra', 38000000, 'Samsung'),
('Tai nghe Sony WH-1000XM5', 8000000, 'Sony'),
('Đồng hồ Apple Watch Series 9', 12000000, 'Apple');
INSERT INTO DonHang (KhachHangId, SanPhamId, SoLuong)
VALUES 
(1, 2, 1), -- Khách hàng 1 mua iPhone 15 Pro Max
(2, 3, 2), -- Khách hàng 2 mua 2 chiếc Samsung Galaxy S23 Ultra
(3, 1, 1), -- Khách hàng 3 mua 1 Laptop Dell XPS 13
(4, 5, 3), -- Khách hàng 4 mua 3 chiếc Apple Watch Series 9
(5, 4, 1); -- Khách hàng 5 mua 1 tai nghe Sony WH-1000XM5
SELECT * FROM SANPHAM
