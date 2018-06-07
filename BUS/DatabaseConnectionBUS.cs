using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

using System.Data.SqlClient;
using DAO;

namespace BUS
{
	public class DatabaseConnectionBUS
	{
		public static bool ConnectToDatabase(string server,string database,string user,string password,ref string exception)
		{
			try
			{


				DatabaseConnectionDAO.connectionDatabase(server, database, user, password,ref exception);
				if(exception == "")
				{
					return true;
				}
			}
			catch(Exception ex)
			{
				exception = ex.Message;
			}
			return false;
		}

		public static bool DisConnectToDatabase(string exception ="")
		{
			try
			{
				DatabaseConnectionDAO.DisConnectFromDatabase();
				return true;
			}
			catch(Exception ex)
			{
				exception = ex.Message;
			}
			return false;
		}

		public static void SaveChangeConection()
		{
			DatabaseConnectionDAO.SaveChangeConection();
		}
	}
}
