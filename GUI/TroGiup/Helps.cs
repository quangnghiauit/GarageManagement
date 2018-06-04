using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace GUI
{
	public partial class fHelps : Form
	{
		public fHelps()
		{
			InitializeComponent();
			LoadTreeView();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string selectedNodeText = e.Node.Text;
			if(selectedNodeText== "Quản lý khách hàng")
			{
				tbHelp.Text = "Hướng dẫn quản lý khách hàng.";
			}
			if (selectedNodeText == "Tra cứu xe")
			{
				tbHelp.Text = "Hướng dẫn tra cứu xe.";
			}
			if (selectedNodeText == "Quản lý vật tư")
			{
				tbHelp.Text = "Hướng dẫn quản lý vật tư.";
			}
			if (selectedNodeText == "Tiếp nhận bảo trì xe")
			{
				tbHelp.Text = "Hướng dẫn tiếp nhận bảo trì xe.";
			}
			if (selectedNodeText == "Lập phiếu sửa chữa")
			{
				tbHelp.Text = "Hướng dẫn lập phiếu sữa chữa.";
			}
			if (selectedNodeText == "Lập phiếu thu tiền")
			{
				tbHelp.Text = "Hướng dẫn lập phiếu thu tiền.";
			}
			if (selectedNodeText == "Báo cáo tồn")
			{
				tbHelp.Text = "Hướng dẫn báo cáo tồn.";
			}
			if (selectedNodeText == "Doanh số")
			{
				tbHelp.Text = "Hướng dẫn doanh số.";
			}
			if (selectedNodeText == "Thay đổi Database")
			{
				tbHelp.Text = "Hướng dẫn thay đổi database.";
			}
			if (selectedNodeText == "Thay đổi quy định")
			{
				tbHelp.Text = "Hướng dẫn thay đổi quy định.";
			}

			if (selectedNodeText == "Thay đổi số loại tiền công")
			{
				tbHelp.Text = "Hướng dẫn thay đổi số loại tiền công.";
			}


		}

		void LoadTreeView()
		{
			
			tvHelp.NodeMouseClick += tvHelp_MouseDoubleClick;

			TreeNode root1 = new TreeNode();
			root1.Text = "Quản lý khách hàng";
			tvHelp.Nodes.Add(root1);
			

			TreeNode root2 = new TreeNode();
			root2.Text = "Tra cứu xe";
			tvHelp.Nodes.Add(root2);

			TreeNode root3 = new TreeNode();
			root3.Text = "Quản lý vật tư";
			tvHelp.Nodes.Add(root3);

			TreeNode root4 = new TreeNode();
			root4.Text = "Giao dịch";
			tvHelp.Nodes.Add(root4);

			TreeNode node41 = new TreeNode() { Text = "Tiếp nhận bảo trì xe" };
			root4.Nodes.Add(node41);
			TreeNode node42 = new TreeNode() { Text = "Lập phiếu sửa chữa" };
			root4.Nodes.Add(node42);
			TreeNode node43 = new TreeNode() { Text = "Lập phiếu thu tiền" };
			root4.Nodes.Add(node43);

			TreeNode root5 = new TreeNode();
			root5.Text = "Báo cáo";
			tvHelp.Nodes.Add(root5);

			TreeNode node51 = new TreeNode() { Text = "Báo cáo tồn" };
			root5.Nodes.Add(node51);
			TreeNode node52 = new TreeNode() { Text = "Doanh số" };
			root5.Nodes.Add(node52);

			TreeNode root6 = new TreeNode();
			root6.Text = "Thông tin";
			tvHelp.Nodes.Add(root6);

			TreeNode node61 = new TreeNode() { Text = "Thay đổi Database" };
			root6.Nodes.Add(node61);
			TreeNode node62 = new TreeNode() { Text = "Thay đổi quy định" };
			root6.Nodes.Add(node62);
			TreeNode node63 = new TreeNode() { Text = "Thay đổi số loại tiền công" };
			root6.Nodes.Add(node63);

			
			
			
			
			
			
		}

		private void tvHelp_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}
	}
}
