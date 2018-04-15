using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using DAO;
using MySql.Data.MySqlClient;
namespace DAO
{


	static class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Getting Connection ...");
			MySqlConnection conn = DatabaseConnectionDAO.HamKetNoi();

			try
			{
				Console.WriteLine("Openning Connection ...");

				conn.Open();

				Console.WriteLine("Connection successful!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}

			Console.Read();
		}
	}

}


