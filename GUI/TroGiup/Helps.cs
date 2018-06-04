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
	public partial class fHelps : Form
	{
		public fHelps()
		{
			InitializeComponent();
			LoadTreeView();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}
		void LoadTreeView()
		{
			
			tvHelp.NodeMouseClick += tvHelp_MouseDoubleClick;

			TreeNode root1 = new TreeNode();
			root1.Text = "Quản lý khách hàng";
			

			TreeNode node1 = new TreeNode() { Text = "Node 1 nè" };
			root1.Nodes.Add(node1);
			
			

			TreeNode root2 = new TreeNode();
			root2.Text = "Tra cứu xe";

			TreeNode root3 = new TreeNode();
			root2.Text = "Tra cứu xe";

			tvShow.Nodes.Add(root1);
			tvShow.Nodes.Add(root2);
		}

		private void tvHelp_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}
	}
}
