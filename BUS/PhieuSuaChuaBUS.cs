using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
	public class PhieuSuaChuaBUS
	{
        public static DataTable selectAllPhieuSuaChua()
        {
            return PhieuSuaChuaDAO.selectAllPhieuSuaChua();
        }
    }
}
