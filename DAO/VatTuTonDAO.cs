using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class VatTuTonDAO
    {
        public static void insertQuanLyNhapVatTu(VatTuTonDTO VatTu)
        {

            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertQUANLYNHAPVATTU", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaVatTu", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_SoLuongTon", MySqlDbType.Int32);
            command.Parameters.Add("@_Thang", MySqlDbType.Decimal);
            command.Parameters.Add("@_Nam", MySqlDbType.Decimal);

            command.Parameters["@_MaVatTu"].Value = VatTu.MaVatTuPhuTung;
            command.Parameters["@_SoLuongTon"].Value = VatTu.SoLuongTon;
            command.Parameters["@_Thang"].Value = VatTu.Thang;
            command.Parameters["@_Nam"].Value = VatTu.Nam;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
