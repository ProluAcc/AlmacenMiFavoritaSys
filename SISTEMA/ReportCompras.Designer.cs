namespace SISTEMA
{
    partial class ReportCompras
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(504, 577);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 576);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(951, 284);
            dataGridView1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(-5, -27);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 75);
            panel2.TabIndex = 35;
            panel2.Paint += panel2_Paint_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(902, 32);
            button1.Name = "button1";
            button1.Size = new Size(73, 35);
            button1.TabIndex = 58;
            button1.Text = "AYUDA";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(18, 35);
            label7.Name = "label7";
            label7.Size = new Size(287, 32);
            label7.TabIndex = 0;
            label7.Text = "REPORTE DE COMPRAS";
            label7.Click += label7_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 160);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(342, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(108, 23);
            dateTimePicker2.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(127, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 55;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(372, 105);
            button6.Name = "button6";
            button6.Size = new Size(111, 43);
            button6.TabIndex = 51;
            button6.Text = "🔍BUSCAR";
            button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 50;
            label1.Text = "Proveedor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(260, 29);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 49;
            label9.Text = "Fecha fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 48;
            label2.Text = "Fecha de inicio:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 66);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(12, 576);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 55;
            label3.Text = "Total de compras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(375, 576);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 56;
            label4.Text = "Total comprado:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(878, 576);
            button4.Name = "button4";
            button4.Size = new Size(96, 33);
            button4.TabIndex = 57;
            button4.Text = "Cerrar";
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(507, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 87);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(248, 22);
            button5.Name = "button5";
            button5.Size = new Size(103, 50);
            button5.TabIndex = 54;
            button5.Text = "🖨IMPRIMIR";
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(6, 22);
            button7.Name = "button7";
            button7.Size = new Size(117, 50);
            button7.TabIndex = 53;
            button7.Text = "\U0001f9feExportar PDF";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(69, 69, 210);
            button8.Location = new Point(129, 22);
            button8.Name = "button8";
            button8.Size = new Size(113, 50);
            button8.TabIndex = 52;
            button8.Text = "🗄Exportar Excel";
            button8.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(260, 66);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 57;
            label5.Text = "No. Compra:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(359, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 27);
            textBox1.TabIndex = 58;
            // 
            // Column1
            // 
            Column1.HeaderText = "n° de compra";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Proveedor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Producto";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 115;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio unitario";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // Column7
            // 
            Column7.HeaderText = "Subtotal";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 120;
            // 
            // Column8
            // 
            Column8.HeaderText = "Total";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 120;
            // 
            // ReportCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportCompras";
            Load += ReportCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private GroupBox groupBox1;
        private Button button6;
        private Label label1;
        private Label label9;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox2;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button1;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox textBox1;
    }
}