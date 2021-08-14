/*
 * Created by SharpDevelop.
 * User: User
 * Date: 2/2/2021
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UASLABSMDB
{
	partial class AdminForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView tabeluser;
		private System.Windows.Forms.TextBox alamat;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnubah;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnhapus;
		private System.Windows.Forms.Button btnlogout;
		
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
            this.tabeluser = new System.Windows.Forms.DataGridView();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnubah = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabeluser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabeluser
            // 
            this.tabeluser.AllowUserToAddRows = false;
            this.tabeluser.AllowUserToDeleteRows = false;
            this.tabeluser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabeluser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabeluser.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.tabeluser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tabeluser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabeluser.GridColor = System.Drawing.Color.Turquoise;
            this.tabeluser.Location = new System.Drawing.Point(12, 120);
            this.tabeluser.Name = "tabeluser";
            this.tabeluser.ReadOnly = true;
            this.tabeluser.RowHeadersWidth = 62;
            this.tabeluser.RowTemplate.Height = 28;
            this.tabeluser.Size = new System.Drawing.Size(1014, 216);
            this.tabeluser.TabIndex = 0;
            this.tabeluser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabeluserCellContentClick);
            this.tabeluser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabeluserCellContentDoubleClick);
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(219, 463);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(329, 27);
            this.alamat.TabIndex = 15;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(219, 410);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(329, 27);
            this.nama.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(19, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alamat : ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(19, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama :";
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnubah.Location = new System.Drawing.Point(652, 360);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(133, 57);
            this.btnubah.TabIndex = 16;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.BtnubahClick);
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(219, 360);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(329, 27);
            this.username.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(19, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username : ";
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnhapus.Location = new System.Drawing.Point(893, 360);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(133, 57);
            this.btnhapus.TabIndex = 19;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.BtnhapusClick);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Brown;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnlogout.Location = new System.Drawing.Point(772, 441);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(133, 45);
            this.btnlogout.TabIndex = 20;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.BtnlogoutClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 61);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Pengguna";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1041, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabeluser);
            this.Font = new System.Drawing.Font("Geometr212 BkCn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selamat Datang Admin!";
            ((System.ComponentModel.ISupportInitialize)(this.tabeluser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label2;
    }
}
