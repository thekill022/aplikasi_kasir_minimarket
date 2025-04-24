using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aplikasi_kasir_minimarket
{
    public partial class appkasir : Form
    {

        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        List<Produk> listBarang = new List<Produk>();

        public class Produk
        {
            public string nama { get; set; }
            public int jumlah { get; set; }
            public float harga { get; set; }
            public float subtotal { get; set; }
            public string metode { get; set; }
        }
        private void loadData(string nama)
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {

                    string query = "SELECT * FROM Produk WHERE nama_produk LIKE @produk";
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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private string nama;
        private string username;
        private bool isUpdating = false;
        public appkasir(string nama, string username)
        {
            InitializeComponent();
            this.nama = nama;
            this.username = username;
            loadData("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Trim() != "" && textBox2.Text != null && textBox2.Text.Trim() != "" && textBox3.Text != null && textBox3.Text.Trim() != "" && textBox4.Text != null && textBox4.Text.Trim() != "" && textBox5.Text != null && textBox5.Text.Trim() != "")
            {
                bool sudahAda = listBarang.Any(p => p.nama.Equals(textBox4.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (sudahAda)
                {
                    MessageBox.Show("Produk sudah ditambahkan ke daftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produk item = new Produk
                {
                    nama = textBox4.Text,
                    harga = float.Parse(textBox2.Text),
                    jumlah = int.Parse(textBox3.Text),
                    subtotal = float.Parse(textBox1.Text),
                    metode = textBox5.Text
                };

                listBarang.Add(item);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listBarang;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox4.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox1.Text = 0.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            kasirpage kasir = new kasirpage(nama,username, "kasir");
            kasir.Show();
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                loadData("");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadData(textBox6.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!isUpdating && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(textBox3.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = listBarang.FirstOrDefault(p => p.nama.Equals(textBox4.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.jumlah = int.Parse(textBox3.Text.Trim());
                item.metode = textBox5.Text;

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listBarang;

                MessageBox.Show("Produk berhasil diperbarui", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var item = listBarang.FirstOrDefault(p => p.nama.Equals(textBox4.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                listBarang.Remove(item);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listBarang;

                MessageBox.Show("Produk berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isUpdating = true;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBox4.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox1.Text = row.Cells[3].Value.ToString();

                isUpdating = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Tunai";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Non-Tunai";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBarang.Count == 0)
            {
                MessageBox.Show("Harap isikan barang terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using(SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {

                    conn.Open();
                    string query = "INSERT INTO Riwayat_Transaksi(id_UserMinimart, total_harga, metode_pembayaran) VALUES ((select id_UserMinimart from UserMinimart where username=@user), @total, @metode); SELECT SCOPE_IDENTITY();";
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@total", (decimal)listBarang.Sum(item => item.subtotal));
                        cmd.Parameters.AddWithValue("@metode", textBox5.Text);

                        int idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (Produk item in listBarang)
                        {
                            string queryDetail = "INSERT INTO Detail_Transaksi (id_transaksi, id_produk, jumlah, subtotal) VALUES (@id_transaksi, (SELECT id_produk FROM Produk WHERE nama_produk = @nama_produk), @jumlah, @subtotal); UPDATE Produk SET stok = stok - @jumlah WHERE nama_produk = @nama_produk;";
                            
                            SqlCommand cmdDetail = new SqlCommand(queryDetail, conn);
                            cmdDetail.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                            cmdDetail.Parameters.AddWithValue("@nama_produk", item.nama);
                            cmdDetail.Parameters.AddWithValue("@jumlah", item.jumlah);
                            cmdDetail.Parameters.AddWithValue("@subtotal", item.subtotal);

                            cmdDetail.ExecuteNonQuery();
                        }

                        MessageBox.Show("Transaksi Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBarang.Clear();
                        dataGridView2.DataSource = null;
                        clearForm();
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
