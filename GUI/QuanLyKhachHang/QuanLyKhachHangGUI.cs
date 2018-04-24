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
	public partial class fQuanLyKhachHang : Form
	{

		#region Form Load
		public fQuanLyKhachHang()
		{
			InitializeComponent();
			//Load_MaKhachSuaXe();
		}



		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		private void fQuanLyKhachHang_Load(object sender, EventArgs e)
		{
			//Setup cbbTienNo

			cbbTienNo.Items.Add("Bằng");


			cbbTienNo.Items.Add("Lớn hơn");

			cbbTienNo.Items.Add("Lớn hơn hoặc bằng");

			cbbTienNo.Items.Add("Nhỏ hơn");

			cbbTienNo.Items.Add("Nhỏ hơn hoặc bằng");
			cbbTienNo.SelectedIndex = 2;



				// setup form
			
			//load CustomerID
			
			//MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			//MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE from KHACHSUAXE", Conncustomer);


			//Conncustomer.Open();
			//MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			//dacustomer.SelectCommand = cmdcustomer;
			//DataSet dscustomer = new DataSet();
			//dacustomer.Fill(dscustomer, "MaKhachSuaXe");
			//cbbMaKhachHangTraCuu.DataSource = dscustomer.Tables[0];
			//cbbMaKhachHangTraCuu.DisplayMember = "MaKhachSuaXe";
			//cbbMaKhachHangTraCuu.ValueMember = "MaKhachSuaXe";






		}
		#endregion
		#region Functions
		//Conditional customer search function
		private void FindCustomer()
		{
			string CompareType = "";

			switch (cbbTienNo.SelectedIndex)
			{
				case 0:
					CompareType = "=";
					break;
				case 1:
					CompareType = ">";
					break;
				case 2:
					CompareType = ">=";
					break;
				case 3:
					CompareType = "<";
					break;
				case 4:
					CompareType = "<=";
					break;
			}
			Decimal SoTienNoCompareType = -99999999;
			if (tbSoTienNoTraCuu.Text == "")
			{
				CompareType = ">=";
			}
			else
			{
				SoTienNoCompareType = Decimal.Parse(tbSoTienNoTraCuu.Text);
			}
			if (!fMainForm.cNullTB(tbMaKhachHangTraCuu.Text) || !fMainForm.cNullTB(tbSoTienNoTraCuu.Text))
			{
				//if (KhachSuaXeBUS.cPrimaryKey(cbbMaKhachHangTraCuu.SelectedValue.ToString().Trim()))
				//{

					string strMaKhachSuaXe = tbMaKhachHangTraCuu.Text.Trim();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
					string TenChuXe = tbTenKhachHangTraCuu.Text;
					string DienThoai = tbDienThoaiTraCuu.Text;
					string DiaChi = tbDiaChiTraCuu.Text;
					string Email = tbEmailTraCuu.Text;
					int TienNo = Convert.ToInt32(tbSoTienNoTraCuu.Text);


					KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);

					dtgvKhachHang.DataSource = KhachSuaXeBUS.SearchAllCustomer(kh, CompareType);
				//}
				//else
				//{
				//	MessageBox.Show("Dữ liệu vừa nhập vào không có.Mời nhập lại.");
				//}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
		}
		//Excel export function
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



		#endregion
		#region Button
		//button search customer
		private void btnTimTatCa_Click(object sender, EventArgs e)
		{
			string tbMaKhachHangTraCuu = "0";
			
			string  tbTenKhachHangTraCuu = "";
			string tbDienThoaiTraCuu = "";
			string tbDiaChiTraCuu = "";
			string tbEmailTraCuu = "";
			string tbSoTienNoTraCuu = "";
			FindCustomer();

		}
		//button export file excel
		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			export2Excel(dtgvKhachHang, @"E:\", "ExportCustomers");
		}
		
		#endregion
	}
}
