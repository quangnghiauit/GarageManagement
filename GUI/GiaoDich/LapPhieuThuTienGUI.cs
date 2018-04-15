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
	public partial class fLapPhieuThuTien : Form
	{
		public fLapPhieuThuTien()
		{
			InitializeComponent();
		}

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(tbBienSo.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbDienThoai.Text)
                && !fMainForm.cNullTB(tbEmail.Text) && !fMainForm.cNullTB(tbSoTienNo.Text) && !fMainForm.cNullTB(tbSoTienNo.Text) &&
                    !fMainForm.cNullTB(tbTienKhachTra.Text) && !fMainForm.cNullTB(tbTienTraKhach.Text) && !fMainForm.cNullTB(tbTienThu.Text))
            {
                string BienSo = tbBienSo.Text;
                DateTime NgayThuTien = dtmNgayThuTien.Value;
                int SoTienThu = int.Parse(tbTienThu.Text);

                PhieuThuTienDTO PhieuThu = new PhieuThuTienDTO("", BienSo,NgayThuTien,SoTienThu);
                PhieuThuTienBUS.addPhieuThuTien(PhieuThu);
                dtgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
            }

        }

        private void btnLichSuThuTien_Click(object sender, EventArgs e)
        {
            dtgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();
        }
    }
}
