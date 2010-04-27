namespace BooBoxClient {
	partial class ConnectionFrm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionFrm));
			this.IPHostnameTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PortTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.OKCmd = new System.Windows.Forms.Button();
			this.DescriptionTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PasswordTxt = new System.Windows.Forms.TextBox();
			this.PasswordLbl = new System.Windows.Forms.Label();
			this.ServerPasswordChk = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// IPHostnameTxt
			// 
			this.IPHostnameTxt.Location = new System.Drawing.Point(83, 38);
			this.IPHostnameTxt.Name = "IPHostnameTxt";
			this.IPHostnameTxt.Size = new System.Drawing.Size(107, 20);
			this.IPHostnameTxt.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(1, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "IP/Hostname:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// PortTxt
			// 
			this.PortTxt.Location = new System.Drawing.Point(83, 64);
			this.PortTxt.Name = "PortTxt";
			this.PortTxt.Size = new System.Drawing.Size(107, 20);
			this.PortTxt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Port:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// OKCmd
			// 
			this.OKCmd.Location = new System.Drawing.Point(95, 139);
			this.OKCmd.Name = "OKCmd";
			this.OKCmd.Size = new System.Drawing.Size(95, 23);
			this.OKCmd.TabIndex = 5;
			this.OKCmd.Text = "Add Connection";
			this.OKCmd.UseVisualStyleBackColor = true;
			this.OKCmd.Click += new System.EventHandler(this.OKCmd_Click);
			// 
			// DescriptionTxt
			// 
			this.DescriptionTxt.Location = new System.Drawing.Point(83, 12);
			this.DescriptionTxt.Name = "DescriptionTxt";
			this.DescriptionTxt.Size = new System.Drawing.Size(107, 20);
			this.DescriptionTxt.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Description:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// PasswordTxt
			// 
			this.PasswordTxt.Enabled = false;
			this.PasswordTxt.Location = new System.Drawing.Point(83, 113);
			this.PasswordTxt.Name = "PasswordTxt";
			this.PasswordTxt.Size = new System.Drawing.Size(107, 20);
			this.PasswordTxt.TabIndex = 4;
			// 
			// PasswordLbl
			// 
			this.PasswordLbl.Enabled = false;
			this.PasswordLbl.Location = new System.Drawing.Point(15, 116);
			this.PasswordLbl.Name = "PasswordLbl";
			this.PasswordLbl.Size = new System.Drawing.Size(62, 13);
			this.PasswordLbl.TabIndex = 12;
			this.PasswordLbl.Text = "Password:";
			this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ServerPasswordChk
			// 
			this.ServerPasswordChk.AutoSize = true;
			this.ServerPasswordChk.Location = new System.Drawing.Point(18, 90);
			this.ServerPasswordChk.Name = "ServerPasswordChk";
			this.ServerPasswordChk.Size = new System.Drawing.Size(151, 17);
			this.ServerPasswordChk.TabIndex = 3;
			this.ServerPasswordChk.Text = "Server Requires Password";
			this.ServerPasswordChk.UseVisualStyleBackColor = true;
			this.ServerPasswordChk.CheckedChanged += new System.EventHandler(this.ServerPasswordChk_CheckedChanged);
			// 
			// ConnectionFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(202, 174);
			this.Controls.Add(this.PasswordTxt);
			this.Controls.Add(this.PasswordLbl);
			this.Controls.Add(this.ServerPasswordChk);
			this.Controls.Add(this.DescriptionTxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.OKCmd);
			this.Controls.Add(this.PortTxt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IPHostnameTxt);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConnectionFrm";
			this.Text = "New Connection";
			this.Load += new System.EventHandler(this.NewConnectionFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox IPHostnameTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PortTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OKCmd;
		private System.Windows.Forms.TextBox DescriptionTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PasswordTxt;
		private System.Windows.Forms.Label PasswordLbl;
		private System.Windows.Forms.CheckBox ServerPasswordChk;
	}
}