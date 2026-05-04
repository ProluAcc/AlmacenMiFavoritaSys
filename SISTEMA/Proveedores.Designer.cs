namespace SISTEMA
{
    partial class Proveedores
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
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            button7 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 23);
            textBox5.TabIndex = 79;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(92, 266);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 78;
            comboBox2.Text = "Código RUC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 269);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 77;
            label7.Text = "Buscar por:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox4.Location = new Point(12, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 76;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 23);
            textBox3.TabIndex = 75;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 74;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(69, 69, 255);
            button2.Location = new Point(191, 227);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 73;
            button2.Text = "✖️CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 69, 255);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(53, 227);
            button1.Name = "button1";
            button1.Size = new Size(99, 25);
            button1.TabIndex = 72;
            button1.Text = "✔️GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(230, 161);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 71;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(53, 161);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 70;
            label4.Text = "Dirección ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(217, 95);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 69;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 68;
            label2.Text = "Nombre del proveedor:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5 });
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(12, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 287);
            dataGridView1.TabIndex = 67;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del proveedor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dirección";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // Column4
            // 
            Column4.HeaderText = "Teléfono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 66;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 69, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1339, 77);
            panel3.TabIndex = 81;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(23, 23, 255);
            button7.Location = new Point(636, 20);
            button7.Name = "button7";
            button7.Size = new Size(80, 36);
            button7.TabIndex = 19;
            button7.Text = "Inicio";
            button7.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 20);
            label6.Name = "label6";
            label6.Size = new Size(259, 32);
            label6.TabIndex = 10;
            label6.Text = "NUEVO PROVEEDOR:";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1341, 707);
            Controls.Add(textBox5);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Panel panel3;
        private Button button7;
        private Label label6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}