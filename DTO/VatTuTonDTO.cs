using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VatTuTonDTO
    {
        private string maVatTuPhuTung;
        public string MaVatTuPhuTung
        {
            get { return maVatTuPhuTung; }
            set { maVatTuPhuTung = value; }
        }
        private int soLuongTon;
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        private DateTime thang;
        public DateTime Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        VatTuTonDTO()
        {
            this.maVatTuPhuTung = "";
            this.soLuongTon = 0;
            this.thang = new DateTime();
        }

        VatTuTonDTO(string _MaVatTuPhuTung, int _SoLuongTon, DateTime _NgayNhap)
        {
            this.maVatTuPhuTung = _MaVatTuPhuTung;
            this.soLuongTon = _SoLuongTon;
            this.thang = _NgayNhap;
        }

        ~VatTuTonDTO() { }
    }
}
