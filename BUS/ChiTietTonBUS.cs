using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
	public class ChiTietTonBUS
	{
        public static void addChiTietTon(string MaBaoCao, int _Month, int _Year)
        {
            ChiTietTonDAO.insertChiTietTon(MaBaoCao, _Month,_Year);
        }        
    }
}
