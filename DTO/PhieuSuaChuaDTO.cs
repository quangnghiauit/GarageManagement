using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuSuaChuaDTO
	{
		private string maPhieuSuaChua;
		public string MaPhieuSuaChua
		{
			get { return maPhieuSuaChua; }
			set { maPhieuSuaChua = value; }
		}

		private string bienSo;
		public string BienSo
		{
			get { return bienSo; }

			set { bienSo = value; }
		}

		private DateTime ngaySuaChua;
		public DateTime NgaySuaChua
		{
			get { return ngaySuaChua; }

			set { ngaySuaChua = value; }
		}

		private Decimal tongTien;
		public Decimal TongTien
		{
			get { return tongTien; }
			set { tongTien = value; }
		}

		private string maKhachSuaXe;
		public string MaKhachSuaXe
		{
			get { return maKhachSuaXe; }
			set { maKhachSuaXe = value; }
		}

        public PhieuSuaChuaDTO()
        {
            this.maPhieuSuaChua = "";
            this.bienSo = "";
            this.ngaySuaChua = new DateTime();
            this.tongTien = 0;
        }

		public PhieuSuaChuaDTO(string maPhieuSuaChua, string bienSo, DateTime ngaySuaChua, Decimal tongTien)
		{
			this.maPhieuSuaChua = maPhieuSuaChua;
			this.bienSo = bienSo;
			this.ngaySuaChua = ngaySuaChua;
			this.tongTien = tongTien;
		}

		~PhieuSuaChuaDTO() { }
	}
}
