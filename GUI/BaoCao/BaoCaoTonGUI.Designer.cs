namespace GUI
{
	partial class fBaoCaoTon
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
            this.dtmThangLapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.dgvBaoCaoTon = new System.Windows.Forms.DataGridView();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBaoCao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmThangLapBaoCao
            // 
            this.dtmThangLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmThangLapBaoCao.Location = new System.Drawing.Point(233, 80);
            this.dtmThangLapBaoCao.Name = "dtmThangLapBaoCao";
            this.dtmThangLapBaoCao.Size = new System.Drawing.Size(125, 20);
            this.dtmThangLapBaoCao.TabIndex = 2;
            // 
            // dgvBaoCaoTon
            // 
            this.dgvBaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoTon.Location = new System.Drawing.Point(5, 124);
            this.dgvBaoCaoTon.Name = "dgvBaoCaoTon";
            this.dgvBaoCaoTon.Size = new System.Drawing.Size(840, 320);
            this.dgvBaoCaoTon.TabIndex = 3;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(216, 472);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(142, 43);
            this.btnLapBaoCao.TabIndex = 4;
            this.btnLapBaoCao.Text = "Lập Báo Cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(407, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Xuất File Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháng Lập Báo Cáo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "LẬP BÁO CÁO TỒN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaBaoCao
            // 
            this.txtMaBaoCao.Location = new System.Drawing.Point(233, 48);
            this.txtMaBaoCao.Name = "txtMaBaoCao";
            this.txtMaBaoCao.Size = new System.Drawing.Size(125, 20);
            this.txtMaBaoCao.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã số báo cáo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 540);
            this.Controls.Add(this.txtMaBaoCao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.dgvBaoCaoTon);
            this.Controls.Add(this.dtmThangLapBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBaoCaoTon";
            this.Text = "BaoCaoTon";
            this.Load += new System.EventHandler(this.BaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dtmThangLapBaoCao;
		private System.Windows.Forms.DataGridView dgvBaoCaoTon;
		private System.Windows.Forms.Button btnLapBaoCao;
		private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBaoCao;
        private System.Windows.Forms.Label label4;
    }
}