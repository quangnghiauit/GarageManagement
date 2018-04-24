namespace GUI
{
	partial class fThemHieuXe
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
			this.dtgvHieuXe = new System.Windows.Forms.DataGridView();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbMaHieuXe = new System.Windows.Forms.TextBox();
			this.tbTenHieuXe = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDongYThem = new System.Windows.Forms.Button();
			this.btnLichSu = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgvHieuXe)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgvHieuXe
			// 
			this.dtgvHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvHieuXe.Location = new System.Drawing.Point(25, 27);
			this.dtgvHieuXe.Name = "dtgvHieuXe";
			this.dtgvHieuXe.Size = new System.Drawing.Size(382, 215);
			this.dtgvHieuXe.TabIndex = 0;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(538, 196);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(94, 46);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(453, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã Hiệu Xe";
			// 
			// tbMaHieuXe
			// 
			this.tbMaHieuXe.Location = new System.Drawing.Point(446, 49);
			this.tbMaHieuXe.Name = "tbMaHieuXe";
			this.tbMaHieuXe.Size = new System.Drawing.Size(163, 20);
			this.tbMaHieuXe.TabIndex = 3;
			// 
			// tbTenHieuXe
			// 
			this.tbTenHieuXe.Location = new System.Drawing.Point(446, 108);
			this.tbTenHieuXe.Name = "tbTenHieuXe";
			this.tbTenHieuXe.Size = new System.Drawing.Size(163, 20);
			this.tbTenHieuXe.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(453, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên Hiệu Xe";
			// 
			// btnDongYThem
			// 
			this.btnDongYThem.Location = new System.Drawing.Point(422, 196);
			this.btnDongYThem.Name = "btnDongYThem";
			this.btnDongYThem.Size = new System.Drawing.Size(98, 46);
			this.btnDongYThem.TabIndex = 7;
			this.btnDongYThem.Text = "Thêm";
			this.btnDongYThem.UseVisualStyleBackColor = true;
			this.btnDongYThem.Click += new System.EventHandler(this.btnDongYThem_Click);
			// 
			// btnLichSu
			// 
			this.btnLichSu.Location = new System.Drawing.Point(151, 265);
			this.btnLichSu.Name = "btnLichSu";
			this.btnLichSu.Size = new System.Drawing.Size(83, 29);
			this.btnLichSu.TabIndex = 8;
			this.btnLichSu.Text = "Lịch Sử";
			this.btnLichSu.UseVisualStyleBackColor = true;
			this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
			// 
			// fThemHieuXe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 321);
			this.Controls.Add(this.btnLichSu);
			this.Controls.Add(this.btnDongYThem);
			this.Controls.Add(this.tbTenHieuXe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbMaHieuXe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.dtgvHieuXe);
			this.Name = "fThemHieuXe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Hiệu Xe";
			((System.ComponentModel.ISupportInitialize)(this.dtgvHieuXe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgvHieuXe;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMaHieuXe;
		private System.Windows.Forms.TextBox tbTenHieuXe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDongYThem;
		private System.Windows.Forms.Button btnLichSu;
	}
}