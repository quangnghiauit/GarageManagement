namespace GUI
{
	partial class fBaoCao
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
			this.btnBaoCaoTon = new System.Windows.Forms.Button();
			this.btnDoanhSo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBaoCaoTon
			// 
			this.btnBaoCaoTon.Location = new System.Drawing.Point(118, 151);
			this.btnBaoCaoTon.Name = "btnBaoCaoTon";
			this.btnBaoCaoTon.Size = new System.Drawing.Size(209, 173);
			this.btnBaoCaoTon.TabIndex = 0;
			this.btnBaoCaoTon.Text = "Báo Cáo Tồn ";
			this.btnBaoCaoTon.UseVisualStyleBackColor = true;
			this.btnBaoCaoTon.Click += new System.EventHandler(this.btnBaoCaoTon_Click);
			// 
			// btnDoanhSo
			// 
			this.btnDoanhSo.Location = new System.Drawing.Point(411, 151);
			this.btnDoanhSo.Name = "btnDoanhSo";
			this.btnDoanhSo.Size = new System.Drawing.Size(209, 173);
			this.btnDoanhSo.TabIndex = 1;
			this.btnDoanhSo.Text = "Doanh Số";
			this.btnDoanhSo.UseVisualStyleBackColor = true;
			this.btnDoanhSo.Click += new System.EventHandler(this.btnDoanhSo_Click);
			// 
			// fBaoCao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 515);
			this.Controls.Add(this.btnDoanhSo);
			this.Controls.Add(this.btnBaoCaoTon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fBaoCao";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBaoCaoTon;
		private System.Windows.Forms.Button btnDoanhSo;
	}
}