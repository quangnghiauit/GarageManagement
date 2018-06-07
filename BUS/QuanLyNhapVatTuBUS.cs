using DAO;
using DTO;

namespace BUS
{
    public class QuanLyNhapVatTuBUS
    {
        public static void addQuanLyNhapVatTu(QuanLyNhapVatTuDTO QuanLy)
        {
            QuanLyNhapVatTuDAO.insertQuanLyNhapVatTu(QuanLy);
        }

        public static void removeQuanLyNhapVatTu(string MaVatTu)
        {
            QuanLyNhapVatTuDAO.deleteQuanLyNhapVatTu(MaVatTu);
        }
    }
}
