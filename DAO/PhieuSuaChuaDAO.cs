using MySql.Data.MySqlClient;
using System.Data;
using DTO;

namespace DAO
{
	public class PhieuSuaChuaDAO
	{
        public static DataTable selectAllPhieuSuaChua()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand command = new MySqlCommand("SelectAllPHIEUSUACHUA", connection);

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public static void insertPHIEUSUACHUA(PhieuSuaChuaDTO PhieuSuaChua)
        {
            MySqlConnection connect = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertPHIEUSUACHUA", connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaPhieuSuaChua", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NgaySuaChua", MySqlDbType.Date);
            command.Parameters.Add("@_TongTien", MySqlDbType.Decimal);

            command.Parameters["@_MaPhieuSuaChua"].Value = PhieuSuaChua.MaPhieuSuaChua;
            command.Parameters["@_BienSo"].Value = PhieuSuaChua.BienSo;
            command.Parameters["@_NgaySuaChua"].Value = PhieuSuaChua.NgaySuaChua;
            command.Parameters["@_TongTien"].Value = PhieuSuaChua.TongTien;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
