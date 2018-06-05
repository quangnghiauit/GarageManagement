namespace GUI
{
	partial class fThayDoiTienCong
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
			this.btnThem = new System.Windows.Forms.Button();
			this.tbTenTienCong = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMaTienCong = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.dtgvTienCong = new System.Windows.Forms.DataGridView();
			this.btnView = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSoTienCong = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTienCong)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(422, 243);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(98, 56);
			this.btnThem.TabIndex = 15;
			this.btnThem.Text = " Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// tbTenTienCong
			// 
			this.tbTenTienCong.Location = new System.Drawing.Point(455, 112);
			this.tbTenTienCong.Name = "tbTenTienCong";
			this.tbTenTienCong.Size = new System.Drawing.Size(163, 20);
			this.tbTenTienCong.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(458, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tên Tiền Công";
			// 
			// tbMaTienCong
			// 
			this.tbMaTienCong.Location = new System.Drawing.Point(455, 53);
			this.tbMaTienCong.Name = "tbMaTienCong";
			this.tbMaTienCong.Size = new System.Drawing.Size(163, 20);
			this.tbMaTienCong.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(462, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã Tiền Công";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(526, 243);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(106, 56);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// dtgvTienCong
			// 
			this.dtgvTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvTienCong.Location = new System.Drawing.Point(34, 31);
			this.dtgvTienCong.Name = "dtgvTienCong";
			this.dtgvTienCong.Size = new System.Drawing.Size(382, 215);
			this.dtgvTienCong.TabIndex = 8;
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(151, 269);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(87, 30);
			this.btnView.TabIndex = 16;
			this.btnView.Text = "Xem Lịch Sử";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(458, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Số tiền";
			// 
			// tbSoTienCong
			// 
			this.tbSoTienCong.Location = new System.Drawing.Point(455, 177);
			this.tbSoTienCong.Name = "tbSoTienCong";
			this.tbSoTienCong.Size = new System.Drawing.Size(163, 20);
			this.tbSoTienCong.TabIndex = 18;
			// 
			// fThayDoiTienCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 321);
			this.Controls.Add(this.tbSoTienCong);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.tbTenTienCong);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbMaTienCong);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.dtgvTienCong);
			this.Name = "fThayDoiTienCong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thay Đổi Số Loại Tiền Công";
			((System.ComponentModel.ISupportInitialize)(this.dtgvTienCong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox tbTenTienCong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbMaTienCong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.DataGridView dtgvTienCong;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbSoTienCong;
	}
}