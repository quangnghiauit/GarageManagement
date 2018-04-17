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
	public partial class fTraCuuXe : Form
	{
		public fTraCuuXe()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void fTraCuuXe_Load(object sender, EventArgs e)
		{
			//Setup cbbTienNo

			cbbTienNoTraCuu.Items.Add("Bằng");


			cbbTienNoTraCuu.Items.Add("Lớn hơn");

			cbbTienNoTraCuu.Items.Add("Lớn hơn hoặc bằng");

			cbbTienNoTraCuu.Items.Add("Nhỏ hơn");

			cbbTienNoTraCuu.Items.Add("Nhỏ hơn hoặc bằng");
			cbbTienNoTraCuu.SelectedIndex = 0;
		}
	}
}
