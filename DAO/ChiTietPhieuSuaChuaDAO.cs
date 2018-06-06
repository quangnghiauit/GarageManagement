using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAO
{
	public class ChiTietPhieuSuaChuaDAO
	{
        public static DataTable selectAllChiTietPhieuSuaChua()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase())
            {
                MySqlCommand command = new MySqlCommand("SelectAllCHITIETPHIEUSUACHUA", connection);

                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public static void initiateGrid(DataGridView dgv)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

            MySqlCommand command = new MySqlCommand("SelectAllCHITIETPHIEUSUACHUA", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            DataTable dt = new DataTable();
            MySqlDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void insertChiTietPhieuChuaChua(ChiTietPhieuSuaChuaDTO ChiTiet)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand command = new MySqlCommand("InsertCHITIETPHIEUSUACHUA", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@_MaPhieuSuaChua", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_NoiDung", MySqlDbType.VarChar, 100);
            command.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@_SoLuongSuaChua", MySqlDbType.Int16);
            command.Parameters.Add("@_TienCong", MySqlDbType.Decimal);
            command.Parameters.Add("@_ThanhTien", MySqlDbType.Decimal);

            command.Parameters["@_MaPhieuSuaChua"].Value = ChiTiet.MaPhieuSuaChua;
            command.Parameters["@_NoiDung"].Value = ChiTiet.NoiDung;
            command.Parameters["@_MaVatTuPhuTung"].Value = ChiTiet.MaVatTuPhuTung;
            command.Parameters["@_SoLuongSuaChua"].Value = ChiTiet.SoLuongSuaChua;
            command.Parameters["@_TienCong"].Value = ChiTiet.TienCong;
            command.Parameters["@_ThanhTien"].Value = ChiTiet.ThanhTien;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
