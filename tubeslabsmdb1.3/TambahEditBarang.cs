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

namespace tubeslabsmdb1._3
{
    public partial class TambahEditBarang : Form
    {
        private readonly DataStokBarang _parent;

        public string ID { get; internal set; }
        public string NAMA { get; internal set; }
        public string HARGA { get; internal set; }
        public string STOK { get; internal set; }

        public TambahEditBarang(DataStokBarang  parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateBarang()
        {
            textBox1.Text = "Edit Barang";
            btnTambah.Text = "Edit";
            txtID.Text = ID;
            txtNama.Text = NAMA;
            txtHarga.Text = HARGA;
            txtStok.Text = STOK;
        }
        public void TambahBarang()
        {
            textBox1.Text = "Tambah Barang";
            btnTambah.Text = "Tambah";
        }

        public void clrscr()
        {
            txtID.Text = txtNama.Text = txtHarga.Text = txtStok.Text = string.Empty;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Trim().Length <= 0)
            {
                MessageBox.Show("ID Kosong!");
                return;
            }
            if (txtNama.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Nama Kosong!!");
                return;
            }
            if (txtHarga.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Harga Kosong!");
                return;
            }
            if (txtStok.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Stok Kosong!");
                return;
            }
            if (btnTambah.Text=="Tambah")
            {
                Barang std = new Barang(txtID.Text.Trim(), txtNama.Text.Trim(), txtHarga.Text.Trim(), txtStok.Text.Trim());
                CRUDBarang.TmbhBarang(std);
                clrscr();
            }
            if(btnTambah.Text == "Edit")
            {
                Barang std = new Barang(txtID.Text.Trim(), txtNama.Text.Trim(), txtHarga.Text.Trim(), txtStok.Text.Trim());
                CRUDBarang.UpdateBarang(std, ID);
                clrscr();

            }
            _parent.Display();
        }
    }
}
