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
	public partial class fThaoTacXe : Form
	{
		public fThaoTacXe()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Add car brands
			fThemHieuXe myForm = new fThemHieuXe();
			
			myForm.ShowDialog();
			
			this.Show();
		}
	}
}
