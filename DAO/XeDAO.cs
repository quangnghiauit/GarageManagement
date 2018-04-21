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
	public class XeDAO
	{
		#region Get Databse
		/// <summary>
		/// Dung de lay du lieu tu DataBase
		/// </summary>
		/// <returns>Tra lai gia tri la mot Table</returns>
		public static DataTable getData()
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("LoadAllCar", Conn);


			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			Conn.Close();
			return dt;
		}
		#endregion
		#region Insert, Update, Remove
		

		public static void InsertCar(string BienSo,int MaKhachSuaXe,string MaHieuXe,int TienNo)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();



			MySqlCommand cmd = new MySqlCommand("InsertCar", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 20);
			
			cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
			cmd.Parameters["@_BienSo"].Value = BienSo;
			cmd.Parameters["@_MaKhachSuaXe"].Value = MaKhachSuaXe;

			cmd.Parameters["@_MaHieuXe"].Value = MaHieuXe;

			cmd.Parameters["@_TienNo"].Value = TienNo;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}


		public static void UpdateCar(string BienSo, int MaKhachSuaXe, string MaHieuXe, int TienNo)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("UpdateCar", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 20);

			cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
			cmd.Parameters["@_BienSo"].Value = BienSo;
			cmd.Parameters["@_MaKhachSuaXe"].Value = MaKhachSuaXe;

			cmd.Parameters["@_MaHieuXe"].Value = MaHieuXe;

			cmd.Parameters["@_TienNo"].Value = TienNo;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}




		public static void RemoveCar(string BienSo, int MaKhachSuaXe, string MaHieuXe)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("RemoveCar", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 20);

			
			cmd.Parameters["@_BienSo"].Value = BienSo;
			cmd.Parameters["@_MaKhachSuaXe"].Value = MaKhachSuaXe;

			cmd.Parameters["@_MaHieuXe"].Value = MaHieuXe;

			
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}





		#endregion


		#region Find Customers
		//Tìm xe theo bien so
		public static void FindCarByID(XeDTO xe)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("FindCar", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);

			cmd.Parameters["@_BienSo"].Value = xe.BienSo;


			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		//Tìm xe theo nhiều điều kiện
		public static DataTable SearchCar(string _BienSo , int _MaKhachSuaXe , string  _MaHieuXe ,string  _TenChuXe ,string  _TenHieuXe , int  _TienNo , string SoTienNoCompareType )
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("FindCars", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenChuXe", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_MaHieuXe", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenHieuXe", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoTienNoCompareType", MySqlDbType.VarChar, 2);

			cmd.Parameters["@_BienSo"].Value = _BienSo;
			cmd.Parameters["@_TenChuXe"].Value = _TenChuXe;
			cmd.Parameters["@_MaKhachSuaXe"].Value = _MaKhachSuaXe;
			cmd.Parameters["@_MaHieuXe"].Value = _MaHieuXe;
			cmd.Parameters["@_TenHieuXe"].Value = _TenHieuXe;
			cmd.Parameters["@_TienNo"].Value = _TienNo;
			cmd.Parameters["@_SoTienNoCompareType"].Value = SoTienNoCompareType;

			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			Conn.Close();
			return dt;

			

			

			


		}

		#endregion
		#region Check
		public static bool KiemTraBienSo(string _textBox)
		{
			bool check = false;

			string cPrimaryKey = "Select *From XE Where BIENSO = '" + _textBox + "' ";
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
