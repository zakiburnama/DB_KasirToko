using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace UASLABSMDB {
	public partial class Register : Form {
		
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = uaslabsmdb; Uid= root"); 
		MySqlCommand mycommand = new MySqlCommand(); 
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		MySqlDataReader myreader;
		PasswordHashing hash = new PasswordHashing();
		
		public Register() {
			InitializeComponent();
		}
		
		void BtnpindahloginClick(object sender, EventArgs e)
		{
			this.Hide();  
            Login login = new Login();  
           	login.ShowDialog(); 
		}
		
		void BtnregisterClick(object sender, EventArgs e)
		{
			 if (konfirmpassword.Text != string.Empty || password.Text != string.Empty || username.Text != string.Empty || nama.Text != string.Empty || alamat.Text != string.Empty)  
            {  
                if (password.Text == konfirmpassword.Text)  
                {  
                	try{
                	co.Open();
                    mycommand.Connection = co;
                    mycommand.CommandText = "select * from pengguna where username='" + username.Text + "'";
	                myadapter.SelectCommand = mycommand;
	                myreader = mycommand.ExecuteReader();
	                
                    if (myreader.Read())  
                    {  
                        myreader.Close();  
                        MessageBox.Show("Username sudah dipakai! Silahkan masukkan username lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    } 
                    
                    else  
                    {  
                        myreader.Close();
                        mycommand.CommandText = "insert into pengguna values(@username, @password, @nama, @alamat, @role)";
                        mycommand.Parameters.AddWithValue("username", username.Text);  
                        mycommand.Parameters.AddWithValue("password", hash.HashingPassword(password.Text));
                        mycommand.Parameters.AddWithValue("nama", nama.Text);  
                        mycommand.Parameters.AddWithValue("alamat", alamat.Text);  
                        mycommand.Parameters.AddWithValue("role","User");
                        mycommand.ExecuteNonQuery();  
                        MessageBox.Show("Akun Berhasil Dibuat! Silahkan Login.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    }
                    
                    co.Close();
                	}
                	catch(Exception){
                		MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                	}
                }  
                
                else  
                {  
                    MessageBox.Show("Silahkan masukkan password yang sama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }  
            }
			 
            else  
            {  
                MessageBox.Show("Silahkan isi semua field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }            
		}
		
		void Tampilpass1CheckedChanged(object sender, EventArgs e)
		{
			if (tampilpass1.Checked == true){
				password.UseSystemPasswordChar = false;	
			}
			else if(tampilpass1.Checked == false){
				password.UseSystemPasswordChar = true;	
			}
		}
		
		void Tampilpass2CheckedChanged(object sender, EventArgs e)
		{
			if (tampilpass2.Checked == true){
				konfirmpassword.UseSystemPasswordChar = false;
			}
			else if(tampilpass2.Checked == false){
				konfirmpassword.UseSystemPasswordChar = true;	
			}
		}
	}
}
