using DAO;
using System.Data;
using DTO;


namespace BUS
{
	public class PhieuSuaChuaBUS
	{
        public static DataTable selectAllPhieuSuaChua()
        {
            return PhieuSuaChuaDAO.selectAllPhieuSuaChua();
        }

        public static void addPhieuSuaChua(PhieuSuaChuaDTO PhieuSuaChua)
        {
            PhieuSuaChuaDAO.insertPHIEUSUACHUA(PhieuSuaChua);
        }
    }
}
