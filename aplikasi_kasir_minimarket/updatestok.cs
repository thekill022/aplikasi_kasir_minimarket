﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_kasir_minimarket
{
    public partial class updatestok : Form
    {

        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        private void loadDataProduk(string nama)
        {

            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nama_produk, stok FROM Produk WHERE nama_produk LIKE @produk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@produk", "%" + nama + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private string nama;
        private string username;
        public updatestok(string nama, string username)
        {
            InitializeComponent();
            this.nama = nama;
            this.username = username;
            loadDataProduk("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {

                    conn.Open();
                    string query = "UPDATE Produk SET stok = (select stok from Produk where nama_produk=@nama) + @stok WHERE nama_produk=@nama";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@stok", textBox2.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Berhasil update", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearForm();
                            loadDataProduk("");
                        }
                        else
                        {
                            MessageBox.Show("Data Gagal Diupdate", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearForm();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kasirpage kasir = new kasirpage(nama, username, "kasir");
            kasir.Show();
            this.Close();
        }
    }
}
