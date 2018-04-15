using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class ChiTietDoanhSoDTO
	{
		private string maChiTietDoanhSo;
		public string MaChiTietDoanhSo
		{
			get { return maChiTietDoanhSo; }
			set { maChiTietDoanhSo = value; }
		}

		private string maDoanhSo;
		public string MaDoanhSo
		{
			get { return maDoanhSo; }
			set { maDoanhSo = value; }
		}

		private string maHieuXe;
		public string MaHieuXe
		{
			get { return maHieuXe; }
			set { maHieuXe = value; }
		}

		private int soLuotSua;
		public int SoLuotSua
		{
			get { return soLuotSua; }
			set { soLuotSua = value; }
		}

		private int thanhTien;
		public int ThanhTien
		{
			get { return thanhTien; }
			set { thanhTien = value; }
		}

		private int tiLe;
		public int TiLe
		{
			get { return tiLe; }
			set { tiLe = value; }
		}

		public ChiTietDoanhSoDTO(string maChiTietDoanhSo, string maDoanhSo, string maHieuXe, int soLuotSua, int thanhTien, int tiLe)
		{
			this.maChiTietDoanhSo = maChiTietDoanhSo;
			this.maDoanhSo = maDoanhSo;
			this.maHieuXe = maHieuXe;
			this.soLuotSua = soLuotSua;
			this.tiLe = tiLe;
		}

		~ChiTietDoanhSoDTO() { }
	}
}
