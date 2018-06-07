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
	public partial class fThongTin : Form
	{
		public fThongTin()
		{
			InitializeComponent();
		}
		#region Button
		private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fThayDoiQuyDinh myForm = new fThayDoiQuyDinh();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnThayDoiDatabase_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fThayDoiDatabase myForm = new fThayDoiDatabase();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fThayDoiTienCong myForm = new fThayDoiTienCong();
			myForm.ShowDialog();
			this.Show();

		}

		private void fThongTin_Load(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
