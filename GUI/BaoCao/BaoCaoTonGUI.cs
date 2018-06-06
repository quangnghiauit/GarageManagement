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
using BUS;
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
            if (!fMainForm.cNullTB(txtMaBaoCao.Text))
            {
                string MaBaoCao = txtMaBaoCao.Text;
                int Month = dtmThangLapBaoCao.Value.Month;
                int Year = dtmThangLapBaoCao.Value.Year;
                DateTime Time = dtmThangLapBaoCao.Value;

                BaoCaoTonDTO BaoCao = new BaoCaoTonDTO(MaBaoCao, Month, Year);
                BaoCaoTonBUS.addBaoCaoTon(BaoCao);
                ChiTietTonBUS.addChiTietTon(MaBaoCao, Time);

                dgvBaoCaoTon.DataSource = BaoCaoTonBUS.createBaoCaoTon(Time);
                VatTuPhuTungBUS.updateSoLuongTon();
            }
            else
                MessageBox.Show("Hãy nhập mã báo cáo.");

        }
    }
}
