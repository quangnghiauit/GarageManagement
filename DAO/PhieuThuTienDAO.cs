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
    public class PhieuThuTienDAO
    {
        public static DataTable selectAllPhieuThuTien()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand command = new MySqlCommand("SelectAllPHIEUTHUTIEN", connection);

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        //Insert
        public static void insertPhieuThuTien(PhieuThuTienDTO PhieuThu)
        {

            MySqlConnection connect = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertPHIEUTHUTIEN", connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NgayThuTien", MySqlDbType.Date);
            command.Parameters.Add("@_SoTienThu", MySqlDbType.Decimal);
            command.Parameters.Add("@_SoTienKhachTra", MySqlDbType.Decimal);
            command.Parameters.Add("@_SoTienTraKhach", MySqlDbType.Decimal);
            command.Parameters["@_BienSo"].Value = PhieuThu.BienSo;
            command.Parameters["@_NgayThuTien"].Value = PhieuThu.NgayThuTien;
            command.Parameters["@_SoTienThu"].Value = PhieuThu.SoTienThu;
            command.Parameters["@_SoTienKhachTra"].Value = PhieuThu.SoTienKhachTra;
            command.Parameters["@_SoTienTraKhach"].Value = PhieuThu.SoTienTraKhach;

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public static void fillCBO(string column, string table, ComboBox receiver)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select * from " + table, connection);
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string getter = reader.GetString(column);
                    receiver.Items.Add(getter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
