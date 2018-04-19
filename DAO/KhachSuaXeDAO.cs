﻿using System;
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
	public class KhachSuaXeDAO
	{

		#region Get Databse
		/// <summary>
		/// Dung de lay du lieu tu DataBase
		/// </summary>
		/// <returns>Tra lai gia tri la mot Table</returns>
		public static DataTable getData()
		{

			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
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
		
		public static void InsertCustomer(KhachSuaXeDTO kh)
		{
			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
			
			
			
			MySqlCommand cmd = new MySqlCommand("InsertCustomer", Conn);
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


		
		public static void UpdateCustomer(KhachSuaXeDTO kh)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
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



		
		public static void RemoveCustomer(int _MaKhachSuaXe)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
			MySqlCommand cmd = new MySqlCommand("RemoveCustomer", Conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add("@_MaKhachSuaXe", MySqlDbType.VarChar, 10);
			cmd.Parameters["@_MaKhachSuaXe"].Value = _MaKhachSuaXe;
			Conn.Open();
			cmd.ExecuteNonQuery();
			Conn.Close();
		}
		#endregion
		#region Find Customers
		//Tìm khách hàng theo mã khách hàng
		public static void FindCustomerByID(KhachSuaXeDTO kh)
		{

			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
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

			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
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
			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
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




