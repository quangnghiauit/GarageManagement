namespace GUI
{
	partial class fDoanhSo
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
			this.btnXuatFileExcel = new System.Windows.Forms.Button();
			this.btnLapBaoCao = new System.Windows.Forms.Button();
			this.dtmThangLapBaoCao = new System.Windows.Forms.DateTimePicker();
			this.dgvBaoCaoDoanhSo = new System.Windows.Forms.DataGridView();
			this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
			this.txtMaBaoCao = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhSo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnXuatFileExcel
			// 
			this.btnXuatFileExcel.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnXuatFileExcel.Location = new System.Drawing.Point(462, 465);
			this.btnXuatFileExcel.Name = "btnXuatFileExcel";
			this.btnXuatFileExcel.Size = new System.Drawing.Size(142, 43);
			this.btnXuatFileExcel.TabIndex = 7;
			this.btnXuatFileExcel.Text = "Xuất File Excel";
			this.btnXuatFileExcel.UseVisualStyleBackColor = true;
			this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click);
			// 
			// btnLapBaoCao
			// 
			this.btnLapBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnLapBaoCao.Location = new System.Drawing.Point(271, 465);
			this.btnLapBaoCao.Name = "btnLapBaoCao";
			this.btnLapBaoCao.Size = new System.Drawing.Size(142, 43);
			this.btnLapBaoCao.TabIndex = 6;
			this.btnLapBaoCao.Text = "Lập Báo Cáo";
			this.btnLapBaoCao.UseVisualStyleBackColor = true;
			this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
			// 
			// dtmThangLapBaoCao
			// 
			this.dtmThangLapBaoCao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtmThangLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtmThangLapBaoCao.Location = new System.Drawing.Point(241, 92);
			this.dtmThangLapBaoCao.Name = "dtmThangLapBaoCao";
			this.dtmThangLapBaoCao.Size = new System.Drawing.Size(123, 20);
			this.dtmThangLapBaoCao.TabIndex = 9;
			// 
			// dgvBaoCaoDoanhSo
			// 
			this.dgvBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCaoDoanhSo.Location = new System.Drawing.Point(5, 124);
			this.dgvBaoCaoDoanhSo.Name = "dgvBaoCaoDoanhSo";
			this.dgvBaoCaoDoanhSo.Size = new System.Drawing.Size(840, 320);
			this.dgvBaoCaoDoanhSo.TabIndex = 10;
			// 
			// txtTongDoanhThu
			// 
			this.txtTongDoanhThu.Location = new System.Drawing.Point(592, 92);
			this.txtTongDoanhThu.Name = "txtTongDoanhThu";
			this.txtTongDoanhThu.ReadOnly = true;
			this.txtTongDoanhThu.Size = new System.Drawing.Size(182, 20);
			this.txtTongDoanhThu.TabIndex = 12;
			// 
			// txtMaBaoCao
			// 
			this.txtMaBaoCao.Location = new System.Drawing.Point(241, 48);
			this.txtMaBaoCao.Name = "txtMaBaoCao";
			this.txtMaBaoCao.Size = new System.Drawing.Size(123, 20);
			this.txtMaBaoCao.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(332, 31);
			this.label5.TabIndex = 21;
			this.label5.Text = "LẬP BÁO CÁO DOANH SỐ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label10.Location = new System.Drawing.Point(438, 91);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 19);
			this.label10.TabIndex = 37;
			this.label10.Text = "Tổng Doanh Thu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label3.Location = new System.Drawing.Point(78, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 19);
			this.label3.TabIndex = 38;
			this.label3.Text = "Tháng Lập Báo Cáo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label6.Location = new System.Drawing.Point(78, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 19);
			this.label6.TabIndex = 39;
			this.label6.Text = "Mã số báo cáo";
			// 
			// fDoanhSo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtMaBaoCao);
			this.Controls.Add(this.txtTongDoanhThu);
			this.Controls.Add(this.dgvBaoCaoDoanhSo);
			this.Controls.Add(this.dtmThangLapBaoCao);
			this.Controls.Add(this.btnXuatFileExcel);
			this.Controls.Add(this.btnLapBaoCao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fDoanhSo";
			this.Text = "DoanhSo";
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhSo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnXuatFileExcel;
		private System.Windows.Forms.Button btnLapBaoCao;
		private System.Windows.Forms.DateTimePicker dtmThangLapBaoCao;
		private System.Windows.Forms.DataGridView dgvBaoCaoDoanhSo;
		private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtMaBaoCao;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
	}
}