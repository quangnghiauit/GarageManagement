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
	public partial class fmThaoTacVatTu : Form
	{
		public fmThaoTacVatTu()
		{
			InitializeComponent();
		}

		#region Buttons Insert, Update, Remove

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaVatTuThaoTac.Text) && !fMainForm.cNullTB(tbTenVatTuThaoTac.Text) && !fMainForm.cNullTB(tbDonGiaThaoTac.Text) && !fMainForm.cNullTB(tbSoLuongThaoTac.Text))
			{
				if (!VatTuPhuTungBUS.cPrimaryKey(tbMaVatTuThaoTac.Text.Trim()))
				{

					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();
					
					string TenVatTuPhuTung = tbTenVatTuThaoTac.Text;
					int DonGia = Convert.ToInt32(tbDonGiaThaoTac.Text);
					int SoLuongVatTu = Convert.ToInt32(tbSoLuongThaoTac.Text);



					VatTuPhuTungDTO vatTu= new VatTuPhuTungDTO (MaVatTuPhuTung,TenVatTuPhuTung,DonGia,SoLuongVatTu);
					VatTuPhuTungBUS.addSpareParts(vatTu);
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
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
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
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaVatTuThaoTac.Text))
			{
				if (VatTuPhuTungBUS.cPrimaryKey(tbMaVatTuThaoTac.Text.Trim()))
				{
					string MaVatTuPhuTung = tbMaVatTuThaoTac.Text.Trim();
					
					VatTuPhuTungBUS.delSpareParts(MaVatTuPhuTung);
					dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
				}
			}
		}

		private void btnLichSuThaoTac_Click(object sender, EventArgs e)
		{
			dtgvThaoTac.DataSource = VatTuPhuTungBUS.loadAllSpareParts();
		}
		#endregion
	}
}
