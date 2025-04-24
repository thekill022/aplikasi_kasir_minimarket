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

namespace aplikasi_kasir_minimarket
{
    public partial class addproduct : Form
    {
        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";

        private void loadDataKategori()
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kategori";
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
        private void loadDataProduk(string nama)
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_produk WHERE nama_produk LIKE @produk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@produk", "%" + nama + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.AutoGenerateColumns = true;
                    dataGridView2.DataSource = dt;

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

        private string namaAdmin;
        private string username;
        public addproduct(string namaAdmin, string username)
        {
            InitializeComponent();
            this.namaAdmin = namaAdmin;
            this.username = username;

            loadDataKategori();
            loadDataProduk("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != null && textBox6.Text.Trim() != "")
            {
                loadDataProduk(textBox6.Text);
                clearForm();
            }
            else
            {
                MessageBox.Show("Input tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBox5.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = Convert.ToDecimal(row.Cells[3].Value).ToString("0");
                textBox3.Text = row.Cells[4].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text != "" && textBox5.Text != null)
            {
                MessageBox.Show("Data Already Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox1.Text != null && textBox1.Text.Trim() != "" && textBox2.Text != null && textBox2.Text.Trim() != "" && textBox3.Text != null && textBox3.Text.Trim() != "" && textBox4.Text != null && textBox4.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Produk(nama_produk, id_kategori, harga, stok) VALUES (@nama, (SELECT id_kategori FROM Kategori WHERE nama_kategori=@kategori), @harga, @stok)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", textBox4.Text.Trim());
                            cmd.Parameters.AddWithValue("@kategori", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@harga", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@stok", textBox3.Text.Trim());

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Data Berhasil Ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadDataProduk("");
                            }
                            else
                            {
                                MessageBox.Show("Data Gagal Ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Input tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Trim() != "" && textBox2.Text != null && textBox2.Text.Trim() != "" && textBox3.Text != null && textBox3.Text.Trim() != "" && textBox4.Text != null && textBox4.Text.Trim() != "" && textBox5.Text != null && textBox5.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Produk SET nama_produk=@nama, id_kategori=(SELECT id_kategori FROM Kategori WHERE nama_kategori=@kategori), harga=@harga, stok=@stok WHERE id_produk=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@nama", textBox4.Text.Trim());
                            cmd.Parameters.AddWithValue("@kategori", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@harga", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@stok", textBox3.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", textBox5.Text.Trim());

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
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
            else
            {
                MessageBox.Show("Input tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Produk WHERE id_produk=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", textBox5.Text);

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Data Berhasil hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadDataProduk("");
                            }
                            else
                            {
                                MessageBox.Show("Data Gagal Dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Pilih data terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            adminpage admin = new adminpage(namaAdmin, username, "admin");
            admin.Show();
            this.Close();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                loadDataProduk("");
            }
        }
    }
}
