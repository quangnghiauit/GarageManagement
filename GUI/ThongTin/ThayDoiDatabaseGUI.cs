using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using DAO;
using MySql.Data.MySqlClient;
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
			DatabaseConnectionBUS.ConnectToDatabase(tbServer.Text, tbDatabaseName.Text, tbUser.Text, tbPassword.Text, ex);
			
			if(ex!="")
			{
				MessageBox.Show(ex,"Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);

			}
			else
			{
				MessageBox.Show("Kết nối thành công!","THÀNH CÔNG",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		

			

			
		}

		private void fThayDoiDatabase_Load(object sender, EventArgs e)
		{
			tbServer.Text = "localhost";
			tbUser.Text = "root";
			tbPassword.PasswordChar = char.Parse("*");
			tbPassword.Text = "123456";
			tbDatabaseName.Text = "gara";
		}
	}
}
