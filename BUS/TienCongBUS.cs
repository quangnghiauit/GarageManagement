using System.Data;
using DTO;
using DAO;




namespace BUS
{
	public class TienCongBUS
	{
		public static DataTable loadAllSalary()
		{
			return TienCongDAO.getData();
		}

		public static void addSalary(TienCongDTO tienCong)
		{
			TienCongDAO.InsertSalary(tienCong);
		}


		public static void delSalary(string _MaTienCong)
		{
			TienCongDAO.RemoveSalary(_MaTienCong);
		}


		public static bool cPrimaryKey(string _cPrim)
		{
			return TienCongDAO.CheckPrimary(_cPrim);
		}
	}
}
