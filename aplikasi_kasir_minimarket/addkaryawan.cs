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
    public partial class addkaryawan : Form
    {
        private string connectionStirng = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        private string namaAdmin;
        private string username;

        private void clearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {
                try
                {

                    string query = "SELECT * FROM vw_karyawan";
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

        public addkaryawan(string namaAdmin, string username)
        {
            InitializeComponent();
            this.namaAdmin = namaAdmin;
            this.username = username;
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionStirng))
            {

                try
                {
                    conn.Open();

                    string session_query = "EXEC sp_set_session_context @key, @value";
                    using (SqlCommand cmd = new SqlCommand(session_query, conn))
                    {
                        cmd.Parameters.AddWithValue("@key", "nama_admin");
                        cmd.Parameters.AddWithValue("@value", namaAdmin);

                        cmd.ExecuteNonQuery();
                    }

                    string query = "EXEC add_karyawan @nama, @username, @password, 'kasir'";
                    if (textBox1.Text != null && textBox1.Text.Trim() != "" && textBox2.Text != null && textBox2.Text.Trim() != "" && textBox3.Text != null && textBox3.Text.Trim() != "")
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());

                            object status = cmd.ExecuteScalar();
                            if (status.ToString() == "Berhasil Menambahkan Data")
                            {
                                MessageBox.Show(status.ToString(), "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadData();
                            }
                            else
                            {
                                MessageBox.Show(status.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clearForm();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearForm();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            adminpage admin = new adminpage(namaAdmin, username, "admin");
            admin.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
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

                        string session_query = "EXEC sp_set_session_context @key, @value";
                        using (SqlCommand cmd = new SqlCommand(session_query, conn))
                        {
                            cmd.Parameters.AddWithValue("@key", "nama_admin");
                            cmd.Parameters.AddWithValue("@value", namaAdmin);

                            cmd.ExecuteNonQuery();
                        }

                        string query = "EXEC update_karyawan @nama, @username, @password, @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBox3.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", textBox4.Text.Trim());

                            object status = cmd.ExecuteScalar();
                            if (status.ToString() == "Berhasil Mengubah Data")
                            {
                                MessageBox.Show(status.ToString(), "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearForm();
                                loadData();
                            }
                            else
                            {
                                MessageBox.Show(status.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clearForm();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearForm();
                    }

                }
            }
            else
            {
                MessageBox.Show("Username atau nama tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah yakin ingin menghapus data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (textBox4.Text != null && textBox4.Text.Trim() != "")
                {
                    using (SqlConnection conn = new SqlConnection(connectionStirng))
                    {
                        try
                        {
                            conn.Open();

                            string session_query = "EXEC sp_set_session_context @key, @value";
                            using (SqlCommand cmd = new SqlCommand(session_query, conn))
                            {
                                cmd.Parameters.AddWithValue("@key", "nama_admin");
                                cmd.Parameters.AddWithValue("@value", namaAdmin);

                                cmd.ExecuteNonQuery();
                            }

                            string query = "EXEC delete_karyawan @id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", textBox4.Text.Trim());

                                object status = cmd.ExecuteScalar();
                                if (status.ToString() == "Berhasil menghapus data")
                                {
                                    MessageBox.Show(status.ToString(), "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearForm();
                                    loadData();
                                }
                                else
                                {
                                    MessageBox.Show(status.ToString(), "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    clearForm();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih karyawan yang ingin dihapus terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
