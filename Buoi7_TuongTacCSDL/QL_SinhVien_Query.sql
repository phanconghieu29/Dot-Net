CREATE DATABASE QL_SinhVien
GO

USE QL_SinhVien
GO

CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(50)
);

-- Tạo bảng Lop với khóa ngoại MaKhoa tham chiếu đến bảng Khoa
CREATE TABLE Lop (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(15),
    MaKhoa VARCHAR(10),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Tạo bảng SinhVien với khóa ngoại MaLop tham chiếu đến bảng Lop
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(30),
    NgaySinh DATE,
    MaLop VARCHAR(10),
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

-- Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(50)
);

-- Tạo bảng Diem với khóa ngoại MaSinhVien và MaMonHoc tham chiếu đến bảng SinhVien và MonHoc
CREATE TABLE Diem (
    MaSinhVien VARCHAR(10),
    MaMonHoc VARCHAR(10),
    Diem FLOAT,
    PRIMARY KEY (MaSinhVien, MaMonHoc),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);
GO

-- Gán giá trị cho bảng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES
    ('K001', N'Khoa Công nghệ thông tin'),
    ('K002', N'Khoa Công nghệ thực phẩm'),
    ('K003', N'Khoa Ngoại ngữ');

-- Gán giá trị cho bảng Lop
INSERT INTO Lop (MaLop, TenLop, MaKhoa)
VALUES
    ('L001', '12DHTH01', 'K001'),
    ('L002', '12DHTH03', 'K001'),
    ('L003', '12DHTP05', 'K002');

-- Gán giá trị cho bảng SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop)
VALUES
    ('2001215781', N'Phan Công Hiệu', '2003-03-29', 'L001'),
    ('2030123981', N'Trần Thị B', '2003-02-15', 'L001'),
    ('2007978921', N'Lê Văn C', '2003-05-20', 'L002');

-- Gán giá trị cho bảng MonHoc
INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
VALUES
    ('MH001', N'Lập trình hướng đối tượng'),
    ('MH002', N'Cơ sở dữ liệu'),
    ('MH003', N'Công nghệ .NET');

SELECT * FROM Lop
GO

CREATE PROC sp_QueryAllKhoa As
	BEGIN
		Select * From KHOA
	END

GO
CREATE PROC sp_InsertLop(@Malop nchar(10), @Tenlop nvarchar(15), @Makh nchar(10)) AS
	BEGIN
		INSERT INTO  LOP Values(@Malop, @Tenlop, @Makh)
	END
GO


CREATE PROC sp_QueryLopWhereMakh(@Makh nchar(10)) AS
	BEGIN
		Select Malop, Tenlop
		From LOP
		Where Makhoa = @Makh
	END