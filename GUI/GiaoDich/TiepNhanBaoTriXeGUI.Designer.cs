namespace GUI
{
	partial class fTiepNhanBaoTriXe
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
            this.btnLichSuTiepNhan = new System.Windows.Forms.Button();
            this.dtgvLichSuTiepNhan = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbHieuXe = new System.Windows.Forms.TextBox();
            this.tbBienSo = new System.Windows.Forms.TextBox();
            this.tbTenChuXe = new System.Windows.Forms.TextBox();
            this.dtmNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuTiepNhan)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLichSuTiepNhan);
            this.panel1.Controls.Add(this.dtgvLichSuTiepNhan);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 461);
            this.panel1.TabIndex = 1;
            // 
            // btnLichSuTiepNhan
            // 
            this.btnLichSuTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuTiepNhan.Location = new System.Drawing.Point(3, 226);
            this.btnLichSuTiepNhan.Name = "btnLichSuTiepNhan";
            this.btnLichSuTiepNhan.Size = new System.Drawing.Size(198, 45);
            this.btnLichSuTiepNhan.TabIndex = 10;
            this.btnLichSuTiepNhan.Text = "Lịch Sử Tiếp Nhận";
            this.btnLichSuTiepNhan.UseVisualStyleBackColor = true;
            this.btnLichSuTiepNhan.Click += new System.EventHandler(this.btnLichSuTiepNhan_Click);
            // 
            // dtgvLichSuTiepNhan
            // 
            this.dtgvLichSuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSuTiepNhan.Location = new System.Drawing.Point(3, 226);
            this.dtgvLichSuTiepNhan.Name = "dtgvLichSuTiepNhan";
            this.dtgvLichSuTiepNhan.Size = new System.Drawing.Size(810, 235);
            this.dtgvLichSuTiepNhan.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnTiepNhan);
            this.panel8.Controls.Add(this.tbDienThoai);
            this.panel8.Controls.Add(this.tbDiaChi);
            this.panel8.Controls.Add(this.tbHieuXe);
            this.panel8.Controls.Add(this.tbBienSo);
            this.panel8.Controls.Add(this.tbTenChuXe);
            this.panel8.Controls.Add(this.dtmNgayTiepNhan);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(761, 220);
            this.panel8.TabIndex = 8;
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(300, 164);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(174, 45);
            this.btnTiepNhan.TabIndex = 12;
            this.btnTiepNhan.Text = "Tiếp Nhận";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(467, 51);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(220, 20);
            this.tbDienThoai.TabIndex = 3;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(467, 18);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(220, 20);
            this.tbDiaChi.TabIndex = 3;
            // 
            // tbHieuXe
            // 
            this.tbHieuXe.Location = new System.Drawing.Point(132, 80);
            this.tbHieuXe.Name = "tbHieuXe";
            this.tbHieuXe.Size = new System.Drawing.Size(200, 20);
            this.tbHieuXe.TabIndex = 3;
            // 
            // tbBienSo
            // 
            this.tbBienSo.Location = new System.Drawing.Point(132, 50);
            this.tbBienSo.Name = "tbBienSo";
            this.tbBienSo.Size = new System.Drawing.Size(200, 20);
            this.tbBienSo.TabIndex = 11;
            // 
            // tbTenChuXe
            // 
            this.tbTenChuXe.Location = new System.Drawing.Point(132, 18);
            this.tbTenChuXe.Name = "tbTenChuXe";
            this.tbTenChuXe.Size = new System.Drawing.Size(200, 20);
            this.tbTenChuXe.TabIndex = 10;
            // 
            // dtmNgayTiepNhan
            // 
            this.dtmNgayTiepNhan.Location = new System.Drawing.Point(132, 122);
            this.dtmNgayTiepNhan.Name = "dtmNgayTiepNhan";
            this.dtmNgayTiepNhan.Size = new System.Drawing.Size(200, 20);
            this.dtmNgayTiepNhan.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày Tiếp Nhận ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hiệu Xe ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Biển Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Chủ Xe ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tiếp Nhận Bảo Trì Xe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fTiepNhanBaoTriXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTiepNhanBaoTriXe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSuTiepNhan)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbDienThoai;
		private System.Windows.Forms.TextBox tbDiaChi;
		private System.Windows.Forms.TextBox tbHieuXe;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox tbBienSo;
		private System.Windows.Forms.TextBox tbTenChuXe;
		private System.Windows.Forms.DateTimePicker dtmNgayTiepNhan;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLichSuTiepNhan;
		private System.Windows.Forms.DataGridView dtgvLichSuTiepNhan;
		private System.Windows.Forms.Button btnTiepNhan;
	}
}