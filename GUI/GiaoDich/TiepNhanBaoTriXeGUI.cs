using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class fTiepNhanBaoTriXe : Form
    {
        public fTiepNhanBaoTriXe()
        {
            InitializeComponent();
            fillCboBienSo();
            fillCboHieuXe();
            fillCboTenChuXe();
        }

        #region Button event
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!fMainForm.cNullTB(cboTenChuXe.Text) && !fMainForm.cNullTB(cboBienSo.DisplayMember) && !fMainForm.cNullTB(cboHieuXe.DisplayMember)
                && !fMainForm.cNullTB(txtDiaChi.Text) && !fMainForm.cNullTB(txtDienThoai.Text))
            {
                string BienSo = cboBienSo.SelectedValue.ToString().Trim();
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

        #endregion

        #region Fill ComboBox

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

        private void fillCboHieuXe()
        {
			MySqlConnection ConnCar = DatabaseConnectionDAO.connectionDatabase();
			MySqlCommand cmdCar = new MySqlCommand("select MAHIEUXE,TENHIEUXE from HIEUXE", ConnCar);


			ConnCar.Open();
			MySqlDataAdapter daCar = new MySqlDataAdapter();
			daCar.SelectCommand = cmdCar;
			DataSet dsCar = new DataSet();
			daCar.Fill(dsCar, "TenHieuXe");
			cboHieuXe.DataSource = dsCar.Tables[0];
			cboHieuXe.DisplayMember = "TenHieuXe";
			cboHieuXe.ValueMember = "MaHieuXe";
			cboHieuXe.SelectedIndex = -1;
		}

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
        #endregion
    }
}
