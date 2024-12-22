use master
create database QLCTV
use QLCTV

create table PhongBan(
	MaPhong nvarchar(10) primary key,
	TenPhong nvarchar(30)
)


insert into PhongBan
values('P01','Ke Toan')
insert into PhongBan
values('P02','Tai Chinh')
insert into PhongBan
values('P03','Ke Hoach')
insert into PhongBan
values('P04','Dau Tu')


create table CongTacVien(
	MaCTV nvarchar(10) primary key,
	HoTen nvarchar(50),
	SoBV int,
	MaPhong nvarchar(10) foreign key references PhongBan(MaPhong)
)

insert into CongTacVien
values('C01','Nguyen Van A','10','P01')
insert into CongTacVien
values('C02','Nguyen Van B','9','P03')
insert into CongTacVien
values('C03','Nguyen Van C','4','P02')
insert into CongTacVien
values('C04','Nguyen Van D','5','P04')


select * from PhongBan
select * from CongTacVien

