namespace SISTEMA
{
    partial class Productos
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
            button2 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            TXTprecioc = new TextBox();
            TXTnombre = new TextBox();
            TXTpreciov = new TextBox();
            TXTcodigo = new TextBox();
            CBcategoria = new ComboBox();
            CBtalla = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            TXTdescripcion = new TextBox();
            label1 = new Label();
            CBbuscar = new ComboBox();
            TXTbuscar = new TextBox();
            button3 = new Button();
            TXTstockmax = new TextBox();
            label12 = new Label();
            TXTstockmin = new TextBox();
            label13 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            CBmarca = new ComboBox();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(832, 209);
            button2.Name = "button2";
            button2.Size = new Size(128, 35);
            button2.TabIndex = 103;
            button2.Text = "🗑LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(698, 209);
            button7.Name = "button7";
            button7.Size = new Size(128, 35);
            button7.TabIndex = 102;
            button7.Text = "✔️GUARDAR";
            button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column9, Column6, Column10 });
            dataGridView1.Location = new Point(7, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(956, 256);
            dataGridView1.TabIndex = 100;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del Producto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Talla";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Marca";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Descripción";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Precio Venta";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Precio Compra";
            Column9.Name = "Column9";
            // 
            // Column6
            // 
            Column6.HeaderText = "Stock Máximo";
            Column6.Name = "Column6";
            Column6.Width = 60;
            // 
            // Column10
            // 
            Column10.HeaderText = "Stock Mínimo";
            Column10.Name = "Column10";
            Column10.Width = 60;
            // 
            // TXTprecioc
            // 
            TXTprecioc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTprecioc.Location = new Point(401, 160);
            TXTprecioc.Name = "TXTprecioc";
            TXTprecioc.Size = new Size(115, 27);
            TXTprecioc.TabIndex = 98;
            // 
            // TXTnombre
            // 
            TXTnombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTnombre.Location = new Point(138, 91);
            TXTnombre.Name = "TXTnombre";
            TXTnombre.Size = new Size(225, 27);
            TXTnombre.TabIndex = 97;
            // 
            // TXTpreciov
            // 
            TXTpreciov.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTpreciov.Location = new Point(283, 161);
            TXTpreciov.Name = "TXTpreciov";
            TXTpreciov.Size = new Size(100, 27);
            TXTpreciov.TabIndex = 96;
            // 
            // TXTcodigo
            // 
            TXTcodigo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTcodigo.Location = new Point(16, 92);
            TXTcodigo.Name = "TXTcodigo";
            TXTcodigo.Size = new Size(100, 27);
            TXTcodigo.TabIndex = 94;
            // 
            // CBcategoria
            // 
            CBcategoria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Items.AddRange(new object[] { "" });
            CBcategoria.Location = new Point(379, 90);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(137, 28);
            CBcategoria.TabIndex = 93;
            CBcategoria.SelectedIndexChanged += CBcategoria_SelectedIndexChanged;
            // 
            // CBtalla
            // 
            CBtalla.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CBtalla.FormattingEnabled = true;
            CBtalla.Items.AddRange(new object[] { "" });
            CBtalla.Location = new Point(574, 90);
            CBtalla.Name = "CBtalla";
            CBtalla.Size = new Size(105, 28);
            CBtalla.TabIndex = 90;
            CBtalla.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.Location = new Point(749, 68);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 89;
            label11.Text = "Marca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.Location = new Point(577, 68);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 88;
            label10.Text = "Talla";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(379, 69);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 87;
            label9.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(401, 136);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 85;
            label7.Text = "Precio Compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(283, 136);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 84;
            label6.Text = "Precio Venta";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(138, 70);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 83;
            label5.Text = "Nombre del Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(16, 135);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 82;
            label4.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(35, 69);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 81;
            label3.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(240, 32);
            label2.TabIndex = 80;
            label2.Text = "NUEVO PRODUCTO";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Enabled = false;
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(976, 61);
            button1.TabIndex = 99;
            button1.UseVisualStyleBackColor = false;
            // 
            // TXTdescripcion
            // 
            TXTdescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTdescripcion.Location = new Point(16, 161);
            TXTdescripcion.Name = "TXTdescripcion";
            TXTdescripcion.Size = new Size(240, 27);
            TXTdescripcion.TabIndex = 105;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(16, 216);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 106;
            label1.Text = "Buscar por:";
            // 
            // CBbuscar
            // 
            CBbuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CBbuscar.FormattingEnabled = true;
            CBbuscar.Location = new Point(111, 213);
            CBbuscar.Name = "CBbuscar";
            CBbuscar.Size = new Size(90, 28);
            CBbuscar.TabIndex = 107;
            // 
            // TXTbuscar
            // 
            TXTbuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTbuscar.Location = new Point(207, 213);
            TXTbuscar.Name = "TXTbuscar";
            TXTbuscar.Size = new Size(225, 27);
            TXTbuscar.TabIndex = 108;
            TXTbuscar.TextChanged += textBox6_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(438, 209);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 109;
            button3.Text = "🔍BUSCAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TXTstockmax
            // 
            TXTstockmax.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTstockmax.Location = new Point(539, 160);
            TXTstockmax.Name = "TXTstockmax";
            TXTstockmax.Size = new Size(115, 27);
            TXTstockmax.TabIndex = 112;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.Location = new Point(539, 136);
            label12.Name = "label12";
            label12.Size = new Size(108, 20);
            label12.TabIndex = 111;
            label12.Text = "Stock Máximo";
            // 
            // TXTstockmin
            // 
            TXTstockmin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTstockmin.Location = new Point(675, 160);
            TXTstockmin.Name = "TXTstockmin";
            TXTstockmin.Size = new Size(115, 27);
            TXTstockmin.TabIndex = 114;
            TXTstockmin.TextChanged += TXTstockmin_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(675, 136);
            label13.Name = "label13";
            label13.Size = new Size(105, 20);
            label13.TabIndex = 113;
            label13.Text = "Stock Mínimo";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(814, 157);
            button4.Name = "button4";
            button4.Size = new Size(128, 35);
            button4.TabIndex = 115;
            button4.Text = "⬇️INGRESAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(587, 209);
            button5.Name = "button5";
            button5.Size = new Size(105, 35);
            button5.TabIndex = 116;
            button5.Text = "✏️EDITAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(524, 88);
            button6.Name = "button6";
            button6.Size = new Size(37, 29);
            button6.TabIndex = 117;
            button6.Text = "➕";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(69, 69, 210);
            button8.Location = new Point(688, 88);
            button8.Name = "button8";
            button8.Size = new Size(37, 29);
            button8.TabIndex = 118;
            button8.Text = "➕";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(69, 69, 210);
            button9.Location = new Point(890, 12);
            button9.Name = "button9";
            button9.Size = new Size(73, 35);
            button9.TabIndex = 119;
            button9.Text = "AYUDA";
            button9.UseVisualStyleBackColor = false;
            // 
            // CBmarca
            // 
            CBmarca.Font = new Font("Segoe UI", 11F);
            CBmarca.FormattingEnabled = true;
            CBmarca.Location = new Point(731, 88);
            CBmarca.Name = "CBmarca";
            CBmarca.Size = new Size(154, 28);
            CBmarca.TabIndex = 120;
            CBmarca.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonFace;
            button10.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button10.ForeColor = Color.FromArgb(69, 69, 210);
            button10.Location = new Point(890, 88);
            button10.Name = "button10";
            button10.Size = new Size(37, 29);
            button10.TabIndex = 121;
            button10.Text = "➕";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(button10);
            Controls.Add(CBmarca);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(TXTstockmin);
            Controls.Add(label13);
            Controls.Add(TXTstockmax);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(TXTbuscar);
            Controls.Add(CBbuscar);
            Controls.Add(label1);
            Controls.Add(TXTdescripcion);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(TXTprecioc);
            Controls.Add(TXTnombre);
            Controls.Add(TXTpreciov);
            Controls.Add(TXTcodigo);
            Controls.Add(CBcategoria);
            Controls.Add(CBtalla);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button7;
        private DataGridView dataGridView1;
        private TextBox TXTprecioc;
        private TextBox TXTnombre;
        private TextBox TXTpreciov;
        private TextBox TXTcodigo;
        private ComboBox CBcategoria;
        private ComboBox CBtalla;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox TXTdescripcion;
        private Label label1;
        private ComboBox CBbuscar;
        private TextBox TXTbuscar;
        private Button button3;
        private TextBox TXTstockmax;
        private Label label12;
        private TextBox TXTstockmin;
        private Label label13;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private ComboBox CBmarca;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column10;
        private Button button10;
    }
}