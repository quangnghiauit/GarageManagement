using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChiTietPhieuSuaChuaDTO
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

		private Decimal thanhTien;
		public Decimal ThanhTien
		{
			get { return thanhTien; }
			set { thanhTien = value; }
		}

        public ChiTietPhieuSuaChuaDTO()
        {
            this.maPhieuSuaChua = "";
            this.noiDung = "";
            this.maVatTuPhuTung = ""; ;
            this.soLuongSuaChua = 0;
            this.tienCong = 0;
            this.thanhTien = 0;
        }

        public ChiTietPhieuSuaChuaDTO(string _maPhieuSuaChua, string _noiDung, string _maVatTuPhuTung, int _soLuongSuaChua, int _tienCong, Decimal _thanhTien)
		{			
			this.maPhieuSuaChua = _maPhieuSuaChua;
			this.noiDung = _noiDung;
			this.maVatTuPhuTung = _maVatTuPhuTung; ;
			this.soLuongSuaChua = _soLuongSuaChua;
			this.tienCong = _tienCong;
			this.thanhTien = _thanhTien;
		}

		~ChiTietPhieuSuaChuaDTO() { }
	}
}
