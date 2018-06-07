using System.Data;
using DAO;

namespace BUS
{
	public class XeBUS
	{
		
		public static DataTable loadAllCar()
		{
			return XeDAO.getData();
		}
		
		public static void addCar(string BienSo, int MaKhachSuaXe, string MaHieuXe, int TienNo)
		{
			XeDAO.InsertCar(BienSo,  MaKhachSuaXe,MaHieuXe,  TienNo);
		}

		public static void updateCar(string BienSo, int MaKhachSuaXe, string MaHieuXe, int TienNo)
		{
			XeDAO.UpdateCar(BienSo, MaKhachSuaXe, MaHieuXe, TienNo);
		}



		public static void delCar(string BienSo, int MaKhachSuaXe, string MaHieuXe)
		{
			XeDAO.RemoveCar(BienSo, MaKhachSuaXe, MaHieuXe);
		}

		public static DataTable SearchAllCar(string _BienSo)
		{
			return XeDAO.SearchCar(_BienSo);

		}


		// Kiểm tra biển số nhập vào có trùng biển số
		public static bool cPrimaryKey(string _cPrim)
		{
			return XeDAO.KiemTraBienSo(_cPrim);
		}

		
		

		
	}
}
