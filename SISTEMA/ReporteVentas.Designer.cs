namespace SISTEMA
{
    partial class ReporteVentas
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "REPORTE DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Inicio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(107, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(107, 51);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(97, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(23, 53);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha Fin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(226, 19);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(210, 53);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Producto:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(293, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(293, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(303, 83);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 10;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(443, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 122);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(6, 19);
            button2.Name = "button2";
            button2.Size = new Size(189, 39);
            button2.TabIndex = 11;
            button2.Text = "\U0001f9eeEXPORTAR EXCEL";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(207, 19);
            button3.Name = "button3";
            button3.Size = new Size(168, 39);
            button3.TabIndex = 12;
            button3.Text = "📄EXPORTAR PDF";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(6, 70);
            button4.Name = "button4";
            button4.Size = new Size(140, 39);
            button4.TabIndex = 13;
            button4.Text = "🖨️IMPRIMIR";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Factura";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cliente";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Producto";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio Unitario";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Descuento";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Total";
            Column8.Name = "Column8";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 358);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 50);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(5, 12);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 11;
            label6.Text = "Total de Facturas: 0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(615, 12);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 12;
            label7.Text = "Total Ventas: C$0";
            // 
            // ReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteVentas";
            Text = "ReporteVentas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Panel panel2;
        private Label label7;
        private Label label6;
    }
}