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
	public partial class fThayDoiTienCong : Form
	{
		public fThayDoiTienCong()
		{
			InitializeComponent();
		}

		#region Add,remove,view

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaTienCong.Text) && !fMainForm.cNullTB(tbTenTienCong.Text))
			{
				if (!TienCongBUS.cPrimaryKey(tbMaTienCong.Text.Trim()))
				{

					string MaTienCong = tbMaTienCong.Text.Trim();
					string TenTienCong = tbTenTienCong.Text;



					TienCongDTO tienCong = new TienCongDTO(MaTienCong, TenTienCong);
					TienCongBUS.addSalary(tienCong);
					dtgvTienCong.DataSource = TienCongBUS.loadAllSalary();

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
			if (!fMainForm.cNullTB(tbMaTienCong.Text))
			{
				if (TienCongBUS.cPrimaryKey(tbMaTienCong.Text.Trim()))
				{
					string MaTienCong = tbMaTienCong.Text;
					TienCongBUS.delSalary(MaTienCong);
					dtgvTienCong.DataSource = TienCongBUS.loadAllSalary();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Hiệu Xe.");
				}
			}
		}
		
		private void btnView_Click(object sender, EventArgs e)
		{
			dtgvTienCong.DataSource = TienCongBUS.loadAllSalary();
		}

		#endregion
	}
}
