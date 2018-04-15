namespace GUI
{
	partial class fMainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTT = new System.Windows.Forms.Button();
			this.btnBC = new System.Windows.Forms.Button();
			this.btnGD = new System.Windows.Forms.Button();
			this.btnTCX = new System.Windows.Forms.Button();
			this.btnQLKH = new System.Windows.Forms.Button();
			this.pnThaoTac = new System.Windows.Forms.Panel();
			this.pnMain = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnTT);
			this.panel1.Controls.Add(this.btnBC);
			this.panel1.Controls.Add(this.btnGD);
			this.panel1.Controls.Add(this.btnTCX);
			this.panel1.Controls.Add(this.btnQLKH);
			this.panel1.Location = new System.Drawing.Point(37, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(849, 93);
			this.panel1.TabIndex = 0;
			// 
			// btnTT
			// 
			this.btnTT.Location = new System.Drawing.Point(676, 3);
			this.btnTT.Name = "btnTT";
			this.btnTT.Size = new System.Drawing.Size(162, 83);
			this.btnTT.TabIndex = 4;
			this.btnTT.Text = "Thông Tin";
			this.btnTT.UseVisualStyleBackColor = true;
			this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
			// 
			// btnBC
			// 
			this.btnBC.Location = new System.Drawing.Point(508, 3);
			this.btnBC.Name = "btnBC";
			this.btnBC.Size = new System.Drawing.Size(162, 83);
			this.btnBC.TabIndex = 3;
			this.btnBC.Text = "Báo Cáo";
			this.btnBC.UseVisualStyleBackColor = true;
			this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
			// 
			// btnGD
			// 
			this.btnGD.Location = new System.Drawing.Point(340, 3);
			this.btnGD.Name = "btnGD";
			this.btnGD.Size = new System.Drawing.Size(162, 83);
			this.btnGD.TabIndex = 2;
			this.btnGD.Text = "Giao Dịch";
			this.btnGD.UseVisualStyleBackColor = true;
			this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
			// 
			// btnTCX
			// 
			this.btnTCX.Location = new System.Drawing.Point(172, 3);
			this.btnTCX.Name = "btnTCX";
			this.btnTCX.Size = new System.Drawing.Size(162, 83);
			this.btnTCX.TabIndex = 1;
			this.btnTCX.Text = "Tra Cứu Xe";
			this.btnTCX.UseVisualStyleBackColor = true;
			this.btnTCX.Click += new System.EventHandler(this.btnTCX_Click);
			// 
			// btnQLKH
			// 
			this.btnQLKH.Location = new System.Drawing.Point(4, 3);
			this.btnQLKH.Name = "btnQLKH";
			this.btnQLKH.Size = new System.Drawing.Size(162, 83);
			this.btnQLKH.TabIndex = 0;
			this.btnQLKH.Text = "Quản Lý Khách Hàng";
			this.btnQLKH.UseVisualStyleBackColor = true;
			this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
			// 
			// pnThaoTac
			// 
			this.pnThaoTac.Location = new System.Drawing.Point(894, 12);
			this.pnThaoTac.Name = "pnThaoTac";
			this.pnThaoTac.Size = new System.Drawing.Size(388, 642);
			this.pnThaoTac.TabIndex = 1;
			// 
			// pnMain
			// 
			this.pnMain.Location = new System.Drawing.Point(38, 134);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(850, 520);
			this.pnMain.TabIndex = 2;
			// 
			// fMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 661);
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnThaoTac);
			this.Controls.Add(this.panel1);
			this.Name = "fMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần Mềm Quản Lý Gara Oto";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTT;
		private System.Windows.Forms.Button btnBC;
		private System.Windows.Forms.Button btnGD;
		private System.Windows.Forms.Button btnTCX;
		private System.Windows.Forms.Button btnQLKH;
		private System.Windows.Forms.Panel pnThaoTac;
		private System.Windows.Forms.Panel pnMain;
	}
}

