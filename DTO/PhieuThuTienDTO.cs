using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuThuTienDTO
	{
		private string maPhieuThuTien;
		public string MaPhieuThuTien
		{
			get { return maPhieuThuTien; }

			set { maPhieuThuTien = value; }
		}

		private string bienSo;
		public string BienSo
		{
			get { return bienSo; }

			set { bienSo = value; }
		}

		private DateTime ngayThuTien;
		public DateTime NgayThuTien
		{
			get { return ngayThuTien; }
			set { ngayThuTien = value; }
		}

		private int soTienThu;
		public int SoTienThu
		{
			get { return soTienThu; }
			set { soTienThu = value; }
		}
        private int soTienTraKhach;
        public int SoTienTraKhach
        {
            get { return soTienTraKhach; }
            set { soTienTraKhach = value; }
        }

        private int soTienKhachTra;
        public int SoTienKhachTra
        {
            get { return soTienKhachTra; }
            set { soTienKhachTra = value; }
        }

        public PhieuThuTienDTO()
        {
            maPhieuThuTien = "";
            bienSo = "";
            ngayThuTien = new DateTime();
            soTienThu = 0;
            soTienTraKhach = 0;
            soTienKhachTra = 0;
        }

		public PhieuThuTienDTO(string maPhieuThuTien, string bienSo, DateTime ngayThuTien, int soTienThu, int soTienKhachTra, int soTienTraKhach)
		{
			this.maPhieuThuTien = maPhieuThuTien;
			this.BienSo = bienSo;
			this.ngayThuTien = ngayThuTien;
			this.soTienThu = soTienThu;
            this.soTienKhachTra = soTienKhachTra;
            this.soTienTraKhach = soTienTraKhach;            
		}

		~PhieuThuTienDTO() { }
	}
}
