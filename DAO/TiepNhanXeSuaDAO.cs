using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
	public class TiepNhanXeSuaDAO
	{
        public static DataTable selectAllTiepNhanXeSua()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.HamKetNoi())
            {
                MySqlCommand command = new MySqlCommand("SelectAllPhieuThuTien", connection);

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //Insert
        public static void insertPhieuThuTien(TiepNhanXeSuaDTO TiepNhan)
        {

            MySqlConnection connect = DatabaseConnectionDAO.HamKetNoi();

            MySqlCommand command = new MySqlCommand("InsertPHIEUTHUTIEN", connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NgayTiepNhan", MySqlDbType.Date);            
            command.Parameters["@_BienSo"].Value = TiepNhan.BienSo;
            command.Parameters["@_NgayTiepNhan"].Value = TiepNhan.NgayTiepNhan;
            
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
