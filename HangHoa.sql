
-- Bước 2: Tạo bảng tblChatlieu (Chất liệu)
CREATE TABLE tblChatlieu (
    Machatlieu NVARCHAR(50) PRIMARY KEY,
    Tenchatlieu NVARCHAR(100) NOT NULL
);
GO

-- Bước 3: Tạo bảng tblHang (Hàng hóa) có khóa ngoại liên kết với tblChatlieu
CREATE TABLE tblHang (
    Mahang NVARCHAR(50) PRIMARY KEY,
    Tenhang NVARCHAR(100) NOT NULL,
    Machatlieu NVARCHAR(50),
    Soluong INT,
    Dongianhap FLOAT,
    Dongiaban FLOAT,
    Anh NVARCHAR(255),
    Ghichu NVARCHAR(MAX),
    CONSTRAINT FK_Hang_Chatlieu FOREIGN KEY (Machatlieu) REFERENCES tblChatlieu(Machatlieu)
);
GO

-- Bước 4: Thêm dữ liệu mẫu vào tblChatlieu (3 chất liệu)[cite: 1]
INSERT INTO tblChatlieu (Machatlieu, Tenchatlieu) VALUES ('CL01', N'Gỗ tự nhiên');
INSERT INTO tblChatlieu (Machatlieu, Tenchatlieu) VALUES ('CL02', N'Nhựa cao cấp');
INSERT INTO tblChatlieu (Machatlieu, Tenchatlieu) VALUES ('CL03', N'Kim loại không gỉ');
GO

-- Bước 5: Thêm dữ liệu mẫu vào tblHang (10 mặt hàng)[cite: 1]
INSERT INTO tblHang (Mahang, Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, Ghichu) VALUES 
('H01', N'Bàn làm việc gỗ', 'CL01', 15, 1200000, 1500000, 'ban_go.jpg', N'Hàng bán chạy'),
('H02', N'Ghế xoay văn phòng', 'CL02', 30, 450000, 600000, 'ghe_nhua.jpg', N'Mẫu mới'),
('H03', N'Tủ đựng tài liệu sắt', 'CL03', 10, 2000000, 2500000, 'tu_sat.jpg', N'Bền chắc'),
('H04', N'Giường ngủ gỗ', 'CL01', 5, 3500000, 4200000, 'giuong_go.jpg', N'Hàng cồng kềnh'),
('H05', N'Kệ sách nhựa', 'CL02', 20, 250000, 350000, 'ke_nhua.jpg', N'Lắp ráp dễ dàng'),
('H06', N'Bàn ăn inox', 'CL03', 12, 1500000, 1800000, 'ban_inox.jpg', N'Chống gỉ sét'),
('H07', N'Ghế xếp nhựa', 'CL02', 50, 80000, 120000, 'ghe_xep.jpg', N'Tiện lợi'),
('H08', N'Tủ quần áo gỗ', 'CL01', 8, 4000000, 4900000, 'tu_go.jpg', N'Gỗ sồi'),
('H09', N'Thang nhôm rút', 'CL03', 15, 900000, 1150000, 'thang_nhom.jpg', N'Đa năng'),
('H10', N'Kệ giày nhựa', 'CL02', 25, 150000, 220000, 'ke_giay.jpg', N'Nhỏ gọn');
GO