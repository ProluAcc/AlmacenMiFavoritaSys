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
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            panel9 = new Panel();
            textBox6 = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            comboBox2 = new ComboBox();
            label12 = new Label();
            panel7 = new Panel();
            button3 = new Button();
            button2 = new Button();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 59);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1069, 12);
            button1.Name = "button1";
            button1.Size = new Size(289, 34);
            button1.TabIndex = 4;
            button1.Text = "Buscar Proveedor ";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(504, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(513, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Suministros ABX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "000432";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "No. Compra:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(13, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 365);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(0, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1011, 348);
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(1052, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 223);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Crediticia del cliente";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label5);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(6, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 40);
            panel5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "C$7,500.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 11);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 2;
            label5.Text = "Disponible:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(6, 168);
            panel6.Name = "panel6";
            panel6.Size = new Size(324, 40);
            panel6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SpringGreen;
            label7.Location = new Point(208, 12);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 4;
            label7.Text = "Aprobado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 12);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Estado:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label4);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(6, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 40);
            panel4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "C$12,500.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 11);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Pendiente:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(6, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 40);
            panel3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "C$ 10,000.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Limite:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(panel9);
            groupBox2.Controls.Add(panel10);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(1052, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 136);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Crediticia del cliente";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(textBox6);
            panel9.Controls.Add(label11);
            panel9.ForeColor = SystemColors.ActiveCaptionText;
            panel9.Location = new Point(6, 76);
            panel9.Name = "panel9";
            panel9.Size = new Size(324, 40);
            panel9.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(88, 6);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(225, 23);
            textBox6.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 10);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 1;
            label11.Text = "Subtotal:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBox2);
            panel10.Controls.Add(label12);
            panel10.ForeColor = SystemColors.ActiveCaptionText;
            panel10.Location = new Point(6, 30);
            panel10.Name = "panel10";
            panel10.Size = new Size(324, 40);
            panel10.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(137, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 23);
            comboBox2.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(2, 10);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 0;
            label12.Text = "Tipo de compra:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button3);
            panel7.Controls.Add(button2);
            panel7.Location = new Point(1051, 495);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 60);
            panel7.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(163, 14);
            button3.Name = "button3";
            button3.Size = new Size(157, 34);
            button3.TabIndex = 1;
            button3.Text = "Nuevo proveedor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(7, 14);
            button2.Name = "button2";
            button2.Size = new Size(138, 34);
            button2.TabIndex = 0;
            button2.Text = "Comprar";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBox8);
            panel8.Controls.Add(textBox7);
            panel8.Controls.Add(textBox5);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(12, 495);
            panel8.Name = "panel8";
            panel8.Size = new Size(1019, 136);
            panel8.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.HotTrack;
            textBox8.ForeColor = SystemColors.InactiveBorder;
            textBox8.Location = new Point(780, 95);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(232, 23);
            textBox8.TabIndex = 5;
            textBox8.Text = "1,029.75";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(780, 55);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(232, 23);
            textBox7.TabIndex = 4;
            textBox7.Text = "129.75";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(780, 17);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 3;
            textBox5.Text = "900.00                    129.75";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(644, 98);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 2;
            label10.Text = "Total Compra:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(716, 55);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 1;
            label9.Text = "IVA:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(685, 14);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 0;
            label8.Text = "Subtotal:";
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(button6);
            panel11.Controls.Add(button5);
            panel11.Controls.Add(button4);
            panel11.Location = new Point(12, 637);
            panel11.Name = "panel11";
            panel11.Size = new Size(1376, 59);
            panel11.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1146, 11);
            button6.Name = "button6";
            button6.Size = new Size(221, 34);
            button6.TabIndex = 2;
            button6.Text = "Imprimir Comprobante";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(1012, 11);
            button5.Name = "button5";
            button5.Size = new Size(128, 34);
            button5.TabIndex = 1;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(774, 11);
            button4.Name = "button4";
            button4.Size = new Size(232, 34);
            button4.TabIndex = 0;
            button4.Text = "Guardar compra";
            button4.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1400, 699);
            Controls.Add(panel11);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Compra";
            Text = "Registro de compra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Panel panel9;
        private TextBox textBox6;
        private Label label11;
        private Panel panel10;
        private ComboBox comboBox2;
        private Label label12;
        private Panel panel7;
        private Button button3;
        private Button button2;
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
    }
}
