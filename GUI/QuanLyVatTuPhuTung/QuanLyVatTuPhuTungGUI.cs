﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAO;
using BUS;
using DTO;
using app = Microsoft.Office.Interop.Excel.Application;

namespace GUI
{
	public partial class fQuanLyVatTuPhuTungGUI : Form
	{
		public fQuanLyVatTuPhuTungGUI()
		{
			InitializeComponent();
			//fillCboBienSo();
		}
		#region Function
		private bool IsNumber(string pValue)
		{
			foreach (Char c in pValue)
			{
				if (!Char.IsDigit(c))
					return false;
			}
			return true;
		}
		private void btnTimKiemTraCuu_Click(object sender, EventArgs e)
		{
			if (IsNumber(tbSoLuongTraCuu.Text) == false)
			{
				MessageBox.Show("Số lượng tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				return;
			}
			if (IsNumber(tbDonGiaTraCuu.Text) == false)
			{
				MessageBox.Show("Đơn giá tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				return;
			}
			if (!fMainForm.cNullTB(cbbMaVatTuTraCuu.Text))
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

		private void QuanLyVatTuPhuTungGUI_Load(object sender, EventArgs e)
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
			cbbMaVatTuTraCuu.SelectedIndex = -1;
			tbDonGiaThaoTac.Text = "0";
			tbSoLuongThaoTac.Text = "0";

			tbDonGiaTraCuu.Text = "0";
			tbSoLuongTraCuu.Text = "0";
		}
		private void btnLichSuThaoTac_Click(object sender, EventArgs e)
		{
			dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();
		}
		//private void fillCboBienSo()
		//{
		//	TiepNhanXeSuaDAO.fillCBO("MaVatTuPhuTung", "VATTUPHUTUNG", cbbMaVatTuTraCuu);
		//}
		private void RefreshGUI()
		{
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
			cbbMaVatTuTraCuu.SelectedIndex = -1;


			tbMaVatTuThaoTac.Text = "";
			tbTenVatTuThaoTac.Text = "";
			tbDonGiaThaoTac.Text = "0";
			tbSoLuongThaoTac.Text = "0";
			tbTenVatTuTraCuu.Text = "";
			tbDonGiaTraCuu.Text = "0";
			tbSoLuongTraCuu.Text = "0";
		}
		#endregion

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
		
		
		#region Buttons Insert, Update, Remove
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (IsNumber(tbSoLuongThaoTac.Text) == false)
			{
				MessageBox.Show("Số lượng tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (IsNumber(tbDonGiaThaoTac.Text) == false)
			{
				MessageBox.Show("Đơn giá tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (!fMainForm.cNullTB(tbMaVatTuThaoTac.Text) && !fMainForm.cNullTB(tbTenVatTuThaoTac.Text) && !fMainForm.cNullTB(tbDonGiaThaoTac.Text) && !fMainForm.cNullTB(tbSoLuongThaoTac.Text))
			{
				if (!VatTuPhuTungBUS.cPrimaryKey(tbMaVatTuThaoTac.Text.Trim()))
				{

					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();

					string TenVatTuPhuTung = tbTenVatTuThaoTac.Text;
					int DonGia = Convert.ToInt32(tbDonGiaThaoTac.Text);
					int SoLuongVatTu = Convert.ToInt32(tbSoLuongThaoTac.Text);

                    DateTime NgayNhap = dtmNgayNhap.Value; // Lay gia tri ngay nhap phu tung


					VatTuPhuTungDTO vatTu = new VatTuPhuTungDTO(MaVatTuPhuTung, TenVatTuPhuTung, DonGia, SoLuongVatTu);
					VatTuPhuTungBUS.addSpareParts(vatTu);
					dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();

                    //Phan chuc nang moi
                    QuanLyNhapVatTuDTO QuanLy = new QuanLyNhapVatTuDTO(MaVatTuPhuTung, SoLuongVatTu, NgayNhap);
                    QuanLyNhapVatTuBUS.addQuanLyNhapVatTu(QuanLy);

				}
				else
				{
					//MessageBox.Show("Dữ liệu vừa nhập vào không hợp lệ, do bị trùng khóa chính.");
					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();

					string TenVatTuPhuTung = tbTenVatTuThaoTac.Text;
					int DonGia = Convert.ToInt32(tbDonGiaThaoTac.Text);
					int SoLuongThem = Convert.ToInt32(tbSoLuongThaoTac.Text);



					//VatTuPhuTungDTO vatTu = new VatTuPhuTungDTO(MaVatTuPhuTung, TenVatTuPhuTung, DonGia,);
					VatTuPhuTungBUS.updateAddSpareParts(MaVatTuPhuTung, TenVatTuPhuTung, DonGia, SoLuongThem);
					dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();
				}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
			RefreshGUI();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (IsNumber(tbSoLuongThaoTac.Text) == false)
			{
				MessageBox.Show("Số lượng tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (IsNumber(tbDonGiaThaoTac.Text) == false)
			{
				MessageBox.Show("Đơn giá tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (!fMainForm.cNullTB(tbMaVatTuThaoTac.Text) && !fMainForm.cNullTB(tbTenVatTuThaoTac.Text) && !fMainForm.cNullTB(tbDonGiaThaoTac.Text) && !fMainForm.cNullTB(tbSoLuongThaoTac.Text))
			{
				if (VatTuPhuTungBUS.cPrimaryKey(tbMaVatTuThaoTac.Text.Trim()))
				{

					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();

					string TenVatTuPhuTung = tbTenVatTuThaoTac.Text;
					int DonGia = Convert.ToInt32(tbDonGiaThaoTac.Text);
					int SoLuongVatTu = Convert.ToInt32(tbSoLuongThaoTac.Text);



					VatTuPhuTungDTO vatTu = new VatTuPhuTungDTO(MaVatTuPhuTung, TenVatTuPhuTung, DonGia, SoLuongVatTu);
					VatTuPhuTungBUS.updateSpareParts(vatTu);
					dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();

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
			RefreshGUI();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (IsNumber(tbSoLuongThaoTac.Text) == false)
			{
				MessageBox.Show("Số lượng tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (IsNumber(tbDonGiaThaoTac.Text) == false)
			{
				MessageBox.Show("Đơn giá tra cứu là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (!fMainForm.cNullTB(tbMaVatTuThaoTac.Text))
			{
				if (VatTuPhuTungBUS.cPrimaryKey(tbMaVatTuThaoTac.Text.Trim()))
				{
					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();
                    
                    //New
                    QuanLyNhapVatTuBUS.removeQuanLyNhapVatTu(MaVatTuPhuTung);
                    //
                    VatTuPhuTungBUS.delSpareParts(MaVatTuPhuTung);
                    
					dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
				}
			}
			RefreshGUI();
		}
		#endregion
		
	}
}
