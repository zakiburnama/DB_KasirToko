using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tubeslabsmdb1._3
{
    class CRUDBarang
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=uaslabsmdb";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("MySql Connection \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void TmbhBarang(Barang std)
        {
            string sql = "INSERT INTO databarang VALUES (@IDBarang, @NamaBarang, @HargaBarang, @StokBarang)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDBarang", MySqlDbType.VarChar).Value = std.ID;
            cmd.Parameters.Add("@NamaBarang", MySqlDbType.VarChar).Value = std.NAMA;
            cmd.Parameters.Add("@HargaBarang", MySqlDbType.VarChar).Value = std.HARGA;
            cmd.Parameters.Add("@StokBarang", MySqlDbType.VarChar).Value = std.STOK;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e )
            {
                MessageBox.Show("Data Gagal Ditambahkan. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateBarang(Barang std, string ID)
        {
            string sql = "UPDATE databarang SET NAMA = @NamaBarang, HARGA = @HargaBarang, STOK = @StokBarang WHERE ID = @IDBarang";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDBarang", MySqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@NamaBarang", MySqlDbType.VarChar).Value = std.NAMA;
            cmd.Parameters.Add("@HargaBarang", MySqlDbType.VarChar).Value = std.HARGA;
            cmd.Parameters.Add("@StokBarang", MySqlDbType.VarChar).Value = std.STOK;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Data Gagal Diupdate. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteBarang (String ID)
        {
            string sql = "DELETE FROM databarang where ID = @IDBarang";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDBarang", MySqlDbType.VarChar).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Data Gagal Dihapus. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayBarang(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

    }
}
