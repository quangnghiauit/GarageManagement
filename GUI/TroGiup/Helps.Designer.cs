namespace GUI
{
	partial class fHelps
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quản lý khách hàng");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tra cứu xe");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý vật tư");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tiếp nhận bảo trì xe");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lập phiếu sữa chữa");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lập phiếu thu tiền");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Giao dịch", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Báo cáo tồn");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Doanh số");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Báo cáo", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Thay đổi Database");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Thay đổi quy định");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Thay đổi số loại tiền công");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Thông tin", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
			this.tvHelp = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbHelp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tvHelp
			// 
			this.tvHelp.Location = new System.Drawing.Point(44, 157);
			this.tvHelp.Name = "tvHelp";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Quản lý khách hàng";
			treeNode1.ToolTipText = "gkjhfjh";
			treeNode2.Name = "Node1";
			treeNode2.Text = "Tra cứu xe";
			treeNode3.Name = "Node2";
			treeNode3.Text = "Quản lý vật tư";
			treeNode4.Name = "Node8";
			treeNode4.Text = "Tiếp nhận bảo trì xe";
			treeNode5.Name = "Node9";
			treeNode5.Text = "Lập phiếu sữa chữa";
			treeNode6.Name = "Node10";
			treeNode6.Text = "Lập phiếu thu tiền";
			treeNode7.Name = "Node3";
			treeNode7.Text = "Giao dịch";
			treeNode8.Name = "Node11";
			treeNode8.Text = "Báo cáo tồn";
			treeNode9.Name = "Node12";
			treeNode9.Text = "Doanh số";
			treeNode10.Name = "Node4";
			treeNode10.Text = "Báo cáo";
			treeNode11.Name = "Node13";
			treeNode11.Text = "Thay đổi Database";
			treeNode12.Name = "Node14";
			treeNode12.Text = "Thay đổi quy định";
			treeNode13.Name = "Node15";
			treeNode13.Text = "Thay đổi số loại tiền công";
			treeNode14.Name = "Node5";
			treeNode14.Text = "Thông tin";
			this.tvHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode7,
            treeNode10,
            treeNode14});
			this.tvHelp.Size = new System.Drawing.Size(181, 298);
			this.tvHelp.TabIndex = 0;
			this.tvHelp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.tvHelp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvHelp_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(414, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hướng dẫn sử dụng phần mềm quản lý gara oto";
			// 
			// tbHelp
			// 
			this.tbHelp.Location = new System.Drawing.Point(276, 157);
			this.tbHelp.Multiline = true;
			this.tbHelp.Name = "tbHelp";
			this.tbHelp.Size = new System.Drawing.Size(461, 293);
			this.tbHelp.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(102, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chức năng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(425, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Hướng dẫn";
			// 
			// fHelps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbHelp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tvHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fHelps";
			this.Text = "Helps";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView tvHelp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbHelp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}