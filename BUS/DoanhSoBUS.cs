using System;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
	public class DoanhSoBUS
	{
        public static DataTable createBaoCaoDoanhSo(int thang, int nam)
        {
            return DoanhSoDAO.createBaoCaoDoanhSo(thang, nam);
        }

        public static void insertBaoCaoDoanhSo(string MaBaoCao, DateTime thang0, int thang, int nam)
        {
            DoanhSoDAO.insertBaoCaoDoanhSo(MaBaoCao, thang0, thang, nam);
        }
        
        public static DataTable selectTongDoanhThu(DateTime _Thang0)
        {
            return DoanhSoDAO.selectTongDoanhThu(_Thang0);
        }

    }
}
