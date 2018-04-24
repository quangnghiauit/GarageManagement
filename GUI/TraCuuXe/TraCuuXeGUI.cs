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
	public partial class fTraCuuXe : Form
	{
		public fTraCuuXe()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void fTraCuuXe_Load(object sender, EventArgs e)
		{



			#region Load and set up values
			//Setup cbbTienNo

			//cbbTienNoTraCuu.Items.Add("Bằng");


			//cbbTienNoTraCuu.Items.Add("Lớn hơn");

			//cbbTienNoTraCuu.Items.Add("Lớn hơn hoặc bằng");

			//cbbTienNoTraCuu.Items.Add("Nhỏ hơn");

			//cbbTienNoTraCuu.Items.Add("Nhỏ hơn hoặc bằng");
			//cbbTienNoTraCuu.SelectedIndex = 2;
			//set up IDCar
			MySqlConnection ConnIDCar = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdIDCar = new MySqlCommand("select BIENSO from XE", ConnIDCar);


			ConnIDCar.Open();
			MySqlDataAdapter daIDCar = new MySqlDataAdapter();
			daIDCar.SelectCommand = cmdIDCar;
			DataSet dsIDCar = new DataSet();
			daIDCar.Fill(dsIDCar, "BienSo");
			cbbBienSoTraCuu.DataSource = dsIDCar.Tables[0];
			cbbBienSoTraCuu.DisplayMember = "BienSo";
			cbbBienSoTraCuu.ValueMember = "BienSo";

			//display car name and set value car
			MySqlConnection ConnCar = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdCar = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", ConnCar);


			ConnCar.Open();
			MySqlDataAdapter daCar = new MySqlDataAdapter();
			daCar.SelectCommand = cmdCar;
			DataSet dsCar = new DataSet();
			daCar.Fill(dsCar, "TenHieuXe");
			cbbHieuXeTraCuu.DataSource = dsCar.Tables[0];
			cbbHieuXeTraCuu.DisplayMember = "TenHieuXe";
			cbbHieuXeTraCuu.ValueMember = "MaHieuXe";

			//display customer name and set value ID customer
			MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE,TENCHUXE from KHACHSUAXE", Conncustomer);


			Conncustomer.Open();
			MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			dacustomer.SelectCommand = cmdcustomer;
			DataSet dscustomer = new DataSet();
			dacustomer.Fill(dscustomer, "TenChuXe");
			cbbTenChuXeTraCuu.DataSource = dscustomer.Tables[0];
			cbbTenChuXeTraCuu.DisplayMember = "TenChuXe";
			cbbTenChuXeTraCuu.ValueMember = "MaKhachSuaXe";

			#endregion
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//string CompareType = "";

			//switch (cbbTienNoTraCuu.SelectedIndex)
			//{
			//	case 0:
			//		CompareType = "=";
			//		break;
			//	case 1:
			//		CompareType = ">";
			//		break;
			//	case 2:
			//		CompareType = ">=";
			//		break;
			//	case 3:
			//		CompareType = "<";
			//		break;
			//	case 4:
			//		CompareType = "<=";
			//		break;
			//}
			//Decimal SoTienNoCompareType = -99999999;
			//if (tbTienNoTraCuu.Text == "")
			//{
			//	CompareType = ">=";
			//}
			//else
			//{
			//	SoTienNoCompareType = Decimal.Parse(tbTienNoTraCuu.Text);
			//}
			//if (!fMainForm.cNullTB(cbbBienSoTraCuu.DisplayMember) && !fMainForm.cNullTB(tbTienNoTraCuu.Text))
			//{

			//	if (XeBUS.cPrimaryKey(cbbBienSoTraCuu.SelectedValue.ToString().Trim()))
			//	{


			//		string BienSo = cbbBienSoTraCuu.SelectedValue.ToString().Trim();
			//		string strMaKhachSuaXe = cbbTenChuXeTraCuu.SelectedValue.ToString();
			//		int MaKhachSuaXe= Convert.ToInt32(strMaKhachSuaXe);
			//		string TenChuXe = cbbTenChuXeTraCuu.DisplayMember;
			//		string MaHieuXe = cbbHieuXeTraCuu.SelectedValue.ToString();
			//		string TenHieuXe = cbbHieuXeTraCuu.SelectedValue.ToString();

			//		int TienNo = Convert.ToInt32(tbTienNoTraCuu.Text);


			//		XeDTO xe = new XeDTO(BienSo, TenChuXe, TenHieuXe, TienNo);

			//		dtgvTraCuuXe.DataSource = XeBUS.SearchAllCar(BienSo, MaKhachSuaXe, MaHieuXe, TenChuXe, TenHieuXe, TienNo, CompareType);
			//	}
			//	else
			//	{
			//		MessageBox.Show("Dữ liệu vừa nhập vào không có.Mời nhập lại.");
			//	}

			//}
			//else
			//{

			//	MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			//}




			if (!fMainForm.cNullTB(cbbBienSoTraCuu.DisplayMember) )
			{

				if (XeBUS.cPrimaryKey(cbbBienSoTraCuu.SelectedValue.ToString().Trim()))
				{


					string BienSo = cbbBienSoTraCuu.SelectedValue.ToString().Trim();
					
					


					

					dtgvTraCuuXe.DataSource = XeBUS.SearchAllCar(BienSo);
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

		private void btnXuatFileTraCuuXe_Click(object sender, EventArgs e)
		{
			export2Excel(dtgvTraCuuXe, @"E:\", "ExportCars");
		}
		#endregion
	}
}
