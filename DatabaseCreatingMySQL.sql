CREATE SCHEMA GARA;
#drop SCHEMA GARA;
USE GARA;

CREATE TABLE PHIEUTHUTIEN
(
	MAPHIEUTHUTIEN INT(10) NOT NULL AUTO_INCREMENT,
	BIENSO CHAR(10), 
	NGAYTHUTIEN DATE,
	SOTIENTHU DECIMAL, 
    SOTIENKHACHTRA DECIMAL,
    SOTIENTRAKHACH DECIMAL,
	PRIMARY KEY (MAPHIEUTHUTIEN)
);
#drop table PHIEUTHUTIEN;
#create lai table PHIEUTHUTIEN, them vao 2 col moi SOTIENTRAKHACH va SOTIENKHACHTRA
#create lai table PHIEUTHUTIEN, doi ma phieu thanh auto-increment


CREATE TABLE DOANHSO 
(
	MADOANHSO CHAR(10) NOT NULL,
	THANG DATE,
	TONGDOANHSO DECIMAL,
	PRIMARY KEY (MADOANHSO)
);


CREATE TABLE XE 
(
	BIENSO CHAR(10) NOT NULL,
	MAKHACHSUAXE int,
	MAHIEUXE CHAR(10),
	PRIMARY KEY (BIENSO)
);


CREATE TABLE TIEPNHANXESUA
(
	MATIEPNHANXESUA INT(10) NOT NULL AUTO_INCREMENT,
	BIENSO CHAR(10),
	NGAYTIEPNHAN DATE,
	PRIMARY KEY (MATIEPNHANXESUA)
);
#drop table TIEPNHANXESUA;
#Chinh lai col MaTiepNhanXeSua co them auto increment


CREATE TABLE CHITIETDOANHSO
(
	MACHITIETDOANHSO CHAR(10) NOT NULL,
	MADOANHSO CHAR(10),
	MAHIEUXE CHAR(10),
	SOLUOTSUA INT,
	THANHTIEN DECIMAL,
	TILE TINYINT,
	PRIMARY KEY (MACHITIETDOANHSO)
);


CREATE TABLE KHACHSUAXE 
(
	MAKHACHSUAXE int NOT NULL,
	TENCHUXE CHAR(100),
	DIENTHOAI CHAR(20),
    DIACHI CHAR(100),
	EMAIL CHAR(40),
	TIENNO DECIMAL,
	PRIMARY KEY (MAKHACHSUAXE)
);


CREATE TABLE BAOCAOTON
(
	MABAOCAOTON CHAR(10) NOT NULL,
	THANGBAOCAOTON DATE,
	NAMBAOCAOTON DATE,
	PRIMARY KEY (MABAOCAOTON)
);


CREATE TABLE CHITIETTON
(
	MACHITIETTON CHAR(10) NOT NULL,
	MABAOCAOTON CHAR(10),
	MAVATTUPHUTUNG CHAR(10),
	TONDAU INT,
	TONPHATSINH INT,
	TONCUOI INT,
	PRIMARY KEY (MACHITIETTON)
);


CREATE TABLE PHIEUSUACHUA 
(
	MAPHIEUSUACHUA INT(10) NOT NULL AUTO_INCREMENT,
	BIENSO CHAR(20),
	NGAYSUACHUA DATE,
	TONGTIEN DECIMAL,
	MAKHACHSUAXE int,
	PRIMARY KEY (MAPHIEUSUACHUA)
);
#drop table PHIEUSUACHUA
#Thay doi MaPhieuSuaChua thanh auto-increment


CREATE TABLE VATTUPHUTUNG 
(
	MAVATTUPHUTUNG CHAR(10) NOT NULL,
	TENVATTUPHUTUNG CHAR(100),
	DONGIA DECIMAL, 
	SOLUONGVATTU INT,
	PRIMARY KEY (MAVATTUPHUTUNG)
);



CREATE TABLE CHITIETPHIEUSUACHUA
(
	MACTPHIEUSUAXE INT(10) NOT NULL AUTO_INCREMENT,
	MAPHIEUSUACHUA INT(10) NOT NULL,
	NOIDUNG CHAR(100),
	MAVATTUPHUTUNG CHAR(10),
	SOLUONGSUACHUA INT,
	TIENCONG DECIMAL, 
	THANHTIEN DECIMAL,
	PRIMARY KEY (MACTPHIEUSUAXE)
);
#drop table CHITIETPHIEUSUACHUA;
#Chinh lai col MaCTPhieuSuaXe co them auto increment


CREATE TABLE HIEUXE
(
	MAHIEUXE CHAR(10) NOT NULL,
	TENHIEUXE CHAR(100),
	PRIMARY KEY (MAHIEUXE)
);


create table TIENCONG
(
MATIENCONG char(10) not null,
TENTIENCONG char(100),
primary key(MATIENCONG)
);

CREATE TABLE THAMSO
(
	
	SUDUNGQUYDINH4 BOOL,
	SOTIENNOTOIDA INT,
	SOXESUACHUATOIDA INT
);

#New Table
create table VATTUTON
(
	MAVATTUPHUTUNG CHAR(10) NOT NULL,
	SOLUONGTON INT,
	THANG DECIMAL,
    NAM DECIMAL,
    PRIMARY KEY(MAVATTUPHUTUNG)
);
#drop table VATTUTON;

create table QUANLYNHAPVATTU
(
	MAVATTUPHUTUNG CHAR(10) NOT NULL,
    SOLUONGNHAP INT,
	NGAYNHAP DATE,
    PRIMARY KEY(MAVATTUPHUTUNG)
);
#drop table QUANLYNHAPVATTU;


alter table CHITIETDOANHSO add foreign key (MADOANHSO) references DOANHSO (MADOANHSO);
#alter table TIEPNHANXESUA add foreign key (BIENSO) references XE (BIENSO);
alter table PHIEUTHUTIEN add foreign key (BIENSO) references XE (BIENSO);
alter table PHIEUSUACHUA add foreign key (BIENSO) references XE (BIENSO);
alter table XE add foreign key (MAKHACHSUAXE) references KHACHSUAXE (MAKHACHSUAXE);
alter table PHIEUSUACHUA add foreign key (MAKHACHSUAXE) references KHACHSUAXE (MAKHACHSUAXE);
alter table CHITIETTON add foreign key (MABAOCAOTON) references BAOCAOTON (MABAOCAOTON);
alter table XE add foreign key (MAHIEUXE) references HIEUXE (MAHIEUXE);
alter table CHITIETDOANHSO add foreign key (MAHIEUXE) references HIEUXE (MAHIEUXE);
alter table CHITIETTON add foreign key (MAVATTUPHUTUNG) references VATTUPHUTUNG (MAVATTUPHUTUNG);
alter table CHITIETPHIEUSUACHUA add foreign key (MAVATTUPHUTUNG) references VATTUPHUTUNG (MAVATTUPHUTUNG);
alter table CHITIETPHIEUSUACHUA add foreign key (MAPHIEUSUACHUA) references PHIEUSUACHUA (MAPHIEUSUACHUA);

#New FK
alter table VATTUTON add foreign key (MAVATTUPHUTUNG) references VATTUPHUTUNG (MAVATTUPHUTUNG);
alter table QUANLYNHAPVATTU add foreign key (MAVATTUPHUTUNG) references VATTUPHUTUNG (MAVATTUPHUTUNG);




/*Phần này sử dụng trong bảng quản lý khách hàng và thao tác khách hàng*/
DELIMITER //
Create Procedure LoadAllCustomer()
Begin
	select MaKhachSuaXe as 'Mã khách sửa xe', TenChuXe as 'Tên Chủ Xe', DienThoai as 'Điện Thoại', DiaChi as 'Địa Chỉ', Email as 'Email', TienNo as 'Tiền Nợ' from KHACHSUAXE;
End //
DELIMITER ;


DELIMITER //
Create Procedure InsertCustomer( in _MaKhachSuaXe int, in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal)
Begin
	insert into KHACHSUAXE values(_MaKhachSuaXe, _TenChuXe, _DienThoai,_DiaChi, _Email, _TienNo);
End //
DELIMITER ;


DELIMITER //
Create Procedure UpdateCustomer(in _MaKhachSuaXe int, in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal)
Begin
	update KHACHSUAXE set TenChuXe = _TenChuXe, DienThoai = _DienThoai,DiaChi=_DiaChi, Email = _Email, TienNo = _TienNo where MaKhachSuaXe = _MaKhachSuaXe;
End //
DELIMITER ;


DELIMITER //
Create Procedure RemoveCustomer(in _MaKhachSuaXe int)
Begin
	delete from KHACHSUAXE where  KHACHSUAXE.MaKhachSuaXe = _MaKhachSuaXe;
    
End //
DELIMITER ;


DELIMITER //
Create Procedure FindCustomer (in _MaKhachSuaXe int)
Begin	
   
    select *
    from KHACHSUAXE
    where MaKhachSuaXe = _MaKhachSuaXe;
          	
End //
DELIMITER ;


DELIMITER // 
create procedure FindCustomers (in _MaKhachSuaXe int , in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal, in _SoTienNoCompareType varchar(2))
Begin 
		create temporary table SoTienNoTable (MaKhachSuaXe int);
        case _SoTienNoCompareType
			when '=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo = _TienNo;
            when '>' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo > _TienNo;
            when '>=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo >= _TienNo;
            when '<' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo < _TienNo;
            when '<=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo <= _TienNo;
            end case;
            
            select MaKhachSuaXe As 'Mã Khách hàng', TenChuXe As 'Tên chủ xe', DienThoai As 'Điện thoại', DiaChi As 'Địa Chỉ' ,Email As 'Email',
            CONCAT('', Format(TienNo,0), ' đ') As 'Số Tiền Nợ'
            from KHACHSUAXE
            where MaKhachSuaXe like CONCAT('%', _MaKhachSuaXe, '%') and TenChuXe like CONCAT('%', _TenChuXe, '%')  and
            DienThoai like CONCAT('%', _DienThoai, '%') and DiaChi like CONCAT('%', _DiaChi, '%')and Email like CONCAT('%', _Email, '%') and MaKhachSuaXe in (select MaKhachSuaXe from SoTienNoTable);
            
            drop table SoTienNoTable; 
End //
DELIMITER ;



DELIMITER //
Create Procedure UpdateTienNo (in _MaKhachHang int, in _SoTien decimal)
Begin
	update KHACHSUAXE set TienNo = TienNo + _SoTien where MaKhachHang=_MaKhachHang;
End //
DELIMITER ;



/*Thao tác với hiệu xe*/
DELIMITER //
Create Procedure LoadAllHIEUXE()
Begin
	select MaHieuXe as 'Mã hiệu xe', TenHieuXe as 'Tên Hiệu Xe' from HIEUXE;
End //
DELIMITER ;


DELIMITER //
Create Procedure InsertHIEUXE( in _MaHieuXe char(10), in _TenHieuXe char(100))
Begin
	insert into HIEUXE values(_MaHieuXe, _TenHieuXe);
End //
DELIMITER ;



DELIMITER //
Create Procedure RemoveHIEUXE(in _MaHieuXe char(10))
Begin
	delete from HIEUXE where  MaHieuXe = _MaHieuXe;
End //
DELIMITER ;



/*DELIMITER //
Create Procedure GetNewIDHIEUXE( in _MaHieuXe char(10), in _TenHieuXe char(100))
Begin
	select Max(cast(Substring(MaTheLoai,3, length(MaTheLoai)-2) as unsigned)) as 'MaxMaTheLoai' from HIEUXE;
End //
DELIMITER ;
*/



        /*Phần này sử dụng trong bảng quản lý xe và thao tác xe*/
DELIMITER //
Create Procedure LoadAllCar()
Begin
	select BienSo as 'Biển sổ', TenChuXe as 'Tên Chủ Xe',  TenHieuXe as 'Tên Hiệu Xe', TienNo as 'Tiền Nợ' 
    from XE,HIEUXE,KHACHSUAXE where XE.MaHieuXe=HIEUXE.MaHieuXe 
    and XE.MAKHACHSUAXE=KHACHSUAXE.MAKHACHSUAXE;
End //
DELIMITER ;



DELIMITER //
Create Procedure InsertCar( in _BienSo char(10), in _MaKhachSuaXe int, in _MaHieuXe char(10),_TienNo decimal)
Begin


update KHACHSUAXE set TienNo = _TienNo  where MaKhachSuaXe=_MaKhachSuaXe;


insert into XE values(_BienSo, _MaKhachSuaXe,_MaHieuXe);
    
End //
DELIMITER ;




DELIMITER //
Create Procedure UpdateCar( in _BienSo char(10), in _MaKhachSuaXe int, in _MaHieuXe char(10),_TienNo decimal)
Begin
	update KHACHSUAXE set  TienNo = _TienNo where MaKhachSuaXe = _MaKhachSuaXe;
End //
DELIMITER ;


DELIMITER //
Create Procedure RemoveCar(in _BienSo char(10), in _MaKhachSuaXe int, in _MaHieuXe char(10))
Begin
	delete from XE where BienSo=_BienSo;
	
    
End //
DELIMITER ;


DELIMITER //
Create Procedure FindCar (in _BienSo char(10))
Begin	
   
    select *
    from XE
    where BienSo = _BienSo;
          	
End //
DELIMITER ;

/*
DELIMITER // 
create procedure FindCars (in _BienSo char(10) , in _MaKhachSuaXe int, in _MaHieuXe char(10),in _TenChuXe char(100),in _TenHieuXe char(100), in _TienNo decimal, in _SoTienNoCompareType varchar(2))
Begin 
		create temporary table SoTienNoTable (MaKhachSuaXe int);
        case _SoTienNoCompareType
			when '=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo = _TienNo;
            when '>' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo > _TienNo;
            when '>=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo >= _TienNo;
            when '<' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo < _TienNo;
            when '<=' then insert into SoTienNoTable select MaKhachSuaXe from KHACHSUAXE where TienNo <= _TienNo;
            end case;
            
            select BienSo As 'Biển số', TenChuXe As 'Tên chủ xe', TenHieuXe As 'Tên hiệu xe',
            CONCAT('', Format(TienNo,0), ' đ') As 'Số Tiền Nợ'
            from KHACHSUAXE,XE,HIEUXE
            where TenChuXe like CONCAT('%', _TenChuXe, '%') and TenHieuXe like CONCAT('%', _TenHieuXe, '%')  and
            MaKhachSuaXe in (select MaKhachSuaXe from SoTienNoTable)  and
            HIEUXE.MaHieuXe= _MaHieuXe and XE.MaHieuXe= _MaHieuXe;
            
            drop table SoTienNoTable; 
End //
DELIMITER ;
*/



DELIMITER // 
create procedure FindCars (in _BienSo char(10) )
Begin 
		
            select BienSo As 'Biển số', TenChuXe As 'Tên chủ xe', TenHieuXe As 'Tên hiệu xe',
            CONCAT('', Format(TienNo,0), ' đ') As 'Số Tiền Nợ'
            from KHACHSUAXE,XE,HIEUXE
            where  
            HIEUXE.MaHieuXe= XE.MaHieuXe and XE.MaKhachSuaXe= KHACHSUAXE.MaKhachSuaXe and XE.BienSo=_BienSo;
            
            
End //
DELIMITER ;

   



/*Sử dụng cho bảng vật tư phụ tùng*/

DELIMITER //

DELIMITER //
Create Procedure LoadAllSpareParts()
Begin
	select MAVATTUPHUTUNG as 'Mã Vật Tư Phụ Tùng', TENVATTUPHUTUNG as 'Tên Vật Tư Phụ Tùng',  DONGIA as 'Đơn Giá', SOLUONGVATTU  as 'Số lượng ' from VATTUPHUTUNG;
End //
DELIMITER ;






DELIMITER // 
create procedure InsertSpareParts ( in _MaVatTuPhuTung char(10), in _TenVatTuPhuTung char(100), in _DonGia decimal, in _SoLuongVatTu int)
Begin 
	Insert into VATTUPHUTUNG values (_MaVatTuPhuTung, _TenVatTuPhuTung, _DonGia, _SoluongVatTu);
End //
DELIMITER ;



DELIMITER // 
create procedure UpdateSpareParts (  in _MaVatTuPhuTung char(10), in _TenVatTuPhuTung char(100), in _DonGia decimal, in _SoLuongVatTu int)
Begin 
	update VATTUPHUTUNG set TenVatTuPhuTung = _TenVatTuPhuTung, DonGia = _DonGia, SoLuongVatTu = _SoLuongVatTu
    where MaVatTuPhuTung = _MaVatTuPhuTung;
End //
DELIMITER ;



DELIMITER //
create procedure UpdateSoLuongSpareParts (in _MaVatTuPhuTung char(10), in _SoLuong int)
Begin
	update VATTUPHUTUNG set SoLuongVatTu = SoLuongVatTu + _SoLuong;
End //
DELIMITER ;



DELIMITER //
Create Procedure RemoveSpareParts(in _MaVatTuPhuTung char(10))
Begin
	delete from VATTUPHUTUNG where MaVatTuPhuTung=_MaVatTuPhuTung;
	
    
End //
DELIMITER ;




DELIMITER //
Create Procedure FindSpareParts (in _MaVatTuPhuTung char(10))
Begin	
   
    select MaVatTuPhuTung as 'Mã Vật Tư Phụ Tùng', TenVatTuPhuTung as 'Tên Vật Tư Phụ Tùng',  DonGia as 'Đơn Giá', SoLuongVatTu as 'Số lượng ' 
    from VATTUPHUTUNG
    where MaVatTuPhuTung = _MaVatTuPhuTung;
End //
DELIMITER ;




DELIMITER // 
create procedure SearchSpareParts (in _MaVatTuPhuTung char(10), in _TenVatTuPhuTung char(100), in _DonGia decimal, in _SoLuongVatTu int)
Begin 
		     select    MaVatTuPhuTung as 'Mã Vật Tư Phụ Tùng', TenVatTuPhuTung as 'Tên Vật Tư Phụ Tùng',  CONCAT('', Format(DonGia,0), ' đ') As 'Đơn giá', SoLuongVatTu as 'Số lượng '   
            
            
            from VATTUPHUTUNG
            where MaVatTuPhuTung like CONCAT('%', _MaVatTuPhuTung, '%') and TenVatTuPhuTung like CONCAT('%', _TenVatTuPhuTung, '%')  and
            DonGia like CONCAT('%', _DonGia, '%') and SoLuongVatTu like CONCAT('%', _SoLuongVatTu, '%') and MaVatTuPhuTung = _MaVatTuPhuTung;
            
         
End //
DELIMITER ;




/*Phần này sử dụng cho bảng tiền công*/
DELIMITER //
Create Procedure LoadAllSalary()
Begin
	select MATIENCONG as 'Mã Tiền Công', TENTIENCONG as 'Tên Tiền Công' from TIENCONG;
End //
DELIMITER ;



DELIMITER // 
create procedure InsertSalary( in _MaTienCong char(10), in _TenTienCong char(100))
Begin 
	Insert into TIENCONG values (_MaTienCong, _TenTienCong);
End //
DELIMITER ;


DELIMITER //
Create Procedure RemoveSalary(in _MaTienCong char(10))
Begin
	delete from TIENCONG where MaTienCong=_MaTienCong;
	
    
End //
DELIMITER ;




/*Phần này sử dụng cho bảng tham số*/
DELIMITER //
Create Procedure GetParameters()
Begin
	select SUDUNGQUYDINH4 as 'Sử dụng quy định 4' , SOTIENNOTOIDA as 'Số tiền nợ tối đa', SOXESUACHUATOIDA as'Số xe sửa chữa tối đa' from THAMSO;
End //
DELIMITER ;



DELIMITER //
create procedure UpdateParameters (in _SuDungQuyDinh4 bool , in _SoTienNoToiDa int, in _SoXeSuaChuaToiDa int)
Begin
	update THAMSO set SUDUNGQUYDINH4 = _SuDungQuyDinh4,SOTIENNOTOIDA=_SoTienNoToiDa,SOXESUACHUATOIDA=_SoXeSuaChuaToiDa;
End //
DELIMITER ;




/*Procedure dung cho PHIEUTHUTIEN*/
DELIMITER // 
create procedure InsertPHIEUTHUTIEN ( in _BienSo char(10), in _NgayThuTien date,
in _SoTienThu decimal, in _SoTienKhachTra decimal, in _SoTienTraKhach decimal)
Begin 
	Insert into PHIEUTHUTIEN (BIENSO, NGAYTHUTIEN, SOTIENTHU, SOTIENKHACHTRA, SOTIENTRAKHACH)
    values (_BienSo, _NgayThuTien, _SoTienThu, _SoTienKhachTra, _SoTienTraKhach);
End //
DELIMITER ;
#drop procedure InsertPHIEUTHUTIEN;



DELIMITER //
Create Procedure SelectAllPHIEUTHUTIEN()
Begin
	select MAPHIEUTHUTIEN as 'Số phiếu thu tiền', BIENSO as 'Biển số', NGAYTHUTIEN as 'Ngày thu tiền', SOTIENTHU as 'Số tiền thu' from PHIEUTHUTIEN;
End //
DELIMITER ;


/* xóa procedure SelectALLPHIEUTHUTIEN và tạo lại bằng cái create đã được chỉnh sửa */
#drop procedure SelectALLPHIEUTHUTIEN

/*Procedure dung cho TIEPNHANXESUA*/
DELIMITER //
Create Procedure SelectAllTIEPNHANXESUA()
Begin
	select MATIEPNHANXESUA as 'Mã tiếp nhận xe sửa',
    KHACHSUAXE.TENCHUXE as 'Tên chủ xe',    
    TIEPNHANXESUA.BIENSO as 'Biển số',
    HIEUXE.TENHIEUXE as 'Hiệu xe',    
    NgayTiepNhan as 'Ngày tiếp nhận',
    DIACHI as 'Địa chỉ',
    DIENTHOAI as 'Điện thoại'
    from TIEPNHANXESUA, XE, KHACHSUAXE, HIEUXE
    where (TIEPNHANXESUA.BIENSO = XE.BIENSO
    and XE.MAKHACHSUAXE = KHACHSUAXE.MAKHACHSUAXE
    and HIEUXE.MAHIEUXE = XE.MAHIEUXE);
End //
DELIMITER ;
#drop procedure SelectAllTIEPNHANXESUA;


DELIMITER // 
create procedure InsertTIEPNHANXESUA ( in _BienSo char(10), in _NgayTiepNhan date)
Begin
	/*declare bienSo char(10);
    set bienSo = (select BIENSO
			from XE
            where XE.BIENSO = _BienSo);*/
	Insert into TIEPNHANXESUA (TIEPNHANXESUA.BIENSO, NGAYTIEPNHAN)
    values (_BienSo, _NgayTiepNhan);
End //
DELIMITER ;
#drop procedure InsertTIEPNHANXESUA;


/*Procedure dung cho PHIEUSUACHUA*/
DELIMITER //
Create Procedure SelectAllCHITIETPHIEUSUACHUA()
Begin
	select MACHITIETPHIEUSUACHUA as 'Mã chi tiết phiếu sửa chữa', NOIDUNG as 'Nội dung',
    MAVATTUPHUTUNG as 'Mã vật tư phụ tùng', SOLUONGSUACHUA as 'Số lượng',
    TIENCONG as 'Tiền công', THANHTIEN as 'Thành tiền' from CHITIETPHIEUSUACHUA;
End //
DELIMITER ;

DELIMITER // 
create procedure InsertCHITIETPHIEUSUACHUA ( in _MaPhieuSuaChua char(10), in _NoiDung char(100),
 in _MaVatTuPhuTung char(10), _SoLuongSuaChua int, in _TienCong decimal, _ThanhTien decimal)
Begin 
	Insert into PHIEUTHUTIEN (MAPHIEUSUACHUA, NOIDUNG, MAVATTUPHUTUNG, SOLUONGSUACHUA, TIENCONG, THANHTIEN)
    values ( _MaPhieuSuaChua, _NoiDung, _MaVatTuPhuTung, _SoLuongSuaChua,
    _TienCong, _ThanhTien);
End //
DELIMITER ;
#drop procedure InsertCHITIETPHIEUSUACHUA;

DELIMITER //
Create Procedure SelectAllPHIEUSUACHUA()
Begin
	select MAPHIEUSUACHUA as 'Số phiếu sửa chữa', BIENSO as 'Biển số',
    NGAYSUACHUA as 'Ngày sửa chữa', TONGTIEN as 'Tổng tiền',
    MAKHACHSUAXE as 'Mã khách sửa xe' from PHIEUSUACHUA;
End //
DELIMITER ;
#drop procedure SelectAllPHIEUSUACHUA;

DELIMITER // 
create procedure InsertPHIEUSUACHUA( in _BienSo char(20), in _NgaySuaChua date,
in _TongTien decimal, in _MaKhachSuaXe int)
Begin
	insert into PHIEUSUACHUA (BIENSO, NGAYSUACHUA, TONGTIEN, MAKHACHSUAXE)
    values (_BienSo, _NgaySuaChua, _TongTien, _MaKhachSuaXe);
End //
DELIMITER ;

/*
DELIMITER // 
create procedure CreatePHIEUSUACHUA( in _BienSo char(20), in _NgaySuaChua date,
in _TongTien decimal, in _MaKhachSuaXe int, in _MaPhieuSuaChua char(10), in _NoiDung char(100),
 in _MaVatTuPhuTung char(10), _SoLuongSuaChua int, in _TienCong decimal, _ThanhTien decimal)
Begin
	insert into PHIEUSUACHUA (BIENSO, NGAYSUACHUA, TONGTIEN, MAKHACHSUAXE)
    values (_BienSo, _NgaySuaChua, _TongTien, _MaKhachSuaXe);
    
    declare id int(10);
    set id = LAST_INSERT_ID();
    Insert into PHIEUTHUTIEN (MAPHIEUSUACHUA, NOIDUNG, MAVATTUPHUTUNG, SOLUONGSUACHUA, TIENCONG, THANHTIEN)
    values ( _MaPhieuSuaChua, _NoiDung, _MaVatTuPhuTung, _SoLuongSuaChua,
    _TienCong, _ThanhTien);
End //
DELIMITER ;
*/

#Procedure cho QuanLyNhapVatTu

DELIMITER // 
create procedure InsertQUANLYNHAPVATTU( in _MaVatTu char(10), in _SoLuongNhap int, in _NgayNhap date)
begin
	declare MaVT char(10);
    set MaVT = (select MAVATTUPHUTUNG
			   from VATTUPHUTUNG
               where MAVATTUPHUTUNG = _MaVatTu);
	insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG, SOLUONGNHAP, NGAYNHAP)
    values (MaVT, _SoLuongNhap, _NgayNhap);
End //
DELIMITER ;

DELIMITER // 
create procedure InsertVATTUTON( in _MaVatTu char(10), in _SoLuongTon int, in _Thang date)
begin
	declare MaVT char(10);
    set MaVT = (select MAVATTUPHUTUNG
			   from VATTUPHUTUNG
               where MAVATTUPHUTUNG = _MaVatTu);
	insert into VATTUTON (MAVATTUPHUTUNG, SOLUONGTON, THANG)
    values (MaVT, _SoLuongTon, _Thang);
End //
DELIMITER ;

DELIMITER //
create procedure countVATTU()
begin
	select count(VATTUPHUTUNG.MAVATUPHUTUNG)
    from VATTUPHUTUNG;
End //
DELIMITER ;

