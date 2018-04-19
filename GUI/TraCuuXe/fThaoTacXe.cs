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

namespace GUI
{
	public partial class fThaoTacXe : Form
	{
		public fThaoTacXe()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Add car brands
			fThemHieuXe myForm = new fThemHieuXe();
			
			myForm.ShowDialog();
			
			this.Show();
		}
		#region Insert , Update, Remove
		private void btnThemXe_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbBienSoXe.Text) && !fMainForm.cNullTB(cbbTenChuXe.DisplayMember) && !fMainForm.cNullTB(cbbHieuXe.DisplayMember) &&  !fMainForm.cNullTB(tbTienNo.Text))
			{

				if(!XeBUS.cPrimaryKey(tbBienSoXe.Text.Trim()))
				
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

		private void fThaoTacXe_Load(object sender, EventArgs e)
		{
			#region Load car name and customer name
			//display car name and set value car
			MySqlConnection ConnCar = DatabaseConnectionDAO.HamKetNoi();
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
			MySqlConnection Conncustomer = DatabaseConnectionDAO.HamKetNoi();
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		
	}
}
