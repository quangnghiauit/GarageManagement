using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Data.SqlClient;
using System.Media;
using System.IO;

using System.Linq;

using System.Threading.Tasks;
using DTO;
using DAO;
using MySql.Data.MySqlClient;

using System.Windows.Forms;


namespace BUS
{
	public class KhachSuaXeBUS
	{
		// Loa tat ca khach hang từ bảng
		public static DataTable loadTatCaKhachHang()
		{
			return KhachSuaXeDAO.getData();
		}
		//Them khach hang vào bảng 
		public static void addKhachHang(KhachSuaXeDTO kh)
		{
			KhachSuaXeDAO.ThemKhachHang(kh);
		}
		//Cập nhật khach hang vào bảng 
		public static void updateKhachHang(KhachSuaXeDTO kh)
		{
			KhachSuaXeDAO.SuaKhachHang(kh);
		}
		// Xoa Khách sửa xe từ Bảng KHACHSUAXE
		public static void delKhachSuaXe(string _MaKhachSuaXe)
		{
			KhachSuaXeDAO.XoaKhachHang(_MaKhachSuaXe);
		}

		public static void SearchAllKhachSuaXe(KhachSuaXeDTO kh, string SoTienNoCompareType)
		{
			KhachSuaXeDAO.SearchKhachHang(kh, SoTienNoCompareType);
		}

		// Kiem tra du lieu nhap vao co bi trung khoa chinh
		public static bool cPrimaryKey(string _cPrim)
		{
			return KhachSuaXeDAO.KiemTraKhoaChinh(_cPrim);
		}

		
	}
}
