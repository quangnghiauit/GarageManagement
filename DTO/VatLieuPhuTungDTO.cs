using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class VatTuPhuTungDTO 
	{
		private string maVatTuPhuTung;
		public string MaVatTuPhuTung
		{
			get { return maVatTuPhuTung; }
			set { maVatTuPhuTung = value; }
		}

		private string tenVatTuPhuTung;
		public string TenVatTuPhuTung
		{
			get { return tenVatTuPhuTung; }
			set { tenVatTuPhuTung = value; }
		}

		private int donGia;
		public int DonGia
		{
			get { return donGia; }
			set { donGia = value; }
		}

		private int soLuongVatTu;
		public int SoLuongVatTu
		{
			get { return soLuongVatTu; }
			set { soLuongVatTu = value; }
		}

        //Thuoc tinh moi SoLuongTon
        private int soLuongTon;
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
		public VatTuPhuTungDTO()
		{
			maVatTuPhuTung = "";
			tenVatTuPhuTung = "";
			donGia = 0;
			soLuongVatTu = 0;
            soLuongTon = 0;
		}

		public VatTuPhuTungDTO(string maVatTuPhuTung, string tenVatTuPhuTung, int donGia, int soLuongVatTu)
		{
			this.maVatTuPhuTung = maVatTuPhuTung;
			this.tenVatTuPhuTung = tenVatTuPhuTung;
			this.donGia = donGia;
			this.soLuongVatTu = soLuongVatTu;
		}

		~VatTuPhuTungDTO() { }
	}
}
