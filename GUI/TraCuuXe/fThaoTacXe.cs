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

		private void btnThemXe_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbBienSoXe.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(cbbHieuXe.DisplayMember)  && !fMainForm.cNullTB(tbTienNo.Text))
			{
				if (!XeBUS.cPrimaryKey(tbBienSoXe.Text.Trim()))
				{

					string BienSoXe = tbBienSoXe.Text.Trim();
					string TenChuXe = tbTenChuXe.Text;
					string HieuXe = cbbHieuXe.ValueMember;
					
					int TienNo = Convert.ToInt32(tbTienNo.Text);


					XeDTO xe = new XeDTO(BienSoXe, TenChuXe,HieuXe,TienNo);
					XeBUS.addXe(xe);
					dtgvLichSuThaoTacXe.DataSource = XeBUS.loadTatCaXe();
					

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

		private void btnLichSuThaoTacXe_Click(object sender, EventArgs e)
		{
			dtgvLichSuThaoTacXe.DataSource = XeBUS.loadTatCaXe();
		}

		private void fThaoTacXe_Load(object sender, EventArgs e)
		{
			MySqlConnection Conn = DatabaseConnectionDAO.HamKetNoi();
			MySqlCommand cmd = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", Conn);


			Conn.Open();
			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;
			DataSet ds = new DataSet();
			da.Fill(ds, "TenHieuXe");
			cbbHieuXe.DataSource = ds.Tables[0];
			cbbHieuXe.DisplayMember = "TenHieuXe";
			cbbHieuXe.ValueMember = "MaHieuXe";
			



		}
	}
}
