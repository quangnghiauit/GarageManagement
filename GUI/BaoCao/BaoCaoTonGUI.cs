using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using MySql.Data.MySqlClient;

namespace GUI
{
	public partial class fBaoCaoTon : Form
	{
		public fBaoCaoTon()
		{
			InitializeComponent();
		}

		private void BaoCaoTon_Load(object sender, EventArgs e)
		{
			dtmThangLapBaoCao.Format = DateTimePickerFormat.Custom;
			dtmThangLapBaoCao.CustomFormat = "MM / yyyy";
			dtmThangLapBaoCao.ShowUpDown = true;
		}

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            int month = dtmThangLapBaoCao.Value.Month;
            int year = dtmThangLapBaoCao.Value.Year;

            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select count(VATTUPHUTUNG.MAVATUPHUTUNG) from VATTUPHUTUNG", connection);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            
            if (month != 6 && year != 2018 )
                for (int i = 0; i < count; i++)
                {

                }
            //VatTuTonDTO VatTu = new VatTuTonDTO()

            //VatTuTonDAO.insertQuanLyNhapVatTu
        }
    }
}
