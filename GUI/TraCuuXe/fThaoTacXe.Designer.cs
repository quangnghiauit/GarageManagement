namespace GUI
{
	partial class fThaoTacXe
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
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbBienSoXe = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Labekl = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbTienNo = new System.Windows.Forms.TextBox();
			this.btnThemHieuXe = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbbTenChuXe = new System.Windows.Forms.ComboBox();
			this.cbbHieuXe = new System.Windows.Forms.ComboBox();
			this.btnLichSuThaoTacXe = new System.Windows.Forms.Button();
			this.dtgvLichSuThaoTacXe = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXoaXe = new System.Windows.Forms.Button();
			this.btnCapNhatXe = new System.Windows.Forms.Button();
			this.btnThemXe = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuThaoTacXe)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "THAO TÁC";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label5.Location = new System.Drawing.Point(7, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 39;
			this.label5.Text = "Tên chủ xe";
			// 
			// tbBienSoXe
			// 
			this.tbBienSoXe.Location = new System.Drawing.Point(98, 13);
			this.tbBienSoXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbBienSoXe.Name = "tbBienSoXe";
			this.tbBienSoXe.Size = new System.Drawing.Size(231, 20);
			this.tbBienSoXe.TabIndex = 45;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.Location = new System.Drawing.Point(7, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 16);
			this.label6.TabIndex = 41;
			this.label6.Text = "Tiền nợ";
			// 
			// Labekl
			// 
			this.Labekl.AutoSize = true;
			this.Labekl.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.Labekl.Location = new System.Drawing.Point(8, 98);
			this.Labekl.Name = "Labekl";
			this.Labekl.Size = new System.Drawing.Size(51, 16);
			this.Labekl.TabIndex = 42;
			this.Labekl.Text = "Hiệu xe";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label7.Location = new System.Drawing.Point(26, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 16);
			this.label7.TabIndex = 43;
			this.label7.Text = "Biển số";
			// 
			// tbTienNo
			// 
			this.tbTienNo.Location = new System.Drawing.Point(93, 145);
			this.tbTienNo.Name = "tbTienNo";
			this.tbTienNo.Size = new System.Drawing.Size(239, 20);
			this.tbTienNo.TabIndex = 46;
			// 
			// btnThemHieuXe
			// 
			this.btnThemHieuXe.Location = new System.Drawing.Point(65, 98);
			this.btnThemHieuXe.Name = "btnThemHieuXe";
			this.btnThemHieuXe.Size = new System.Drawing.Size(22, 22);
			this.btnThemHieuXe.TabIndex = 47;
			this.btnThemHieuXe.Text = "+";
			this.btnThemHieuXe.UseVisualStyleBackColor = true;
			this.btnThemHieuXe.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbbTenChuXe);
			this.panel2.Controls.Add(this.cbbHieuXe);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.btnThemHieuXe);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.tbTienNo);
			this.panel2.Controls.Add(this.Labekl);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.tbBienSoXe);
			this.panel2.Location = new System.Drawing.Point(6, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(356, 196);
			this.panel2.TabIndex = 49;
			// 
			// cbbTenChuXe
			// 
			this.cbbTenChuXe.FormattingEnabled = true;
			this.cbbTenChuXe.Location = new System.Drawing.Point(94, 58);
			this.cbbTenChuXe.Name = "cbbTenChuXe";
			this.cbbTenChuXe.Size = new System.Drawing.Size(231, 21);
			this.cbbTenChuXe.TabIndex = 49;
			// 
			// cbbHieuXe
			// 
			this.cbbHieuXe.FormattingEnabled = true;
			this.cbbHieuXe.Location = new System.Drawing.Point(93, 98);
			this.cbbHieuXe.Name = "cbbHieuXe";
			this.cbbHieuXe.Size = new System.Drawing.Size(233, 21);
			this.cbbHieuXe.TabIndex = 48;
			// 
			// btnLichSuThaoTacXe
			// 
			this.btnLichSuThaoTacXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLichSuThaoTacXe.Location = new System.Drawing.Point(3, 290);
			this.btnLichSuThaoTacXe.Name = "btnLichSuThaoTacXe";
			this.btnLichSuThaoTacXe.Size = new System.Drawing.Size(170, 40);
			this.btnLichSuThaoTacXe.TabIndex = 51;
			this.btnLichSuThaoTacXe.Text = "Lịch Sử Thao Tác";
			this.btnLichSuThaoTacXe.UseVisualStyleBackColor = true;
			this.btnLichSuThaoTacXe.Click += new System.EventHandler(this.btnLichSuThaoTacXe_Click);
			// 
			// dtgvLichSuThaoTacXe
			// 
			this.dtgvLichSuThaoTacXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvLichSuThaoTacXe.Location = new System.Drawing.Point(3, 336);
			this.dtgvLichSuThaoTacXe.Name = "dtgvLichSuThaoTacXe";
			this.dtgvLichSuThaoTacXe.Size = new System.Drawing.Size(375, 202);
			this.dtgvLichSuThaoTacXe.TabIndex = 50;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnXoaXe);
			this.panel1.Controls.Add(this.btnCapNhatXe);
			this.panel1.Controls.Add(this.btnThemXe);
			this.panel1.Location = new System.Drawing.Point(17, 236);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(325, 48);
			this.panel1.TabIndex = 52;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnXoaXe
			// 
			this.btnXoaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaXe.Location = new System.Drawing.Point(240, 3);
			this.btnXoaXe.Name = "btnXoaXe";
			this.btnXoaXe.Size = new System.Drawing.Size(81, 42);
			this.btnXoaXe.TabIndex = 2;
			this.btnXoaXe.Text = "XÓA";
			this.btnXoaXe.UseVisualStyleBackColor = true;
			this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
			// 
			// btnCapNhatXe
			// 
			this.btnCapNhatXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhatXe.Location = new System.Drawing.Point(106, 3);
			this.btnCapNhatXe.Name = "btnCapNhatXe";
			this.btnCapNhatXe.Size = new System.Drawing.Size(117, 42);
			this.btnCapNhatXe.TabIndex = 1;
			this.btnCapNhatXe.Text = "CẬP NHẬT";
			this.btnCapNhatXe.UseVisualStyleBackColor = true;
			this.btnCapNhatXe.Click += new System.EventHandler(this.btnCapNhatXe_Click);
			// 
			// btnThemXe
			// 
			this.btnThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemXe.Location = new System.Drawing.Point(9, 3);
			this.btnThemXe.Name = "btnThemXe";
			this.btnThemXe.Size = new System.Drawing.Size(81, 42);
			this.btnThemXe.TabIndex = 0;
			this.btnThemXe.Text = "THÊM";
			this.btnThemXe.UseVisualStyleBackColor = true;
			this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
			// 
			// fThaoTacXe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLichSuThaoTacXe);
			this.Controls.Add(this.dtgvLichSuThaoTacXe);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fThaoTacXe";
			this.Text = "fThaoTacXe";
			this.Load += new System.EventHandler(this.fThaoTacXe_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuThaoTacXe)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbBienSoXe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Labekl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbTienNo;
		private System.Windows.Forms.Button btnThemHieuXe;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLichSuThaoTacXe;
		private System.Windows.Forms.DataGridView dtgvLichSuThaoTacXe;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnXoaXe;
		private System.Windows.Forms.Button btnCapNhatXe;
		private System.Windows.Forms.Button btnThemXe;
		private System.Windows.Forms.ComboBox cbbHieuXe;
		private System.Windows.Forms.ComboBox cbbTenChuXe;
	}
}