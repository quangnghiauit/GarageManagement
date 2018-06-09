﻿using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
	public partial class fThayDoiDatabase : Form
	{
		public fThayDoiDatabase()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			string ex = "";
			DatabaseConnectionBUS.ConnectToDatabase(tbServer.Text, tbDatabaseName.Text, tbUser.Text, tbPassword.Text, ref ex);

			if (ex != "")
			{
				MessageBox.Show(ex, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
			{
				MessageBox.Show("Kết nối thành công!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnLuuKetNoi.Enabled = true;
			}





		}

		private void fThayDoiDatabase_Load(object sender, EventArgs e)
		{
			tbServer.Text = "localhost";
			tbUser.Text = "root";
			tbPassword.PasswordChar = char.Parse("*");
			tbPassword.Text = "123456";
			tbDatabaseName.Text = "gara";
			btnLuuKetNoi.Enabled = false;
		}

		private void btnLuuKetNoi_Click(object sender, EventArgs e)
		{
			DatabaseConnectionBUS.SaveChangeConection();
			MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}
	}
}
