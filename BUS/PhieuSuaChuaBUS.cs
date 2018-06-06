using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace BUS
{
	public class PhieuSuaChuaBUS
	{
        public static DataTable selectAllPhieuSuaChua()
        {
            return PhieuSuaChuaDAO.selectAllPhieuSuaChua();
        }

        public static void addPhieuSuaChua(PhieuSuaChuaDTO PhieuSuaChua)
        {
            PhieuSuaChuaDAO.insertPHIEUSUACHUA(PhieuSuaChua);
        }
    }
}
