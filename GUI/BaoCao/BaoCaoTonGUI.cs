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
	public partial class fBaoCaoTon : Form
	{
		public fBaoCaoTon()
		{
			InitializeComponent();
		}

		private void BaoCaoTon_Load(object sender, EventArgs e)
		{
			dtmThangLapBaoCao.Format = DateTimePickerFormat.Custom;
			dtmThangLapBaoCao.CustomFormat = "MM / yyyy";
			dtmThangLapBaoCao.ShowUpDown = true;
		}

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            int month = dtmThangLapBaoCao.Value.Month;
            int year = dtmThangLapBaoCao.Value.Year;
        }
    }
}
