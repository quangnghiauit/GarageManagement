using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Windows.Forms;

namespace BUS
{
	public class ChiTietPhieuSuaChuaBUS
	{
        public static DataTable selectAllChiTietPhieuSuaChua()
        {
            return ChiTietPhieuSuaChuaDAO.selectAllChiTietPhieuSuaChua();
        }

        public static void addChiTietPhieuSuaChua(ChiTietPhieuSuaChuaDTO ChiTiet)
        {
            ChiTietPhieuSuaChuaDAO.insertChiTietPhieuChuaChua(ChiTiet);
        }
    }
}
