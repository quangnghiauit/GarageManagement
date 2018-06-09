using System.Data;
using DAO;
using DTO;
namespace BUS
{
	public class ChiTietPhieuSuaChuaBUS
	{
        public static DataTable selectAllChiTietPhieuSuaChua()
        {
            return ChiTietPhieuSuaChuaDAO.selectAllChiTietPhieuSuaChua();
        }

        public static void addChiTietPhieuSuaChua(ChiTietPhieuSuaChuaDTO ChiTiet)
        {
            ChiTietPhieuSuaChuaDAO.insertChiTietPhieuChuaChua(ChiTiet);
        }
    }
}
