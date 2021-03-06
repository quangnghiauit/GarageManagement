﻿using DTO;
using MySql.Data.MySqlClient;
using System.Data;


namespace DAO
{
	public class VatTuPhuTungDAO
	{
		#region Get Databse
	
		
		public static DataTable getData()
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("LoadAllSpareParts", Conn);


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

		public static void InsertSpareParts(VatTuPhuTungDTO vatTu)
		{
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();



			MySqlCommand cmd = new MySqlCommand("InsertSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenVatTuPhuTung", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DonGia", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoLuongVatTu", MySqlDbType.Decimal);

			cmd.Parameters["@_MaVatTuPhuTung"].Value = vatTu.MaVatTuPhuTung;
			cmd.Parameters["@_TenVatTuPhuTung"].Value = vatTu.TenVatTuPhuTung;
			cmd.Parameters["@_DonGia"].Value = vatTu.DonGia;
			cmd.Parameters["@_SoLuongVatTu"].Value = vatTu.SoLuongVatTu;
			
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}

		public static void InsertAddSpareParts(string _MaVatTuPhuTung,string _TenVatTuPhuTung,decimal _DonGia, decimal _SoLuongThem)
		{
			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();



			MySqlCommand cmd = new MySqlCommand("UpdateAddSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenVatTuPhuTung", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DonGia", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoLuongThem", MySqlDbType.Decimal);

			cmd.Parameters["@_MaVatTuPhuTung"].Value = _MaVatTuPhuTung;
			cmd.Parameters["@_TenVatTuPhuTung"].Value = _TenVatTuPhuTung;
			cmd.Parameters["@_DonGia"].Value = _DonGia;
			cmd.Parameters["@_SoLuongThem"].Value = _SoLuongThem;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}



		public static void UpdateSpareParts(VatTuPhuTungDTO vatTu)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();



			MySqlCommand cmd = new MySqlCommand("UpdateSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenVatTuPhuTung", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DonGia", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoLuongVatTu", MySqlDbType.Decimal);

			cmd.Parameters["@_MaVatTuPhuTung"].Value = vatTu.MaVatTuPhuTung;
			cmd.Parameters["@_TenVatTuPhuTung"].Value = vatTu.TenVatTuPhuTung;
			cmd.Parameters["@_DonGia"].Value = vatTu.DonGia;
			cmd.Parameters["@_SoLuongVatTu"].Value = vatTu.SoLuongVatTu;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}




		public static void RemoveSpareParts(string _MaVatTuPhuTung)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("RemoveSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
			cmd.Parameters["@_MaVatTuPhuTung"].Value = _MaVatTuPhuTung;
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		#endregion
		#region Find Customers
		
		public static DataTable FindSpareParts(string _MaVatTuPhuTung)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("FindSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);

			cmd.Parameters["@_MaVatTuPhuTung"].Value = _MaVatTuPhuTung;


			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable();
			da.Fill(dt);
			Conn.Close();
			return dt;
		}
		
		public static DataTable SearchSpareParts(VatTuPhuTungDTO vatTu)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("SearchSpareParts", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenVatTuPhuTung", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DonGia", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoLuongVatTu", MySqlDbType.Decimal);

			cmd.Parameters["@_MaVatTuPhuTung"].Value = vatTu.MaVatTuPhuTung;
			cmd.Parameters["@_TenVatTuPhuTung"].Value = vatTu.TenVatTuPhuTung;
			cmd.Parameters["@_DonGia"].Value = vatTu.DonGia;
			cmd.Parameters["@_SoLuongVatTu"].Value = vatTu.SoLuongVatTu;

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
		public static bool CheckPrimary(string _MaVatTuPhuTung)
		{
			bool check = false;

			string cPrimaryKey = "Select *From VATTUPHUTUNG Where MaVatTuPhuTung = '" + _MaVatTuPhuTung + "' ";
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
		//public static void fillCBO(string column, string table, ComboBox receiver)
		//{
		//	MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
		//	MySqlCommand cmd = new MySqlCommand("select * from " + table, connection);
		//	MySqlDataReader reader;
		//	try
		//	{
		//		connection.Open();
		//		reader = cmd.ExecuteReader();

		//		while (reader.Read())
		//		{
		//			string getter = reader.GetString(column);
		//			receiver.Items.Add(getter);
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//}

        public static void updateSoLuongTon()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("updateSoLuongTonVT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void decreaseSoLuongVatTu(string MaVatTuPhuTung, int SoLuong)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("decreaseSpareParts", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@_SoLuong", MySqlDbType.Int16);

            cmd.Parameters["@_MaVatTuPhuTung"].Value = MaVatTuPhuTung;
            cmd.Parameters["@_SoLuong"].Value = SoLuong;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
	}
}
