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
	MACHITIETDOANHSO INT(10) NOT NULL AUTO_INCREMENT,
	MADOANHSO CHAR(10),
	MAHIEUXE CHAR(10),
	SOLUOTSUA INT,
	THANHTIEN DECIMAL,
	TILE TINYINT,
	PRIMARY KEY (MACHITIETDOANHSO)
);
#drop table CHITIETDOANHSO
#Sua lai bang chi tiet doanh so

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
	THANGBAOCAOTON INT,
	NAMBAOCAOTON INT,
	PRIMARY KEY (MABAOCAOTON)
);
#drop table BAOCAOTON;


CREATE TABLE CHITIETTON
(
	MACHITIETTON INT(10) NOT NULL AUTO_INCREMENT,
	MABAOCAOTON CHAR(10),
	MAVATTUPHUTUNG CHAR(10),
	TONDAU INT,
	TONPHATSINH INT,
	TONCUOI INT,
	PRIMARY KEY (MACHITIETTON)
);
#drop table CHITIETTON;


CREATE TABLE PHIEUSUACHUA 
(
	MAPHIEUSUACHUA CHAR(10) NOT NULL,
	BIENSO CHAR(20),
	NGAYSUACHUA DATE,
	TONGTIEN DECIMAL,
	MAKHACHSUAXE int,
	PRIMARY KEY (MAPHIEUSUACHUA)
);
#drop table PHIEUSUACHUA


CREATE TABLE VATTUPHUTUNG 
(
	MAVATTUPHUTUNG CHAR(10) NOT NULL,
	TENVATTUPHUTUNG CHAR(100),
	DONGIA DECIMAL, 
	SOLUONGVATTU INT,
    SOLUONGTON INT, #Thuộc tính mới
	PRIMARY KEY (MAVATTUPHUTUNG)
);
#drop table VATTUPHUTUNG;


CREATE TABLE CHITIETPHIEUSUACHUA
(
	MACTPHIEUSUAXE INT(10) NOT NULL AUTO_INCREMENT,
	MAPHIEUSUACHUA CHAR(10) NOT NULL,
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
	SOTIENCONG decimal,
	primary key(MATIENCONG)
);


CREATE TABLE THAMSO
(	
	SUDUNGQUYDINH4 BOOL,
	SOTIENNOTOIDA INT,
	SOXESUACHUATOIDA INT
);

#New Table
#Xoa bang Vat Tu Ton
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
	update KHACHSUAXE
    set TienNo = TienNo + _SoTien
    where MaKhachHang=_MaKhachHang;
End //
DELIMITER ;

#Procedure dung cho PhieuThuTien
DELIMITER //
create procedure payTIENNO (in _BienSo char (10), in _SoTien decimal)
Begin
	declare MaKH int;
    set MaKH = 
    (
    select KHACHSUAXE.MAKHACHSUAXE
    from KHACHSUAXE, XE
    where KHACHSUAXE.MAKHACHSUAXE = XE.MAKHACHSUAXE
    and XE.BIENSO = _BienSo
    );
	update KHACHSUAXE
    set TienNo = TienNo - _SoTien
    where MAKHACHSUAXE = MaKH;
End //
DELIMITER ;
#drop procedure payTIENNO;

/*select * from KHACHSUAXE;*/

DELIMITER //
Create Procedure addTienNo (in _BienSo char (10), in _SoTien decimal)
Begin
	declare MaKH int;
    set MaKH = 
    (
    select KHACHSUAXE.MAKHACHSUAXE
    from KHACHSUAXE, XE
    where KHACHSUAXE.MAKHACHSUAXE = XE.MAKHACHSUAXE
    and XE.BIENSO = _BienSo
    );
	update KHACHSUAXE
    set TienNo = TienNo + _SoTien
    where MAKHACHSUAXE = MaKH;
End //
DELIMITER ;
#drop Procedure addTienNo;


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
	Insert into VATTUPHUTUNG(MAVATTUPHUTUNG, TENVATTUPHUTUNG, DONGIA, SOLUONGVATTU, SOLUONGTON)
    values (_MaVatTuPhuTung, _TenVatTuPhuTung, _DonGia, _SoluongVatTu, 0);
End //
DELIMITER ;
#drop procedure InsertSpareParts;


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


#Cap nhat cho thuoc tinh moi cua VatTuPhuTung
DELIMITER //
create procedure updateSoLuongTonVT()
begin
	
	update VATTUPHUTUNG  
    set SOLUONGTON = SOLUONGVATTU;
end //
DELIMITER //

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
	select MATIENCONG as 'Mã Tiền Công', TENTIENCONG as 'Tên Tiền Công',SOTIENCONG as 'Số Tiền Công' from TIENCONG;
End //
DELIMITER ;



DELIMITER // 
create procedure InsertSalary( in _MaTienCong char(10), in _TenTienCong char(100), in _SoTienCong decimal)
Begin 
	Insert into TIENCONG values (_MaTienCong, _TenTienCong,_SoTienCong);
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
	Insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA, NOIDUNG, MAVATTUPHUTUNG, SOLUONGSUACHUA, TIENCONG, THANHTIEN)
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
	create procedure InsertPHIEUSUACHUA(in _MaPhieuSuaChua char (10), in _BienSo char(20), in _NgaySuaChua date,
	in _TongTien decimal)
	Begin
		declare MaKhachSuaXe int;
		set MaKhachSuaXe =
		(
		select XE.MaKhachSuaXe
		from XE
		where XE.BIENSO = _BienSo
		);    
		insert into PHIEUSUACHUA (MAPHIEUSUACHUA, BIENSO, NGAYSUACHUA, TONGTIEN, MAKHACHSUAXE)
		values (_MaPhieuSuaChua, _BienSo, _NgaySuaChua, _TongTien, MaKhachSuaXe);
	End //
	DELIMITER ;
#drop procedure InsertPHIEUSUACHUA;

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

#New
DELIMITER //
create procedure deleteQUANLYNHAPVATTU( in _MaVatTu char(10))
begin
	delete from QUANLYNHAPVATTU
    where MAVATTUPHUTUNG = _MaVatTu;
end //
DELIMITER ;


#Procedure tao bao cao doanh so
DELIMITER // 
create procedure createBAOCAODOANHSO(in _Thang int, in _Nam int)
begin
	declare total int;
    
    set total = (select sum(PHIEUSUACHUA.TONGTIEN)
    from PHIEUSUACHUA
    where PHIEUSUACHUA.NGAYSUACHUA = _Thang);
    
	select HIEUXE.TENHIEUXE as 'Hiệu Xe',
    count(PHIEUSUACHUA.MAPHIEUSUACHUA) as 'Số Lượt Sửa',
    sum(PHIEUSUACHUA.TONGTIEN) as 'Thành Tiền',
    (sum(PHIEUSUACHUA.TONGTIEN)/total*100) as 'Tỉ Lệ'
    from HIEUXE, PHIEUSUACHUA, XE
    where XE.BIENSO = PHIEUSUACHUA.BIENSO
    and XE.MAHIEUXE = HIEUXE.MAHIEUXE
    and month(PHIEUSUACHUA.NGAYSUACHUA) = 10
    and year(PHIEUSUACHUA.NGAYSUACHUA) = 2018
    group by HIEUXE.TENHIEUXE;
end //
DELIMITER ;
#drop procedure createBAOCAODOANHSO;

DELIMITER // 
create procedure insertBAOCAODOANHSO(in _MaBaoCao char(10), in _Thang0 date
, in _Thang int, in _Nam int)
begin
	declare total int;
    
    set total = (select sum(PHIEUSUACHUA.TONGTIEN)
    from PHIEUSUACHUA
    where PHIEUSUACHUA.NGAYSUACHUA = _Thang);
    
    insert into DOANHSO (MADOANHSO, THANG, TONGDOANHSO)
    values (_MaBaoCao, _Thang0, total);
    
    insert into CHITIETDOANHSO (MADOANHSO, MAHIEUXE, SOLUOTSUA, THANHTIEN, TILE)
	(select _MaBaoCao, HIEUXE.TENHIEUXE,
    count(PHIEUSUACHUA.MAPHIEUSUACHUA),
    sum(PHIEUSUACHUA.TONGTIEN),
    (
    sum(PHIEUSUACHUA.TONGTIEN)/total*100)
    from HIEUXE, PHIEUSUACHUA, XE
    where XE.BIENSO = PHIEUSUACHUA.BIENSO
    and XE.MAHIEUXE = HIEUXE.MAHIEUXE
    and month(PHIEUSUACHUA.NGAYSUACHUA) = _Thang
    and year(PHIEUSUACHUA.NGAYSUACHUA) = _Nam
    group by HIEUXE.TENHIEUXE
    );
end //
DELIMITER ;
#drop procedure insertBAOCAODOANHSO;

DELIMITER // 
create procedure selectTongDoanhThu(in _Thang0 date)
begin
	select sum(PHIEUSUACHUA.TONGTIEN)
    from PHIEUSUACHUA
    where PHIEUSUACHUA.NGAYSUACHUA = _Thang0;
end //
DELIMITER ;

DELIMITER //
create procedure insertBaoCaoTon( in _MaBaoCao char(10), _Thang int, _Nam int)
begin
	insert into BAOCAOTON (MABAOCAOTON, THANGBAOCAOTON, NAMBAOCAOTON)
    values (_MaBaoCao, _Thang, _Nam);
end //
DELIMITER ;




DELIMITER //
create procedure insertCTBaoCaoTon( in _MaBaoCao char(10), in _Month int , in _Year int)
begin
	insert into CHITIETTON (MABAOCAOTON, MAVATTUPHUTUNG, TONDAU, TONPHATSINH, TONCUOI)
    (select _MaBaoCao, VATTUPHUTUNG.MAVATTUPHUTUNG ,
      VATTUPHUTUNG.SOLUONGTON ,
     sum(QUANLYNHAPVATTU.SOLUONGNHAP) ,
   
    (VATTUPHUTUNG.SOLUONGTON + sum(QUANLYNHAPVATTU.SOLUONGNHAP))
    from VATTUPHUTUNG, QUANLYNHAPVATTU
    where  month(QUANLYNHAPVATTU.NGAYNHAP) = _Month
    and year(QUANLYNHAPVATTU.NGAYNHAP) =_Year
    and QUANLYNHAPVATTU.MAVATTUPHUTUNG = VATTUPHUTUNG.MAVATTUPHUTUNG
    group by VATTUPHUTUNG.MAVATTUPHUTUNG);
end //
DELIMITER ;


DELIMITER //
create procedure createBaoCaoTon( in _Time date)
begin
	select VATTUPHUTUNG.TENVATTUPHUTUNG as 'Vật Tư Phụ Tùng',
    VATTUPHUTUNG.SOLUONGTON as 'Tồn Đầu',
    sum(SOLUONGNHAP) as 'Phát Sinh',
    (VATTUPHUTUNG.SOLUONGTON + sum(SOLUONGNHAP)) as 'Tồn Cuối'
    from VATTUPHUTUNG, QUANLYNHAPVATTU
    where month(_Time) = month(QUANLYNHAPVATTU.NGAYNHAP)
    and year(_Time) = year(QUANLYNHAPVATTU.NGAYNHAP)
    and QUANLYNHAPVATTU.MAVATTUPHUTUNG = VATTUPHUTUNG.MAVATTUPHUTUNG
    group by VATTUPHUTUNG.TENVATTUPHUTUNG;
end //
DELIMITER ;
#drop procedure createBaoCaoTon;

#Example Data
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX001','Honda');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX002','Toyota');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX003','Hyundai');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX004','BMW');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX005','Ford');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX006','Kia');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX007','Ferrari');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX008','Nissan');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX009','Suzuki');
insert into HIEUXE (MAHIEUXE,TENHIEUXE) values ('HX010','Chevrolet');


insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('67N15126',115,'HX002');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('34N21531',116,'HX002');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('22N62235',113,'HX010');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('54A81264',119,'HX008');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('53B65323',114,'HX005');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('32A21163',111,'HX006');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('32A84135',120,'HX004');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('53B22484',112,'HX003');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('34N11415',118,'HX007');
insert into XE (BIENSO,MAKHACHSUAXE,MAHIEUXE) values ('62A25314',117,'HX009');


insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (111,'Nguyễn Minh Luân','0922636154', '54/12, Quận 4, TP Hồ Chí Minh', 'luan214@gmail.com',100000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (112,'Trần Hoàng','0903677951', '26/5, Quận Tân Bình, TP Hồ Chí Minh', 'hoangtran88@gmail.com',931000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (113,'Lê Nguyễn Minh Anh','0935541986', '12/8A, Quận 7, TP Hồ Chí Minh', 'minhanhle@gmail.com',951000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (114,'Võ Văn Nhân','0922316285', '30/5, Dĩ An, Bình Dương', 'nhan9887@gmail.com',150000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (115,'Lê Trần Ánh Dương','0903122893', '20/8, Quận 8, TP Hồ Chí Minh', 'anhduong040595@gmail.com',0);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (116,'Trương Hoàng Thái','0908988263', '34/3, Phường 4, TP Vũng Tàu', 'thaihoangtruong@gmail.com',0);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (117,'Lê Anh Tuấn','0981200874', '28/7, Phường 12, TP Vũng Tàu', 'anhtuanle22@gmail.com',2835000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (118,'Hà Anh Tú','0925521226', '3/5, Dĩ An, Bình Dương', 'anhtu6692@gmail.com',535000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (119,'Nguyễn Nhật Anh','0931568325', '26/7, Dĩ An Bình Dương', 'nhatanhnguyen@gmail.com',757000);
insert into KHACHSUAXE (MAKHACHSUAXE,TENCHUXE,DIENTHOAI,DIACHI,EMAIL,TIENNO) values (120,'Nguyễn Mỹ Kim','0921538876', '56/5, Phường 3, TP Vũng Tàu', 'mykim12896@gmail.com',0);


insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('67N15126',STR_TO_DATE('20/5/2018', '%d/%m/%Y'),30000, 300000, 270000);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('34N21531',STR_TO_DATE('20/5/2018', '%d/%m/%Y'),0, 250000, 250000);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('22N62235',STR_TO_DATE('12/5/2018', '%d/%m/%Y'),1350000, 1350000, 0);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('54A81264',STR_TO_DATE('3/6/2018', '%d/%m/%Y'),1825000, 1825000, 0);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('67N15126',STR_TO_DATE('1/2/2018', '%d/%m/%Y'),250000, 250000, 0);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('53B65323',STR_TO_DATE('20/3/2018', '%d/%m/%Y'),120000, 120000, 0);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('53B65323',STR_TO_DATE('5/6/2018', '%d/%m/%Y'),30000, 50000, 20000);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('32A21163',STR_TO_DATE('12/5/2018', '%d/%m/%Y'),100000, 200000, 100000);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('32A84135',STR_TO_DATE('10/8/2018', '%d/%m/%Y'),0, 2000000, 2000000);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('53B22484',STR_TO_DATE('10/4/2018', '%d/%m/%Y'),1600000, 1600000, 0);
insert into PHIEUTHUTIEN (BIENSO,NGAYTHUTIEN,SOTIENTHU,SOTIENKHACHTRA,SOTIENTRAKHACH) values ('53B22484',STR_TO_DATE('9/4/2018', '%d/%m/%Y'),1300000, 1300000, 0);


insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC001','Lau chùi',150000);
insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC002','Thay mới',50000);
insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC003','Sửa chữa',300000);
insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC004','Tân trang',450000);
insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC005','Kiểm tra',350000);
insert into TIENCONG (MATIENCONG,TENTIENCONG,SOTIENCONG) values ('TC006','Lắp đặt thêm',75000);


insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT001','Gương chiếu hậu',300000, 150, 50);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT002','Kính',250000, 50, 35);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT003','Thắng xe',200000, 65, 20);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT004','Đèn',325000, 150, 15);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT005','Sơn phủ',400000, 200, 50);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT006','Hộp số',725000, 45, 30);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT007','Bánh xe',51000, 300, 100);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT008','Nhớt Castrol GTX Magnatec',250000, 100, 0);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT009','Nhớt Mobil 1 Advanced Fuel Economy',200000, 80, 25);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT010','Nhớt Valvoline Full Synthetic MaxLife ',230000, 90, 30);
insert into VATTUPHUTUNG (MAVATTUPHUTUNG,TENVATTUPHUTUNG,DONGIA,SOLUONGVATTU,SOLUONGTON) values ('VT000','Không',0, 0, 0);


insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT001',100,STR_TO_DATE('10/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT002',15,STR_TO_DATE('12/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT003',45,STR_TO_DATE('3/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT004',135,STR_TO_DATE('26/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT005',150,STR_TO_DATE('25/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT006',15,STR_TO_DATE('10/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT007',200,STR_TO_DATE('8/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT008',100,STR_TO_DATE('15/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT009',55,STR_TO_DATE('30/5/2018', '%d/%m/%Y'));
insert into QUANLYNHAPVATTU (MAVATTUPHUTUNG,SOLUONGNHAP,NGAYNHAP) values ('VT010',60,STR_TO_DATE('20/5/2018', '%d/%m/%Y'));


insert into PHIEUSUACHUA (MAPHIEUSUACHUA,BIENSO,NGAYSUACHUA,TONGTIEN,MAKHACHSUAXE) values ('SC001','54A81264',STR_TO_DATE('5/4/2018', '%d/%m/%Y'), 2454000, 119);
insert into PHIEUSUACHUA (MAPHIEUSUACHUA,BIENSO,NGAYSUACHUA,TONGTIEN,MAKHACHSUAXE) values ('SC002','53B22484',STR_TO_DATE('15/4/2018', '%d/%m/%Y'), 600000, 112);
insert into PHIEUSUACHUA (MAPHIEUSUACHUA,BIENSO,NGAYSUACHUA,TONGTIEN,MAKHACHSUAXE) values ('SC003','22N62235',STR_TO_DATE('26/4/2018', '%d/%m/%Y'), 2301000, 113);


insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC001','Thay nhớt','VT009', 1, 50000,250000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC001','Sửa thắng xe','VT000', 0, 300000,300000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC001','Sơn phủ chống trầy','VT005', 3, 450000,1650000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC001','Thay lốp','VT007', 4, 50000,254000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC002','Sửa hộp số','VT000', 0, 300000,300000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC002','Sửa đèn xe','VT000', 0, 300000,300000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC003','Thay gương chiếu hậu','VT001', 2, 50000,650000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC003','Sơn phủ chống trầy','VT005', 2, 450000,1250000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC003','Thay lốp','VT007', 1, 50000,101000);
insert into CHITIETPHIEUSUACHUA (MAPHIEUSUACHUA,NOIDUNG,MAVATTUPHUTUNG,SOLUONGSUACHUA,TIENCONG,THANHTIEN) values ('SC003','Sửa gạt nước xe','VT000', 0, 300000,300000);


insert into BAOCAOTON (MABAOCAOTON,THANGBAOCAOTON,NAMBAOCAOTON) values ('BCT001',12,2017);
insert into BAOCAOTON (MABAOCAOTON,THANGBAOCAOTON,NAMBAOCAOTON) values ('BCT002',1,2018);
insert into BAOCAOTON (MABAOCAOTON,THANGBAOCAOTON,NAMBAOCAOTON) values ('BCT003',2,2018);
insert into BAOCAOTON (MABAOCAOTON,THANGBAOCAOTON,NAMBAOCAOTON) values ('BCT004',3,2018);
insert into BAOCAOTON (MABAOCAOTON,THANGBAOCAOTON,NAMBAOCAOTON) values ('BCT005',4,2018);


insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT001','VT001',50, 20, 70);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT001','VT002',25, 5, 30);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT001','VT003',15, 20, 35);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT002','VT001',70, 5, 75);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT002','VT002',30, 25, 55);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT002','VT003',35, 10, 45);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT003','VT001',75, -10, 65);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT003','VT002',55, -5, 50);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT003','VT003',45, -25, 20);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT001',65, -30, 35);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT002',50, -20, 30);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT003',20, -10, 10);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT004',0, 20, 20);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT005',0, 30, 30);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT006',0, 15, 15);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT007',0, 60, 60);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT009',0, 55, 55);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT004','VT010',0, 60, 60);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT001',35, 15, 50);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT002',30, 5, 35);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT003',10, 10, 20);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT004',20, -5, 15);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT005',30, 20, 50);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT006',15, 15, 30);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT007',60, 40, 100);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT009',55, -30, 25);
insert into CHITIETTON (MABAOCAOTON,MAVATTUPHUTUNG,TONDAU,TONPHATSINH,TONCUOI) values ('BCT005','VT010',60, -30, 30);


insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('34N21531',STR_TO_DATE('20/11/2017', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('67N15126',STR_TO_DATE('3/12/2017', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('53B65323',STR_TO_DATE('8/1/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('34N11415',STR_TO_DATE('5/2/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('32A84135',STR_TO_DATE('8/2/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('34N21531',STR_TO_DATE('3/4/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('32A21163',STR_TO_DATE('15/4/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('22N62235',STR_TO_DATE('20/4/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('34N11415',STR_TO_DATE('6/5/2018', '%d/%m/%Y'));
insert into TIEPNHANXESUA (BIENSO,NGAYTIEPNHAN) values ('53B22484',STR_TO_DATE('12/5/2018', '%d/%m/%Y'));


insert into DOANHSO (MADOANHSO,THANG,TONGDOANHSO) values ('DS001',STR_TO_DATE('12/2017', '%m/%Y'),1850000);
insert into DOANHSO (MADOANHSO,THANG,TONGDOANHSO) values ('DS002',STR_TO_DATE('1/2018', '%m/%Y'),2000000);
insert into DOANHSO (MADOANHSO,THANG,TONGDOANHSO) values ('DS003',STR_TO_DATE('2/2018', '%m/%Y'),250000);
insert into DOANHSO (MADOANHSO,THANG,TONGDOANHSO) values ('DS004',STR_TO_DATE('3/2018', '%m/%Y'),1200000);
insert into DOANHSO (MADOANHSO,THANG,TONGDOANHSO) values ('DS005',STR_TO_DATE('4/2018', '%m/%Y'),2900000);


insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS001','HX005',3, 999000, 54);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS001','HX003',5, 481000, 26);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS001','HX001',2, 370000, 20);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS002','HX002',2, 1200000, 60);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS002','HX006',1, 800000, 40);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS003','HX002',2, 250000, 100);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS004','HX005',3, 1200000, 100);
insert into CHITIETDOANHSO (MADOANHSO,MAHIEUXE,SOLUOTSUA,THANHTIEN,TILE) values ('DS005','HX003',2, 2900000, 100);
