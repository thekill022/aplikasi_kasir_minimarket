namespace aplikasi_kasir_minimarket
{
    partial class addproduct
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
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 1;
            label1.Text = "Manajemen Produk";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(142, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 31);
            textBox4.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 126);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 11;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 13;
            label2.Text = "Kategori";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 162);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(263, 31);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 211);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 14;
            label4.Text = "Harga";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 31);
            textBox2.TabIndex = 17;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 256);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 16;
            label5.Text = "Stok";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(332, 227);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 31);
            textBox3.TabIndex = 19;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(650, 71);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 20;
            label6.Text = "Pilih Kategori";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(47, 410);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(716, 166);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(42, 373);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 22;
            label7.Text = "Produk";
            // 
            // button1
            // 
            button1.Location = new Point(49, 292);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 23;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 292);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 24;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(305, 292);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 25;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 86);
            label8.Name = "label8";
            label8.Size = new Size(27, 25);
            label8.TabIndex = 26;
            label8.Text = "id";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(142, 78);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(263, 31);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(397, 373);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Cari Produk.....";
            textBox6.Size = new Size(263, 31);
            textBox6.TabIndex = 28;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(666, 370);
            button4.Name = "button4";
            button4.Size = new Size(97, 34);
            button4.TabIndex = 29;
            button4.Text = "Cari";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 15);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 30;
            label9.Text = "< Back";
            label9.Click += label9_Click;
            // 
            // addproduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "addproduct";
            Text = "Manajemen Produk";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button4;
        private Label label9;
    }
}