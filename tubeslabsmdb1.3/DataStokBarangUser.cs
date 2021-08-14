using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UASLABSMDB;

namespace tubeslabsmdb1._3
{
    public partial class DataStokBarangUser : Form
    {
        public DataStokBarangUser()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            CRUDBarang.DisplayBarang("SELECT ID, NAMA, HARGA, STOK FROM databarang", tabelbarang);
        }

        private void barpencarian_TextChanged(object sender, EventArgs e)
        {
            CRUDBarang.DisplayBarang("SELECT ID, NAMA, HARGA, STOK FROM databarang WHERE NAMA LIKE'%" + barpencarian.Text + "%'", tabelbarang);
        }

        private void DataStokBarangUser_Shown(object sender, EventArgs e)
        {
            CRUDBarang.DisplayBarang("SELECT ID, NAMA, HARGA, STOK FROM databarang", tabelbarang);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
