using MySql.Data.MySqlClient;
using System;
using System.Data;
using DTO;

namespace DAO
{
	public class BaoCaoTonDAO
	{
        public static void insertBaoCaoTon(BaoCaoTonDTO BaoCao)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("insertBaoCaoTon", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaBaoCao", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_Thang", MySqlDbType.Int32);
            command.Parameters.Add("@_Nam", MySqlDbType.Int32);

            command.Parameters["@_MaBaoCao"].Value = BaoCao.MaBaoCaoTon;
            command.Parameters["@_Thang"].Value = BaoCao.ThangBaoCaoTon;
            command.Parameters["@_Nam"].Value = BaoCao.NamBaoCaoTon;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable createBaoCaoTon(DateTime Time)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand cmd = new MySqlCommand("createBaoCaoTon", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@_Time", MySqlDbType.Date);

                cmd.Parameters["@_Time"].Value = Time;
                
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public static bool CheckPrimary(string _textBox)
        {
            bool check = false;

            string cPrimaryKey = "Select *From BAOCAOTON Where MABAOCAOTON = '" + _textBox + "' ";
            MySqlConnection Conn = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand cmd = new MySqlCommand(cPrimaryKey, Conn);
            cmd.CommandType = CommandType.Text;
            Conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                check = true;
            }

            return check;
        }
    }
}
