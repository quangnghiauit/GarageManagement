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
	public partial class fBaoCao : Form
	{
		public fBaoCao()
		{
			InitializeComponent();
		}

		private void btnDoanhSo_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fDoanhSo myForm = new fDoanhSo();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnBaoCaoTon_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			fBaoCaoTon myForm = new fBaoCaoTon();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			this.Parent.Controls.Add(myForm);
			myForm.Show();
		}
	}
}
