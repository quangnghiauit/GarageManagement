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
		private static MySqlDataReader _reader = null;
		private static MySqlConnection _mySql = null;
		private static MySqlDataAdapter _adapter;




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
		public static void DisConnectFromDatabase(string exception ="")
		{
			try
			{
				_mySql.Close();
			}
			catch(MySqlException ex)
			{
				exception = ex.Message;
			}
			_mySql.Dispose();
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

			MySqlCommand command = new MySqlCommand(query, _mySql);
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

		public static MySqlDataReader ExcuteProcedure(string procedureName,string exception, MySqlParameter[] values)
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


