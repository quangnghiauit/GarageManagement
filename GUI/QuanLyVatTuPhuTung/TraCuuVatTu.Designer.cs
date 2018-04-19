namespace GUI
{
	partial class fmTraCuuVatTu
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
			this.label15 = new System.Windows.Forms.Label();
			this.dtgvVatTu = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXuatFile = new System.Windows.Forms.Button();
			this.btnTimTatCa = new System.Windows.Forms.Button();
			this.tbSoLuongTraCuu = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDonGiaTraCuu = new System.Windows.Forms.TextBox();
			this.tbTenVatTuTraCuu = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.cbbMaVatTuTraCuu = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgvVatTu)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(226, 228);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(385, 31);
			this.label15.TabIndex = 14;
			this.label15.Text = "QUẢN LÝ VẬT TƯ PHỤ TÙNG";
			// 
			// dtgvVatTu
			// 
			this.dtgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvVatTu.Location = new System.Drawing.Point(36, 284);
			this.dtgvVatTu.Name = "dtgvVatTu";
			this.dtgvVatTu.Size = new System.Drawing.Size(763, 253);
			this.dtgvVatTu.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbbMaVatTuTraCuu);
			this.panel1.Controls.Add(this.btnXuatFile);
			this.panel1.Controls.Add(this.btnTimTatCa);
			this.panel1.Controls.Add(this.tbSoLuongTraCuu);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbDonGiaTraCuu);
			this.panel1.Controls.Add(this.tbTenVatTuTraCuu);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Location = new System.Drawing.Point(31, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 191);
			this.panel1.TabIndex = 16;
			// 
			// btnXuatFile
			// 
			this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
			this.btnXuatFile.Location = new System.Drawing.Point(667, 147);
			this.btnXuatFile.Name = "btnXuatFile";
			this.btnXuatFile.Size = new System.Drawing.Size(109, 34);
			this.btnXuatFile.TabIndex = 26;
			this.btnXuatFile.Text = "Xuất file excel";
			this.btnXuatFile.UseVisualStyleBackColor = true;
			// 
			// btnTimTatCa
			// 
			this.btnTimTatCa.ForeColor = System.Drawing.Color.Black;
			this.btnTimTatCa.Location = new System.Drawing.Point(541, 147);
			this.btnTimTatCa.Name = "btnTimTatCa";
			this.btnTimTatCa.Size = new System.Drawing.Size(109, 34);
			this.btnTimTatCa.TabIndex = 25;
			this.btnTimTatCa.Text = "Tìm tất cả";
			this.btnTimTatCa.UseVisualStyleBackColor = true;
			this.btnTimTatCa.Click += new System.EventHandler(this.btnTimTatCa_Click);
			// 
			// tbSoLuongTraCuu
			// 
			this.tbSoLuongTraCuu.Location = new System.Drawing.Point(389, 109);
			this.tbSoLuongTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbSoLuongTraCuu.Name = "tbSoLuongTraCuu";
			this.tbSoLuongTraCuu.Size = new System.Drawing.Size(195, 20);
			this.tbSoLuongTraCuu.TabIndex = 24;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(268, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 16);
			this.label8.TabIndex = 23;
			this.label8.Text = "Số lượng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(268, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "Đơn giá";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(264, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tên vật tư";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(268, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Mã vật tư";
			// 
			// tbDonGiaTraCuu
			// 
			this.tbDonGiaTraCuu.Location = new System.Drawing.Point(389, 68);
			this.tbDonGiaTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDonGiaTraCuu.Name = "tbDonGiaTraCuu";
			this.tbDonGiaTraCuu.Size = new System.Drawing.Size(195, 20);
			this.tbDonGiaTraCuu.TabIndex = 17;
			// 
			// tbTenVatTuTraCuu
			// 
			this.tbTenVatTuTraCuu.Location = new System.Drawing.Point(389, 41);
			this.tbTenVatTuTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbTenVatTuTraCuu.Name = "tbTenVatTuTraCuu";
			this.tbTenVatTuTraCuu.Size = new System.Drawing.Size(195, 20);
			this.tbTenVatTuTraCuu.TabIndex = 18;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(389, 41);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(130, 20);
			this.textBox2.TabIndex = 19;
			// 
			// cbbMaVatTuTraCuu
			// 
			this.cbbMaVatTuTraCuu.FormattingEnabled = true;
			this.cbbMaVatTuTraCuu.Location = new System.Drawing.Point(389, 11);
			this.cbbMaVatTuTraCuu.Name = "cbbMaVatTuTraCuu";
			this.cbbMaVatTuTraCuu.Size = new System.Drawing.Size(194, 21);
			this.cbbMaVatTuTraCuu.TabIndex = 27;
			// 
			// fmTraCuuVatTu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dtgvVatTu);
			this.Controls.Add(this.label15);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fmTraCuuVatTu";
			this.Text = "TraCuuVatTu";
			this.Load += new System.EventHandler(this.fmTraCuuVatTu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvVatTu)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataGridView dtgvVatTu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnXuatFile;
		private System.Windows.Forms.Button btnTimTatCa;
		private System.Windows.Forms.TextBox tbSoLuongTraCuu;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDonGiaTraCuu;
		private System.Windows.Forms.TextBox tbTenVatTuTraCuu;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox cbbMaVatTuTraCuu;
	}
}