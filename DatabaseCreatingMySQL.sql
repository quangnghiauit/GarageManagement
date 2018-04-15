CREATE SCHEMA GARA;
#drop SCHEMA GARA;
USE GARA;

CREATE TABLE PHIEUTHUTIEN
(
	MAPHIEUTHUTIEN CHAR(10) NOT NULL,
	BIENSO CHAR(10), 
	NGAYTHUTIEN DATE,
	SOTIENTHU DECIMAL, 
	PRIMARY KEY (MAPHIEUTHUTIEN)
);

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
	MAKHACHSUAXE CHAR(10),
	DIENTHOAI CHAR(20),
	DIACHI CHAR(100),
	MAHIEUXE CHAR(10),
	PRIMARY KEY (BIENSO)
);

CREATE TABLE TIEPNHANXESUA
(
	MATIEPNHANXESUA CHAR(10) NOT NULL,
	BIENSO CHAR(10),
	NGAYTIEPNHAN DATE,
	PRIMARY KEY (MATIEPNHANXESUA)
);

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
	MAKHACHSUAXE CHAR(10) NOT NULL,
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
	MAPHIEUSUACHUA CHAR(10) NOT NULL,
	BIENSO CHAR(20),
	NGAYSUACHUA DATE,
	TONGTIEN DECIMAL,
	MAKHACHSUAXE CHAR(10),
	PRIMARY KEY (MAPHIEUSUACHUA)
);

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
	MACTPHIEUSUAXE CHAR(10) NOT NULL,
	MAPHIEUSUACHUA CHAR(10),
	NOIDUNG CHAR(100),
	MAVATTUPHUTUNG CHAR(10),
	SOLUONGSUACHUA INT,
	TIENCONG DECIMAL, 
	THANHTIEN DECIMAL,
	PRIMARY KEY (MACTPHIEUSUAXE)
);

CREATE TABLE HIEUXE
(
	MAHIEUXE CHAR(10) NOT NULL,
	TENHIEUXE CHAR(100),
	PRIMARY KEY (MAHIEUXE)
);

CREATE TABLE THAMSO
(
	TIEPNHANSUACHUATOIDA INT,
	SOLOAIPHUTUNG INT,
	SOLOAITIENCONG INT,
	SUDUNGQUYDINH4 BOOL,
	SOLUONGHIEUXETOIDA INT,
	SOXESUACHUATOIDA INT
);
alter table CHITIETDOANHSO add foreign key (MADOANHSO) references DOANHSO (MADOANHSO);
alter table TIEPNHANXESUA add foreign key (BIENSO) references XE (BIENSO);
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


DELIMITER //
create procedure insertTIEPNHANXESUA ( in _TenChuXe char(100), in _BienSo char(10), in _DiaChi char(100), in _DienThoai char(20), in _MaHieuXe char(10), in _NgayTiepNhan date)
Begin
	insert into TIEPNHANXESUA values ( _BienSo, _NgayTiepNhan);
	insert into KHACHSUAXE value ( _TenChuXe, _DienThoai);
	insert into XE value ( _MaHieuXe, _DiaChi);
End //
DELIMITER ; 

DELIMITER //
Create Procedure UpdateTIEPNHANXESUA(in _TenChuXe char(100), in _BienSo char(10), in _DiaChi char(100), in _DienThoai char(20), in _MaHieuXe char(10), in _NgayTiepNhan date)
Begin
	update TIEPNHANHXESUA set NgayTiepNhan = _NgayTiepNhan where BIENSO = _BienSo;
	update KHACHSUAXE set TenChuXe = _TenChuXe, DienThoai = _DienThoai;
	update XE set DiaChi = _DiaChi where MaHieuXe = _MaHieuXe;
End //
DELIMITER ;

DELIMITER //
Create Procedure LoadAllKHACHSUAXE()
Begin
	select MaKhachSuaXe as 'Mã khách sửa xe', TenChuXe as 'Tên Chủ Xe', DienThoai as 'Điện Thoại', DiaChi as 'Địa Chỉ', Email as 'Email', TienNo as 'Tiền Nợ' from KHACHSUAXE;
End //
DELIMITER ;

DELIMITER //
Create Procedure InsertKHACHSUAXE( in _MaKhachSuaXe char(10), in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal)
Begin
	insert into KHACHSUAXE values(_MaKhachSuaXe, _TenChuXe, _DienThoai,_DiaChi, _Email, _TienNo);
End //
DELIMITER ;

DELIMITER //
Create Procedure UpdateKHACHSUAXE(in _MaKhachSuaXe char(10), in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal)
Begin
	update KHACHSUAXE set TenChuXe = _TenChuXe, DienThoai = _DienThoai,DiaChi=_DiaChi, Email = _Email, TienNo = _TienNo where MaKhachSuaXe = _MaKhachSuaXe;
End //
DELIMITER ;

DELIMITER //
Create Procedure RemoveKHACHSUAXE(in _MaKhachSuaXe char(10))
Begin
	delete from KHACHSUAXE where  MaKhachSuaXe = _MaKhachSuaXe;
End //

DELIMITER ;


DELIMITER //
Create Procedure UpdateTienNo (in _MaKhachHang char(10), in _SoTien decimal)
Begin
	update KhachHang set TienNo = TienNo + _SoTien where MaKhachHang=_MaKhachHang;
End //
DELIMITER ;

DELIMITER //
Create Procedure FindCustomer (in _MaKhachSuaXe char(10))
Begin	
   
    select *
    from KHACHSUAXE
    where MaKhachSuaXe = _MaKhachSuaXe;
          	
End //
DELIMITER ;

DELIMITER // 
create procedure FindCustomers (in _MaKhachSuaXe char(10), in _TenChuXe char(100), in _DienThoai char(20),in _DiaChi char(100), in _Email char(40), in _TienNo decimal, in _SoTienNoCompareType varchar(2))
Begin 
		create temporary table SoTienNoTable (MaKhachSuaXe char(10));
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
create procedure TimXE ( in _BienSo char(10), in _MaKhachSuaXe char(10))
Begin 
	select *
    from XE
    where BienSo = _BienSo and MaKhachSuaXe = _MaKhachSuaXe;
End //
DELIMITER ;


DELIMITER // 
create procedure InsertVATTUPHUTUNG ( in _MaVatTuPhuTung char(10), in _TenVatTuPhuTung char(100), in _DonGia decimal, in _SoLuongVatTu int)
Begin 
	Insert into VATTUPHUTUNG values (_MaVatTuPhuTung, _TenVatTuPhuTung, _DonGia, _SoluongVatTu);
End //
DELIMITER ;

DELIMITER // 
create procedure UpdateVATTUPHUTUNG (  in _MaVatTuPhuTung char(10), in _TenVatTuPhuTung char(100), in _DonGia decimal, in _SoLuongVatTu int)
Begin 
	update VATTUPHUTUNG set TenVatTuPhuTung = _TenVatTuPhuTung, DonGia = _DonGia, SoLuongVatTu = _SoLuongVatTu
    where MaVatTuPhuTung = _MaVatTuPhuTung;
End //
DELIMITER ;

DELIMITER //
create procedure UpdateSoLuong (in _MaVatTuPhuTung char(10), in _SoLuong int)
Begin
	update VATTUPHUTUNG set SoLuongVatTu = SoLuongVatTu + _SoLuong;
End //
DELIMITER ;

DELIMITER //
Create Procedure TimVATTUPHUTUNG (in _MaVatTuPhuTung char(10))
Begin	
   
    select *
    from VATTUPHUTUNG
    where MaVatTuPhuTung = _MaVatTuPhuTung;
End //
DELIMITER ;


/*Procedure dung cho PHIEUTHUTIEN*/
DELIMITER // 
create procedure InsertPHIEUTHUTIEN ( in _BienSo char(10), in _NgayThuTien date, in _SoTienThu decimal)
Begin 
	Insert into PHIEUTHUTIEN values (_BienSo, _NgayThuTien, _SoTienThu);
End //
DELIMITER ;

DELIMITER //
Create Procedure SelectAllPHIEUTHUTIEN()
Begin
	select BienSo as 'Biển số', NgayThuTien as 'Ngày thu tiền', SoTienThu as 'Số tiền thu' from PHIEUTHUTIEN;
End //
DELIMITER ;


/* xóa procedure SelectALLPHIEUTHUTIEN và tạo lại bằng cái create đã được chỉnh sửa */
/*drop procedure SelectALLPHIEUTHUTIEN*/

/*Procedure dung cho TIEPNHANXESUA*/
DELIMITER //
Create Procedure SelectAllTIEPNHANXESUA()
Begin
	select BienSo as 'Biển số', NgayTiepNhan as 'Ngày tiếp nhận' from TIEPNHANXESUA;
End //
DELIMITER ;

DELIMITER // 
create procedure InsertTIEPNHANXESUA ( in _BienSo char(10), in _NgayTiepNhan date)
Begin 
	Insert into PHIEUTHUTIEN values (_BienSo, _NgayTiepNhan);
End //
DELIMITER ;




