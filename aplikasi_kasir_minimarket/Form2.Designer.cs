namespace aplikasi_kasir_minimarket
{
    partial class Form2
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
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(294, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(258, 29);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Apakah Ingin Mengupdate?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 31);
            textBox2.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 145);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 22;
            label6.Text = "Nama Baru";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(660, 167);
            dataGridView1.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(584, 228);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 20;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(437, 227);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 19;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(291, 225);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 231);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 17;
            label4.Text = "Tindakan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 317);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 16;
            label3.Text = "Daftar Kategori Produk";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 31);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 94);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 14;
            label2.Text = "Nama Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(291, 19);
            label1.Name = "label1";
            label1.Size = new Size(274, 38);
            label1.TabIndex = 13;
            label1.Text = "Manajemen Kategori";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
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
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}