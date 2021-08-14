/*
 * Created by SharpDevelop.
 * User: User
 * Date: 1/30/2021
 * Time: 2:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UASLABSMDB
{
	partial class Register
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelusername;
		private System.Windows.Forms.Label labelpassword;
		private System.Windows.Forms.Label labelkonfirmpassword;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox konfirmpassword;
		private System.Windows.Forms.Button btnregister;
		private System.Windows.Forms.Button btnpindahlogin;
		private System.Windows.Forms.Label labelnama;
		private System.Windows.Forms.Label labelalamat;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.CheckBox tampilpass1;
		private System.Windows.Forms.CheckBox tampilpass2;
		private System.Windows.Forms.Label label6;
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
			this.labelusername = new System.Windows.Forms.Label();
			this.labelpassword = new System.Windows.Forms.Label();
			this.labelkonfirmpassword = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.konfirmpassword = new System.Windows.Forms.TextBox();
			this.btnregister = new System.Windows.Forms.Button();
			this.btnpindahlogin = new System.Windows.Forms.Button();
			this.labelnama = new System.Windows.Forms.Label();
			this.labelalamat = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.tampilpass1 = new System.Windows.Forms.CheckBox();
			this.tampilpass2 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.bg1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// labelusername
			// 
			this.labelusername.BackColor = System.Drawing.Color.MediumTurquoise;
			this.labelusername.Location = new System.Drawing.Point(34, 116);
			this.labelusername.Name = "labelusername";
			this.labelusername.Size = new System.Drawing.Size(192, 23);
			this.labelusername.TabIndex = 0;
			this.labelusername.Text = "Username : ";
			// 
			// labelpassword
			// 
			this.labelpassword.BackColor = System.Drawing.Color.MediumTurquoise;
			this.labelpassword.Location = new System.Drawing.Point(36, 183);
			this.labelpassword.Name = "labelpassword";
			this.labelpassword.Size = new System.Drawing.Size(192, 23);
			this.labelpassword.TabIndex = 1;
			this.labelpassword.Text = "Password : ";
			// 
			// labelkonfirmpassword
			// 
			this.labelkonfirmpassword.BackColor = System.Drawing.Color.MediumTurquoise;
			this.labelkonfirmpassword.Location = new System.Drawing.Point(34, 253);
			this.labelkonfirmpassword.Name = "labelkonfirmpassword";
			this.labelkonfirmpassword.Size = new System.Drawing.Size(192, 23);
			this.labelkonfirmpassword.TabIndex = 2;
			this.labelkonfirmpassword.Text = "Konfirmasi Password : ";
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(234, 116);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(263, 27);
			this.username.TabIndex = 3;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(234, 183);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(263, 27);
			this.password.TabIndex = 4;
			this.password.UseSystemPasswordChar = true;
			// 
			// konfirmpassword
			// 
			this.konfirmpassword.Location = new System.Drawing.Point(234, 250);
			this.konfirmpassword.Name = "konfirmpassword";
			this.konfirmpassword.Size = new System.Drawing.Size(263, 27);
			this.konfirmpassword.TabIndex = 5;
			this.konfirmpassword.UseSystemPasswordChar = true;
			// 
			// btnregister
			// 
			this.btnregister.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnregister.Location = new System.Drawing.Point(154, 485);
			this.btnregister.Name = "btnregister";
			this.btnregister.Size = new System.Drawing.Size(202, 41);
			this.btnregister.TabIndex = 6;
			this.btnregister.Text = "Register";
			this.btnregister.UseVisualStyleBackColor = false;
			this.btnregister.Click += new System.EventHandler(this.BtnregisterClick);
			// 
			// btnpindahlogin
			// 
			this.btnpindahlogin.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnpindahlogin.Location = new System.Drawing.Point(154, 558);
			this.btnpindahlogin.Name = "btnpindahlogin";
			this.btnpindahlogin.Size = new System.Drawing.Size(202, 58);
			this.btnpindahlogin.TabIndex = 7;
			this.btnpindahlogin.Text = "Sudah punya akun? Login";
			this.btnpindahlogin.UseVisualStyleBackColor = false;
			this.btnpindahlogin.Click += new System.EventHandler(this.BtnpindahloginClick);
			// 
			// labelnama
			// 
			this.labelnama.BackColor = System.Drawing.Color.MediumTurquoise;
			this.labelnama.Location = new System.Drawing.Point(34, 322);
			this.labelnama.Name = "labelnama";
			this.labelnama.Size = new System.Drawing.Size(111, 23);
			this.labelnama.TabIndex = 8;
			this.labelnama.Text = "Nama :";
			// 
			// labelalamat
			// 
			this.labelalamat.BackColor = System.Drawing.Color.MediumTurquoise;
			this.labelalamat.Location = new System.Drawing.Point(34, 393);
			this.labelalamat.Name = "labelalamat";
			this.labelalamat.Size = new System.Drawing.Size(111, 23);
			this.labelalamat.TabIndex = 9;
			this.labelalamat.Text = "Alamat : ";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(234, 322);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(263, 27);
			this.nama.TabIndex = 10;
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(234, 393);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(263, 27);
			this.alamat.TabIndex = 11;
			// 
			// tampilpass1
			// 
			this.tampilpass1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.tampilpass1.Location = new System.Drawing.Point(234, 216);
			this.tampilpass1.Name = "tampilpass1";
			this.tampilpass1.Size = new System.Drawing.Size(263, 24);
			this.tampilpass1.TabIndex = 18;
			this.tampilpass1.Text = "Tampilkan";
			this.tampilpass1.UseVisualStyleBackColor = false;
			this.tampilpass1.CheckedChanged += new System.EventHandler(this.Tampilpass1CheckedChanged);
			// 
			// tampilpass2
			// 
			this.tampilpass2.BackColor = System.Drawing.Color.MediumTurquoise;
			this.tampilpass2.Location = new System.Drawing.Point(234, 283);
			this.tampilpass2.Name = "tampilpass2";
			this.tampilpass2.Size = new System.Drawing.Size(263, 24);
			this.tampilpass2.TabIndex = 19;
			this.tampilpass2.Text = "Tampilkan";
			this.tampilpass2.UseVisualStyleBackColor = false;
			this.tampilpass2.CheckedChanged += new System.EventHandler(this.Tampilpass2CheckedChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(125, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(265, 67);
			this.label6.TabIndex = 20;
			this.label6.Text = "Register";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bg1
			// 
			this.bg1.BackColor = System.Drawing.Color.MediumTurquoise;
			this.bg1.Location = new System.Drawing.Point(12, 88);
			this.bg1.Name = "bg1";
			this.bg1.Size = new System.Drawing.Size(502, 364);
			this.bg1.TabIndex = 21;
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(526, 628);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tampilpass2);
			this.Controls.Add(this.tampilpass1);
			this.Controls.Add(this.alamat);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.labelalamat);
			this.Controls.Add(this.labelnama);
			this.Controls.Add(this.btnpindahlogin);
			this.Controls.Add(this.btnregister);
			this.Controls.Add(this.konfirmpassword);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.labelkonfirmpassword);
			this.Controls.Add(this.labelpassword);
			this.Controls.Add(this.labelusername);
			this.Controls.Add(this.bg1);
			this.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Register";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
