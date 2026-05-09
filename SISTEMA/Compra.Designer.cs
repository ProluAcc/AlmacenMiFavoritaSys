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
            button3 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel11 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnInicio = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 69, 210);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 50);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(790, 6);
            button3.Name = "button3";
            button3.Size = new Size(157, 34);
            button3.TabIndex = 1;
            button3.Text = "Nuevo proveedor";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(615, 7);
            button1.Name = "button1";
            button1.Size = new Size(154, 34);
            button1.TabIndex = 4;
            button1.Text = "Buscar Proveedor ";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(366, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Suministros ABX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(311, 14);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.Location = new Point(106, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "000432";
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
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 286);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(0, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Producto";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "IVA";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Subtotal";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
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
            panel8.Location = new Point(3, 356);
            panel8.Name = "panel8";
            panel8.Size = new Size(904, 104);
            panel8.TabIndex = 5;
            panel8.Paint += panel8_Paint;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(69, 69, 210);
            textBox8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox8.ForeColor = SystemColors.InactiveBorder;
            textBox8.Location = new Point(709, 70);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(185, 27);
            textBox8.TabIndex = 5;
            textBox8.Text = "1,029.75";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox7.Location = new Point(709, 40);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(185, 27);
            textBox7.TabIndex = 4;
            textBox7.Text = "129.75";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox5.Location = new Point(709, 9);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 27);
            textBox5.TabIndex = 3;
            textBox5.Text = "900.00                    129.75";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(599, 70);
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
            label9.Location = new Point(666, 43);
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
            label8.Location = new Point(634, 12);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 0;
            label8.Text = "Subtotal:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(69, 69, 210);
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(btnInicio);
            panel11.Controls.Add(button6);
            panel11.Controls.Add(button5);
            panel11.Controls.Add(button4);
            panel11.Location = new Point(3, 466);
            panel11.Name = "panel11";
            panel11.Size = new Size(972, 59);
            panel11.TabIndex = 6;
            panel11.Paint += panel11_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(69, 69, 210);
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(786, 12);
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
            button5.Location = new Point(682, 12);
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
            button4.Location = new Point(533, 12);
            button4.Name = "button4";
            button4.Size = new Size(140, 34);
            button4.TabIndex = 0;
            button4.Text = "Guardar compra";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ControlLight;
            btnInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInicio.ForeColor = Color.FromArgb(69, 69, 210);
            btnInicio.Location = new Point(8, 12);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(97, 34);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 223, 96);
            ClientSize = new Size(975, 527);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button3;
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
    }
}
