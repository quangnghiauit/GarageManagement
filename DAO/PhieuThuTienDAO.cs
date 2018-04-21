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
	public class PhieuThuTienDAO
	{
        public static DataTable selectAllPhieuThuTien()
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
        public static void insertPhieuThuTien(PhieuThuTienDTO PhieuThu)
        {

            MySqlConnection connect = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("InsertPHIEUTHUTIEN", connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_BienSo", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NgayThuTien", MySqlDbType.Date);
            command.Parameters.Add("@_SoTienThu", MySqlDbType.Decimal);
            command.Parameters["@_BienSo"].Value = PhieuThu.BienSo;
            command.Parameters["@_NgayThuTien"].Value = PhieuThu.NgayThuTien;
            command.Parameters["@_SoTienThu"].Value = PhieuThu.SoTienThu;
            
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
