using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace UASLABSMDB {
	public partial class AdminForm : Form {
		
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = uaslabsmdb; Uid= root"); 
		MySqlCommand mycommand = new MySqlCommand(); 
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public AdminForm() {
			InitializeComponent();
			readdata();
		}
		
		public void readdata(){
            try{
                mycommand.Connection = co;
                myadapter.SelectCommand = mycommand;
                mycommand.CommandText = "select * from pengguna";
                DataSet ds= new DataSet();
                if (myadapter.Fill(ds,"x")>0){
                    tabeluser.DataSource = ds;
                    tabeluser.DataMember = "x";
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

		void BtnubahClick(object sender, EventArgs e)
		{
            try
            {
                co.Open();
                mycommand.CommandText = "update pengguna set username='" + username.Text + "',nama='" + nama.Text + "',alamat='" + alamat.Text + "' where username ='" + username.Text + "'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    readdata();
                }
                co.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
		
		void BtnhapusClick(object sender, EventArgs e)
		{
            try
            {
                co.Open();
                mycommand.CommandText = "delete from pengguna where username='" + username.Text + "'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    readdata();
                }
                co.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
		
		void TabeluserCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			username.Text = tabeluser.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama.Text = tabeluser.Rows[e.RowIndex].Cells[2].Value.ToString();
			alamat.Text = tabeluser.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void TabeluserCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			username.Clear();
			nama.Clear();
			alamat.Clear();
		}
		void BtnlogoutClick(object sender, EventArgs e)
		{
			this.Hide();  
            Login login = new Login();  
           	login.ShowDialog(); 
		}
	}
}
