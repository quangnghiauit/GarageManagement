using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
	public class PhieuThuTienBUS
	{
        public static DataTable selectAllPhieuThuTien()
        {
            return PhieuThuTienDAO.selectAllPhieuThuTien();
        }

        public static void addPhieuThuTien(PhieuThuTienDTO PhieuThu)
        {
            PhieuThuTienDAO.insertPhieuThuTien(PhieuThu);
        }

	}
}
