namespace Inventario
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 1;
            label1.Text = "INVENTARIO";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(4, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 90);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de Búsqueda";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(642, 34);
            button3.Name = "button3";
            button3.Size = new Size(145, 35);
            button3.TabIndex = 18;
            button3.Text = "♻️ACTUALIZAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(526, 34);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 17;
            button2.Text = "🗑️LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkBox1.Location = new Point(379, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 24);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Solo stock abajo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(272, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(101, 28);
            comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 28);
            comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(292, 19);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(165, 19);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 3;
            label6.Text = "Categoria:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(114, 42);
            button1.Name = "button1";
            button1.Size = new Size(41, 27);
            button1.TabIndex = 3;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(8, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 19);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 0;
            label3.Text = "Buscar Productos:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(3, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(970, 273);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Productos de Inventario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column10, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.Location = new Point(5, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(959, 245);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Producto";
            Column2.Name = "Column2";
            // 
            // Column10
            // 
            Column10.HeaderText = "Stock Máximo";
            Column10.Name = "Column10";
            // 
            // Column3
            // 
            Column3.HeaderText = "Stock Actual";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock Minimo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Medida";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio Venta";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Valor Total";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Acciones";
            Column9.Name = "Column9";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button4);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(3, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 84);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(150, 22);
            button7.Name = "button7";
            button7.Size = new Size(138, 38);
            button7.TabIndex = 19;
            button7.Text = "Imprimir reporte";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(9, 22);
            button4.Name = "button4";
            button4.Size = new Size(135, 38);
            button4.TabIndex = 18;
            button4.Text = "Exportar a Excel";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 46);
            panel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(889, 4);
            button5.Name = "button5";
            button5.Size = new Size(73, 35);
            button5.TabIndex = 18;
            button5.Text = "AYUDA";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Inventario";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button4;
        private Button button7;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button5;
    }
}