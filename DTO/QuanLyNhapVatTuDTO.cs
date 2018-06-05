using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyNhapVatTuDTO
    {
        private string maVatTuPhuTung;
        public string MaVatTuPhuTung
        {
            get { return maVatTuPhuTung; }
            set { maVatTuPhuTung = value; }
        }

        private int soLuongNhap;
        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }

        private DateTime ngayNhap;
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public QuanLyNhapVatTuDTO()
        {
            this.maVatTuPhuTung = "";
            this.soLuongNhap = 0;
            this.ngayNhap = new DateTime();
        }

        public QuanLyNhapVatTuDTO(string _MaVatTuPhuTung, int _SoLuongNhap, DateTime _NgayNhap)
        {
            this.maVatTuPhuTung = _MaVatTuPhuTung;
            this.soLuongNhap = _SoLuongNhap;
            this.ngayNhap = _NgayNhap;
        }

        ~QuanLyNhapVatTuDTO() { }
    }
}
