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
	public partial class fDoanhSo : Form
	{
		public fDoanhSo()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "MM   yyyy";
			dateTimePicker1.ShowUpDown = true;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			
			

		}
	}
}
