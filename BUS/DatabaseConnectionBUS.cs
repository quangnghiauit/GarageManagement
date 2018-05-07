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
		public static bool ConnectToDatabase(string server,string database,string user,string password,string exception)
		{
			try
			{


				DatabaseConnectionDAO.connectionDatabase(server, database, user, password,exception);
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
	}
}
