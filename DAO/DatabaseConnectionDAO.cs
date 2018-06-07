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
using DAO.Properties;



namespace DAO

{

	public class DatabaseConnectionDAO
	{
		private static MySqlDataReader _reader = null;
		private static MySqlConnection Conn = null;
		private static MySqlDataAdapter _adapter;

		public static string ConnectionString { get; set; }
		public static string ServerName { get; set; }
		public static string DatabaseName { get; set; }
		public static string UserID { get; set; }
		public static string Password { get; set; }


		public  DatabaseConnectionDAO()
		{
			ConnectionString = Settings.Default.ConnectionString;
			ServerName = Settings.Default.ServerName;
			DatabaseName = Settings.Default.DatabaseName;
			UserID = Settings.Default.UserID;
			Password = Settings.Default.Password;
		}

		public static void SaveChangeConection()
		{
			Settings.Default.ServerName = ServerName;
			Settings.Default.DatabaseName = DatabaseName;
			Settings.Default.UserID = UserID;
			Settings.Default.Password = Password;
			Settings.Default.ConnectionString = ConnectionString;
			Settings.Default.Save();
		}

		public static MySqlConnection connectionDatabase()
		{
			ConnectionString = string.Format("Server = {0} ; Database = {1}; port = 3306 ; User Id = {2} ; password = {3} ", ServerName, DatabaseName,UserID,Password);
			MySqlConnection Conn = new MySqlConnection(ConnectionString);

			return Conn;
		}

		public static MySqlConnection connectionDatabase(string strServer,string strDatabase,string strUser,string strPassword,ref string exception)
		{
			//
			ServerName = strServer;
			DatabaseName = strDatabase;
			UserID = strUser;
			Password = strPassword;
			//
			MySqlConnection Conn = new MySqlConnection();
			try
			{

				Conn.ConnectionString = String.Format("Server = {0} ; Database = {1}; port = 3306 ; User Id = {2} ; password = {3}", ServerName, DatabaseName, UserID, Password);
				Conn.Open();

			}
			catch(MySqlException ex)
			{
				exception = ex.Message;
			}
			return Conn;
		}
		public static void DisConnectFromDatabase(string exception ="")
		{
			try
			{
				Conn.Close();
			}
			catch(MySqlException ex)
			{
				exception = ex.Message;
			}
			Conn.Dispose();
			if(_reader != null)
			{
				_reader.Dispose();
			}
			if(_adapter!=null)
			{
				_adapter.Dispose();
			}

			

		}
		public static MySqlDataReader ExcuteQuery(string query , string exception ="")
		{
			// we have to close previous reader first to be able to excute new reader
			if(!(_reader ==null))
			{
				_reader.Close();
			}

			MySqlCommand command = new MySqlCommand(query, Conn);
			//Excute reader
			try
			{
				_reader = command.ExecuteReader();
			}
			catch(MySqlException ex)
			{
				exception = ex.Message;
			}
			command.Dispose();
			return _reader;
		
		}

		public static MySqlDataReader ExcuteProcedure(string procedureName,ref string exception, MySqlParameter[] values)
		{
			//we have to close previous reader first to be able to excute new reader
			if(!(_reader==null))
			{
				_reader.Close();

			}
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			Conn.Open();
			//Excute reader
			MySqlCommand command = new MySqlCommand(procedureName, Conn);
			try
			{
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.AddRange(values);
				_reader = command.ExecuteReader();
			
			}
			catch (MySqlException ex)
			{
				exception = ex.Message;
			}
			command.Dispose();
			return _reader;

		}
	}

}


