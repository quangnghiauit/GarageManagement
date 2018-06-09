using System;
using System.Data;
using System.Windows.Forms;
using DAO;
using BUS;
using DTO;
using MySql.Data.MySqlClient;
using app = Microsoft.Office.Interop.Excel.Application;


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

        #region Button event
        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {         
                reset = true;                
                rownum = 1;
                this.dgvPhieuSuaChua.Rows.Clear();
                TongTien = 0;
                txtTongTien.Text = TongTien.ToString();
                reset = false;
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(cboBienSo.Text) && !fMainForm.cNullTB(txtSoPhieuSuaChua.Text))
            {
                string MaPhieuSuaChua = txtSoPhieuSuaChua.Text.Trim();
                string BienSo = cboBienSo.SelectedValue.ToString();
                DateTime NgaySuaChua = dtmNgaySuaChua.Value;
                Decimal _TongTien = int.Parse(txtTongTien.Text);

                if (!PhieuSuaChuaBUS.checkPK(MaPhieuSuaChua))
                {
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
                        VatTuPhuTungBUS.decreaseSoLuongVatTu(MaVatTuPhuTung, SoLuongSuaChua);
                    }

                    KhachSuaXeDAO.addTienNo(BienSo, _TongTien);

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
                    MessageBox.Show("Dữ liệu vừa nhập vào không hợp lệ, do bị trùng khóa chính.");
                
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
                if (IsNumber(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            export2Excel(dgvLichSuLapPhieu, @"E:\", "ExportPhieuSuaChua");
        }
        #endregion

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
                if (IsNumber(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtSoLuong.Text) && !fMainForm.cNullTB(cboTienCong.Text) && !reset)
            {
                if (IsNumber(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }

        private void cboTienCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(txtDonGia.Text) && !fMainForm.cNullTB(txtSoLuong.Text) && !reset)
            {
                if (IsNumber(txtSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsNumber(txtDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text) + int.Parse(cboTienCong.SelectedValue.ToString())).ToString();
            }
        }
        #endregion
        
        #region Function
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

        private void export2Excel(DataGridView g, string path, string filename)
        {

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(path + filename + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

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
