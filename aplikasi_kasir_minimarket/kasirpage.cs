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
    public partial class kasirpage : Form
    {
        private string nama;
        private string username;
        public kasirpage(string nama, string username, string role)
        {
            InitializeComponent();
            this.nama = nama;
            this.username = username;
            label1.Text = nama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            appkasir kasir = new appkasir(nama, username);
            kasir.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            updatestok update = new updatestok(nama, username);
            update.Show();
            this.Close();
        }
    }
}
