using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;
using System.Windows.Forms;

namespace DAO
{
	public class TiepNhanXeSuaDAO
	{
        public static DataTable selectAllTiepNhanXeSua()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand command = new MySqlCommand("SelectAllTIEPNHANXESUA", connection);

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //Insert
        public static void insertTiepNhanXeSua(TiepNhanXeSuaDTO TiepNhan)
        {

            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertTIEPNHANXESUA", connection);
            command.CommandType = CommandType.StoredProcedure;
                        
            command.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NgayTiepNhan", MySqlDbType.Date);
                        
            command.Parameters["@_BienSo"].Value = TiepNhan.BienSo;
            command.Parameters["@_NgayTiepNhan"].Value = TiepNhan.NgayTiepNhan;
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void fillCBO(string column, string table,ComboBox receiver)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select " + column  + " from " + table, connection);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataset, column);
            receiver.DataSource = dataset.Tables[0];
            receiver.DisplayMember = column;
            receiver.ValueMember = column;            
        }        
    }
}
