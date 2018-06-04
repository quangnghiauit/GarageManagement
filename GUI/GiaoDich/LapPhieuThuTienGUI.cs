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
                int SoTienKhachTra = int.Parse(txtTienKhachTra.Text);
                int SoTienTraKhach = int.Parse(txtTienTraKhach.Text);

                PhieuThuTienDTO PhieuThu = new PhieuThuTienDTO("", BienSo,NgayThuTien,SoTienThu, SoTienKhachTra, SoTienTraKhach);
                PhieuThuTienBUS.addPhieuThuTien(PhieuThu);
                dgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();

                #region Reset value of form after insertion
                cboBienSo.SelectedIndex = -1;
                dtmNgayThuTien.Value = DateTime.Today;
                txtTenChuXe.Clear();
                txtDienThoai.Clear();
                txtEmail.Clear();
                txtSoTienNo.Clear();
                txtTienKhachTra.Clear();
                txtTienTraKhach.Clear();
                #endregion
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
            TiepNhanXeSuaDAO.fillCBO("BIENSO", "XE", cboBienSo);
        }

        #region Calculate value of SoTienThu
        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtTienKhachTra.Text) && !fMainForm.cNullTB(txtTienTraKhach.Text))
                txtTienThu.Text = (int.Parse(txtTienKhachTra.Text) - int.Parse(txtTienTraKhach.Text)).ToString();
        }

        private void txtTienTraKhach_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtTienKhachTra.Text) && !fMainForm.cNullTB(txtTienTraKhach.Text))
                txtTienThu.Text = (int.Parse(txtTienKhachTra.Text) - int.Parse(txtTienTraKhach.Text)).ToString();
        }
        #endregion
    }
}
