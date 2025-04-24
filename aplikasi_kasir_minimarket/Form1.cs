using System.Data;
using System.Data.SqlClient;

namespace aplikasi_kasir_minimarket;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form3 form3 = new Form3();
        form3.Show();
        this.Hide();
    }

}

