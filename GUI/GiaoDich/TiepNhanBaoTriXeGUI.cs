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
            fillCboBienSo();
            fillCboHieuXe();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtTenChuXe.Text) && !fMainForm.cNullTB(cboBienSo.Text) && !fMainForm.cNullTB(cboHieuXe.Text)
                && !fMainForm.cNullTB(txtDiaChi.Text) && !fMainForm.cNullTB(txtDienThoai.Text))
            {
                string BienSo = cboBienSo.SelectedText;
                DateTime NgayTiepNhan = dtmNgayTiepNhan.Value;

                TiepNhanXeSuaDTO TiepNhan = new TiepNhanXeSuaDTO(BienSo, NgayTiepNhan);
                TiepNhanXeSuaBUS.addTiepNhanXeSua(TiepNhan);
                dgvLichSuTiepNhan.DataSource = TiepNhanXeSuaBUS.selectAllTiepNhanXeSua();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
            }
        }

        private void btnLichSuTiepNhan_Click(object sender, EventArgs e)
        {
            dgvLichSuTiepNhan.DataSource = TiepNhanXeSuaBUS.selectAllTiepNhanXeSua();
        }

        #region Fill ComboBox

        private void fillCboBienSo()
        {
            LapPhieuThuTienDAO.fillCBO("BIENSO", "XE", cboBienSo);
        }

        private void fillCboHieuXe()
        {
            LapPhieuThuTienDAO.fillCBO("TENHIEUXE", "HIEUXE", cboHieuXe);
        }
        #endregion
    }
}
