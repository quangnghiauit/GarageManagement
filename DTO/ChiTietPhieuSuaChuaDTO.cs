using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class ChiTietPhieuSuaChuaDTO
	{
		private string maChiTietPhieuSuaChua;
		public string MaChiTietPhieuSuaChua
		{
			get { return maChiTietPhieuSuaChua; }
			set { maChiTietPhieuSuaChua = value; }
		}

		private string maPhieuSuaChua;
		public string MaPhieuSuaChua
		{
			get { return maPhieuSuaChua; }
			set { maPhieuSuaChua = value; }
		}

		private string noiDung;
		public string NoiDung
		{
			get { return noiDung; }
			set { noiDung = value; }
		}

		private string maVatTuPhuTung;
		public string MaVatTuPhuTung
		{
			get { return maVatTuPhuTung; }
			set { maVatTuPhuTung = value; }
		}

		private int soLuongSuaChua;
		public int SoLuongSuaChua
		{
			get { return soLuongSuaChua; }
			set { soLuongSuaChua = value; }
		}

		private int tienCong;
		public int TienCong
		{
			get { return tienCong; }
			set { tienCong = value; }
		}

		private Int64 thanhTien;
		public Int64 ThanhTien
		{
			get { return thanhTien; }
			set { thanhTien = value; }
		}

		public ChiTietPhieuSuaChuaDTO(string maChiTietPhieuSuaChua, string maPhieuSuaChua, string noiDung, string maVatTuPhuTung, int soLuongSuaChua, int tienCong, Int64 thanhTien)
		{
			this.maChiTietPhieuSuaChua = maChiTietPhieuSuaChua;
			this.maPhieuSuaChua = maPhieuSuaChua;
			this.noiDung = noiDung;
			this.maVatTuPhuTung = maVatTuPhuTung; ;
			this.soLuongSuaChua = soLuongSuaChua;
			this.tienCong = tienCong;
			this.thanhTien = thanhTien;
		}

		~ChiTietPhieuSuaChuaDTO() { }
	}
}
