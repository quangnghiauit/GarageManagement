namespace GUI
{
	partial class fHelps
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
			this.tvHelp = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbHelp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tvHelp
			// 
			this.tvHelp.Location = new System.Drawing.Point(44, 157);
			this.tvHelp.Name = "tvHelp";
			this.tvHelp.Size = new System.Drawing.Size(181, 298);
			this.tvHelp.TabIndex = 0;
			this.tvHelp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.tvHelp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvHelp_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(134, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(532, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hướng dẫn sử dụng phần mềm quản lý gara oto";
			// 
			// tbHelp
			// 
			this.tbHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbHelp.Location = new System.Drawing.Point(276, 157);
			this.tbHelp.Multiline = true;
			this.tbHelp.Name = "tbHelp";
			this.tbHelp.ReadOnly = true;
			this.tbHelp.Size = new System.Drawing.Size(461, 293);
			this.tbHelp.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(102, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chức năng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(425, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Hướng dẫn";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(40, 476);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(771, 38);
			this.label4.TabIndex = 5;
			this.label4.Text = "LƯU Ý: ĐỂ SỬ DỤNG ĐƯỢC PHẦN MỀM PHẢI KẾT NỐI VỚI DATABASE VÀ LƯU THÔNG TIN KẾT NỐ" +
    "I\r\n Ở PHẦN THAY ĐỔI DATABASE TRONG CHỨC NĂNG THÔNG TIN.\r\n";
			// 
			// fHelps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbHelp);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tvHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fHelps";
			this.Text = "Helps";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView tvHelp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbHelp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}