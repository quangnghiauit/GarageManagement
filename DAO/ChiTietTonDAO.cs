using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
	public class ChiTietTonDAO
	{
        public static void insertChiTietTon(string MaBaoCao, DateTime Time)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("insertCTBaoCaoTon", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaBaoCao", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_Time", MySqlDbType.Date);

            command.Parameters["@_MaBaoCao"].Value = MaBaoCao;
            command.Parameters["@_Time"].Value = Time;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
	}
}
