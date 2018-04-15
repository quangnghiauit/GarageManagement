using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
	public class TiepNhanXeSuaBUS
	{
        public static DataTable selectAllTiepNhanXeSua()
        {
            return TiepNhanXeSuaDAO.selectAllTiepNhanXeSua();
        }

        public static void addTiepNhanXeSua(TiepNhanXeSuaDTO TiepNhan)
        {
            TiepNhanXeSuaDAO.insertPhieuThuTien(TiepNhan);
        }
    }
}
