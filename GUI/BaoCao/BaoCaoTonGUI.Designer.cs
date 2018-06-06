namespace GUI
{
	partial class fBaoCaoTon
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
			this.dtmThangLapBaoCao = new System.Windows.Forms.DateTimePicker();
			this.dgvBaoCaoTon = new System.Windows.Forms.DataGridView();
			this.btnLapBaoCao = new System.Windows.Forms.Button();
			this.btnXuatFileExcel = new System.Windows.Forms.Button();
			this.txtMaBaoCao = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).BeginInit();
			this.SuspendLayout();
			// 
			// dtmThangLapBaoCao
			// 
			this.dtmThangLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtmThangLapBaoCao.Location = new System.Drawing.Point(233, 80);
			this.dtmThangLapBaoCao.Name = "dtmThangLapBaoCao";
			this.dtmThangLapBaoCao.Size = new System.Drawing.Size(125, 20);
			this.dtmThangLapBaoCao.TabIndex = 2;
			// 
			// dgvBaoCaoTon
			// 
			this.dgvBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCaoTon.Location = new System.Drawing.Point(5, 124);
			this.dgvBaoCaoTon.Name = "dgvBaoCaoTon";
			this.dgvBaoCaoTon.Size = new System.Drawing.Size(840, 320);
			this.dgvBaoCaoTon.TabIndex = 3;
			// 
			// btnLapBaoCao
			// 
			this.btnLapBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnLapBaoCao.Location = new System.Drawing.Point(216, 472);
			this.btnLapBaoCao.Name = "btnLapBaoCao";
			this.btnLapBaoCao.Size = new System.Drawing.Size(142, 43);
			this.btnLapBaoCao.TabIndex = 4;
			this.btnLapBaoCao.Text = "Lập Báo Cáo";
			this.btnLapBaoCao.UseVisualStyleBackColor = true;
			this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
			// 
			// btnXuatFileExcel
			// 
			this.btnXuatFileExcel.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnXuatFileExcel.Location = new System.Drawing.Point(407, 472);
			this.btnXuatFileExcel.Name = "btnXuatFileExcel";
			this.btnXuatFileExcel.Size = new System.Drawing.Size(142, 43);
			this.btnXuatFileExcel.TabIndex = 5;
			this.btnXuatFileExcel.Text = "Xuất File Excel";
			this.btnXuatFileExcel.UseVisualStyleBackColor = true;
			this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click);
			// 
			// txtMaBaoCao
			// 
			this.txtMaBaoCao.Location = new System.Drawing.Point(233, 48);
			this.txtMaBaoCao.Name = "txtMaBaoCao";
			this.txtMaBaoCao.Size = new System.Drawing.Size(125, 20);
			this.txtMaBaoCao.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(250, 31);
			this.label3.TabIndex = 20;
			this.label3.Text = "LẬP BÁO CÁO TỒN";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label10.Location = new System.Drawing.Point(73, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(133, 19);
			this.label10.TabIndex = 38;
			this.label10.Text = "Tháng Lập Báo Cáo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label2.Location = new System.Drawing.Point(73, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 19);
			this.label2.TabIndex = 39;
			this.label2.Text = "Mã số báo cáo";
			// 
			// fBaoCaoTon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMaBaoCao);
			this.Controls.Add(this.btnXuatFileExcel);
			this.Controls.Add(this.btnLapBaoCao);
			this.Controls.Add(this.dgvBaoCaoTon);
			this.Controls.Add(this.dtmThangLapBaoCao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fBaoCaoTon";
			this.Text = "BaoCaoTon";
			this.Load += new System.EventHandler(this.BaoCaoTon_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dtmThangLapBaoCao;
		private System.Windows.Forms.DataGridView dgvBaoCaoTon;
		private System.Windows.Forms.Button btnLapBaoCao;
		private System.Windows.Forms.Button btnXuatFileExcel;
        private System.Windows.Forms.TextBox txtMaBaoCao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
	}
}