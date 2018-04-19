namespace GUI
{
	partial class fThongTin
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
			this.btnThayDoiDatabase = new System.Windows.Forms.Button();
			this.btnThayDoiQuyDinh = new System.Windows.Forms.Button();
			this.fThayDoiTienCong = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnThayDoiDatabase
			// 
			this.btnThayDoiDatabase.Location = new System.Drawing.Point(155, 113);
			this.btnThayDoiDatabase.Name = "btnThayDoiDatabase";
			this.btnThayDoiDatabase.Size = new System.Drawing.Size(198, 119);
			this.btnThayDoiDatabase.TabIndex = 1;
			this.btnThayDoiDatabase.Text = "Thay Đổi Database";
			this.btnThayDoiDatabase.UseVisualStyleBackColor = true;
			this.btnThayDoiDatabase.Click += new System.EventHandler(this.btnThayDoiDatabase_Click);
			// 
			// btnThayDoiQuyDinh
			// 
			this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(438, 113);
			this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
			this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(207, 119);
			this.btnThayDoiQuyDinh.TabIndex = 2;
			this.btnThayDoiQuyDinh.Text = "Thay Đổi Quy Định";
			this.btnThayDoiQuyDinh.UseVisualStyleBackColor = true;
			this.btnThayDoiQuyDinh.Click += new System.EventHandler(this.btnThayDoiQuyDinh_Click);
			// 
			// fThayDoiTienCong
			// 
			this.fThayDoiTienCong.Location = new System.Drawing.Point(155, 254);
			this.fThayDoiTienCong.Name = "fThayDoiTienCong";
			this.fThayDoiTienCong.Size = new System.Drawing.Size(207, 119);
			this.fThayDoiTienCong.TabIndex = 4;
			this.fThayDoiTienCong.Text = "Thay Đổi Số Loại \r\nTiền Công";
			this.fThayDoiTienCong.UseVisualStyleBackColor = true;
			this.fThayDoiTienCong.Click += new System.EventHandler(this.button1_Click);
			// 
			// fThongTin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.fThayDoiTienCong);
			this.Controls.Add(this.btnThayDoiQuyDinh);
			this.Controls.Add(this.btnThayDoiDatabase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fThongTin";
			this.Text = "fThongTin";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnThayDoiDatabase;
		private System.Windows.Forms.Button btnThayDoiQuyDinh;
		private System.Windows.Forms.Button fThayDoiTienCong;
	}
}