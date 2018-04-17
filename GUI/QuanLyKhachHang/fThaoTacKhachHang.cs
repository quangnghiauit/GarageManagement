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
	public partial class fThaoTacKhachHang : Form
	{
		
		private void fThaoTacKhachHang_Load(object sender, EventArgs e)
		{
			

		}
		public fThaoTacKhachHang()
		{
			InitializeComponent();
			//Set background
			btnThem.BackColor = Color.LightGray;
			btnThem.ForeColor = Color.Black;
			btnCapNhat.BackColor = Color.LightGray;
			btnCapNhat.ForeColor = Color.Black;
			btnXoa.BackColor = Color.LightGray;
			btnXoa.ForeColor = Color.Black;
		}
		
    


		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}


		#region Buttons Insert, Update, Remove
		//hàm thêm khách hàng
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbDienThoai.Text) && !fMainForm.cNullTB(tbDiaChi.Text) && !fMainForm.cNullTB(tbEmail.Text) && !fMainForm.cNullTB(tbSoTienNo.Text))
			{
				if (!KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{

					string MaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
					string TenChuXe = tbTenChuXe.Text;
					string DienThoai = tbDienThoai.Text;
					string DiaChi = tbDiaChi.Text;
					string Email = tbEmail.Text;
					int TienNo = Convert.ToInt32(tbSoTienNo.Text);


					KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe,TenChuXe,DienThoai,DiaChi,Email,TienNo);
					KhachSuaXeBUS.addKhachHang(kh);
					dtgvThaoTac.DataSource = KhachSuaXeBUS.loadTatCaKhachHang();

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

		// Ham xóa khách hàng
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text))
			{
				if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{
					string MaKhach = tbMaKhachSuaXe.Text;
					KhachSuaXeBUS.delKhachSuaXe(MaKhach);
					dtgvThaoTac.DataSource = KhachSuaXeBUS.loadTatCaKhachHang();
				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
				}
			}
			
		}
		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbDienThoai.Text) && !fMainForm.cNullTB(tbDiaChi.Text) && !fMainForm.cNullTB(tbEmail.Text) && !fMainForm.cNullTB(tbSoTienNo.Text))
			{
				if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{

					string MaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
					string TenChuXe = tbTenChuXe.Text;
					string DienThoai = tbDienThoai.Text;
					string DiaChi = tbDiaChi.Text;
					string Email = tbEmail.Text;
					int TienNo = Convert.ToInt32(tbSoTienNo.Text);


					KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);
					KhachSuaXeBUS.updateKhachHang(kh);
					dtgvThaoTac.DataSource = KhachSuaXeBUS.loadTatCaKhachHang();

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
		//Lịch sử thao tác
		private void btnLichSuThaoTac_Click(object sender, EventArgs e)
		{
			dtgvThaoTac.DataSource = KhachSuaXeBUS.loadTatCaKhachHang();
		}

		#endregion


	}
}
