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
	public partial class fThemHieuXe : Form
	{
		public fThemHieuXe()
		{
			InitializeComponent();
		}
		#region Add, Remove
		private void btnDongYThem_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaHieuXe.Text) && !fMainForm.cNullTB(tbTenHieuXe.Text))
			{
				if (!HieuXeBUS.cPrimaryKey(tbMaHieuXe.Text.Trim()))
				{

					string MaHieuXe = tbMaHieuXe.Text.Trim();
					string TenHieuXe = tbTenHieuXe.Text;



					HieuXeDTO hx = new HieuXeDTO(MaHieuXe, TenHieuXe);
					HieuXeBUS.addHieuXe(hx);
					dtgvHieuXe.DataSource = HieuXeBUS.loadTatCaHieuXe();

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
			if (!fMainForm.cNullTB(tbMaHieuXe.Text))
			{
				if (HieuXeBUS.cPrimaryKey(tbMaHieuXe.Text.Trim()))
				{
					string MaHieuXe = tbMaHieuXe.Text;
					HieuXeBUS.delHieuXe(MaHieuXe);
					dtgvHieuXe.DataSource = HieuXeBUS.loadTatCaHieuXe();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Hiệu Xe.");
				}
			}
		}
		#endregion
	}
}
