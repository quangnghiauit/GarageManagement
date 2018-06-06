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
	public class VatTuPhuTungBUS
	{
		public static DataTable loadAllSpareParts()
		{
			return VatTuPhuTungDAO.getData();
		}

		public static void addSpareParts(VatTuPhuTungDTO vatTu)
		{
			VatTuPhuTungDAO.InsertSpareParts(vatTu);
		}

		public static void updateSpareParts(VatTuPhuTungDTO vatTu)
		{
			VatTuPhuTungDAO.UpdateSpareParts(vatTu);
		}

		public static void delSpareParts(string _MaVatTuPhuTung)
		{
			VatTuPhuTungDAO.RemoveSpareParts(_MaVatTuPhuTung);
		}


		public static DataTable FindSparePartsID(string _MaVatTuPhuTung)
		{
			return VatTuPhuTungDAO.FindSpareParts(_MaVatTuPhuTung);
		}


		public static DataTable SearchAllSpareParts(VatTuPhuTungDTO vatTu)
		{
			return VatTuPhuTungDAO.SearchSpareParts(vatTu);

		}
        public static void updateSoLuongTon()
        {
            VatTuPhuTungDAO.updateSoLuongTon();
        }


		public static bool cPrimaryKey(string _cPrim)
		{
			return VatTuPhuTungDAO.CheckPrimary(_cPrim);
		}

	}
}
