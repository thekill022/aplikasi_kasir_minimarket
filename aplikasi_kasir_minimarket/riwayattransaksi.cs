using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aplikasi_kasir_minimarket
{
    public partial class riwayattransaksi : Form
    {

        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Riwayat_Transaksi";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
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

        private void loadDetail(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {

                conn.Open();
                string query = "SELECT (SELECT nama_produk FROM Produk WHERE id_produk=Detail_transaksi.id_produk) AS produk, jumlah, subtotal FROM Detail_Transaksi WHERE id_transaksi=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dt;
            }
        }

        private void clearForm()
        {
            textBox1.Text = "";
        }

        private string nama;
        private string user;
        public riwayattransaksi(string nama, string user)
        {
            InitializeComponent();
            this.nama = nama;
            this.user = user;
            loadData();
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
            if (textBox1.Text != null && textBox1.Text.Trim() != "")
            {
                loadDetail(int.Parse(textBox1.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Trim() != "")
            {

                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    conn.Open();
                    string query = "DELETE FROM Riwayat_Transaksi WHERE id_transaksi=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", textBox1.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Berhasil hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearForm();
                            loadData();
                            dataGridView2.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Data Gagal Dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Pilih data terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            adminpage admin = new adminpage(nama, user, "admin");
            admin.Show();
            this.Close();
        }
    }
}
