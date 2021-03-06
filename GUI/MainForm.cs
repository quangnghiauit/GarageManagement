﻿using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
	
	public partial class fMainForm : Form
	{
		public fMainForm()
		{
			InitializeComponent();

		}
		#region Button processing
		private void btnBC_Click(object sender, EventArgs e)
		{
			//Export report table
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fBaoCao myForm = new fBaoCao();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnGD_Click(object sender, EventArgs e)
		{
			//Export transaction table
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fGiaoDich myForm = new fGiaoDich();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnTT_Click(object sender, EventArgs e)
		{
			//Export table information
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fThongTin myForm = new fThongTin();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnQLKH_Click(object sender, EventArgs e)
		{

			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fQuanLyKhachHangGUI myForm = new fQuanLyKhachHangGUI();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();

		}

		private void btnTCX_Click(object sender, EventArgs e)
		{
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;

			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fQuanLyXeGUI myForm = new fQuanLyXeGUI();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();





		}

		private void btnQuanLyVatTu_Click(object sender, EventArgs e)
		{
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fQuanLyVatTuPhuTungGUI myForm = new fQuanLyVatTuPhuTungGUI();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();

		}

		private void btnTroGiup_Click(object sender, EventArgs e)
		{
			pnMainGara.Controls.Clear();
			pnMainGara.BackgroundImage = null;
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fHelps myForm = new fHelps();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();
		}
		#endregion
		#region Check and FormEvent
		// TextBox trong thi tra ve gt true.
		public static bool cNullTB(string _textBox)
		{
			bool check = false;
			if (_textBox == "")
			{

				check = true;
			}
			return check;
		}


		private void fMainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			DatabaseConnectionBUS.DisConnectToDatabase();
		}

		private void fMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Một số công việc có thể chưa hoàn thành,bạn có chắc chắn muốn thoát không?", "Cẩn Thận!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				e.Cancel = true;
			}





		}

		private void fMainForm_Load(object sender, EventArgs e)
		{
			pnMain.Visible = false;
			pnThaoTac.Visible = false;
		}

		private void pnMainGara_BackgroundImageChanged(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
