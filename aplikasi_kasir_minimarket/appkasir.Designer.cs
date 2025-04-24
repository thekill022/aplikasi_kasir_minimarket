namespace aplikasi_kasir_minimarket
{
    partial class appkasir
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 0;
            label1.Text = "Aplikasi Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 18);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "< Back";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(436, 227);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 121);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 4;
            label4.Text = "Jumlah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 159);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 5;
            label5.Text = "harga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 194);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 6;
            label6.Text = "Sub-total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 191);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 152);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(193, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 31);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 79);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(193, 31);
            textBox4.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 373);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(748, 144);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(15, 338);
            label8.Name = "label8";
            label8.Size = new Size(157, 32);
            label8.TabIndex = 14;
            label8.Text = "Barang Dibeli";
            // 
            // button1
            // 
            button1.Location = new Point(20, 263);
            button1.Name = "button1";
            button1.Size = new Size(285, 34);
            button1.TabIndex = 15;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 300);
            button2.Name = "button2";
            button2.Size = new Size(137, 34);
            button2.TabIndex = 16;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(163, 300);
            button3.Name = "button3";
            button3.Size = new Size(142, 34);
            button3.TabIndex = 17;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 524);
            button4.Name = "button4";
            button4.Size = new Size(209, 34);
            button4.TabIndex = 18;
            button4.Text = "Tambah Transaksi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(327, 51);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Cari Produk.....";
            textBox6.Size = new Size(327, 31);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(660, 48);
            button5.Name = "button5";
            button5.Size = new Size(103, 34);
            button5.TabIndex = 20;
            button5.Text = "Cari";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(533, 321);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 21;
            button6.Text = "Tunai";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(651, 321);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 22;
            button7.Text = "Non-Tunai";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(112, 228);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(193, 31);
            textBox5.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 231);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 23;
            label7.Text = "Metode";
            // 
            // appkasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "appkasir";
            Text = "Aplikasi Kasir";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView2;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox5;
        private Label label7;
    }
}