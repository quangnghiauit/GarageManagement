using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI
{
	public partial class fThayDoiQuyDinh : Form
	{
		public fThayDoiQuyDinh()
		{
			InitializeComponent();
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
		private void fThayDoiQuyDinh_Load(object sender, EventArgs e)
		{
			//a variable to store exception
			string ex = "";

			ThamSoBUS.GetParameters(ex);

			//if there is exception
			if (ex != "")
			{
				MessageBox.Show(ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//Set the text in text boxes by thamso's information
			tbSoXeSua.Text = ThamSoDTO.SoXeSuaChuaToiDa.ToString();
			tbSoTienNo.Text = ThamSoDTO.SoTienNoToiDa.ToString();
			checkSuDungQuyDinh.Checked = ThamSoDTO.SuDungQuyDinh4;

		}
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			if (IsNumber(tbSoTienNo.Text) == false)
			{
				MessageBox.Show("Số tiền nợ là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			if (IsNumber(tbSoXeSua.Text) == false)
			{
				MessageBox.Show("Số xe sửa là số.Mời nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			//if there is nothing in any text boxes
			if (tbSoTienNo.Text==""||tbSoXeSua.Text=="")
			{
				MessageBox.Show("Xin hãy điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//store exception
			string ex = "";
			//we have to save the old ThamSo for sure
			//if we didn't save that and exception occur, we have to revert them
			decimal oldSoTienNoToiDa = ThamSoDTO.SoTienNoToiDa;
			decimal oldSoXeSuaChuaToiDa = ThamSoDTO.SoXeSuaChuaToiDa;
			bool oldSuDungQuyDinh4 = ThamSoDTO.SuDungQuyDinh4;

			//set thamso's information
			ThamSoDTO.SoTienNoToiDa = decimal.Parse(tbSoTienNo.Text);
			ThamSoDTO.SoXeSuaChuaToiDa = decimal.Parse(tbSoXeSua.Text);
			ThamSoDTO.SuDungQuyDinh4 = checkSuDungQuyDinh.Checked;

			//update ThamSo
			ThamSoBUS.UpdateParameters(ex);

			//if there is exception, show it
			if(ex!="")
			{
				MessageBox.Show(ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//Revert
				ThamSoDTO.SoTienNoToiDa = oldSoTienNoToiDa;
				ThamSoDTO.SoXeSuaChuaToiDa = oldSoXeSuaChuaToiDa;
				ThamSoDTO.SuDungQuyDinh4 = oldSuDungQuyDinh4;
				//Update ThamSo again
				ThamSoBUS.UpdateParameters(ex);
				return;
				
			}
			//show success message
			MessageBox.Show("Cập nhật thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);


		}


	}
}
