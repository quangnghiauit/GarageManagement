namespace GUI
{
	partial class fGiaoDich
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
			this.btnLapPhieuSuaChua = new System.Windows.Forms.Button();
			this.btnLapPhieuThuTien = new System.Windows.Forms.Button();
			this.btnTiepNhanBaoTriXe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLapPhieuSuaChua
			// 
			this.btnLapPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnLapPhieuSuaChua.Location = new System.Drawing.Point(334, 154);
			this.btnLapPhieuSuaChua.Name = "btnLapPhieuSuaChua";
			this.btnLapPhieuSuaChua.Size = new System.Drawing.Size(174, 152);
			this.btnLapPhieuSuaChua.TabIndex = 0;
			this.btnLapPhieuSuaChua.Text = "Lập Phiếu Sửa Chữa";
			this.btnLapPhieuSuaChua.UseVisualStyleBackColor = true;
			this.btnLapPhieuSuaChua.Click += new System.EventHandler(this.btnLapPhieuSuaChua_Click);
			// 
			// btnLapPhieuThuTien
			// 
			this.btnLapPhieuThuTien.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnLapPhieuThuTien.Location = new System.Drawing.Point(560, 154);
			this.btnLapPhieuThuTien.Name = "btnLapPhieuThuTien";
			this.btnLapPhieuThuTien.Size = new System.Drawing.Size(174, 152);
			this.btnLapPhieuThuTien.TabIndex = 1;
			this.btnLapPhieuThuTien.Text = "Lập Phiếu Thu Tiền";
			this.btnLapPhieuThuTien.UseVisualStyleBackColor = true;
			this.btnLapPhieuThuTien.Click += new System.EventHandler(this.btnLapPhieuThuTien_Click);
			// 
			// btnTiepNhanBaoTriXe
			// 
			this.btnTiepNhanBaoTriXe.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnTiepNhanBaoTriXe.Location = new System.Drawing.Point(97, 154);
			this.btnTiepNhanBaoTriXe.Name = "btnTiepNhanBaoTriXe";
			this.btnTiepNhanBaoTriXe.Size = new System.Drawing.Size(174, 152);
			this.btnTiepNhanBaoTriXe.TabIndex = 2;
			this.btnTiepNhanBaoTriXe.Text = "Tiếp Nhận Bảo Trì Xe";
			this.btnTiepNhanBaoTriXe.UseVisualStyleBackColor = true;
			this.btnTiepNhanBaoTriXe.Click += new System.EventHandler(this.btnTiepNhanBaoTriXe_Click);
			// 
			// fGiaoDich
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 515);
			this.Controls.Add(this.btnTiepNhanBaoTriXe);
			this.Controls.Add(this.btnLapPhieuThuTien);
			this.Controls.Add(this.btnLapPhieuSuaChua);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fGiaoDich";
			this.Text = "fGiaoDich";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLapPhieuSuaChua;
		private System.Windows.Forms.Button btnLapPhieuThuTien;
		private System.Windows.Forms.Button btnTiepNhanBaoTriXe;
	}
}