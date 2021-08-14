using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using tubeslabsmdb1._3;

namespace UASLABSMDB {
	public partial class Login : Form {
		
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = uaslabsmdb; Uid= root"); 
		MySqlCommand mycommand = new MySqlCommand(); 
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		MySqlDataReader myreader;
		PasswordHashing hash = new PasswordHashing();
		
		public Login() {
			InitializeComponent();
		}
		
		void BtnpindahregisClick(object sender, EventArgs e)
		{
			this.Hide();  
            Register reg = new Register();  
            reg.ShowDialog();  
		}
		
		void BtnloginClick(object sender, EventArgs e)
		{
			if (password.Text != string.Empty || username.Text != string.Empty)  
            {
				try
				{
					co.Open();
					mycommand.Connection = co;
					mycommand.CommandText = "select * from pengguna where username='" + username.Text + "' and password='" + hash.HashingPassword(password.Text) + "'";
					myadapter.SelectCommand = mycommand;
					myreader = mycommand.ExecuteReader();
					string peran = string.Empty;

					if (myreader.Read())
					{
						peran = myreader["role"].ToString();
						if (peran == "User")
						{
							myreader.Close();
							this.Hide();
							DataStokBarangUser du = new DataStokBarangUser();
							du.ShowDialog();
						}
						else if (peran == "Admin")
						{
							myreader.Close();
							this.Hide();
							AdminForm af = new AdminForm();
							af.ShowDialog();
						}
						else if (peran == "Kasir")
						{
							myreader.Close();
							this.Hide();
							DataStokBarang db = new DataStokBarang();
							db.ShowDialog();
						}
					}

					else
					{
						myreader.Close();
						MessageBox.Show("Akun tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					co.Close();
				}
				catch (Exception)
                {
					MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
            }  
            else  
            {  
                MessageBox.Show("Mohon isi seluruh data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            } 
		}
		
		void TampilpassCheckedChanged(object sender, EventArgs e)
		{
			if (tampilpass.Checked == true){
				password.UseSystemPasswordChar = false;	
			}
			else if(tampilpass.Checked == false){
				password.UseSystemPasswordChar = true;	
			}
		}
	}
}
