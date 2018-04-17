using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.IO;

namespace GUI
{
	partial class fQuanLyKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyKhachHang));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbMaKhachHangTraCuu = new System.Windows.Forms.TextBox();
			this.btnXuatFile = new System.Windows.Forms.Button();
			this.btnTimTatCa = new System.Windows.Forms.Button();
			this.tbSoTienNoTraCuu = new System.Windows.Forms.TextBox();
			this.cbbTienNo = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDiaChiTraCuu = new System.Windows.Forms.TextBox();
			this.tbDienThoaiTraCuu = new System.Windows.Forms.TextBox();
			this.tbEmailTraCuu = new System.Windows.Forms.TextBox();
			this.tbTenKhachHangTraCuu = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbMaKhachHangTraCuu);
			this.groupBox1.Controls.Add(this.btnXuatFile);
			this.groupBox1.Controls.Add(this.btnTimTatCa);
			this.groupBox1.Controls.Add(this.tbSoTienNoTraCuu);
			this.groupBox1.Controls.Add(this.cbbTienNo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbDiaChiTraCuu);
			this.groupBox1.Controls.Add(this.tbDienThoaiTraCuu);
			this.groupBox1.Controls.Add(this.tbEmailTraCuu);
			this.groupBox1.Controls.Add(this.tbTenKhachHangTraCuu);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(21, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 213);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quản lý khách hàng";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// tbMaKhachHangTraCuu
			// 
			this.tbMaKhachHangTraCuu.Location = new System.Drawing.Point(360, 35);
			this.tbMaKhachHangTraCuu.Name = "tbMaKhachHangTraCuu";
			this.tbMaKhachHangTraCuu.Size = new System.Drawing.Size(130, 20);
			this.tbMaKhachHangTraCuu.TabIndex = 16;
			// 
			// btnXuatFile
			// 
			this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
			this.btnXuatFile.Location = new System.Drawing.Point(638, 173);
			this.btnXuatFile.Name = "btnXuatFile";
			this.btnXuatFile.Size = new System.Drawing.Size(109, 34);
			this.btnXuatFile.TabIndex = 15;
			this.btnXuatFile.Text = "Xuất file excel";
			this.btnXuatFile.UseVisualStyleBackColor = true;
			// 
			// btnTimTatCa
			// 
			this.btnTimTatCa.ForeColor = System.Drawing.Color.Black;
			this.btnTimTatCa.Location = new System.Drawing.Point(512, 173);
			this.btnTimTatCa.Name = "btnTimTatCa";
			this.btnTimTatCa.Size = new System.Drawing.Size(109, 34);
			this.btnTimTatCa.TabIndex = 14;
			this.btnTimTatCa.Text = "Tìm tất cả";
			this.btnTimTatCa.UseVisualStyleBackColor = true;
			this.btnTimTatCa.Click += new System.EventHandler(this.btnTimTatCa_Click);
			// 
			// tbSoTienNoTraCuu
			// 
			this.tbSoTienNoTraCuu.Location = new System.Drawing.Point(530, 140);
			this.tbSoTienNoTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbSoTienNoTraCuu.Name = "tbSoTienNoTraCuu";
			this.tbSoTienNoTraCuu.Size = new System.Drawing.Size(131, 20);
			this.tbSoTienNoTraCuu.TabIndex = 10;
			// 
			// cbbTienNo
			// 
			this.cbbTienNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTienNo.FormattingEnabled = true;
			this.cbbTienNo.Location = new System.Drawing.Point(361, 139);
			this.cbbTienNo.Name = "cbbTienNo";
			this.cbbTienNo.Size = new System.Drawing.Size(130, 21);
			this.cbbTienNo.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(262, 145);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Số tiền nợ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(26, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 184);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(533, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa chỉ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(262, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "Điện thoại";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(235, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên khách hàng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(533, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(239, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã khách hàng";
			// 
			// tbDiaChiTraCuu
			// 
			this.tbDiaChiTraCuu.Location = new System.Drawing.Point(617, 35);
			this.tbDiaChiTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDiaChiTraCuu.Name = "tbDiaChiTraCuu";
			this.tbDiaChiTraCuu.Size = new System.Drawing.Size(130, 20);
			this.tbDiaChiTraCuu.TabIndex = 1;
			// 
			// tbDienThoaiTraCuu
			// 
			this.tbDienThoaiTraCuu.Location = new System.Drawing.Point(360, 94);
			this.tbDienThoaiTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDienThoaiTraCuu.Name = "tbDienThoaiTraCuu";
			this.tbDienThoaiTraCuu.Size = new System.Drawing.Size(131, 20);
			this.tbDienThoaiTraCuu.TabIndex = 1;
			// 
			// tbEmailTraCuu
			// 
			this.tbEmailTraCuu.Location = new System.Drawing.Point(617, 67);
			this.tbEmailTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbEmailTraCuu.Name = "tbEmailTraCuu";
			this.tbEmailTraCuu.Size = new System.Drawing.Size(131, 20);
			this.tbEmailTraCuu.TabIndex = 1;
			// 
			// tbTenKhachHangTraCuu
			// 
			this.tbTenKhachHangTraCuu.Location = new System.Drawing.Point(360, 67);
			this.tbTenKhachHangTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbTenKhachHangTraCuu.Name = "tbTenKhachHangTraCuu";
			this.tbTenKhachHangTraCuu.Size = new System.Drawing.Size(130, 20);
			this.tbTenKhachHangTraCuu.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(360, 67);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(130, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(185, 245);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(480, 31);
			this.label15.TabIndex = 13;
			this.label15.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtgvKhachHang);
			this.panel1.Location = new System.Drawing.Point(12, 286);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(809, 227);
			this.panel1.TabIndex = 14;
			// 
			// dtgvKhachHang
			// 
			this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvKhachHang.Location = new System.Drawing.Point(3, 10);
			this.dtgvKhachHang.Name = "dtgvKhachHang";
			this.dtgvKhachHang.Size = new System.Drawing.Size(792, 216);
			this.dtgvKhachHang.TabIndex = 0;
			// 
			// fQuanLyKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 520);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fQuanLyKhachHang";
			this.Text = "QuanLyKhachHang";
			this.Load += new System.EventHandler(this.fQuanLyKhachHang_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDiaChiTraCuu;
		private System.Windows.Forms.TextBox tbDienThoaiTraCuu;
		private System.Windows.Forms.TextBox tbEmailTraCuu;
		private System.Windows.Forms.TextBox tbTenKhachHangTraCuu;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgvKhachHang;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox cbbTienNo;
		private System.Windows.Forms.TextBox tbSoTienNoTraCuu;
		private System.Windows.Forms.Button btnXuatFile;
		private System.Windows.Forms.Button btnTimTatCa;
		private TextBox tbMaKhachHangTraCuu;
	}
}