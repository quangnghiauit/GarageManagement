using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class ChiTietTonDTO
	{
		private string maChiTietBaoCaoTon;
		public string MaChiTietBaoCaoTon
		{
			get { return maChiTietBaoCaoTon; }
			set { maChiTietBaoCaoTon = value; }
		}

		private string maBaoCaoTon;
		public string MaBaoCaoTon
		{
			get { return maBaoCaoTon; }
			set { maBaoCaoTon = value; }
		}

		private string maVatTuPhuTung;
		public string MaVatTuPhuTung
		{
			get { return maVatTuPhuTung; }
			set { maVatTuPhuTung = value; }
		}

		private int tonDau;
		public int TonDau
		{
			get { return tonDau; }
			set { tonDau = value; }
		}

		private int tonPhatSinh;
		public int TonPhatSinh
		{
			get { return tonPhatSinh; }
			set { tonPhatSinh = value; }
		}

		private int tonCuoi;
		public int TonCuoi
		{
			get { return tonCuoi; }
			set { TonCuoi = value; }
		}

		public ChiTietTonDTO(string maChiTietBaoCaoTon, string maBaoCaoTon, string maVatTuPhuTung, int tonDau, int tonPhatSinh, int tonCuoi)
		{
			this.maChiTietBaoCaoTon = maChiTietBaoCaoTon;
			this.maBaoCaoTon = maBaoCaoTon;
			this.maVatTuPhuTung = maVatTuPhuTung;
			this.tonDau = tonDau;
			this.tonPhatSinh = tonPhatSinh;
			this.tonCuoi = tonCuoi;
		}

		~ChiTietTonDTO() { }
	}
}
