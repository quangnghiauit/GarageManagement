namespace GUI
{
	partial class fThayDoiQuyDinh
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
			this.tbSoXeSua = new System.Windows.Forms.TextBox();
			this.tbSoTienNo = new System.Windows.Forms.TextBox();
			this.checkSuDungQuyDinh = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbSoXeSua
			// 
			this.tbSoXeSua.Location = new System.Drawing.Point(407, 78);
			this.tbSoXeSua.Name = "tbSoXeSua";
			this.tbSoXeSua.Size = new System.Drawing.Size(213, 20);
			this.tbSoXeSua.TabIndex = 3;
			// 
			// tbSoTienNo
			// 
			this.tbSoTienNo.Location = new System.Drawing.Point(407, 133);
			this.tbSoTienNo.Name = "tbSoTienNo";
			this.tbSoTienNo.Size = new System.Drawing.Size(213, 20);
			this.tbSoTienNo.TabIndex = 4;
			// 
			// checkSuDungQuyDinh
			// 
			this.checkSuDungQuyDinh.AutoSize = true;
			this.checkSuDungQuyDinh.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.checkSuDungQuyDinh.Location = new System.Drawing.Point(407, 204);
			this.checkSuDungQuyDinh.Name = "checkSuDungQuyDinh";
			this.checkSuDungQuyDinh.Size = new System.Drawing.Size(79, 23);
			this.checkSuDungQuyDinh.TabIndex = 6;
			this.checkSuDungQuyDinh.Text = "Sử dụng";
			this.checkSuDungQuyDinh.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label1.Location = new System.Drawing.Point(49, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(417, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Quy định 4: Số tiền thu không vượt quá số tiền khách hàng đang  nợ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "THAY ĐỔI QUY ĐỊNH";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label3.Location = new System.Drawing.Point(78, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "Số Xe Sửa Tối Đa Trong Ngày";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label4.Location = new System.Drawing.Point(78, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Số Tiền Nợ Tối Đa";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.label5.Location = new System.Drawing.Point(78, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 19);
			this.label5.TabIndex = 11;
			this.label5.Text = "Sử Dụng Quy Định 4";
			// 
			// btnApply
			// 
			this.btnApply.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.btnApply.Location = new System.Drawing.Point(315, 349);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(157, 61);
			this.btnApply.TabIndex = 12;
			this.btnApply.Text = "ÁP DỤNG";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// fThayDoiQuyDinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkSuDungQuyDinh);
			this.Controls.Add(this.tbSoTienNo);
			this.Controls.Add(this.tbSoXeSua);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fThayDoiQuyDinh";
			this.Text = "ThayDoiQuyDinh";
			this.Load += new System.EventHandler(this.fThayDoiQuyDinh_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbSoXeSua;
		private System.Windows.Forms.TextBox tbSoTienNo;
		private System.Windows.Forms.CheckBox checkSuDungQuyDinh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnApply;
	}
}