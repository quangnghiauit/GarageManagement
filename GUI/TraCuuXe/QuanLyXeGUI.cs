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
	public partial class fQuanLyXeGUI : Form
	{
		public fQuanLyXeGUI()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnTimKiemTraCuuXe_Click(object sender, EventArgs e)
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




			if (!fMainForm.cNullTB(cbbBienSoTraCuu.DisplayMember))
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


		private void QuanLyXeGUI_Load(object sender, EventArgs e)
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
			//MySqlConnection ConnCar = DatabaseConnectionDAO.connectionDatabase();
			//MySqlCommand cmdCar = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", ConnCar);


			//ConnCar.Open();
			//MySqlDataAdapter daCar = new MySqlDataAdapter();
			//daCar.SelectCommand = cmdCar;
			//DataSet dsCar = new DataSet();
			//daCar.Fill(dsCar, "TenHieuXe");
			//cbbHieuXeTraCuu.DataSource = dsCar.Tables[0];
			//cbbHieuXeTraCuu.DisplayMember = "TenHieuXe";
			//cbbHieuXeTraCuu.ValueMember = "MaHieuXe";

			////display customer name and set value ID customer
			//MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			//MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE,TENCHUXE from KHACHSUAXE", Conncustomer);


			//Conncustomer.Open();
			//MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			//dacustomer.SelectCommand = cmdcustomer;
			//DataSet dscustomer = new DataSet();
			//dacustomer.Fill(dscustomer, "TenChuXe");
			//cbbTenChuXeTraCuu.DataSource = dscustomer.Tables[0];
			//cbbTenChuXeTraCuu.DisplayMember = "TenChuXe";
			//cbbTenChuXeTraCuu.ValueMember = "MaKhachSuaXe";

			#endregion

			#region Load car name and customer name
			//display car name and set value car
			MySqlConnection ConnCar = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdCar = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", ConnCar);


			ConnCar.Open();
			MySqlDataAdapter daCar = new MySqlDataAdapter();
			daCar.SelectCommand = cmdCar;
			DataSet dsCar = new DataSet();
			daCar.Fill(dsCar, "TenHieuXe");
			cbbHieuXe.DataSource = dsCar.Tables[0];
			cbbHieuXe.DisplayMember = "TenHieuXe";
			cbbHieuXe.ValueMember = "MaHieuXe";

			//display customer name and set value ID customer
			MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE,TENCHUXE from KHACHSUAXE", Conncustomer);


			Conncustomer.Open();
			MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			dacustomer.SelectCommand = cmdcustomer;
			DataSet dscustomer = new DataSet();
			dacustomer.Fill(dscustomer, "TenChuXe");
			cbbTenChuXe.DataSource = dscustomer.Tables[0];
			cbbTenChuXe.DisplayMember = "TenChuXe";
			cbbTenChuXe.ValueMember = "MaKhachSuaXe";

			#endregion
		}

		public void RefreshTraCuuXeGUI()
		{
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
		}
		#region Insert , Update, Remove
		private void btnThemXe_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbBienSoXe.Text) && !fMainForm.cNullTB(cbbTenChuXe.DisplayMember) && !fMainForm.cNullTB(cbbHieuXe.DisplayMember) && !fMainForm.cNullTB(tbTienNo.Text))
			{

				if (!XeBUS.cPrimaryKey(tbBienSoXe.Text.Trim()))

				{

					string BienSo = tbBienSoXe.Text.Trim();
					string strMaKhachSuaXe = cbbTenChuXe.SelectedValue.ToString();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
					string MaHieuXe = cbbHieuXe.SelectedValue.ToString();

					int TienNo = Convert.ToInt32(tbTienNo.Text);


					XeBUS.addCar(BienSo, MaKhachSuaXe, MaHieuXe, TienNo);
					dtgvLichSuThaoTacXe.DataSource = XeBUS.loadAllCar();

				}
				else
				{
					MessageBox.Show("Dữ liệu vừa nhập vào không hợp lệ, do bị trùng khóa chính.");
				}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}


		}

		private void btnCapNhatXe_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbBienSoXe.Text) && !fMainForm.cNullTB(cbbTenChuXe.DisplayMember) && !fMainForm.cNullTB(cbbHieuXe.DisplayMember) && !fMainForm.cNullTB(tbTienNo.Text))
			{
				if (XeBUS.cPrimaryKey(tbBienSoXe.Text.Trim()))
				{

					string BienSo = tbBienSoXe.Text.Trim();
					string strMaKhachSuaXe = cbbTenChuXe.SelectedValue.ToString();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
					string MaHieuXe = cbbHieuXe.SelectedValue.ToString();

					int TienNo = Convert.ToInt32(tbTienNo.Text);


					XeBUS.updateCar(BienSo, MaKhachSuaXe, MaHieuXe, TienNo);

					dtgvLichSuThaoTacXe.DataSource = XeBUS.loadAllCar();

				}
				else
				{
					MessageBox.Show("Mã khách hàng vừa nhập vào không tồn tại.Kiểm tra lại mã để cập nhật dữ liệu.");
				}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
		}

		private void btnXoaXe_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbBienSoXe.Text) && !fMainForm.cNullTB(cbbTenChuXe.DisplayMember) && !fMainForm.cNullTB(cbbHieuXe.DisplayMember))
			{
				if (XeBUS.cPrimaryKey(tbBienSoXe.Text.Trim()))
				{
					string BienSo = tbBienSoXe.Text.Trim();
					string strMaKhachSuaXe = cbbTenChuXe.SelectedValue.ToString();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
					string MaHieuXe = cbbHieuXe.SelectedValue.ToString();

					XeBUS.delCar(BienSo, MaKhachSuaXe, MaHieuXe);
					dtgvLichSuThaoTacXe.DataSource = XeBUS.loadAllCar();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
				}
			}
		}
		#endregion
		private void btnLichSuThaoTacXe_Click(object sender, EventArgs e)
		{
			dtgvLichSuThaoTacXe.DataSource = XeBUS.loadAllCar();
		}

		private void btnThemHieuXe_Click(object sender, EventArgs e)
		{
			//Add car brands
			fThemHieuXe myForm = new fThemHieuXe();

			myForm.ShowDialog();

			this.Show();
			RefreshGUI();
		}
		private void RefreshGUI()
		{
			#region Load car name and customer name
			//display car name and set value car
			MySqlConnection ConnCar = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdCar = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", ConnCar);


			ConnCar.Open();
			MySqlDataAdapter daCar = new MySqlDataAdapter();
			daCar.SelectCommand = cmdCar;
			DataSet dsCar = new DataSet();
			daCar.Fill(dsCar, "TenHieuXe");
			cbbHieuXe.DataSource = dsCar.Tables[0];
			cbbHieuXe.DisplayMember = "TenHieuXe";
			cbbHieuXe.ValueMember = "MaHieuXe";

			//display customer name and set value ID customer
			MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE,TENCHUXE from KHACHSUAXE", Conncustomer);


			Conncustomer.Open();
			MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			dacustomer.SelectCommand = cmdcustomer;
			DataSet dscustomer = new DataSet();
			dacustomer.Fill(dscustomer, "TenChuXe");
			cbbTenChuXe.DataSource = dscustomer.Tables[0];
			cbbTenChuXe.DisplayMember = "TenChuXe";
			cbbTenChuXe.ValueMember = "MaKhachSuaXe";

			#endregion
		}
	}
}
