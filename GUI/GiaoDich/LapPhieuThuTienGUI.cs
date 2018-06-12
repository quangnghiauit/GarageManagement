using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using MySql.Data.MySqlClient;

namespace GUI
{
	public partial class fLapPhieuThuTien : Form
	{
		public fLapPhieuThuTien()
		{
			InitializeComponent();
            fillCboTenChuXe();
            fillCboBienSo();
		}


        #region Button event
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(cboBienSo.Text) && !fMainForm.cNullTB(cboTenChuXe.Text) && !fMainForm.cNullTB(txtDienThoai.Text)
                && !fMainForm.cNullTB(txtEmail.Text) && !fMainForm.cNullTB(txtSoTienNo.Text) && !fMainForm.cNullTB(txtSoTienNo.Text) &&
                    !fMainForm.cNullTB(txtTienKhachTra.Text))
            {
                string BienSo = cboBienSo.Text;
                DateTime NgayThuTien = dtmNgayThuTien.Value;                
                int SoTienKhachTra = int.Parse(txtTienKhachTra.Text);
                int SoTienTraKhach;
                int SoTienNo = int.Parse(txtSoTienNo.Text);                
                if (SoTienNo > SoTienKhachTra)
                {
                    SoTienTraKhach = 0;
                    SoTienNo -= SoTienKhachTra;
                    KhachSuaXeDAO.addTienNo(BienSo, SoTienNo);
                }                    
                else
                {
                    SoTienTraKhach = SoTienKhachTra - SoTienNo;
                    KhachSuaXeDAO.payTienNo(BienSo, SoTienNo);
                }
                    
                int SoTienThu = SoTienNo;

                PhieuThuTienDTO PhieuThu = new PhieuThuTienDTO("", BienSo,NgayThuTien,SoTienThu, SoTienKhachTra, SoTienTraKhach);
                PhieuThuTienBUS.addPhieuThuTien(PhieuThu);
                dgvLichSuPTT.DataSource = PhieuThuTienBUS.selectAllPhieuThuTien();

                #region Reset value of form after insertion
                cboBienSo.SelectedIndex = -1;
                dtmNgayThuTien.Value = DateTime.Today;
                cboTenChuXe.SelectedIndex = -1;
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
        #endregion

        #region fillCBO

        private void fillCboTenChuXe()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select MAKHACHSUAXE, TENCHUXE from KHACHSUAXE", connection);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataset, "TENCHUXE");
            cboTenChuXe.DataSource = dataset.Tables[0];
            cboTenChuXe.DisplayMember = "TENCHUXE";
            cboTenChuXe.ValueMember = "MAKHACHSUAXE";

            cboTenChuXe.SelectedIndex = -1;
        }

        private void fillCboBienSo()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select BIENSO from XE", connection);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataset, "BIENSO");
            cboBienSo.DataSource = dataset.Tables[0];
            cboBienSo.DisplayMember = "BIENSO";
            cboBienSo.ValueMember = "BIENSO";

            cboBienSo.SelectedIndex = -1;
        }

        #endregion

        #region Calculate value of SoTienThu
        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtSoTienNo.Text))
            {
                if (IsNumber(txtSoTienNo.Text) == false)
                {
                    MessageBox.Show("Số tiền nợ là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtTienKhachTra.Text) == false)
                {
                    MessageBox.Show("Số khách trả là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int SoTienKhachTra = int.Parse(txtTienKhachTra.Text);
                int SoTienTraKhach;
                int SoTienNo = int.Parse(txtSoTienNo.Text);

                if (SoTienNo > SoTienKhachTra)
                {
                    SoTienTraKhach = 0;
                    SoTienNo -= SoTienKhachTra;
                    txtTienThu.Text = SoTienKhachTra.ToString();
                }
                else
                {
                    SoTienTraKhach = SoTienKhachTra - SoTienNo;
                }
                txtTienTraKhach.Text = SoTienTraKhach.ToString();
            }            
        }

        private void txtTienTraKhach_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtTienKhachTra.Text) && !fMainForm.cNullTB(txtTienTraKhach.Text))
            {
                if (!(int.Parse(txtSoTienNo.Text) > int.Parse(txtTienKhachTra.Text)))
                    txtTienThu.Text = (int.Parse(txtTienKhachTra.Text) - int.Parse(txtTienTraKhach.Text)).ToString();
            }
                

                    
        }

        private void txtSoTienNo_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtTienKhachTra.Text))
            {
                if (IsNumber(txtSoTienNo.Text) == false)
                {
                    MessageBox.Show("Số tiền nợ là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtTienKhachTra.Text) == false)
                {
                    MessageBox.Show("Số khách trả là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int SoTienKhachTra = int.Parse(txtTienKhachTra.Text);
                int SoTienTraKhach;
                int SoTienNo = int.Parse(txtSoTienNo.Text);

                if (SoTienNo > SoTienKhachTra)
                {
                    SoTienTraKhach = 0;
                    SoTienNo -= SoTienKhachTra;
                    txtTienThu.Text = SoTienKhachTra.ToString();
                }
                else
                {
                    SoTienTraKhach = SoTienKhachTra - SoTienNo;
                }
                txtTienTraKhach.Text = SoTienTraKhach.ToString();
            }

        }
        #endregion

        #region Function
        private bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        #endregion
    }
}
