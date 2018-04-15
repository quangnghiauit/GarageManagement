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
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fBaoCao myForm = new fBaoCao();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMain.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnGD_Click(object sender, EventArgs e)
		{
			//Export transaction table
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fGiaoDich myForm = new fGiaoDich();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMain.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnTT_Click(object sender, EventArgs e)
		{
			//Export table information
			pnMain.Controls.Clear();
			pnThaoTac.Controls.Clear();
			fThongTin myForm = new fThongTin();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMain.Controls.Add(myForm);
			myForm.Show();
		}

		private void btnQLKH_Click(object sender, EventArgs e)
		{
			#region Export customer information
			pnMain.Controls.Clear();
			fQuanLyKhachHang myForm = new fQuanLyKhachHang();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMain.Controls.Add(myForm);
			myForm.Show();
			#endregion

			#region Export customer operations
			pnThaoTac.Controls.Clear();
			fThaoTacKhachHang myForm1 = new fThaoTacKhachHang();
			myForm1.TopLevel = false;
			myForm1.AutoScroll = true;
			pnThaoTac.Controls.Add(myForm1);
			myForm1.Show();
			#endregion
		}

		private void btnTCX_Click(object sender, EventArgs e)
		{
			#region Export car information
			pnMain.Controls.Clear();
			fTraCuuXe myForm = new fTraCuuXe();
			myForm.TopLevel = false;
			myForm.AutoScroll = true;
			pnMain.Controls.Add(myForm);
			myForm.Show();
			#endregion

			#region Export car operations
			pnThaoTac.Controls.Clear();
			fThaoTacXe myForm1 = new fThaoTacXe();
			myForm1.TopLevel = false;
			myForm1.AutoScroll = true;
			pnThaoTac.Controls.Add(myForm1);
			myForm1.Show();
			#endregion
		}
	}
}
