namespace Registro_de_compra
{
    partial class Compra
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
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel8 = new Panel();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel11 = new Panel();
            btnInicio = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            panel3 = new Panel();
            button3 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 69, 210);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 50);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(723, 7);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 4;
            button1.Text = "Aceptar ";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.Location = new Point(106, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "No. Compra:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(200, 56, 56);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(1, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 186);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(0, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 164);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(200, 56, 56);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBox8);
            panel8.Controls.Add(textBox7);
            panel8.Controls.Add(textBox5);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(1, 405);
            panel8.Name = "panel8";
            panel8.Size = new Size(487, 120);
            panel8.TabIndex = 5;
            panel8.Paint += panel8_Paint;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(69, 69, 210);
            textBox8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox8.ForeColor = SystemColors.InactiveBorder;
            textBox8.Location = new Point(286, 67);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(185, 27);
            textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox7.Location = new Point(286, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(185, 27);
            textBox7.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox5.Location = new Point(286, 6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 27);
            textBox5.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(176, 70);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 2;
            label10.Text = "Total Compra:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(243, 40);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 1;
            label9.Text = "IVA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(211, 9);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 0;
            label8.Text = "Subtotal:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(69, 69, 210);
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(button6);
            panel11.Controls.Add(button4);
            panel11.Location = new Point(494, 405);
            panel11.Name = "panel11";
            panel11.Size = new Size(220, 95);
            panel11.TabIndex = 6;
            panel11.Paint += panel11_Paint;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ControlLight;
            btnInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.FromArgb(69, 69, 210);
            btnInicio.Location = new Point(876, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(86, 34);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(18, 49);
            button6.Name = "button6";
            button6.Size = new Size(180, 34);
            button6.TabIndex = 2;
            button6.Text = "Imprimir Comprobante";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(765, 93);
            button5.Name = "button5";
            button5.Size = new Size(97, 34);
            button5.TabIndex = 1;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(34, 9);
            button4.Name = "button4";
            button4.Size = new Size(140, 34);
            button4.TabIndex = 0;
            button4.Text = "Guardar compra";
            button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(422, 15);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Proveedor:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(512, 11);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 69, 210);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 145);
            panel3.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(662, 93);
            button3.Name = "button3";
            button3.Size = new Size(97, 34);
            button3.TabIndex = 4;
            button3.Text = "Ingresar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(287, 15);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 2;
            label5.Text = "Fecha de Entrega:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox2.Location = new Point(142, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 27);
            textBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(7, 15);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 0;
            label6.Text = "Fecha de Compra:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox3.Location = new Point(422, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox4.Location = new Point(274, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 27);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(201, 15);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox6.Location = new Point(721, 11);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 27);
            textBox6.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(567, 15);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 6;
            label4.Text = "Número de Factura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 52);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 8;
            label7.Text = "Producto:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox9.Location = new Point(422, 52);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(139, 27);
            textBox9.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(344, 54);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 9;
            label11.Text = "Cantidad:";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox10.Location = new Point(721, 51);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(139, 27);
            textBox10.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(581, 54);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 11;
            label12.Text = "Precio de compra:";
            // 
            // Column1
            // 
            Column1.HeaderText = "No. Compra";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "No. Factura";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha de Compra";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha de Entrega";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Producto";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cantidad";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio de Compra";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Subtotal";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "IVA";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Total";
            Column10.Name = "Column10";
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 96);
            ClientSize = new Size(975, 527);
            Controls.Add(panel3);
            Controls.Add(panel11);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compra";
            Text = "Registro de compra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel11.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel8;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private Panel panel11;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnInicio;
        private ComboBox comboBox2;
        private Label label3;
        private Panel panel3;
        private Button button3;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox9;
        private Label label11;
        private ComboBox comboBox1;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
