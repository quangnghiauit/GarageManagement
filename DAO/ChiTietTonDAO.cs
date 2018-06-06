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
        public static void insertChiTietTon(string MaBaoCao, int _Month, int _Year)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("insertCTBaoCaoTon", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaBaoCao", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_Month", MySqlDbType.Int16);
			command.Parameters.Add("@_Year", MySqlDbType.Int16);

			command.Parameters["@_MaBaoCao"].Value = MaBaoCao;
			command.Parameters["@_Month"].Value = _Month;
			command.Parameters["@_Year"].Value = _Year;

			connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
	}
}
