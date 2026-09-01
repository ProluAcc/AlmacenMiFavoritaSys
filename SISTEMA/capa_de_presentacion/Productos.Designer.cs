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
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            CBbuscar = new ComboBox();
            TXTbuscar = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column9, Column6, Column10 });
            dataGridView1.Location = new Point(-1, 207);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(218, 162);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 106;
            label1.Text = "Buscar por:";
            // 
            // CBbuscar
            // 
            CBbuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CBbuscar.FormattingEnabled = true;
            CBbuscar.Location = new Point(313, 159);
            CBbuscar.Name = "CBbuscar";
            CBbuscar.Size = new Size(90, 28);
            CBbuscar.TabIndex = 107;
            // 
            // TXTbuscar
            // 
            TXTbuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TXTbuscar.Location = new Point(409, 159);
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
            button3.Location = new Point(640, 155);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 109;
            button3.Text = "🔍BUSCAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(344, 90);
            button4.Name = "button4";
            button4.Size = new Size(128, 35);
            button4.TabIndex = 115;
            button4.Text = "➕AGREGAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(478, 90);
            button5.Name = "button5";
            button5.Size = new Size(132, 35);
            button5.TabIndex = 116;
            button5.Text = "✏️EDITAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonFace;
            button9.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(69, 69, 210);
            button9.Location = new Point(882, 16);
            button9.Name = "button9";
            button9.Size = new Size(73, 35);
            button9.TabIndex = 119;
            button9.Text = "AYUDA";
            button9.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(959, 469);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(TXTbuscar);
            Controls.Add(CBbuscar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Label label1;
        private ComboBox CBbuscar;
        private TextBox TXTbuscar;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button9;
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
    }
}