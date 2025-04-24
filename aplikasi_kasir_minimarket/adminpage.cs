using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_kasir_minimarket
{
    public partial class adminpage : Form
    {
        private string namaAdmin;
        private string username;
        public adminpage(string namaAdmin, string username, string roleAdmin)
        {
            InitializeComponent();
            this.namaAdmin = namaAdmin;
            this.username = username;
            label1.Text = namaAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addkaryawan karyawan = new addkaryawan(namaAdmin, username);
            karyawan.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            addkategori kategori = new addkategori(namaAdmin, username);
            kategori.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addproduct produk = new addproduct(namaAdmin, username);
            produk.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            riwayattransaksi transaksi = new riwayattransaksi(namaAdmin, username);
            transaksi.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            grafik Grafik = new grafik(namaAdmin, username);
            Grafik.Show();
            this.Close();
        }
    }
}
