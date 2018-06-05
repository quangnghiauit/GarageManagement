namespace GUI
{
	partial class fLapPhieuSuaChua
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboBienSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmNgaySuaChua = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnNhapExcel = new System.Windows.Forms.Button();
            this.btnTaoPhieuMoi = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvLichSuLapPhieu = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTuPhuTung = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLichSuLapPhieu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuLapPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboBienSo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtmNgaySuaChua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 84);
            this.panel1.TabIndex = 1;
            // 
            // cboBienSo
            // 
            this.cboBienSo.FormattingEnabled = true;
            this.cboBienSo.Location = new System.Drawing.Point(144, 40);
            this.cboBienSo.Name = "cboBienSo";
            this.cboBienSo.Size = new System.Drawing.Size(208, 21);
            this.cboBienSo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Biển Số";
            // 
            // dtmNgaySuaChua
            // 
            this.dtmNgaySuaChua.Location = new System.Drawing.Point(144, 8);
            this.dtmNgaySuaChua.Name = "dtmNgaySuaChua";
            this.dtmNgaySuaChua.Size = new System.Drawing.Size(208, 20);
            this.dtmNgaySuaChua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Sữa Chữa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnNhapExcel);
            this.panel2.Controls.Add(this.btnTaoPhieuMoi);
            this.panel2.Controls.Add(this.btnLapPhieu);
            this.panel2.Location = new System.Drawing.Point(4, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 43);
            this.panel2.TabIndex = 4;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(705, 8);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(106, 27);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất File Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnNhapExcel
            // 
            this.btnNhapExcel.Location = new System.Drawing.Point(573, 7);
            this.btnNhapExcel.Name = "btnNhapExcel";
            this.btnNhapExcel.Size = new System.Drawing.Size(106, 27);
            this.btnNhapExcel.TabIndex = 2;
            this.btnNhapExcel.Text = "Nhập Từ File Excel";
            this.btnNhapExcel.UseVisualStyleBackColor = true;
            // 
            // btnTaoPhieuMoi
            // 
            this.btnTaoPhieuMoi.Location = new System.Drawing.Point(9, 6);
            this.btnTaoPhieuMoi.Name = "btnTaoPhieuMoi";
            this.btnTaoPhieuMoi.Size = new System.Drawing.Size(119, 28);
            this.btnTaoPhieuMoi.TabIndex = 1;
            this.btnTaoPhieuMoi.Text = "Tạo Phiếu Mới";
            this.btnTaoPhieuMoi.UseVisualStyleBackColor = true;
            this.btnTaoPhieuMoi.Click += new System.EventHandler(this.btnTaoPhieuMoi_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(316, 3);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(128, 36);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "LẬP PHIẾU";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dgvLichSuLapPhieu
            // 
            this.dgvLichSuLapPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuLapPhieu.Location = new System.Drawing.Point(8, 428);
            this.dgvLichSuLapPhieu.Name = "dgvLichSuLapPhieu";
            this.dgvLichSuLapPhieu.Size = new System.Drawing.Size(830, 109);
            this.dgvLichSuLapPhieu.TabIndex = 5;
            // 
            // dgvPhieuSuaChua
            // 
            this.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NoiDung,
            this.VatTuPhuTung,
            this.Soluong,
            this.DonGia,
            this.TienCong,
            this.ThanhTien});
            this.dgvPhieuSuaChua.Location = new System.Drawing.Point(13, 126);
            this.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua";
            this.dgvPhieuSuaChua.Size = new System.Drawing.Size(824, 230);
            this.dgvPhieuSuaChua.TabIndex = 6;
            this.dgvPhieuSuaChua.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPhieuSuaChua_RowsAdded);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.Name = "NoiDung";
            // 
            // VatTuPhuTung
            // 
            this.VatTuPhuTung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VatTuPhuTung.DataPropertyName = "MAVATTUPHUTUNG";
            this.VatTuPhuTung.HeaderText = "Vật tư phụ tùng";
            this.VatTuPhuTung.Name = "VatTuPhuTung";
            this.VatTuPhuTung.ReadOnly = true;
            this.VatTuPhuTung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VatTuPhuTung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Soluong
            // 
            this.Soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // TienCong
            // 
            this.TienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienCong.HeaderText = "Tiền công";
            this.TienCong.Name = "TienCong";
            this.TienCong.ReadOnly = true;
            this.TienCong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnLichSuLapPhieu
            // 
            this.btnLichSuLapPhieu.Location = new System.Drawing.Point(8, 396);
            this.btnLichSuLapPhieu.Name = "btnLichSuLapPhieu";
            this.btnLichSuLapPhieu.Size = new System.Drawing.Size(117, 32);
            this.btnLichSuLapPhieu.TabIndex = 7;
            this.btnLichSuLapPhieu.Text = "Lịch Sử Lập Phiếu";
            this.btnLichSuLapPhieu.UseVisualStyleBackColor = true;
            this.btnLichSuLapPhieu.Click += new System.EventHandler(this.btnLichSuLapPhieu_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "LẬP PHIẾU SỬA CHỮA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLapPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLichSuLapPhieu);
            this.Controls.Add(this.dgvPhieuSuaChua);
            this.Controls.Add(this.dgvLichSuLapPhieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLapPhieuSuaChua";
            this.Text = "LapPhieuSuaChua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuLapPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtmNgaySuaChua;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnXuatExcel;
		private System.Windows.Forms.Button btnNhapExcel;
		private System.Windows.Forms.Button btnTaoPhieuMoi;
		private System.Windows.Forms.Button btnLapPhieu;
		private System.Windows.Forms.DataGridView dgvLichSuLapPhieu;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dgvPhieuSuaChua;
		private System.Windows.Forms.Button btnLichSuLapPhieu;
        private System.Windows.Forms.ComboBox cboBienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewComboBoxColumn VatTuPhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn TienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label3;
    }
}