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
