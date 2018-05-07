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



namespace DAO

{

	public class DatabaseConnectionDAO
	{

		public static MySqlConnection connectionDatabase()
		{

			MySqlConnection Conn = new MySqlConnection("Server = localhost ; Database = gara; port = 3306 ; User Id = root ; password = 123456");

			return Conn;
		}

		public static MySqlConnection connectionDatabase(string strServer,string strDatabase,string strUser,string strPassword,string exception="")
		{
			MySqlConnection Conn = new MySqlConnection();
			try
			{
				
				Conn.ConnectionString = String.Format("Server = {0} ; Database = {1}; port = 3306 ; User Id = {2} ; password = {3}", strServer, strDatabase, strUser, strPassword);
				Conn.Open();
			}
			catch(MySqlException ex)
			{
				exception = ex.Message;
			}
			return Conn;
		}
	}

}


