using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class DoanhSoDAO
	{
        public static DataTable createBaoCaoDoanhSo(int thang, int nam)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand cmd = new MySqlCommand("createBAOCAODOANHSO", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@_Thang", MySqlDbType.Int16);
                cmd.Parameters.Add("@_Nam", MySqlDbType.Int16);

                cmd.Parameters["@_Thang"].Value = thang;
                cmd.Parameters["@_Nam"].Value = nam;

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public static void insertBaoCaoDoanhSo(string MaBaoCao, DateTime thang0, int thang, int nam)
        {

            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("insertBAOCAODOANHSO", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@_MaBaoCao", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@_Thang0", MySqlDbType.Date);
            cmd.Parameters.Add("@_Thang", MySqlDbType.Int16);
            cmd.Parameters.Add("@_Nam", MySqlDbType.Int16);

            cmd.Parameters["@_MaBaoCao"].Value = MaBaoCao;
            cmd.Parameters["@_Thang0"].Value = thang0;
            cmd.Parameters["@_Thang"].Value = thang;
            cmd.Parameters["@_Nam"].Value = nam;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable selectTongDoanhThu(DateTime _Thang0)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand cmd = new MySqlCommand("selectTongDoanhThu", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@_Thang0", MySqlDbType.Date);
                cmd.Parameters["@_Thang0"].Value = _Thang0;
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            return data;
        }
    }
}
