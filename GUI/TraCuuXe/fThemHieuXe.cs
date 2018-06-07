using System;
using System.Windows.Forms;
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
		private void btnLichSu_Click(object sender, EventArgs e)
		{
			dtgvHieuXe.DataSource = HieuXeBUS.loadTatCaHieuXe();
		}
		#endregion


	}
}
