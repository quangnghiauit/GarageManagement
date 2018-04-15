namespace GUI
{
	partial class fTraCuuXe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraCuuXe));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtTinhTrangXe = new System.Windows.Forms.ComboBox();
			this.txtHangXe = new System.Windows.Forms.TextBox();
			this.txtBienKiemSoat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Labekl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.txtTinhTrangXe);
			this.groupBox1.Controls.Add(this.txtHangXe);
			this.groupBox1.Controls.Add(this.txtBienKiemSoat);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Labekl);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.groupBox1.ForeColor = System.Drawing.Color.Red;
			this.groupBox1.Location = new System.Drawing.Point(12, 13);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(760, 222);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quản lý xe";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(590, 172);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 34);
			this.button2.TabIndex = 13;
			this.button2.Text = "Xuất file excel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(447, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 34);
			this.button1.TabIndex = 12;
			this.button1.Text = "Tìm tất cả";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(447, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(147, 22);
			this.textBox2.TabIndex = 11;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(324, 58);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(140, 22);
			this.textBox1.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(227, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Tên chủ xe";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(9, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 161);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// txtTinhTrangXe
			// 
			this.txtTinhTrangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtTinhTrangXe.FormattingEnabled = true;
			this.txtTinhTrangXe.Items.AddRange(new object[] {
            "BUSY",
            "NOT BUSY"});
			this.txtTinhTrangXe.Location = new System.Drawing.Point(324, 132);
			this.txtTinhTrangXe.Name = "txtTinhTrangXe";
			this.txtTinhTrangXe.Size = new System.Drawing.Size(103, 24);
			this.txtTinhTrangXe.TabIndex = 7;
			// 
			// txtHangXe
			// 
			this.txtHangXe.Location = new System.Drawing.Point(324, 93);
			this.txtHangXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtHangXe.Name = "txtHangXe";
			this.txtHangXe.Size = new System.Drawing.Size(140, 22);
			this.txtHangXe.TabIndex = 3;
			// 
			// txtBienKiemSoat
			// 
			this.txtBienKiemSoat.Location = new System.Drawing.Point(324, 19);
			this.txtBienKiemSoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtBienKiemSoat.Name = "txtBienKiemSoat";
			this.txtBienKiemSoat.Size = new System.Drawing.Size(136, 22);
			this.txtBienKiemSoat.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(244, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tiền nợ";
			// 
			// Labekl
			// 
			this.Labekl.AutoSize = true;
			this.Labekl.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.Labekl.ForeColor = System.Drawing.Color.Red;
			this.Labekl.Location = new System.Drawing.Point(244, 99);
			this.Labekl.Name = "Labekl";
			this.Labekl.Size = new System.Drawing.Size(51, 16);
			this.Labekl.TabIndex = 2;
			this.Labekl.Text = "Hiệu xe";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(246, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Biển số";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(17, 292);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(811, 215);
			this.dataGridView1.TabIndex = 10;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.DarkRed;
			this.label14.Location = new System.Drawing.Point(309, 239);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(175, 31);
			this.label14.TabIndex = 11;
			this.label14.Text = "TRA CỨU XE";
			// 
			// fTraCuuXe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 520);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fTraCuuXe";
			this.Text = "TraCuuXe";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox txtTinhTrangXe;
		private System.Windows.Forms.TextBox txtHangXe;
		private System.Windows.Forms.TextBox txtBienKiemSoat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Labekl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}