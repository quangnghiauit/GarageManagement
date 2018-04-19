using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Data.SqlClient;
using System.Media;
using System.IO;

using System.Linq;

using System.Threading.Tasks;
using DTO;
using DAO;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

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

		public static DataTable SearchAllCar(string _BienSo, int _MaKhachSuaXe, string _MaHieuXe, string _TenChuXe, string _TenHieuXe, int _TienNo, string SoTienNoCompareType)
		{
			return XeDAO.SearchCar(_BienSo, _MaKhachSuaXe, _MaHieuXe,_TenChuXe,_TenHieuXe,_TienNo, SoTienNoCompareType);

		}


		// Kiểm tra biển số nhập vào có trùng biển số
		public static bool cPrimaryKey(string _cPrim)
		{
			return XeDAO.KiemTraBienSo(_cPrim);
		}

		
		

		
	}
}
