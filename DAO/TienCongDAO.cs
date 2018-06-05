using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAO
{
	public class TienCongDAO
	{

		public static DataTable getData()
		{
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("LoadAllSalary", Conn);


			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			Conn.Close();
			return dt;
		}


		public static void InsertSalary(TienCongDTO tienCong)
		{
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();



			MySqlCommand cmd = new MySqlCommand("InsertSalary", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaTienCong", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenTienCong", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_SoTienCong", MySqlDbType.Decimal);


			cmd.Parameters["@_MaTienCong"].Value = tienCong.maTienCong;
			cmd.Parameters["@_TenTienCong"].Value = tienCong.tenTienCong;
			cmd.Parameters["@_SoTienCong"].Value = tienCong.soTienCong;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		public static void RemoveSalary(string _MaTienCong)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("RemoveSalary", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaTienCong", MySqlDbType.VarChar, 10);
			cmd.Parameters["@_MaTienCong"].Value = _MaTienCong;
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		public static bool CheckPrimary(string _textBox)
		{
			bool check = false;

			string cPrimaryKey = "Select *From TIENCONG Where MaTienCong = '" + _textBox + "' ";
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand(cPrimaryKey, Conn);
			cmd.CommandType = CommandType.Text;
			Conn.Open();
			MySqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				check = true;
			}

			return check;
		}
	}
}
