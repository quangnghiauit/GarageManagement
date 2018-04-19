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
	public class KhachSuaXeBUS
	{
		
		public static DataTable loadAllCustomer()
		{
			return KhachSuaXeDAO.getData();
		}
		
		public static void addCustomer(KhachSuaXeDTO kh)
		{
			KhachSuaXeDAO.InsertCustomer(kh);
		}
		
		public static void updateCustomer(KhachSuaXeDTO kh)
		{
			KhachSuaXeDAO.UpdateCustomer(kh);
		}
		
		public static void delCustomer(int _MaKhachSuaXe)
		{
			KhachSuaXeDAO.RemoveCustomer(_MaKhachSuaXe);
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
