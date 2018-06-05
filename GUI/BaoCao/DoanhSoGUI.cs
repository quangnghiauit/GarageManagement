using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace GUI
{
	public partial class fDoanhSo : Form
	{
		public fDoanhSo()
		{
			InitializeComponent();
			dtmThangLapBaoCao.Format = DateTimePickerFormat.Custom;
			dtmThangLapBaoCao.CustomFormat = "MM   yyyy";
			dtmThangLapBaoCao.ShowUpDown = true;
		}

		

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            DateTime thang0 = dtmThangLapBaoCao.Value;
            string maBC = txtMaBaoCao.Text;

            dgvBaoCaoDoanhSo.DataSource = DoanhSoBUS.createBaoCaoDoanhSo(thang0.Month, thang0.Year);
            DoanhSoBUS.insertBaoCaoDoanhSo(maBC, thang0, thang0.Month, thang0.Year);

            txtTongDoanhThu.Text = DoanhSoBUS.selectTongDoanhThu(thang0).ToString();
        }
    }
}
