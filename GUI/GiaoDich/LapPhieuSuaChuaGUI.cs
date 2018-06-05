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
using MySql.Data.MySqlClient;

namespace GUI
{
	public partial class fLapPhieuSuaChua : Form
	{
        #region Variables for dgv table
        int cellnum = 0;
        int rownum = 0;
        bool reset = false;
        #endregion
        public fLapPhieuSuaChua()
		{
			InitializeComponent();
            #region Hiding columns of dgvPhieuSuaChua at the beginning
            this.dgvPhieuSuaChua.Columns["STT"].Visible = false;
            this.dgvPhieuSuaChua.Columns["NoiDung"].Visible = false;
            this.dgvPhieuSuaChua.Columns["VatTuPhuTung"].Visible = false;
            this.dgvPhieuSuaChua.Columns["SoLuong"].Visible = false;
            this.dgvPhieuSuaChua.Columns["DonGia"].Visible = false;
            this.dgvPhieuSuaChua.Columns["TienCong"].Visible = false;
            this.dgvPhieuSuaChua.Columns["ThanhTien"].Visible = false;
            #endregion

            dgvPhieuSuaChua.Rows[0].Cells[0].Value = 1;

            fillBienSo();
            
        }

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {
           
            if (this.dgvPhieuSuaChua.Columns["STT"].Visible == false)
            {
                this.dgvPhieuSuaChua.Columns["STT"].Visible = true;
                this.dgvPhieuSuaChua.Columns["NoiDung"].Visible = true;
                this.dgvPhieuSuaChua.Columns["VatTuPhuTung"].Visible = true;
                this.dgvPhieuSuaChua.Columns["SoLuong"].Visible = true;
                this.dgvPhieuSuaChua.Columns["DonGia"].Visible = true;
                this.dgvPhieuSuaChua.Columns["TienCong"].Visible = true;
                this.dgvPhieuSuaChua.Columns["ThanhTien"].Visible = true;
                fillVatTuPhuTung();
            }
            else
            {
                fillVatTuPhuTung();
                reset = true;
                cellnum = 0;
                rownum = 0;
                this.dgvPhieuSuaChua.Rows.Clear();               
                dgvPhieuSuaChua.Rows[0].Cells[0].Value = 1;                
                reset = false;
            }

            //Creating default value for "Vật tư phụ tùng", "Đơn giá" and "Số lượng" when creating the table the first time.
            //dgvPhieuSuaChua.Rows[0].Cells[2].Value = "Không";
            dgvPhieuSuaChua.Rows[0].Cells[3].Value = 0;
            dgvPhieuSuaChua.Rows[0].Cells[4].Value = 0;
        }

        private void fillBienSo()
        {
            PhieuSuaChuaDAO.fillCBO("BIENSO", "XE", cboBienSo);
        }

        private void fillVatTuPhuTung()
        {

            using (MySqlConnection conn = DatabaseConnectionDAO.connectionDatabase())
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM VATTUPHUTUNG", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow topItem = table.NewRow();
                topItem[0] = 0;
                topItem[1] = "Select";
                VatTuPhuTung.ValueMember = "MAVATTUPHUTUNG";
                VatTuPhuTung.DisplayMember = "TENVATTUPHUTUNG";
                VatTuPhuTung.DataSource = table.Copy();
                

                //dgvPhieuSuaChua.DataSource = new DataView(table).ToTable(true, new string[] { "MAVATTUPHUTUNG, TENVATTUPHUTUNG" });
                //dgvPhieuSuaChua.DataSource = table;
                //DataGridViewComboBoxColumn dgvCboColumn = new DataGridViewComboBoxColumn();
                //dgvCboColumn.Name = "VatTuPhuTung";
                //dgvPhieuSuaChua.Columns.Add(dgvCboColumn);
                //foreach (DataGridViewRow row in dgvPhieuSuaChua.Rows)
                //{
                //    DataGridViewComboBoxCell cboVatTuPhuTung = (DataGridViewComboBoxCell)(row.Cells["VatTuPhuTung"]);
                //    cboVatTuPhuTung.DataSource = row.Cells["TENVATTUPHUTUNG"];
                //    cboVatTuPhuTung.DisplayMember = "TENVATTUPHUTUNG";
                //    cboVatTuPhuTung.ValueMember = "MAVATTUPHUTUNG";
                //}
            }
            dgvPhieuSuaChua.Update();

            //PhieuSuaChuaDAO.fillDGVCBO("TENVATTUPHUTUNG", "VATTUPHUTUNG", VatTuPhuTung);
            //VatTuPhuTung.Items.Add("Testing item.");
        }

        private void dgvPhieuSuaChua_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            #region Creating auto-increment for STT column and default value for "Vật tư phụ tùng", "Đơn giá" and "Số lượng"
            if (!reset)
            {
                cellnum++;
                dgvPhieuSuaChua.Rows[rownum].Cells[0].Value = cellnum;
                //dgvPhieuSuaChua.Rows[rownum].Cells[2].Value = "Không";
                dgvPhieuSuaChua.Rows[rownum].Cells[3].Value = 0;
                dgvPhieuSuaChua.Rows[rownum].Cells[4].Value = 0;                
                rownum++;
            }

            #endregion

            fillVatTuPhuTung();

            for (int i = 0; i < dgvPhieuSuaChua.RowCount - 1; i++)
            {
                int soluong = int.Parse(dgvPhieuSuaChua.Rows[i].Cells[3].Value.ToString());
                int dongia = int.Parse(dgvPhieuSuaChua.Rows[i].Cells[4].Value.ToString());
                //if (dgvPhieuSuaChua.Rows[i].Cells[5].Value == null)
                //    dgvPhieuSuaChua.Rows[i].Cells[5].Value = 0;
                //int tiencong = int.Parse(dgvPhieuSuaChua.Rows[i].Cells[5].Value.ToString());
                //dgvPhieuSuaChua.Rows[i].Cells[6].Value = soluong * dongia + tiencong;
            }

        }

        //public void initiateGrid()
        //{
        //    MySqlConnection connection = DatabaseConnectionDAO.connectionDatabase();

        //    MySqlCommand command = new MySqlCommand("SelectAllCHITIETPHIEUSUACHUA", connection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    connection.Open();
        //    DataTable dt = new DataTable();
        //    MySqlDataReader dr = command.ExecuteReader();
        //    dt.Load(dr);
        //    dgvPhieuSuaChua.DataSource = dt;
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //}

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
            bool insert = true;
            for (int i = 0; i < dgvPhieuSuaChua.RowCount; i++)
            {
                if (dgvPhieuSuaChua.Rows[i].Cells[1].Value == null && dgvPhieuSuaChua.Rows[i].Cells[2].Value == null &&
                    dgvPhieuSuaChua.Rows[i].Cells[3].Value == null && dgvPhieuSuaChua.Rows[i].Cells[4].Value == null &&
                    dgvPhieuSuaChua.Rows[i].Cells[5].Value == null)
                {
                    insert = false;
                    break;
                }                    
                
            }

            if (insert)
            {
                insertPhieuSuaChua();
                dgvLichSuLapPhieu.DataSource = PhieuSuaChuaBUS.selectAllPhieuSuaChua();

                #region Clear dgvTable
                reset = true;
                cellnum = 0;
                rownum = 0;
                this.dgvPhieuSuaChua.Rows.Clear();
                dgvPhieuSuaChua.Rows[0].Cells[0].Value = 1;
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
            //if (!fMainForm.cNullTB(txtNoiDung.Text) && !fMainForm.cNullTB(cboVatTuPhuTung.Text) &&
            //    !fMainForm.cNullTB(txtSoLuong.Text) && !fMainForm.cNullTB(txtDonGia.Text) &&
            //    !fMainForm.cNullTB(cboTienCong.Text))

        }
    }
}
