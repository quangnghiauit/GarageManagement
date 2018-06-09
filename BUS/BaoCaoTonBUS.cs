using System;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
	public class BaoCaoTonBUS
	{
        public static void addBaoCaoTon(BaoCaoTonDTO BaoCao)
        {
            BaoCaoTonDAO.insertBaoCaoTon(BaoCao);
        }

        public static DataTable createBaoCaoTon(DateTime Time)
        {
            return BaoCaoTonDAO.createBaoCaoTon(Time);
        }

    }
}
