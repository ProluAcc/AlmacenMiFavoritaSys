namespace Pantalla_ventas
{
    partial class Ventas
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBox3 = new GroupBox();
            btnInicio = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(69, 69, 210);
            groupBox1.Controls.Add(btnInicio);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(973, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(615, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(444, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(557, 24);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(326, 23);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "No. de factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(200, 56, 56);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(2, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(540, 59);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 7;
            button2.Text = "❌Descartar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 69, 210);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(417, 59);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 6;
            button1.Text = "🔽Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(531, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(101, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(367, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(470, 21);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(288, 21);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "Cantidad:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Productos:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(2, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(945, 268);
            dataGridView1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 22);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 3;
            label7.Text = "Total a pagar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(247, 23);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 4;
            label8.Text = "Monto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 39);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(659, 15);
            button3.Name = "button3";
            button3.Size = new Size(101, 35);
            button3.TabIndex = 6;
            button3.Text = "🔃Cambio";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(444, 23);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 7;
            label10.Text = "IVA";
            label10.Click += label10_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(482, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(108, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(132, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(312, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(126, 23);
            textBox8.TabIndex = 10;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(69, 69, 210);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(2, 463);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(973, 63);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ControlLight;
            btnInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.FromArgb(69, 69, 210);
            btnInicio.Location = new Point(860, 17);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(101, 35);
            btnInicio.TabIndex = 11;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "No. de factura";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha:";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Productos";
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 96);
            ClientSize = new Size(975, 527);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button3;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private GroupBox groupBox3;
        private Button btnInicio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
