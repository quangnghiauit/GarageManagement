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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

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
                ChiTietTonBUS.addChiTietTon(MaBaoCao, Month,Year);

                dgvBaoCaoTon.DataSource = BaoCaoTonBUS.createBaoCaoTon(Time);
                VatTuPhuTungBUS.updateSoLuongTon();
            }
            else
                MessageBox.Show("Hãy nhập mã báo cáo.");

        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvBaoCaoTon, @"E:\", "ExportBaoCaoTon");
        }

        private void export2Excel(DataGridView g, string path, string filename)
        {

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + filename + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
