using System.Data;
using DAO;
using DTO;

namespace BUS
{
	public class ChiTietTonBUS
	{
        public static void addChiTietTon(string MaBaoCao, int _Month, int _Year)
        {
            ChiTietTonDAO.insertChiTietTon(MaBaoCao, _Month,_Year);
        }        
    }
}
