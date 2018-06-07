using System;
using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
	public class KhachSuaXeDAO
	{

		#region Get Databse
		/// <summary>
		/// Dung de lay du lieu tu DataBase
		/// </summary>
		/// <returns>Tra lai gia tri la mot Table</returns>
		public static DataTable getData()
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			
			MySqlCommand cmd = new MySqlCommand("LoadAllCustomer", Conn);
			

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
		
		//public static void InsertCustomer(KhachSuaXeDTO kh)
		//{
		//	MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			
			
			
		//	MySqlCommand cmd = new MySqlCommand("InsertCustomer", Conn);
		//	cmd.CommandType = CommandType.StoredProcedure;

		//	cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
		//	cmd.Parameters.Add("@_TenChuXe", MySqlDbType.VarChar, 100);
		//	cmd.Parameters.Add("@_DienThoai", MySqlDbType.VarChar, 20);
		//	cmd.Parameters.Add("@_DiaChi", MySqlDbType.VarChar, 100);
		//	cmd.Parameters.Add("@_Email", MySqlDbType.VarChar, 40);
		//	cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
		//	cmd.Parameters["@_MaKhachSuaXe"].Value = kh.MaKhachSuaXe;
		//	cmd.Parameters["@_TenChuXe"].Value = kh.TenChuXe;
		//	cmd.Parameters["@_DienThoai"].Value = kh.DienThoai;
		//	cmd.Parameters["@_DiaChi"].Value = kh.DiaChi;
		//	cmd.Parameters["@_Email"].Value = kh.Email;
		//	cmd.Parameters["@_TienNo"].Value = kh.TienNo;

		//	Conn.Open();
		//	cmd.ExecuteNonQuery();
		//	Conn.Close();
		//}

		public static bool InsertCustomer(KhachSuaXeDTO kh, string exception ="")
		{

			try
			{

				//ExcuteQuery
				DatabaseConnectionDAO.ExcuteProcedure("InsertCustomer", ref exception, new MySqlParameter[] { new MySqlParameter("@_MaKhachSuaXe", kh.MaKhachSuaXe), new MySqlParameter("@_TenChuXe", kh.TenChuXe), new MySqlParameter("@_DienThoai", kh.DienThoai), new MySqlParameter("@_DiaChi", kh.DiaChi), new MySqlParameter("@_Email", kh.Email), new MySqlParameter("@_TienNo", kh.TienNo) });
				//if there is no exception
				if (exception == "")
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				exception = ex.Message;
			}


			return false;
		}


		public static void UpdateCustomer(KhachSuaXeDTO kh)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("UpdateCustomer", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenChuXe", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DienThoai", MySqlDbType.VarChar, 20);
			cmd.Parameters.Add("@_DiaChi", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_Email", MySqlDbType.VarChar, 40);
			cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
			cmd.Parameters["@_MaKhachSuaXe"].Value = kh.MaKhachSuaXe;
			cmd.Parameters["@_TenChuXe"].Value = kh.TenChuXe;
			cmd.Parameters["@_DienThoai"].Value = kh.DienThoai;
			cmd.Parameters["@_DiaChi"].Value = kh.DiaChi;
			cmd.Parameters["@_Email"].Value = kh.Email;
			cmd.Parameters["@_TienNo"].Value = kh.TienNo;

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}



		
		public static bool RemoveCustomer(int _MaKhachSuaXe,string exception="")
		{
			try
			{
				
				//ExcuteQuery
				DatabaseConnectionDAO.ExcuteProcedure("RemoveCustomer",ref exception, new MySqlParameter[] { new MySqlParameter ("@_MaKhachSuaXe", _MaKhachSuaXe) });
				//if there is no exception
				if(exception=="")
				{
					return true;
				}
			}
			catch(Exception ex)
			{
				exception = ex.Message;
			}
			return false;
			//MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			//MySqlCommand cmd = new MySqlCommand("RemoveCustomer", Conn);
			//cmd.CommandType = CommandType.StoredProcedure;

			//cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
			//cmd.Parameters["@_MaKhachSuaXe"].Value = _MaKhachSuaXe;
			//Conn.Open();
			//cmd.ExecuteNonQuery();
			//Conn.Close();
		}

        public static void addTienNo(string BienSo, decimal SoTien)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("addTienNo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);            
            cmd.Parameters.Add("@_SoTien", MySqlDbType.Decimal);

            cmd.Parameters["@_BienSo"].Value = BienSo;            
            cmd.Parameters["@_SoTien"].Value = SoTien;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void payTienNo(string BienSo, decimal SoTien)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("payTienNo", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@_SoTien", MySqlDbType.Decimal);

            cmd.Parameters["@_BienSo"].Value = BienSo;
            cmd.Parameters["@_SoTien"].Value = SoTien;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        #endregion
        #region Find Customers
        //Tìm khách hàng theo mã khách hàng
        public static void FindCustomerByID(KhachSuaXeDTO kh)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("FindCustomer", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
			
			cmd.Parameters["@_MaKhachSuaXe"].Value = kh.MaKhachSuaXe;
			

			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		//Tìm khách hàng theo nhiều điều kiện
		public static DataTable SearchCustomer(KhachSuaXeDTO kh, string SoTienNoCompareType)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmd = new MySqlCommand("FindCustomers", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
			cmd.Parameters.Add("@_TenChuXe", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_DienThoai", MySqlDbType.VarChar, 20);
			cmd.Parameters.Add("@_DiaChi", MySqlDbType.VarChar, 100);
			cmd.Parameters.Add("@_Email", MySqlDbType.VarChar, 40);
			cmd.Parameters.Add("@_TienNo", MySqlDbType.Decimal);
			cmd.Parameters.Add("@_SoTienNoCompareType", MySqlDbType.VarChar, 2);
			
			cmd.Parameters["@_MaKhachSuaXe"].Value = kh.MaKhachSuaXe;
			cmd.Parameters["@_TenChuXe"].Value = kh.TenChuXe;
			cmd.Parameters["@_DienThoai"].Value = kh.DienThoai;
			cmd.Parameters["@_DiaChi"].Value = kh.DiaChi;
			cmd.Parameters["@_Email"].Value = kh.Email;
			cmd.Parameters["@_TienNo"].Value = kh.TienNo;
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
		public static bool CheckPrimary(string _textBox)
		{
			bool check = false;

			string cPrimaryKey = "Select *From KHACHSUAXE Where MAKHACHSUAXE = '" + _textBox + "' ";
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





