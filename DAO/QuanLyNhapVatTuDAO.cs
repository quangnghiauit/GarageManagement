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
    public class QuanLyNhapVatTuDAO
    {
        public static void insertQuanLyNhapVatTu(QuanLyNhapVatTuDTO QuanLy)
        {

            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertQUANLYNHAPVATTU", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaVatTu", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_SoLuongNhap", MySqlDbType.Int32);
            command.Parameters.Add("@_NgayNhap", MySqlDbType.Date);

            command.Parameters["@_MaVatTu"].Value = QuanLy.MaVatTuPhuTung;
            command.Parameters["@_SoLuongNhap"].Value = QuanLy.SoLuongNhap;
            command.Parameters["@_NgayNhap"].Value = QuanLy.NgayNhap;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
