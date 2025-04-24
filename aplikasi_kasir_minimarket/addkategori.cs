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
    public partial class addkategori : Form
    {
        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {

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

        private void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }

        private string namaAdmin;
        private string username;
        public addkategori(string namaAdmin, string username)
        {
            InitializeComponent();
            this.namaAdmin = namaAdmin;
            this.username= username;
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MessageBox.Show("Data Already Exist", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text != null && textBox2.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Kategori(nama_kategori) VALUES (@kategori)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@kategori", textBox2.Text.Trim());

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Data Berhasil Ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadData();
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
            if (textBox1.Text != null && textBox1.Text.Trim() != "" && textBox2.Text != null && textBox2.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionStirng))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Kategori SET nama_kategori=@kategori WHERE id_kategori=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@kategori", textBox2.Text);
                            cmd.Parameters.AddWithValue("@id", textBox1.Text);

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Data Berhasil update", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadData();
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
                        string query = "DELETE FROM Kategori WHERE id_kategori=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", textBox1.Text);

                            int rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Data Berhasil hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadData();
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

        private void label4_Click(object sender, EventArgs e)
        {
            adminpage admin = new adminpage(namaAdmin, username, "admin");
            admin.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
