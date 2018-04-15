using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	class DoanhSoDTO
	{
		private string maDoanhSo;
		public string MaDoanhSo
		{
			get { return maDoanhSo; }

			set { maDoanhSo = value; }
		}

		private int thang;
		public int Thang
		{
			get { return thang; }
			set { thang = value; }
		}

		private Int64 tongDoanhThu;
		public Int64 TongDoanhThu
		{
			get { return tongDoanhThu; }
			set { tongDoanhThu = value; }
		}

		public DoanhSoDTO(string maDoanhSo, int thang, Int64 tongDoanhThu)
		{
			this.maDoanhSo = maDoanhSo;
			this.thang = thang;
			this.tongDoanhThu = tongDoanhThu;
		}

		~DoanhSoDTO() { }
	}
}
