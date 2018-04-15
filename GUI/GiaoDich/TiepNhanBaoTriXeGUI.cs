using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace GUI
{
	public partial class fTiepNhanBaoTriXe : Form
	{
		public fTiepNhanBaoTriXe()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void fontDialog1_Apply(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbBienSo.Text) && !fMainForm.cNullTB(tbHieuXe.Text) && !fMainForm.cNullTB(tbDiaChi.Text)
                && !fMainForm.cNullTB(tbDienThoai.Text))
            {
                string BienSo = tbBienSo.Text;
                DateTime NgayTiepNhan = dtmNgayTiepNhan.Value;

                TiepNhanXeSuaDTO TiepNhan = new TiepNhanXeSuaDTO("", BienSo, NgayTiepNhan);
                TiepNhanXeSuaBUS.addTiepNhanXeSua(TiepNhan);
                dtgvLichSuTiepNhan.DataSource = TiepNhanXeSuaBUS.selectAllTiepNhanXeSua();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
            }
        }

        private void btnLichSuTiepNhan_Click(object sender, EventArgs e)
        {
            dtgvLichSuTiepNhan.DataSource = TiepNhanXeSuaBUS.selectAllTiepNhanXeSua();
        }
    }
}
