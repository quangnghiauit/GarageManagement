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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMaBaoCao = new System.Windows.Forms.TextBox();
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label1.Location = new System.Drawing.Point(60, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 40);
			this.label1.TabIndex = 13;
			this.label1.Text = "Tháng Lập Báo Cáo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label2.Location = new System.Drawing.Point(426, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 40);
			this.label2.TabIndex = 14;
			this.label2.Text = "Tổng Doanh Thu";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(350, 35);
			this.label3.TabIndex = 15;
			this.label3.Text = "LẬP BÁO CÁO DOANH SỐ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label4.Location = new System.Drawing.Point(60, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 40);
			this.label4.TabIndex = 16;
			this.label4.Text = "Mã số báo cáo";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMaBaoCao
			// 
			this.txtMaBaoCao.Location = new System.Drawing.Point(241, 48);
			this.txtMaBaoCao.Name = "txtMaBaoCao";
			this.txtMaBaoCao.Size = new System.Drawing.Size(123, 20);
			this.txtMaBaoCao.TabIndex = 17;
			// 
			// fDoanhSo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.txtMaBaoCao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBaoCao;
    }
}