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
            button6 = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
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
            label1.ForeColor = Color.Black;
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
            label2.ForeColor = Color.Black;
            label2.Location = new Point(190, 20);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 64);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(891, 14);
            button6.Name = "button6";
            button6.Size = new Size(73, 35);
            button6.TabIndex = 18;
            button6.Text = "AYUDA";
            button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDolar.ForeColor = Color.Black;
            lblDolar.Location = new Point(615, 21);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(235, 20);
            lblDolar.TabIndex = 16;
            lblDolar.Text = "Cambio de Dólar: $1 -> C$37.50";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(67, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
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
            // Column3
            // 
            Column3.HeaderText = "Monto";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Concepto";
            Column2.Name = "Column2";
            Column2.Width = 290;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(12, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 161);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(117, 83);
            label15.Name = "label15";
            label15.Size = new Size(18, 20);
            label15.TabIndex = 9;
            label15.Text = "$";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(6, 83);
            label16.Name = "label16";
            label16.Size = new Size(105, 20);
            label16.TabIndex = 8;
            label16.Text = "Total Ingreso:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(362, 19);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 7;
            label14.Text = "C$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(114, 113);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 6;
            label13.Text = "C$";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(117, 53);
            label12.Name = "label12";
            label12.Size = new Size(27, 20);
            label12.TabIndex = 5;
            label12.Text = "C$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(117, 19);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 4;
            label7.Text = "C$";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(268, 19);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 3;
            label11.Text = "Saldo Final:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 2;
            label10.Text = "Total Egresos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(6, 53);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 1;
            label9.Text = "Total Ingreso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 19);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 0;
            label8.Text = "Saldo Inicial:";
            label8.Click += label8_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button2);
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(567, 283);
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
            button4.Location = new Point(11, 24);
            button4.Name = "button4";
            button4.Size = new Size(110, 49);
            button4.TabIndex = 6;
            button4.Text = "💲ARQUEO";
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
            button2.Size = new Size(101, 49);
            button2.TabIndex = 5;
            button2.Text = "🗄CIERRE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(566, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 181);
            panel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(10, 126);
            button5.Name = "button5";
            button5.Size = new Size(192, 36);
            button5.TabIndex = 16;
            button5.Text = "🗄CONTROL EGRESOS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(208, 126);
            button1.Name = "button1";
            button1.Size = new Size(143, 36);
            button1.TabIndex = 15;
            button1.Text = "💾GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox8.Location = new Point(90, 54);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(132, 27);
            textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox7.Location = new Point(90, 93);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(261, 27);
            textBox7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(29, 57);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 10;
            label6.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(11, 93);
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
            panel2.Size = new Size(363, 43);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(93, 8);
            label3.Name = "label3";
            label3.Size = new Size(186, 25);
            label3.TabIndex = 8;
            label3.Text = "Crear Egreso de Caja";
            label3.Click += label3_Click;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
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
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox7;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button6;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Label label15;
        private Label label16;
    }
}
