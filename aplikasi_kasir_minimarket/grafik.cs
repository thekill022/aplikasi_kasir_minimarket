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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;


namespace aplikasi_kasir_minimarket
{
    public partial class grafik : Form
    {
        string connectionString = "Data Source=LAPTOP-5DVR7M3S\\GFB_SERVER;Initial Catalog=KasirMinimarket;Integrated Security=True";
        private void chartBulanan()
        {
            Chart chart = new Chart();

            chart.Width = 500;
            chart.Height = 300;

            chart.Top = 150;
            chart.Left = 150;
            Title chartTitle = new Title("Pendapatan Bulanan", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black);
            chart.Titles.Add(chartTitle);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea); Series series = new Series("Pendapatan Harian");
            series.ChartType = SeriesChartType.Bar;
            series.Color = System.Drawing.Color.Blue;
            string query = @"
                SELECT 
                    CONVERT(DATE, tanggal_transaksi) AS Tanggal,
                    SUM(total_harga) AS TotalPendapatan
                FROM 
                    Riwayat_Transaksi
                WHERE 
                    tanggal_transaksi >= @StartDate AND tanggal_transaksi < @EndDate
                GROUP BY 
                    CONVERT(DATE, tanggal_transaksi)
                ORDER BY 
                    Tanggal;
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value.Date.AddDays(1));

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string tanggal = row["Tanggal"].ToString();
                    decimal totalPendapatan = Convert.ToDecimal(row["TotalPendapatan"]);
                    series.Points.AddXY(tanggal, totalPendapatan);
                }
            }
            chart.Series.Add(series);
            this.Controls.Add(chart);
        }

        private void chartTahunan()
        {
            Chart chart = new Chart();

            chart.Width = 500;
            chart.Height = 300;

            chart.Top = 150;
            chart.Left = 150;
            Title chartTitle = new Title("Pendapatan Tahunan", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black);
            chart.Titles.Add(chartTitle);

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea); Series series = new Series("Pendapatan Tahunan");
            series.ChartType = SeriesChartType.Bar;
            series.Color = System.Drawing.Color.Blue;
            string query = @"
                SELECT 
                    YEAR(tanggal_transaksi) AS Tahun, 
                    MONTH(tanggal_transaksi) AS Bulan, 
                    SUM(total_harga) AS TotalPendapatan
                FROM 
                    Riwayat_Transaksi
                WHERE 
                    tanggal_transaksi >= @StartDate AND tanggal_transaksi < @EndDate
                GROUP BY 
                    YEAR(tanggal_transaksi), MONTH(tanggal_transaksi)
                ORDER BY 
                    Tahun, Bulan;

            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", dateTimePicker2.Value.Date.AddDays(1));

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string bulan = "Bulan " + row["Bulan"].ToString() + " - " + row["Tahun"].ToString();
                    decimal totalPendapatan = Convert.ToDecimal(row["TotalPendapatan"]);
                    series.Points.AddXY(bulan, totalPendapatan);
                }
            }
            chart.Series.Add(series);
            this.Controls.Add(chart);
        }

        private string nama;
        private string username;
        public grafik(string nama, string username)
        {
            InitializeComponent();
            this.nama = nama;
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buat bersihin dulu
            Controls.OfType<Chart>().ToList().ForEach(c => c.Dispose());
            chartBulanan();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            adminpage admin = new adminpage(nama, username, "admin");
            admin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buat bersihin dulu
            Controls.OfType<Chart>().ToList().ForEach(c => c.Dispose());
            chartTahunan();
        }
    }
}
