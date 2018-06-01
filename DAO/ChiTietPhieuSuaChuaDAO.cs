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

        public static void insertChiTietPhieuChuaChua(ChiTietPhieuSuaChuaDTO ChiTiet, DataGridView dgv)
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();            
            MySqlCommand command = new MySqlCommand("InsertCHITIETPHIEUSUACHUA", connection);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < dgv.Rows.Count-1; i++)
            {
                command.Parameters.Add("@_MaPhieSuaChua", MySqlDbType.VarChar, 10);
                command.Parameters.Add(new MySqlParameter("@_NoiDung", dgv.Rows[i].Cells["NoiDung"].Value));
                command.Parameters.Add(new MySqlParameter("@_MaVatTuPhuTung", dgv.Rows[i].Cells["VatTuPhuTung"].Value));
                command.Parameters.Add(new MySqlParameter("@_SoLuongSuaChua", dgv.Rows[i].Cells["SoLuongSuaChua"].Value));
                command.Parameters.Add(new MySqlParameter("@_TienCong", dgv.Rows[i].Cells["TienCong"].Value));
                command.Parameters.Add(new MySqlParameter("@_ThanhTien", dgv.Rows[i].Cells["ThanhTien"].Value));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }


        //public static void insertChiTietPhieuChuaChua(ChiTietPhieuSuaChuaDTO ChiTiet)
        //{

        //    MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

        //    MySqlCommand command = new MySqlCommand("InsertCHITIETPHIEUSUACHUA", connection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    command.Parameters.Add("@_MaPhieSuaChua", MySqlDbType.VarChar, 10);
        //    command.Parameters.Add("@_NoiDung", MySqlDbType.VarChar, 100);
        //    command.Parameters.Add("@_MaVatTuPhuTung", MySqlDbType.VarChar, 10);
        //    command.Parameters.Add("@_SoLuongSuaChua", MySqlDbType.Int32);
        //    command.Parameters.Add("@_TienCong", MySqlDbType.Int64);
        //    command.Parameters.Add("@_ThanhTien", MySqlDbType.Int64);

        //    command.Parameters["@_MaPhieSuaChua"].Value = ChiTiet.MaPhieuSuaChua;
        //    command.Parameters["@_NoiDung"].Value = ChiTiet.NoiDung;
        //    command.Parameters["@_MaVatTuPhuTung"].Value = ChiTiet.MaVatTuPhuTung;
        //    command.Parameters["@_SoLuongSucChua"].Value = ChiTiet.SoLuongSuaChua;
        //    command.Parameters["@_TienCong"].Value = ChiTiet.TienCong;
        //    command.Parameters["@_ThanhTien"].Value = ChiTiet.ThanhTien;


        //    connection.Open();            
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //}
    }
}
