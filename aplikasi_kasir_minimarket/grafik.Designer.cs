namespace aplikasi_kasir_minimarket
{
    partial class grafik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            Dari = new Label();
            sampai = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(281, 22);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 4;
            label1.Text = "Grafik Pendapatan";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(225, 63);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 5;
            button1.Text = "Laporan Bulanan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(390, 63);
            button2.Name = "button2";
            button2.Size = new Size(192, 34);
            button2.TabIndex = 6;
            button2.Text = "Laporan Tahunan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 7;
            label2.Text = "< Back";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(94, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(400, 103);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 9;
            // 
            // Dari
            // 
            Dari.AutoSize = true;
            Dari.Location = new Point(44, 103);
            Dari.Name = "Dari";
            Dari.Size = new Size(44, 25);
            Dari.TabIndex = 10;
            Dari.Text = "Dari";
            // 
            // sampai
            // 
            sampai.AutoSize = true;
            sampai.Location = new Point(706, 105);
            sampai.Name = "sampai";
            sampai.Size = new Size(71, 25);
            sampai.TabIndex = 11;
            sampai.Text = "Sampai";
            // 
            // grafik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(sampai);
            Controls.Add(Dari);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "grafik";
            Text = "Grafik Penjualan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label Dari;
        private Label sampai;
    }
}