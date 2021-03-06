create database QuanLyCuaHangGiay
go


use QuanLyCuaHangGiay
go

create table NHANVIEN
(	
	MaNV nvarchar(30) NOT NULL,
	TenNV nvarchar(50) NOT NULL,
	Gioitinh nvarchar(10) NOT NULL,
	DiaChi nvarchar(150) NOT NULL,
	NgaySinh DATE NOT NULL,
	DienThoai nvarchar(20) NOT NULL,
	TrangThai int NOT NULL, --1.hoatdong 0.khonghoatdong(đã xóa)
	constraint NHANVIEN_pk primary key(MaNV)
)
go


create table KHACHHANG
(
	MaKH nvarchar(30) NOT NULL,
	TenKH nvarchar(50) NOT NULL,
	DiaChi nvarchar(150) NOT NULL,
	DienThoai nvarchar(15) NOT NULL,
	TrangThai int NOT NULL,
	
	constraint KHACHHANG_pk primary key(MaKH)
)
go
create table SHOES
(
	MaShoes nvarchar (30) NOT NULL,
	TenShoes nvarchar (50) NOT NULL,
	MaChatLieu nvarchar (30) NOT NULL,
	MaNCC nvarchar(30) NOT NULL,
	DonGia float(53) not null,
	GhiChu nvarchar(250), 
	TrangThai int NOT NULL,
	constraint SHOES_pk primary key(MaShoes)
)
GO

create table HOADONBAN
(
	MaHD nvarchar(30) NOT NULL,
	MaNV nvarchar(30) NOT NULL,
	MaKH nvarchar(30) NOT NULL,
	NgayBan date NOT NULL,
	TongTien float(53) NOT NULL,
	GhiChu nvarchar(250),
	TrangThai int NOT NULL,
	constraint HOADONBAN_pk primary key(MaHD)
)
go
create table CHITIETHOADONBAN
(
	MaHD nvarchar(30) NOT NULL,
	MaShoes nvarchar(30) NOT NULL,
	SoLuong int NOT NULL,
	--DonGia float(53) NOT NULL,
	ThanhTien float(53) NOT NULL,
	GiamGia float(53) not null,
	TrangThai int NOT NULL ,
	constraint CHITIETHOADONBAN_pk primary key(MaHD,MaShoes)
)

create table NHACUNGCAP
(
	MaNCC nvarchar(30) NOT NULL,
	TenNCC nvarchar(50) NOT NULL,
	DiaChi nvarchar(150) not null,
	DienThoai nvarchar(20) not null,
	GhiChu nvarchar(250) not null,
	TrangThai int not null,
	constraint NHACUNGCAP_pk primary key(MaNCC)
	
)
create table HOADONNHAP
(
	MaHD nvarchar(30) not null,
	MaShoes nvarchar (30) NOT NULL,
	SoLuong int not null,
	NgayNhap datetime not null,
	MaNCC nvarchar(30) not null,
	MaNV nvarchar(30) NOT NULL,
	GiaNhap float(53) not null,
	ThanhTien float(53) not null,
	TrangThai int not null,
	
	constraint HOADONNHAP_pk primary key(MaHD)
)
go
create table CHATLIEU
(
	MaChatLieu nvarchar(30) NOT NULL,
	TenChatLieu nvarchar(50) NOT NULL,
	TrangThai int NOT NULL,
	constraint CHATLIEU_pk primary key (MaChatLieu)
)
go 



create table TAIKHOAN
(
	
	UserName nvarchar(50) not null,
	Pasword  nvarchar(10) NOT NULL,
	HoTen nvarchar(50) not null,
	Quyen int, /* 1 quan ly , 2 nhan vien kho 3 thu ngan*/
	TrangThai int not null, /* 1 HOAT DONG  0 KHOA  2 KO CO*/
	constraint TAIKHOAN_pk primary key(UserName)
	
)drop table TAIKHOAN
go



alter table SHOES
add foreign key (MaChatLieu) references CHATLIEU(MaChatLieu)

alter table HOADONBAN
add foreign key (MaNV) references NHANVIEN(MaNV)

alter table HOADONBAN
add foreign key (MaKH) references KHACHHANG(MaKH)  

alter table CHITIETHOADONBAN
add foreign key (MaHD) references HOADONBAN(MaHD)

alter table CHITIETHOADONBAN
add foreign key (MaShoes) references SHOES(MaShoes)

alter table HOADONNHAP
add foreign key(MaNV) references NHANVIEN(MaNV)

alter table HOADONNHAP
add foreign key (MaNCC) references NHACUNGCAP(MaNCC)  

alter table HOADONNHAP
add foreign key (MaShoes) references SHOES(MaShoes)

alter table SHOES
add foreign key(MaNCC) references NHACUNGCAP(MaNCC)


insert into NHANVIEN  values('NV001',N'Nguyễn Văn An',N'Nam',N'TPHCM','2/2/2000','0999999999',1)
insert into NHANVIEN  values('NV002',N'Nguyễn Hạnh An',N'Nữ',N'TPHCM','3/6/2000','0912345678',1)
insert into NHANVIEN  values('NV003',N'Nguyễn Văn Hiếu',N'Nam',N'Đồng Tháp','2/2/1990','0356999679',1)
insert into NHANVIEN  values('NV004',N'Lê Thị Hoài',N'Nữ',N'An Giang','9/2/2000','0936668829',1)
insert into NHANVIEN  values('NV005',N'Nguyễn Văn An',N'Nam',N'TPHCM','2/2/1980','0993336643',1)

insert into KHACHHANG values('KH01',N'Lê Triệu Long',N'Phú Yên','0356225229',1)
insert into KHACHHANG values('KH02',N'Lê Thanh Toàn',N'Hưng Yên','0356993366',1)
insert into KHACHHANG values('KH03',N'Bùi Mạnh Thường',N'Đồng Tháp','0912366146',1)
insert into KHACHHANG values('KH04',N'Nguyễn Văn Anh',N'An Giang','0759361455',1)
insert into KHACHHANG values('KH05',N'Nguyễn Tuấn Mạnh',N'TPHCM','0569932225',1)

insert into CHATLIEU values('CL01',N'PVC',1)
insert into CHATLIEU values('CL02',N'Cao Su',1)
insert into CHATLIEU values('CL03',N'Vải',1)
insert into CHATLIEU values('CL04',N'Da',1)

insert into NHACUNGCAP values('NCC01',N'Cty TNHH Giày Xuân Hạ ',N'50 Phan Huy Ích,Tân Bình,TPHCM','0969232323','',1)
insert into NHACUNGCAP values('NCC02',N'Cty TNHH Giày Tràng Tiền',N'77 M1,Bình Tân,TPHCM','0988696969','',1)
insert into NHACUNGCAP values('NCC03',N'Cty TNHH Duy Phong ',N'11 Nguyễn Thị Kiều,Quận 12,TPHCM','0968656464','',1)
insert into NHACUNGCAP values('NCC04',N'Cty TNHH Giày Việt ',N'99 Phan Văn Hớn,Bình Tân,TPHCM','0969955685','',1)

insert into SHOES values ('G001',N'Ananas Blue','CL03','NCC03',500000,N'Bảo quản nơi khô ráo',1)
insert into SHOES values ('G002',N'Giày Da SM','CL04','NCC02',650000,N'Bảo quản nơi khô ráo',1)
insert into SHOES values ('G003',N'Giày Bis','CL02','NCC01',300000,N'Bảo quản nơi khô ráo',1)
insert into SHOES values ('G004',N'Giày Thượng Đình ','CL03','NCC01',200000,N'Bảo quản nơi khô ráo',1)
insert into SHOES values ('G005',N'Shondo','CL04','NCC04',300000,N'Bảo quản nơi khô ráo',1)
insert into SHOES values ('G006',N'Giày Nhựa Hulen','CL01','NCC01',250000,N'Bảo quản nơi khô ráo',1)

insert into HOADONNHAP values('HDN001','G001',100,'02/28/2019','NCC03','NV001',300000,30000000,1)
insert into HOADONNHAP values('HDN002','G002',20,'02/06/2019','NCC02','NV001',400000,8000000,1)
insert into HOADONNHAP values('HDN003','G003',30,'02/23/2019','NCC01','NV001',200000,6000000,1)
insert into HOADONNHAP values('HDN004','G004',50,'02/22/2019','NCC01','NV001',100000,5000000,1)
insert into HOADONNHAP values('HDN005','G005',30,'02/20/2019','NCC04','NV001',200000,6000000,1)
insert into HOADONNHAP values('HDN006','G006',50,'02/12/2019','NCC01','NV001',200000,10000000,1)

insert into HOADONBAN values('HDB001','NV002','KH01','03/26/2019',300000,N'Bảo hành 3 tháng',1)
insert into HOADONBAN values('HDB002','NV003','KH02','03/22/2019',400000,N'Bảo hành 3 tháng',1)
insert into HOADONBAN values('HDB003','NV002','KH03','03/06/2019',600000,N'Bảo hành 3 tháng',1)
 

insert into CHITIETHOADONBAN values('HDB001','G001',1,500000,0,1)
insert into CHITIETHOADONBAN values('HDB002','G004',2,400000,0,1)
insert into CHITIETHOADONBAN values('HDB003','G005',2,600000,0,1)


insert into TAIKHOAN values('1','quanly','123456',N'Nguyễn Văn Học','0966666885',1,1)/*1 quan lý  2.nhan vien kho 3. thu ngân*/
insert into TAIKHOAN values('2','nhanvienkho','123456',N'Nguyễn Thái Hùng','0966666885',2,1)
insert into TAIKHOAN values('3','thungan','123456',N'Nguyễn Thị Lan Anh','0966666866',3,1)
--Thêm Nhân Viên
CREATE PROCEDURE sp_ThemNhanVien(@MaNV NVARCHAR(30),
	@TenNV NVARCHAR(50),
	@Gioitinh NVARCHAR(10),
	@Diachi NVARCHAR(150),
	@NgaySinh DATE,
	@DienThoai NVARCHAR(20),
	@TrangThai int)
AS
 INSERT [dbo].[NHANVIEN](MaNV,TenNV,Gioitinh,DiaChi,NgaySinh,DienThoai,TrangThai) VALUES(@MaNV,@TenNV,@Gioitinh,@DiaChi,@NgaySinh,@DienThoai,@TrangThai)
 /* Xoá Nhân Viên */
 CREATE PROCEDURE sp_XoaNhanVien(@MANV NVARCHAR(30))
 AS
	UPDATE [dbo].[NHANVIEN] SET TRANGTHAI = 0 WHERE MaNV = @MANV
	
--Xóa Khách hàng
 CREATE PROCEDURE sp_XoaKhachHang(@MaKH NVARCHAR(30))
 AS
	UPDATE [dbo].[KHACHHANG] SET TRANGTHAI = 0 WHERE MaKH = @MaKH
--Xóa Chất Liệu
 CREATE PROCEDURE sp_XoaChatLieu(@MaCL NVARCHAR(30))
 AS
	UPDATE [dbo].[CHATLIEU] SET TRANGTHAI = 0 WHERE MaChatLieu = @MaCL
--Xóa Nhà Cung Cấp
 CREATE PROCEDURE sp_XoaNhaCungCap(@MaNCC NVARCHAR(30))
 AS
	UPDATE [dbo].[NHACUNGCAP] SET TRANGTHAI = 0 WHERE MaNCC = @MaNCC
--xóa Shoes
CREATE PROCEDURE sp_XoaShoes(@MaShoes NVARCHAR(30))
 AS
	UPDATE [dbo].[SHOES] SET TRANGTHAI = 0 WHERE MaShoes = @MaShoes

	
	
-----------------------
CREATE PROCEDURE sp_TongTienHoaDon(@MaHD varchar(30))
AS
	SELECT SUM(ThanhTien)
	FROM CHITIETHOADONBAN
	WHERE MaHD=@MaHD
exec sp_TongTienHoaDon 'HDB001'

select SUM(ThanhTien) from CHITIETHOADONBAN ct where ct.MaHD='HDB001'

drop PROCEDURE sp_ThemNhanVien
