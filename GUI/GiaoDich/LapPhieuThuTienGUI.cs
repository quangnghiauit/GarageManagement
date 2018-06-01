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
            fillCboTenChuXe();
		}

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(cboBienSo.Text) && !fMainForm.cNullTB(txtTenChuXe.Text) && !fMainForm.cNullTB(txtDienThoai.Text)
                && !fMainForm.cNullTB(txtEmail.Text) && !fMainForm.cNullTB(txtSoTienNo.Text) && !fMainForm.cNullTB(txtSoTienNo.Text) &&
                    !fMainForm.cNullTB(txtTienKhachTra.Text) && !fMainForm.cNullTB(txtTienTraKhach.Text) && !fMainForm.cNullTB(txtTienThu.Text))
            {
                string BienSo = cboBienSo.Text;
                DateTime NgayThuTien = dtmNgayThuTien.Value;
                int SoTienThu = int.Parse(txtTienThu.Text);

                PhieuThuTienDTO PhieuThu = new PhieuThuTienDTO("", BienSo,NgayThuTien,SoTienThu);
                PhieuThuTienBUS.addPhieuThuTien(PhieuThu);
                dgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
            }

        }

        private void btnLichSuThuTien_Click(object sender, EventArgs e)
        {
            dgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();
        }

        private void fillCboTenChuXe()
        {
            LapPhieuThuTienDAO.fillCBO("BIENSO", "XE", cboBienSo);
        }
    }
}
