using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

using System.Data;


namespace DAO
{
	public class ThamSoDAO
	{
		

		public static Boolean UpdateParameters(bool _SuDungQuyDinh4, int _SoTienNoToiDa, int _SoXeSuaChuaToiDa,   string exception="")
		{
			try
			{


				//query
				string query = string.Format("update THAMSO set SUDUNGQUYDINH4 = {0}, " +
					"SOTIENNOTOIDA = {1}, SOXESUACHUATOIDA = {2}", _SuDungQuyDinh4, _SoTienNoToiDa, _SoXeSuaChuaToiDa);

				//excute reader
				MySqlDataReader reader = DatabaseConnectionDAO.ExcuteQuery(query, exception);

				if (exception == "")
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


		//public static Boolean GetParameters( string exception ="")
		//{
		//	try
		//	{
		//		//query
		//		string query = string.Format("Select * from THAMSO");

		//		//excute reader
		//		MySqlDataReader reader = DatabaseConnectionDAO.ExcuteQuery(query, exception);

		//		//if there is no exception
		//		if(exception=="")
		//		{
		//			//get Parameters
		//			while (reader.Read())
		//			{
		//				ThamSoDTO thamSoDTO;
		//				thamSoDTO.SuDungQuyDinh4 = reader.GetBoolean("SUDUNGQUYDINH4");
		//			}
		//		}



		//	}
		//}



		
	}
}
