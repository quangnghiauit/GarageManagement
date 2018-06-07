using System;
using System.Windows.Forms;
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
					string soTienCong = tbSoTienCong.Text;
					decimal SoTienCong = decimal.Parse(soTienCong);



					TienCongDTO tienCong = new TienCongDTO(MaTienCong, TenTienCong,SoTienCong);
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
			RefreshGUI();
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
			RefreshGUI();
		}
		
		private void btnView_Click(object sender, EventArgs e)
		{
			dtgvTienCong.DataSource = TienCongBUS.loadAllSalary();
		}

		#endregion
		private void RefreshGUI()
		{
			tbMaTienCong.Text = "";
			tbTenTienCong.Text = "";
			tbSoTienCong.Text = "0";
		}
	}
}
