namespace aplikasi_kasir_minimarket
{
    partial class updatestok
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 76);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(264, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(264, 24);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 2;
            label1.Text = "Update Stok Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 80);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 134);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 5;
            label3.Text = "Stok Masuk";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 31);
            textBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(736, 225);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(34, 217);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Cari Produk....";
            textBox3.Size = new Size(264, 31);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(304, 213);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 165);
            button2.Name = "button2";
            button2.Size = new Size(376, 34);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 24);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 10;
            label4.Text = "< Back";
            label4.Click += label4_Click;
            // 
            // updatestok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "updatestok";
            Text = "Update Stok";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}