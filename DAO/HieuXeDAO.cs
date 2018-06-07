using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
	public class HieuXeDAO
	{
		#region Get Databse
		/// <summary>
		/// Dung de lay du lieu tu DataBase
		/// </summary>
		/// <returns>Tra lai gia tri la mot Table</returns>
		public static DataTable getData()
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("LoadAllHIEUXE", Conn);


			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			Conn.Close();
			return dt;
		}
		
		
			 
		#endregion
		#region Add,Remove
		public static void ThemHieuXe(HieuXeDTO hx)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("InsertHIEUXE", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenHieuXe", MySqlDbType.VarChar, 100);

			cmd.Parameters["@_MaHieuXe"].Value = hx.MaHieuXe;
			cmd.Parameters["@_TenHieuXe"].Value = hx.TenHieuXe;

			

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		public static void XoaHieuXe(string _MaHieuXe)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("RemoveHIEUXE", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 10);
			cmd.Parameters["@_MaHieuXe"].Value = _MaHieuXe;
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		#endregion
		#region Check
		public static bool KiemTraKhoaChinh(string _textBox)
		{
			bool check = false;

			string cPrimaryKey = "Select *From HIEUXE Where MAHIEUXE = '" + _textBox + "' ";
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
		#endregion
	}
}
