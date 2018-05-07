namespace GUI
{
	partial class fThayDoiDatabase
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
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbDatabaseName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(325, 389);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(224, 107);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Kết Nối";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// tbServer
			// 
			this.tbServer.Location = new System.Drawing.Point(286, 95);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(273, 20);
			this.tbServer.TabIndex = 6;
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(286, 149);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(273, 20);
			this.tbUser.TabIndex = 7;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(286, 205);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(273, 20);
			this.tbPassword.TabIndex = 8;
			// 
			// tbDatabaseName
			// 
			this.tbDatabaseName.Location = new System.Drawing.Point(286, 267);
			this.tbDatabaseName.Name = "tbDatabaseName";
			this.tbDatabaseName.Size = new System.Drawing.Size(273, 20);
			this.tbDatabaseName.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "THAY ĐỔI DATABASE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Server";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(103, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 25);
			this.label3.TabIndex = 12;
			this.label3.Text = "User";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(103, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 25);
			this.label4.TabIndex = 13;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(103, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(166, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "Database Name";
			// 
			// fThayDoiDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 540);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDatabaseName);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.btnConnect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "fThayDoiDatabase";
			this.Text = "ThayDoiDatabase";
			this.Load += new System.EventHandler(this.fThayDoiDatabase_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbDatabaseName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}