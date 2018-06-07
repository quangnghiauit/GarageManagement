using System;
using System.Windows.Forms;
using BUS;
using DTO;
using app = Microsoft.Office.Interop.Excel.Application;


namespace GUI
{
	public partial class fQuanLyKhachHangGUI : Form
	{
		public fQuanLyKhachHangGUI()
		{
			InitializeComponent();
		}



		#region Functions
		//button search customer
		private void btnTimKiem_Click(object sender, EventArgs e)
		{

			FindCustomer();
		}




		private void fQuanLyKhachHangGUI_Load(object sender, EventArgs e)
		{

			//Setup cbbTienNo

			cbbTienNo.Items.Add("Bằng");


			cbbTienNo.Items.Add("Lớn hơn");

			cbbTienNo.Items.Add("Lớn hơn hoặc bằng");

			cbbTienNo.Items.Add("Nhỏ hơn");

			cbbTienNo.Items.Add("Nhỏ hơn hoặc bằng");
			cbbTienNo.SelectedIndex = 2;


			//set value tbSoTienNoTraCuu
			tbSoTienNoTraCuu.Text = "0";
			tbSoTienNo.Text = "0";
			//Set up some text boxes to prevent user type in
			//tbMaKhachSuaXe.ReadOnly = true;
			//tbTenChuXe.ReadOnly = true;
			//tbDiaChi.ReadOnly = true;
			//tbDienThoai.ReadOnly = true;
			//tbEmail.ReadOnly = true;
			//tbSoTienNo.ReadOnly = true;


			// setup form

			//load CustomerID

			//MySqlConnection Conncustomer = DatabaseConnectionDAO.connectionDatabase();
			//MySqlCommand cmdcustomer = new MySqlCommand("select MAKHACHSUAXE from KHACHSUAXE", Conncustomer);


			//Conncustomer.Open();
			//MySqlDataAdapter dacustomer = new MySqlDataAdapter();
			//dacustomer.SelectCommand = cmdcustomer;
			//DataSet dscustomer = new DataSet();
			//dacustomer.Fill(dscustomer, "MaKhachSuaXe");
			//cbbMaKhachHangTraCuu.DataSource = dscustomer.Tables[0];
			//cbbMaKhachHangTraCuu.DisplayMember = "MaKhachSuaXe";
			//cbbMaKhachHangTraCuu.ValueMember = "MaKhachSuaXe";





		}
		//Conditional customer search function
		private void FindCustomer()
		{
			if (IsNumber(tbMaKhachHangTraCuu.Text) == false)
			{
				MessageBox.Show("Mã khách hàng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				return;
			}
			
			string CompareType = "";

			switch (cbbTienNo.SelectedIndex)
			{
				case 0:
					CompareType = "=";
					break;
				case 1:
					CompareType = ">";
					break;
				case 2:
					CompareType = ">=";
					break;
				case 3:
					CompareType = "<";
					break;
				case 4:
					CompareType = "<=";
					break;
			}
			Decimal SoTienNoCompareType = -99999999;
			if (tbSoTienNoTraCuu.Text == "")
			{
				CompareType = ">=";
			}
			else
			{
				SoTienNoCompareType = Decimal.Parse(tbSoTienNoTraCuu.Text);
			}
			if (!fMainForm.cNullTB(tbMaKhachHangTraCuu.Text) && !fMainForm.cNullTB(tbSoTienNoTraCuu.Text))
			{
				//if (KhachSuaXeBUS.cPrimaryKey(cbbMaKhachHangTraCuu.SelectedValue.ToString().Trim()))
				//{

				string strMaKhachSuaXe = tbMaKhachHangTraCuu.Text.Trim();
				int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
				string TenChuXe = tbTenKhachHangTraCuu.Text;
				string DienThoai = tbDienThoaiTraCuu.Text;
				string DiaChi = tbDiaChiTraCuu.Text;
				string Email = tbEmailTraCuu.Text;
				int TienNo = Convert.ToInt32(tbSoTienNoTraCuu.Text);


				KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);

				dtgvKhachHang.DataSource = KhachSuaXeBUS.SearchAllCustomer(kh, CompareType);
				//}
				//else
				//{
				//	MessageBox.Show("Dữ liệu vừa nhập vào không có.Mời nhập lại.");
				//}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
		}
		//Excel export function
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
		//button export file excel
		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			export2Excel(dtgvKhachHang, @"E:\", "ExportCustomers");
		}

		private void RefreshQLKH()
		{
			tbMaKhachSuaXe.Text = "";
			tbTenChuXe.Text = "";
			tbDienThoai.Text = "";
			tbDiaChi.Text = "";
			tbEmail.Text = "";
			tbSoTienNo.Text = "0";
		}

		private void btnLichSuThaoTac_Click_1(object sender, EventArgs e)
		{
			dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();
		}
		private void pnThaoTac_Paint(object sender, PaintEventArgs e)
		{

		}
		#endregion



		#region Buttons Insert, Update, Remove



		private bool IsNumber(string pValue)
		{
			foreach (Char c in pValue)
			{
				if (!Char.IsDigit(c))
					return false;
			}
			return true;
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			//Set background
			//btnThem.BackColor = Color.DimGray;
			//btnThem.ForeColor = Color.White;

			//btnXoa.BackColor = Color.LightGray;
			//btnXoa.ForeColor = Color.Black;


			//btnCapNhat.BackColor = Color.LightGray;
			//btnCapNhat.ForeColor = Color.Black;


			//Set up some text boxes to prevent user type in
			//tbMaKhachSuaXe.ReadOnly = false;
			//tbTenChuXe.ReadOnly = false;
			//tbDiaChi.ReadOnly = false;
			//tbDienThoai.ReadOnly = false;
			//tbEmail.ReadOnly = false;
			//tbSoTienNo.ReadOnly = false;


			//if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbDienThoai.Text) && !fMainForm.cNullTB(tbDiaChi.Text) && !fMainForm.cNullTB(tbEmail.Text) && !fMainForm.cNullTB(tbSoTienNo.Text))
			//{
			//	if (!KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
			//	{

			//		string strMaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
			//		int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
			//		string TenChuXe = tbTenChuXe.Text;
			//		string DienThoai = tbDienThoai.Text;
			//		string DiaChi = tbDiaChi.Text;
			//		string Email = tbEmail.Text;
			//		int TienNo = Convert.ToInt32(tbSoTienNo.Text);


			//		KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);
			//		KhachSuaXeBUS.addCustomer(kh);
			//		dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();

			//	}
			//	else
			//	{
			//		MessageBox.Show("Dữ liệu vừa nhập vào không hợp lệ, do bị trùng khóa chính.");
			//	}

			//}
			//else
			//{

			//	MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			//}
			if(IsNumber(tbMaKhachSuaXe.Text)==false)
			{
				MessageBox.Show("Mã khách hàng là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				RefreshQLKH();
				return;
			}
			if (IsNumber(tbDienThoai.Text) == false)
			{
				MessageBox.Show("Điện thoại là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (fMainForm.cNullTB(tbMaKhachSuaXe.Text) || fMainForm.cNullTB(tbTenChuXe.Text) || fMainForm.cNullTB(tbDienThoai.Text) || fMainForm.cNullTB(tbDiaChi.Text) || fMainForm.cNullTB(tbEmail.Text) || fMainForm.cNullTB(tbSoTienNo.Text))
			{
				MessageBox.Show("Xin hãy điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				RefreshQLKH();
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng này không? ", "Cảnh báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				if (!KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{
					string ex = "";
				string strMaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
				int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
				string TenChuXe = tbTenChuXe.Text;
				string DienThoai = tbDienThoai.Text;
				string DiaChi = tbDiaChi.Text;
				string Email = tbEmail.Text;
				int TienNo = Convert.ToInt32(tbSoTienNo.Text);
				KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);
				if ( KhachSuaXeBUS.InsertCustomer(kh,ex)==true)
				{
					MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();
					RefreshQLKH();
					return;
				}
				}
				else
				{
					MessageBox.Show("Dữ liệu vừa nhập vào không hợp lệ, do bị trùng khóa chính.");
				}
				//MessageBox.Show(ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			RefreshQLKH();
		}

		private void btnCapNhat_Click_1(object sender, EventArgs e)
		{
			//Set background
			//btnThem.BackColor = Color.LightGray;
			//btnThem.ForeColor = Color.Black;

			//btnXoa.BackColor = Color.LightGray;
			//btnXoa.ForeColor = Color.Black;


			//btnCapNhat.BackColor = Color.DimGray;
			//btnCapNhat.ForeColor = Color.White;

			if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text) && !fMainForm.cNullTB(tbTenChuXe.Text) && !fMainForm.cNullTB(tbDienThoai.Text) && !fMainForm.cNullTB(tbDiaChi.Text) && !fMainForm.cNullTB(tbEmail.Text) && !fMainForm.cNullTB(tbSoTienNo.Text))
			{
				if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{

					string strMaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
					string TenChuXe = tbTenChuXe.Text;
					string DienThoai = tbDienThoai.Text;
					string DiaChi = tbDiaChi.Text;
					string Email = tbEmail.Text;
					int TienNo = Convert.ToInt32(tbSoTienNo.Text);


					KhachSuaXeDTO kh = new KhachSuaXeDTO(MaKhachSuaXe, TenChuXe, DienThoai, DiaChi, Email, TienNo);
					KhachSuaXeBUS.updateCustomer(kh);
					dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();

				}
				else
				{
					MessageBox.Show("Mã khách hàng vừa nhập vào không tồn tại.Kiểm tra lại mã để cập nhật dữ liệu.");
				}

			}
			else
			{

				MessageBox.Show("Bạn chưa nhập vào đủ dữ liệu xin vui lòng nhập lại.");
			}
			RefreshQLKH();
		}

		private void btnXoa_Click_1(object sender, EventArgs e)
		{
			//Set background
			//btnThem.BackColor = Color.LightGray;
			//btnThem.ForeColor = Color.Black;

			//btnXoa.BackColor = Color.DimGray;
			//btnXoa.ForeColor = Color.White;


			//btnCapNhat.BackColor = Color.LightGray;
			//btnCapNhat.ForeColor = Color.Black;


			//if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text))
			//{
			//	if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
			//	{
			//		string strMaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
			//		int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);
			//		KhachSuaXeBUS.delCustomer(MaKhachSuaXe);
			//		dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();
			//	}
			//	else
			//	{

			//		MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
			//	}
			//}

			string ex = "";
			if (!fMainForm.cNullTB(tbMaKhachSuaXe.Text))
			{
				
				if (KhachSuaXeBUS.cPrimaryKey(tbMaKhachSuaXe.Text.Trim()))
				{
					string strMaKhachSuaXe = tbMaKhachSuaXe.Text.Trim();
					int MaKhachSuaXe = Convert.ToInt32(strMaKhachSuaXe);

					if(KhachSuaXeBUS.delCustomer(MaKhachSuaXe,ex)==true)
					{
						//show message
						MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
						dtgvThaoTac.DataSource = KhachSuaXeBUS.loadAllCustomer();
						RefreshQLKH();
						return;
					}
					else
					{
						//Or something bad happened
						MessageBox.Show("Bạn phải xóa tất cả các xe của khách hàng này. Sau đó mới được quyền xóa khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					

					//KhachSuaXeBUS.delCustomer(MaKhachSuaXe);

				}
				else
				{

					MessageBox.Show("Dữ liệu nhập vào chưa đúng vui lòng nhập vào ô Mã Khách Sửa Xe.");
				}
			}

			
		}
		#endregion
		
		
	}
}
