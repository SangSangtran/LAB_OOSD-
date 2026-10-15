-- Tạo 
CREATE DATABASE QuanLyDuLich;
GO
USE QuanLyDuLich;
GO

-- Bảng tour
CREATE TABLE tour (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ma_tour VARCHAR(50) NOT NULL,
    ten_tour NVARCHAR(255) NOT NULL,
    so_ngay INT,
    so_dem INT,
    don_gia DECIMAL(18,2)
);

-- Bảng diem_dung_chan
CREATE TABLE diem_dung_chan (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tour_id INT FOREIGN KEY REFERENCES tour(id),
    ten_diem NVARCHAR(255),
    phuong_tien NVARCHAR(100),
    co_an_uong BIT,
    co_khach_san BIT,
    loai_ks_sao INT
);

-- Bảng diem_tham_quan
CREATE TABLE diem_tham_quan (
    id INT IDENTITY(1,1) PRIMARY KEY,
    dung_chan_id INT FOREIGN KEY REFERENCES diem_dung_chan(id),
    ma_dtq VARCHAR(50),
    ten_dtq NVARCHAR(255),
    noi_dung NVARCHAR(MAX),
    y_nghia NVARCHAR(MAX)
);

-- Bảng chuyen_di 
CREATE TABLE chuyen_di (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tour_id INT FOREIGN KEY REFERENCES tour(id),
    ngay_di DATE,
    ngay_ve DATE,
    so_cho_trong INT
);

-- Bảng khach_hang
CREATE TABLE khach_hang (
    id INT IDENTITY(1,1) PRIMARY KEY,
    loai_khach NVARCHAR(50), -- 'Doan' hoặc 'Le'
    ten_dai_dien NVARCHAR(255),
    dia_chi NVARCHAR(255),
    dien_thoai VARCHAR(20),
    so_nguoi INT,
    ds_bao_hiem NVARCHAR(MAX)
);

-- Bảng phieu_dang_ky
CREATE TABLE phieu_dang_ky (
    id INT IDENTITY(1,1) PRIMARY KEY,
    khach_hang_id INT FOREIGN KEY REFERENCES khach_hang(id),
    tour_id INT FOREIGN KEY REFERENCES tour(id), -- Có data nếu là khách đoàn
    chuyen_di_id INT FOREIGN KEY REFERENCES chuyen_di(id), -- Có data nếu là khách lẻ
    so_luong INT,
    tien_coc DECIMAL(18,2),
    trang_thai NVARCHAR(50)
);

-- Bảng nhan_vien_hdv
CREATE TABLE nhan_vien_hdv (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ma_hdv VARCHAR(50) NOT NULL,
    ho_ten NVARCHAR(255),
    luong_co_ban DECIMAL(18,2)
);

-- Bảng phan_cong_hdv
CREATE TABLE phan_cong_hdv (
    id INT IDENTITY(1,1) PRIMARY KEY,
    hdv_id INT FOREIGN KEY REFERENCES nhan_vien_hdv(id),
    phieu_dang_ky_id INT FOREIGN KEY REFERENCES phieu_dang_ky(id),
    tien_luong_tour DECIMAL(18,2)
);
GO