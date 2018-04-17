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
	public class XeBUS
	{
		// Loa tat ca xe từ bảng
		public static DataTable loadTatCaXe()
		{
			return XeDAO.getData();
		}
		//Them xe  vào bảng 
		public static void addXe(XeDTO xe)
		{
			XeDAO.ThemXe(xe);
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

		// Kiểm tra biển số nhập vào có trùng biển số
		public static bool cPrimaryKey(string _cPrim)
		{
			return XeDAO.KiemTraBienSo(_cPrim);
		}
	}
}
