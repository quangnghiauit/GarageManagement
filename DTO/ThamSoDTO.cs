using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class ThamSoDTO
	{
		private int tiepNhanSuaToiDa;
		public int TiepNhanSuaToiDa
		{
			get { return tiepNhanSuaToiDa; }
			set { tiepNhanSuaToiDa = value; }
		}

		private string danhSachLoaiPhuTung;
		public string DanhSachLoaiPhuTung
		{
			get { return danhSachLoaiPhuTung; }
			set { danhSachLoaiPhuTung = value; }
		}

		private string danhSachLoaiTienCong;
		public string DanhSachLoaiTienCong
		{
			get { return danhSachLoaiTienCong; }
			set { danhSachLoaiTienCong = value; }
		}

		private bool suDungQuyDinh4;
		public bool SuDungQuyDinh4
		{
			get { return suDungQuyDinh4; }
			set { suDungQuyDinh4 = value; }
		}

		private int soLuongHieuXeToiDa;
		public int SoLuongHieuXeToiDa
		{
			get { return soLuongHieuXeToiDa; }
			set { soLuongHieuXeToiDa = value; }
		}

		private int soXeSuaChuaToiDa;
		public int SoXeSuaChuaToiDa
		{
			get { return soXeSuaChuaToiDa; }
			set { soXeSuaChuaToiDa = value; }
		}

		private int soLoaiVatTuPhuTung;
		public int SoLoaiVatTuPhuTung
		{
			get { return soLoaiVatTuPhuTung; }
			set { soLoaiVatTuPhuTung = value; }
		}

		private int soLoaiTienCong;
		public int SoLoaiTienCong
		{
			get { return soLoaiTienCong; }
			set { soLoaiTienCong = value; }
		}

		public ThamSoDTO(int tiepNhanSuaToiDa, string danhSachLoaiPhuTung, string danhSachLoaiTienCong, bool suDungQuyDinh4, int soLuongHieuXeToiDa, int soXeSuaChuaToiDa, int soLoaiVatTuPhuTung, int soLoaiTienCong)
		{
			this.tiepNhanSuaToiDa = tiepNhanSuaToiDa;
			this.danhSachLoaiPhuTung = danhSachLoaiPhuTung;
			this.danhSachLoaiTienCong = danhSachLoaiTienCong;
			this.suDungQuyDinh4 = suDungQuyDinh4;
			this.soLuongHieuXeToiDa = soLuongHieuXeToiDa;
			this.soXeSuaChuaToiDa = soXeSuaChuaToiDa;
			this.soLoaiVatTuPhuTung = soLoaiVatTuPhuTung;
			this.soLoaiTienCong = soLoaiTienCong;
		}

		~ThamSoDTO() { }
	}
}
