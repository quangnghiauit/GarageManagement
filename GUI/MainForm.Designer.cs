﻿namespace GUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnMainGara = new System.Windows.Forms.Panel();
			this.pnThaoTac = new System.Windows.Forms.Panel();
			this.pnMain = new System.Windows.Forms.Panel();
			this.btnGD = new System.Windows.Forms.Button();
			this.btnQuanLyVatTu = new System.Windows.Forms.Button();
			this.btnTroGiup = new System.Windows.Forms.Button();
			this.btnTT = new System.Windows.Forms.Button();
			this.btnBC = new System.Windows.Forms.Button();
			this.btnTCX = new System.Windows.Forms.Button();
			this.btnQLKH = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.pnMainGara.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnGD);
			this.panel1.Controls.Add(this.btnQuanLyVatTu);
			this.panel1.Controls.Add(this.btnTroGiup);
			this.panel1.Controls.Add(this.btnTT);
			this.panel1.Controls.Add(this.btnBC);
			this.panel1.Controls.Add(this.btnTCX);
			this.panel1.Controls.Add(this.btnQLKH);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1250, 93);
			this.panel1.TabIndex = 0;
			// 
			// pnMainGara
			// 
			this.pnMainGara.BackgroundImage = global::GUI.Properties.Resources.VerticalLogo;
			this.pnMainGara.Controls.Add(this.pnThaoTac);
			this.pnMainGara.Controls.Add(this.pnMain);
			this.pnMainGara.Location = new System.Drawing.Point(12, 104);
			this.pnMainGara.Name = "pnMainGara";
			this.pnMainGara.Size = new System.Drawing.Size(1260, 550);
			this.pnMainGara.TabIndex = 1;
			this.pnMainGara.BackgroundImageChanged += new System.EventHandler(this.pnMainGara_BackgroundImageChanged);
			// 
			// pnThaoTac
			// 
			this.pnThaoTac.Location = new System.Drawing.Point(870, 7);
			this.pnThaoTac.Name = "pnThaoTac";
			this.pnThaoTac.Size = new System.Drawing.Size(380, 540);
			this.pnThaoTac.TabIndex = 1;
			// 
			// pnMain
			// 
			this.pnMain.Location = new System.Drawing.Point(3, 7);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(850, 540);
			this.pnMain.TabIndex = 0;
			// 
			// btnGD
			// 
			this.btnGD.BackgroundImage = global::GUI.Properties.Resources.IconGiaoDich;
			this.btnGD.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnGD.Location = new System.Drawing.Point(552, 3);
			this.btnGD.Name = "btnGD";
			this.btnGD.Size = new System.Drawing.Size(162, 83);
			this.btnGD.TabIndex = 2;
			this.btnGD.UseVisualStyleBackColor = true;
			this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
			// 
			// btnQuanLyVatTu
			// 
			this.btnQuanLyVatTu.BackgroundImage = global::GUI.Properties.Resources.IconQuanLyVatTu;
			this.btnQuanLyVatTu.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnQuanLyVatTu.Location = new System.Drawing.Point(380, 3);
			this.btnQuanLyVatTu.Name = "btnQuanLyVatTu";
			this.btnQuanLyVatTu.Size = new System.Drawing.Size(162, 83);
			this.btnQuanLyVatTu.TabIndex = 6;
			this.btnQuanLyVatTu.UseVisualStyleBackColor = true;
			this.btnQuanLyVatTu.Click += new System.EventHandler(this.btnQuanLyVatTu_Click);
			// 
			// btnTroGiup
			// 
			this.btnTroGiup.BackgroundImage = global::GUI.Properties.Resources.IconTroGiup;
			this.btnTroGiup.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnTroGiup.Location = new System.Drawing.Point(1073, 3);
			this.btnTroGiup.Name = "btnTroGiup";
			this.btnTroGiup.Size = new System.Drawing.Size(162, 83);
			this.btnTroGiup.TabIndex = 5;
			this.btnTroGiup.UseVisualStyleBackColor = true;
			this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
			// 
			// btnTT
			// 
			this.btnTT.BackgroundImage = global::GUI.Properties.Resources.IconThongTin;
			this.btnTT.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnTT.Location = new System.Drawing.Point(900, 3);
			this.btnTT.Name = "btnTT";
			this.btnTT.Size = new System.Drawing.Size(162, 83);
			this.btnTT.TabIndex = 4;
			this.btnTT.UseVisualStyleBackColor = true;
			this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
			// 
			// btnBC
			// 
			this.btnBC.BackgroundImage = global::GUI.Properties.Resources.IconBaoCao;
			this.btnBC.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnBC.Location = new System.Drawing.Point(725, 3);
			this.btnBC.Name = "btnBC";
			this.btnBC.Size = new System.Drawing.Size(162, 83);
			this.btnBC.TabIndex = 3;
			this.btnBC.UseVisualStyleBackColor = true;
			this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
			// 
			// btnTCX
			// 
			this.btnTCX.BackgroundImage = global::GUI.Properties.Resources.IconTraCuuXe;
			this.btnTCX.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnTCX.Location = new System.Drawing.Point(207, 3);
			this.btnTCX.Name = "btnTCX";
			this.btnTCX.Size = new System.Drawing.Size(162, 83);
			this.btnTCX.TabIndex = 1;
			this.btnTCX.UseVisualStyleBackColor = true;
			this.btnTCX.Click += new System.EventHandler(this.btnTCX_Click);
			// 
			// btnQLKH
			// 
			this.btnQLKH.BackgroundImage = global::GUI.Properties.Resources.IconQuanLyKhachHang;
			this.btnQLKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQLKH.Location = new System.Drawing.Point(34, 3);
			this.btnQLKH.Name = "btnQLKH";
			this.btnQLKH.Size = new System.Drawing.Size(162, 83);
			this.btnQLKH.TabIndex = 0;
			this.btnQLKH.UseVisualStyleBackColor = true;
			this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
			// 
			// fMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 661);
			this.Controls.Add(this.pnMainGara);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần Mềm Quản Lý Gara Oto";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMainForm_FormClosed);
			this.Load += new System.EventHandler(this.fMainForm_Load);
			this.panel1.ResumeLayout(false);
			this.pnMainGara.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTT;
		private System.Windows.Forms.Button btnBC;
		private System.Windows.Forms.Button btnGD;
		private System.Windows.Forms.Button btnTCX;
		private System.Windows.Forms.Button btnQLKH;
		private System.Windows.Forms.Button btnQuanLyVatTu;
		private System.Windows.Forms.Button btnTroGiup;
		private System.Windows.Forms.Panel pnMainGara;
		private System.Windows.Forms.Panel pnThaoTac;
		private System.Windows.Forms.Panel pnMain;
	}
}

