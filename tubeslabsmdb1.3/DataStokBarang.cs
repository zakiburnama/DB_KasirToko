using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using UASLABSMDB;

namespace tubeslabsmdb1._3
{
    public partial class DataStokBarang : Form
    {

        TambahEditBarang formm;
        private string a,b,c,d;
        private long tot;

        public DataStokBarang()
        {
            InitializeComponent();
            formm = new TambahEditBarang(this);
            Display();
        }

		public void Display()
        {
			CRUDBarang.DisplayBarang("SELECT ID, NAMA, HARGA, STOK FROM databarang", tabelstok);
        }

        void btnTambah_Click(object sender, EventArgs e)
		{
            formm.clrscr();
            formm.TambahBarang();
			formm.ShowDialog();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CRUDBarang.DisplayBarang("SELECT ID, NAMA, HARGA, STOK FROM databarang WHERE NAMA LIKE'%"+ barpencarian.Text +"%'", tabelstok);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            barpencarian.Text = txtID.Text = txtJml.Text = txtHarga.Text = txtTotHarga.Text = string.Empty;
            tot = 0;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void tabelstok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                formm.clrscr();
      
                formm.ID = tabelstok.Rows[e.RowIndex].Cells[2].Value.ToString();
                formm.NAMA = tabelstok.Rows[e.RowIndex].Cells[3].Value.ToString();
                formm.HARGA = tabelstok.Rows[e.RowIndex].Cells[4].Value.ToString();
                formm.STOK = tabelstok.Rows[e.RowIndex].Cells[5].Value.ToString();
                formm.UpdateBarang();
                formm.ShowDialog();
                
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Yakin ingin dihapus?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CRUDBarang.DeleteBarang(tabelstok.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            try
            {
                string sjml = txtJml.Text;
                int jml = Convert.ToInt16(sjml);
                long har = Convert.ToInt16(c);
                int stk = Convert.ToInt16(d);
                har = jml * har;
                stk -= jml;
                tot += har;

                if (stk >= 0) {
                    string shar = Convert.ToString(har);
                    string stot = Convert.ToString(tot);
                    d = Convert.ToString(stk);
                    txtHarga.Text = shar;
                    txtTotHarga.Text = stot;

                    Barang std = new Barang(a, b, c, d);
                    CRUDBarang.UpdateBarang(std, a);
                }
                else {
                    txtID.Text = txtJml.Text = txtHarga.Text = txtTotHarga.Text = string.Empty;
                    MessageBox.Show("Stok tidak mencukupi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabelstok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = tabelstok.Rows[e.RowIndex].Cells[2].Value.ToString();
            a = tabelstok.Rows[e.RowIndex].Cells[2].Value.ToString();
            b = tabelstok.Rows[e.RowIndex].Cells[3].Value.ToString();
            c = tabelstok.Rows[e.RowIndex].Cells[4].Value.ToString();
            d = tabelstok.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
