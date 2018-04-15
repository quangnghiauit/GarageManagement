using System;
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
	public partial class fGiaoDich : Form 
	{
		public fGiaoDich()
		{
			InitializeComponent();
		}

		private void btnTiepNhanBaoTriXe_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fTiepNhanBaoTriXe myForm = new fTiepNhanBaoTriXe();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();

		}

		private void btnLapPhieuSuaChua_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fLapPhieuSuaChua myForm = new fLapPhieuSuaChua();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fLapPhieuThuTien myForm = new fLapPhieuThuTien();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}
	}
	
	
}
