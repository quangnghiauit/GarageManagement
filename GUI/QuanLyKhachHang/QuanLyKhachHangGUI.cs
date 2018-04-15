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
namespace GUI
{
	public partial class fQuanLyKhachHang : Form
	{
		public fQuanLyKhachHang()
		{
			InitializeComponent();
			//Load_MaKhachSuaXe();
		}

		private void Bằng_SelectedIndexChanged(object sender, EventArgs e)
		{

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
			cbbTienNo.SelectedIndex = 0;








		}

		#region Functions
		private void btnTimTatCa_Click(object sender, EventArgs e)
		{
			string CompareType = "";

			switch(cbbTienNo.SelectedIndex)
			{
				case 0:	CompareType = "=";
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
			if(tbSoTienNoTraCuu.Text=="")
			{
				CompareType = ">=";
			}
			else
			{
				SoTienNoCompareType = Decimal.Parse(tbSoTienNoTraCuu.Text);
			}
			if (!fMainForm.cNullTB(tbMaKhachHangTraCuu.Text) && !fMainForm.cNullTB(tbTenKhachHangTraCuu.Text) && !fMainForm.cNullTB(tbDienThoaiTraCuu.Text) && !fMainForm.cNullTB(tbDiaChiTraCuu.Text) && !fMainForm.cNullTB(tbEmailTraCuu.Text) && !fMainForm.cNullTB(tbSoTienNoTraCuu.Text))
			{
				if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachHangTraCuu.Text.Trim()))
				{

					string MaKhachSuaXe = tbMaKhachHangTraCuu.Text.Trim();
					string TenChuXe =tbTenKhachHangTraCuu.Text;
					string DienThoai = tbDienThoaiTraCuu.Text;
					string DiaChi = tbDiaChiTraCuu.Text;
					string Email = tbEmailTraCuu.Text;
					int TienNo = Convert.ToInt32(tbSoTienNoTraCuu.Text);


					KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);
					KhachSuaXeBUS.SearchAllKhachSuaXe(kh, CompareType);
					dtgvKhachHang.DataSource = KhachSuaXeBUS.loadTatCaKhachHang();

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
		#endregion


	}
}
