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
		

		public static Boolean UpdateParameters( string exception="")
		{
			try
			{


				//query
				string query = string.Format("update THAMSO set SUDUNGQUYDINH4 = {0}, " +
					"SOTIENNOTOIDA = {1}, SOXESUACHUATOIDA = {2}",ThamSoDTO.SuDungQuyDinh4 ,ThamSoDTO.SoTienNoToiDa,ThamSoDTO.SoXeSuaChuaToiDa );

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


		public static Boolean GetParameters(string exception = "")
		{
			try
			{
				//query
				string query = string.Format("Select * from THAMSO");

				//excute reader
				MySqlDataReader reader = DatabaseConnectionDAO.ExcuteQuery(query, exception);

				//if there is no exception
				if (exception == "")
				{
					//get Parameters
					while (reader.Read())
					{
						ThamSoDTO.SoTienNoToiDa = decimal.Parse(reader.GetString("SoTienNoToiDa"));
						ThamSoDTO.SoXeSuaChuaToiDa = decimal.Parse(reader.GetString("SoXeSuaChuaToiDa"));
						ThamSoDTO.SuDungQuyDinh4 = bool.Parse( reader.GetString("SuDungQuyDinh4"));
					}
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
