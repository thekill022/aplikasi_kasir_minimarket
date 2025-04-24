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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aplikasi_kasir_minimarket
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataToDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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
                catch (Exception e)
                {
                    MessageBox.Show("Error : " + e.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
