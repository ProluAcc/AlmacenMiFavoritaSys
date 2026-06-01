namespace caja
{
    partial class Caja
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(333, 20);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(69, 69, 210);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(978, 64);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(889, 14);
            button1.Name = "button1";
            button1.Size = new Size(78, 36);
            button1.TabIndex = 4;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(401, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(70, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(69, 69, 210);
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(212, 160);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 5;
            button3.Text = "Abrir Caja";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(200, 56, 56);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(3, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 266);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(535, 238);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Concepto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Monto";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Saldo";
            Column4.Name = "Column4";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(69, 69, 210);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(12, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 161);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox6.Location = new Point(251, 120);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox5.Location = new Point(251, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox4.Location = new Point(251, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox3.Location = new Point(251, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 27);
            textBox3.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(144, 123);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 3;
            label11.Text = "Saldo Final";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(144, 87);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 2;
            label10.Text = "Total Egresos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(144, 53);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 1;
            label9.Text = "Total Ingreso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(144, 23);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 0;
            label8.Text = "Saldo Inicial";
            label8.Click += label8_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(69, 69, 210);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button2);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(451, 354);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(258, 94);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opciones de Caja";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(24, 24);
            button4.Name = "button4";
            button4.Size = new Size(95, 56);
            button4.TabIndex = 6;
            button4.Text = "Arqueo de Caja";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(140, 24);
            button2.Name = "button2";
            button2.Size = new Size(95, 56);
            button2.TabIndex = 5;
            button2.Text = "Cierre de Caja";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(566, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 209);
            panel1.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox8.Location = new Point(119, 91);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(190, 27);
            textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox7.Location = new Point(119, 127);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(190, 27);
            textBox7.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(9, 56);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 11;
            label7.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(9, 94);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 10;
            label6.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(8, 130);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "Concepto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 69, 210);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 43);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(66, 6);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 8;
            label3.Text = "Registrar Movimiento";
            label3.Click += label3_Click;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(975, 527);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caja";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private TextBox textBox8;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}
