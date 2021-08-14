/*
 * Created by SharpDevelop.
 * User: User
 * Date: 1/31/2021
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UASLABSMDB
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnpindahregis;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox tampilpass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel bg1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnpindahregis = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tampilpass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bg1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnpindahregis
            // 
            this.btnpindahregis.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnpindahregis.Location = new System.Drawing.Point(164, 367);
            this.btnpindahregis.Name = "btnpindahregis";
            this.btnpindahregis.Size = new System.Drawing.Size(202, 58);
            this.btnpindahregis.TabIndex = 15;
            this.btnpindahregis.Text = "Belum punya akun? Register";
            this.btnpindahregis.UseVisualStyleBackColor = false;
            this.btnpindahregis.Click += new System.EventHandler(this.BtnpindahregisClick);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnlogin.Location = new System.Drawing.Point(164, 293);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(202, 41);
            this.btnlogin.TabIndex = 14;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.BtnloginClick);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(246, 190);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(263, 27);
            this.password.TabIndex = 12;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(246, 113);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(263, 27);
            this.username.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(46, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(46, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username : ";
            // 
            // tampilpass
            // 
            this.tampilpass.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tampilpass.Location = new System.Drawing.Point(246, 223);
            this.tampilpass.Name = "tampilpass";
            this.tampilpass.Size = new System.Drawing.Size(263, 24);
            this.tampilpass.TabIndex = 17;
            this.tampilpass.Text = "Tampilkan Password";
            this.tampilpass.UseVisualStyleBackColor = false;
            this.tampilpass.CheckedChanged += new System.EventHandler(this.TampilpassCheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 57);
            this.label3.TabIndex = 18;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bg1
            // 
            this.bg1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bg1.Location = new System.Drawing.Point(34, 95);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(484, 169);
            this.bg1.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(544, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tampilpass);
            this.Controls.Add(this.btnpindahregis);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bg1);
            this.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
