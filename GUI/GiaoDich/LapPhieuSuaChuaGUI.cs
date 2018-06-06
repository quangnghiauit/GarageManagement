using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;
using DTO;
using MySql.Data.MySqlClient;

namespace GUI
{
	public partial class fLapPhieuSuaChua : Form
	{
        #region Variables for dgv table
        int rownum = 1;
        bool reset = false;
        int TongTien;
        #endregion
        public fLapPhieuSuaChua()
		{
			InitializeComponent();

            fillBienSo();
            fillCBOTIENCONG();
            fillCBOVatTuPhuTung();
            TongTien = 0;
            txtTongTien.Text = TongTien.ToString();
        }

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {         
                reset = true;                
                rownum = 1;
                this.dgvPhieuSuaChua.Rows.Clear();
                TongTien = 0;
                txtTongTien.Text = TongTien.ToString();
                reset = false;
        }
        

        public void insertPhieuSuaChua()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand command = new MySqlCommand("InsertCHITIETPHIEUSUACHUA", connection);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < dgvPhieuSuaChua.Rows.Count - 1; i++)
            {
                command.Parameters.Add("@_MaPhieSuaChua", MySqlDbType.VarChar, 10);
                command.Parameters.Add(new MySqlParameter("@_NoiDung", dgvPhieuSuaChua.Rows[i].Cells["NoiDung"].Value));
                command.Parameters.Add(new MySqlParameter("@_MaVatTuPhuTung", dgvPhieuSuaChua.Rows[i].Cells["VatTuPhuTung"].Value));
                command.Parameters.Add(new MySqlParameter("@_SoLuongSuaChua", dgvPhieuSuaChua.Rows[i].Cells["SoLuong"].Value));
                command.Parameters.Add(new MySqlParameter("@_TienCong", dgvPhieuSuaChua.Rows[i].Cells["TienCong"].Value));
                command.Parameters.Add(new MySqlParameter("@_ThanhTien", dgvPhieuSuaChua.Rows[i].Cells["ThanhTien"].Value));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(cboBienSo.Text) && !fMainForm.cNullTB(txtSoPhieuSuaChua.Text))
            {
                string MaPhieuSuaChua = txtSoPhieuSuaChua.Text;
                string BienSo = cboBienSo.SelectedValue.ToString();
                DateTime NgaySuaChua = dtmNgaySuaChua.Value;
                Decimal _TongTien = int.Parse(txtTongTien.Text);

                PhieuSuaChuaDTO PhieuSuaChua = new PhieuSuaChuaDTO(MaPhieuSuaChua, BienSo, NgaySuaChua, _TongTien);
                PhieuSuaChuaBUS.addPhieuSuaChua(PhieuSuaChua);

                for (int i = 0; i < dgvPhieuSuaChua.Rows.Count - 1; i++)
                {
                    string NoiDung = dgvPhieuSuaChua.Rows[i].Cells["NoiDung"].Value.ToString();
                    string MaVatTuPhuTung = dgvPhieuSuaChua.Rows[i].Cells["VatTuPhuTung"].Value.ToString();
                    int SoLuongSuaChua = int.Parse(dgvPhieuSuaChua.Rows[i].Cells["SoLuong"].Value.ToString());
                    int TienCong = int.Parse(dgvPhieuSuaChua.Rows[i].Cells["TienCong"].Value.ToString());
                    Decimal ThanhTien = int.Parse(dgvPhieuSuaChua.Rows[i].Cells["ThanhTien"].Value.ToString());

                    ChiTietPhieuSuaChuaDTO CTPhieuSuaChua = new ChiTietPhieuSuaChuaDTO(MaPhieuSuaChua, NoiDung, MaVatTuPhuTung,
                        SoLuongSuaChua, TienCong, ThanhTien);
                    ChiTietPhieuSuaChuaBUS.addChiTietPhieuSuaChua(CTPhieuSuaChua);
                }
                  
                dgvLichSuLapPhieu.DataSource = PhieuSuaChuaBUS.selectAllPhieuSuaChua();

                #region Clear dgvTable
                reset = true;
                rownum = 1;
                this.dgvPhieuSuaChua.Rows.Clear();
                TongTien = 0;
                txtTongTien.Text = TongTien.ToString();
                reset = false;
                #endregion
            }
            else
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
        }

        private void btnLichSuLapPhieu_Click(object sender, EventArgs e)
        {
            dgvLichSuLapPhieu.DataSource = PhieuSuaChuaBUS.selectAllPhieuSuaChua();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtNoiDung.Text) && !fMainForm.cNullTB(cboVatTuPhuTung.Text) &&
                !fMainForm.cNullTB(txtSoLuong.Text) && !fMainForm.cNullTB(txtDonGia.Text) &&
                !fMainForm.cNullTB(cboTienCong.Text))
            {                
                dgvPhieuSuaChua.Rows.Add(rownum, txtNoiDung.Text, cboVatTuPhuTung.SelectedValue, txtSoLuong.Text,
                    txtDonGia.Text, cboTienCong.SelectedValue, txtThanhTien.Text);

                TongTien += int.Parse(txtThanhTien.Text);
                txtTongTien.Text = TongTien.ToString();

                #region Creating auto-increment for STT column
                if (!reset)
                    rownum++;
                #endregion

                #region Refresh
                reset = true;
                txtNoiDung.Clear();
                cboVatTuPhuTung.SelectedIndex = -1;
                txtSoLuong.Clear();
                txtDonGia.Clear();
                txtThanhTien.Clear();
                cboTienCong.SelectedIndex = -1;
                reset = false;
                #endregion
            }
            else
                MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");

        }

        #region Fill cbo
        private void fillCBOVatTuPhuTung()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select MAVATTUPHUTUNG, TENVATTUPHUTUNG from VATTUPHUTUNG", connection);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataset, "TENVATTUPHUTUNG");
            cboVatTuPhuTung.DataSource = dataset.Tables[0];
            cboVatTuPhuTung.DisplayMember = "TENVATTUPHUTUNG";
            cboVatTuPhuTung.ValueMember = "MAVATTUPHUTUNG";

            cboVatTuPhuTung.SelectedIndex = -1;            
        }

        private void fillCBOTIENCONG()
        {
            MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();
            MySqlCommand cmd = new MySqlCommand("select SOTIENCONG, TENTIENCONG from TIENCONG", connection);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(dataset, "TENTIENCONG");
            cboTienCong.DataSource = dataset.Tables[0];
            cboTienCong.DisplayMember = "TENTIENCONG";
            cboTienCong.ValueMember = "SOTIENCONG";

            cboTienCong.SelectedIndex = -1;
        }

        private void fillBienSo()
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

        #region Calculate ThanhTien
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtDonGia.Text) && !fMainForm.cNullTB(cboTienCong.Text) && !reset)
            {
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtSoLuong.Text) && !fMainForm.cNullTB(cboTienCong.Text) && !reset)
            {
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }

        private void cboTienCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtDonGia.Text) && !fMainForm.cNullTB(txtSoLuong.Text) && !reset)
            {
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }
        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reset = true;
            txtNoiDung.Clear();
            cboVatTuPhuTung.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            cboTienCong.SelectedIndex = -1;
            reset = false;
        }
    }
}
