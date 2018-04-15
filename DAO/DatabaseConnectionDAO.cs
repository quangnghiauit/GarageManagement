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

		public static MySqlConnection HamKetNoi()
		{

			MySqlConnection Conn = new MySqlConnection("Server = localhost ; Database = gara; port = 3306 ; User Id = root ; password = 123456");

			return Conn;
		}

	}

}


