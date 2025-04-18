namespace aplikasi_kasir_minimarket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(277, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 38);
            label1.TabIndex = 0;
            label1.Text = "Manajemen Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 98);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Kategori";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 321);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 3;
            label3.Text = "Daftar Kategori Produk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 233);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 4;
            label4.Text = "Tindakan";
            // 
            // button1
            // 
            button1.Location = new Point(277, 229);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(423, 231);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(570, 232);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(660, 167);
            dataGridView1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 149);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 10;
            label6.Text = "Nama Baru";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 31);
            textBox2.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(280, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(258, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Apakah Ingin Mengupdate?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox textBox2;
        private CheckBox checkBox1;
    }
}
