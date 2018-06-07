using System.Data;
using DTO;
using DAO;

namespace BUS
{
	public class HieuXeBUS
	{
		// Loa tat ca hieu xe từ bảng
		public static DataTable loadTatCaHieuXe()
		{
			return HieuXeDAO.getData();
		}
		//Them hieu xe vào bảng 
		public static void addHieuXe(HieuXeDTO hx)
		{
			HieuXeDAO.ThemHieuXe(hx);
		}
		// Xoa hieu xe từ Bảng HIEUXE
		public static void delHieuXe(string _MaHieuXe)
		{
			HieuXeDAO.XoaHieuXe(_MaHieuXe);
		}
		// Kiem tra du lieu nhap vao co bi trung khoa chinh
		public static bool cPrimaryKey(string _cPrim)
		{
			return HieuXeDAO.KiemTraKhoaChinh(_cPrim);
		}
	}
}
