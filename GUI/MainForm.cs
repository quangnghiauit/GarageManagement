﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	
	public partial class fMainForm : Form
	{
		public fMainForm()
		{
			InitializeComponent();

		}
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
		private void btnBC_Click(object sender, EventArgs e)
		{
			//Export report table
			pnMainGara.Controls.Clear();
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
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fQuanLyVatTuPhuTungGUI myForm = new fQuanLyVatTuPhuTungGUI();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMainGara.Controls.Add(myForm);
			myForm.Show();
			

			
			
		
		}
	}
}
