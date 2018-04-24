using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.IO;
using MySql.Data.MySqlClient;
using DAO;
using BUS;
using DTO;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace GUI
{
	public partial class fmTraCuuVatTu : Form
	{
		public fmTraCuuVatTu()
		{
			InitializeComponent();
		}

		private void btnTimTatCa_Click(object sender, EventArgs e)
		{

			if (!fMainForm.cNullTB(cbbMaVatTuTraCuu.DisplayMember) )
			{
				if (VatTuPhuTungBUS.cPrimaryKey(cbbMaVatTuTraCuu.SelectedValue.ToString().Trim()))
				{

					string MaVatTuPhuTung = cbbMaVatTuTraCuu.SelectedValue.ToString().Trim();

					//string TenVatTuPhuTung = tbTenVatTuTraCuu.Text;
					//int DonGia = Convert.ToInt32(tbDonGiaTraCuu.Text);
					//int SoLuongVatTu = Convert.ToInt32(tbSoLuongTraCuu.Text);



					//VatTuPhuTungDTO vatTu = new VatTuPhuTungDTO(MaVatTuPhuTung, TenVatTuPhuTung, DonGia, SoLuongVatTu);

					dtgvVatTu.DataSource = VatTuPhuTungBUS.FindSparePartsID(MaVatTuPhuTung);
				}
				else
				{
					MessageBox.Show("Dữ liệu vừa nhập vào không có.Mời nhập lại.");
				}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
		}

		private void fmTraCuuVatTu_Load(object sender, EventArgs e)
		{
			//load CustomerID

			MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdcustomer = new MySqlCommand("select MaVatTuPhuTung from VATTUPHUTUNG", Conncustomer);


			Conncustomer.Open();
			MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			dacustomer.SelectCommand = cmdcustomer;
			DataSet dscustomer = new DataSet();
			dacustomer.Fill(dscustomer, "MaVatTuPhuTung");
			cbbMaVatTuTraCuu.DataSource = dscustomer.Tables[0];
			cbbMaVatTuTraCuu.DisplayMember = "MaVatTuPhuTung";
			cbbMaVatTuTraCuu.ValueMember = "MaVatTuPhuTung";
		}

		
		#region Export Excel
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

		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			export2Excel(dtgvVatTu, @"E:\", "ExportSpareParts");
		}
		#endregion
	}
}
