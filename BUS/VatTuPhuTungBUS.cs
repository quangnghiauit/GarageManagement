using System.Data;
using DTO;
using DAO;

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

		public static void updateAddSpareParts(string _MaVatTuPhuTung, string _TenVatTuPhuTung, decimal _DonGia, decimal SoLuongThem)
		{
			VatTuPhuTungDAO.InsertAddSpareParts(_MaVatTuPhuTung,_TenVatTuPhuTung,_DonGia,SoLuongThem);
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

        public static void decreaseSoLuongVatTu(string MaVatTu, int SoLuong)
        {
            VatTuPhuTungDAO.decreaseSoLuongVatTu(MaVatTu, SoLuong);
        }

		public static bool cPrimaryKey(string _cPrim)
		{
			return VatTuPhuTungDAO.CheckPrimary(_cPrim);
		}

	}
}
