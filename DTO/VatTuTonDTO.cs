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

        private decimal thang;
        public decimal Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        private decimal nam;
        public decimal Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        VatTuTonDTO()
        {
            this.maVatTuPhuTung = "";
            this.soLuongTon = 0;
            this.thang = 0;
            this.nam = 0;
        }

        VatTuTonDTO(string _MaVatTuPhuTung, int _SoLuongTon, decimal _Thang, decimal _Nam)
        {
            this.maVatTuPhuTung = _MaVatTuPhuTung;
            this.soLuongTon = _SoLuongTon;
            this.thang = _Thang;
            this.nam = _Nam;
        }

        ~VatTuTonDTO() { }
    }
}
