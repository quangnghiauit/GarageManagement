namespace GUI
{
	partial class fLapPhieuThuTien
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
            this.dtmNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cboBienSo = new System.Windows.Forms.ComboBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.txtTienTraKhach = new System.Windows.Forms.TextBox();
            this.txtTienKhachTra = new System.Windows.Forms.TextBox();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.dgvLichSuPTT = new System.Windows.Forms.DataGridView();
            this.btnLichSuThuTien = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTenChuXe = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmNgayThuTien
            // 
            this.dtmNgayThuTien.Location = new System.Drawing.Point(160, 13);
            this.dtmNgayThuTien.Name = "dtmNgayThuTien";
            this.dtmNgayThuTien.Size = new System.Drawing.Size(200, 20);
            this.dtmNgayThuTien.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTenChuXe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.cboBienSo);
            this.panel1.Controls.Add(this.btnLapPhieu);
            this.panel1.Controls.Add(this.txtTienThu);
            this.panel1.Controls.Add(this.txtTienTraKhach);
            this.panel1.Controls.Add(this.txtTienKhachTra);
            this.panel1.Controls.Add(this.txtSoTienNo);
            this.panel1.Controls.Add(this.dtmNgayThuTien);
            this.panel1.Location = new System.Drawing.Point(20, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 294);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(296, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Số tiền trả khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(556, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số tiền thu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label15.Location = new System.Drawing.Point(30, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 19);
            this.label15.TabIndex = 42;
            this.label15.Text = "Tên chủ xe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label14.Location = new System.Drawing.Point(30, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 19);
            this.label14.TabIndex = 41;
            this.label14.Text = "Số tiền nợ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.Location = new System.Drawing.Point(30, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Số tiền khách trả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.Location = new System.Drawing.Point(409, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 39;
            this.label12.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(409, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Biển số";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(30, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ngày thu tiền";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(511, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(511, 16);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 33;
            // 
            // cboBienSo
            // 
            this.cboBienSo.FormattingEnabled = true;
            this.cboBienSo.Location = new System.Drawing.Point(160, 45);
            this.cboBienSo.Name = "cboBienSo";
            this.cboBienSo.Size = new System.Drawing.Size(200, 21);
            this.cboBienSo.TabIndex = 29;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLapPhieu.Location = new System.Drawing.Point(323, 255);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(128, 36);
            this.btnLapPhieu.TabIndex = 19;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // txtTienThu
            // 
            this.txtTienThu.Location = new System.Drawing.Point(654, 169);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.ReadOnly = true;
            this.txtTienThu.Size = new System.Drawing.Size(93, 20);
            this.txtTienThu.TabIndex = 18;
            // 
            // txtTienTraKhach
            // 
            this.txtTienTraKhach.Location = new System.Drawing.Point(413, 169);
            this.txtTienTraKhach.Name = "txtTienTraKhach";
            this.txtTienTraKhach.ReadOnly = true;
            this.txtTienTraKhach.Size = new System.Drawing.Size(93, 20);
            this.txtTienTraKhach.TabIndex = 16;
            this.txtTienTraKhach.TextChanged += new System.EventHandler(this.txtTienTraKhach_TextChanged);
            // 
            // txtTienKhachTra
            // 
            this.txtTienKhachTra.Location = new System.Drawing.Point(160, 168);
            this.txtTienKhachTra.Name = "txtTienKhachTra";
            this.txtTienKhachTra.Size = new System.Drawing.Size(93, 20);
            this.txtTienKhachTra.TabIndex = 14;
            this.txtTienKhachTra.TextChanged += new System.EventHandler(this.txtTienKhachTra_TextChanged);
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Location = new System.Drawing.Point(160, 121);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(200, 20);
            this.txtSoTienNo.TabIndex = 10;
            this.txtSoTienNo.TextChanged += new System.EventHandler(this.txtSoTienNo_TextChanged);
            // 
            // dgvLichSuPTT
            // 
            this.dgvLichSuPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuPTT.Location = new System.Drawing.Point(20, 398);
            this.dgvLichSuPTT.Name = "dgvLichSuPTT";
            this.dgvLichSuPTT.Size = new System.Drawing.Size(799, 141);
            this.dgvLichSuPTT.TabIndex = 4;
            // 
            // btnLichSuThuTien
            // 
            this.btnLichSuThuTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLichSuThuTien.Location = new System.Drawing.Point(20, 369);
            this.btnLichSuThuTien.Name = "btnLichSuThuTien";
            this.btnLichSuThuTien.Size = new System.Drawing.Size(141, 29);
            this.btnLichSuThuTien.TabIndex = 5;
            this.btnLichSuThuTien.Text = "Lịch Sử Thu Tiền";
            this.btnLichSuThuTien.UseVisualStyleBackColor = true;
            this.btnLichSuThuTien.Click += new System.EventHandler(this.btnLichSuThuTien_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 31);
            this.label11.TabIndex = 7;
            this.label11.Text = "PHIẾU THU TIỀN";
            // 
            // cboTenChuXe
            // 
            this.cboTenChuXe.FormattingEnabled = true;
            this.cboTenChuXe.Location = new System.Drawing.Point(160, 81);
            this.cboTenChuXe.Name = "cboTenChuXe";
            this.cboTenChuXe.Size = new System.Drawing.Size(200, 21);
            this.cboTenChuXe.TabIndex = 45;
            // 
            // fLapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLichSuThuTien);
            this.Controls.Add(this.dgvLichSuPTT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLapPhieuThuTien";
            this.Text = "LapPhieuThuTien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuPTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dtmNgayThuTien;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLapPhieu;
		private System.Windows.Forms.TextBox txtTienThu;
		private System.Windows.Forms.TextBox txtTienTraKhach;
		private System.Windows.Forms.TextBox txtTienKhachTra;
		private System.Windows.Forms.TextBox txtSoTienNo;
		private System.Windows.Forms.DataGridView dgvLichSuPTT;
		private System.Windows.Forms.Button btnLichSuThuTien;
        private System.Windows.Forms.ComboBox cboBienSo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenChuXe;
    }
}