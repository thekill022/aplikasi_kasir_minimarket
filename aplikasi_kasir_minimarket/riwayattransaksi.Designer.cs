namespace aplikasi_kasir_minimarket
{
    partial class riwayattransaksi
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(279, 38);
            label1.Name = "label1";
            label1.Size = new Size(232, 38);
            label1.TabIndex = 3;
            label1.Text = "Riwayat Transaksi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 91);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "ID Transaksi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 88);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(227, 125);
            button1.Name = "button1";
            button1.Size = new Size(168, 34);
            button1.TabIndex = 6;
            button1.Text = "Hapus Transaksi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(303, 225);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(402, 125);
            button2.Name = "button2";
            button2.Size = new Size(168, 34);
            button2.TabIndex = 8;
            button2.Text = "Lihat Detail";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 25);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 9;
            label3.Text = "< Back";
            label3.Click += label3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(434, 213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(303, 225);
            dataGridView2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 185);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 12;
            label5.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 185);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 13;
            label4.Text = "Transaksi";
            // 
            // riwayattransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "riwayattransaksi";
            Text = "Riwayat Transaksi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label3;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label4;
    }
}