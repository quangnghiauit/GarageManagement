using System.Data;
using DTO;
using DAO;



namespace BUS
{
	public class KhachSuaXeBUS
	{
		
		public static DataTable loadAllCustomer()
		{
			return KhachSuaXeDAO.getData();
		}
		
		//public static void addCustomer(KhachSuaXeDTO kh)
		//{
		//	KhachSuaXeDAO.InsertCustomer(kh);
		//}
		public static bool InsertCustomer(KhachSuaXeDTO kh, string exception="")
		{
			return KhachSuaXeDAO.InsertCustomer(kh, exception);
			
		}




		public static void updateCustomer(KhachSuaXeDTO kh)
		{
			KhachSuaXeDAO.UpdateCustomer(kh);
		}
		
		public static bool  delCustomer(int _MaKhachSuaXe,string exception ="")
		{
			return KhachSuaXeDAO.RemoveCustomer(_MaKhachSuaXe,exception);
		}

		public static DataTable SearchAllCustomer(KhachSuaXeDTO kh, string SoTienNoCompareType)
		{
			return KhachSuaXeDAO.SearchCustomer(kh, SoTienNoCompareType);
			
		}

		
		public static bool cPrimaryKey(string _cPrim)
		{
			return KhachSuaXeDAO.CheckPrimary(_cPrim);
		}

		
	}
}
