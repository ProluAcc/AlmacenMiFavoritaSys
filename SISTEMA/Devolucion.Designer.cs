namespace Pantalla_de_devolución
{
    partial class Devolución
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidadvendida = new DataGridViewTextBoxColumn();
            CantidadDevolver = new DataGridViewTextBoxColumn();
            Mótivo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(23, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(889, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(777, 36);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(105, 27);
            button1.TabIndex = 6;
            button1.Text = "Buscar venta";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(593, 36);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de venta:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 32);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "No. Factura:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 32);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(23, 104);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(889, 174);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidadvendida, CantidadDevolver, Mótivo, Estado });
            dataGridView1.Location = new Point(55, 22);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(774, 137);
            dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 140;
            // 
            // Cantidadvendida
            // 
            Cantidadvendida.HeaderText = "Cant. Vendida";
            Cantidadvendida.Name = "Cantidadvendida";
            // 
            // CantidadDevolver
            // 
            CantidadDevolver.HeaderText = "Cant. Devolver";
            CantidadDevolver.Name = "CantidadDevolver";
            // 
            // Mótivo
            // 
            Mótivo.HeaderText = "Mótivo";
            Mótivo.Name = "Mótivo";
            Mótivo.Width = 140;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Width = 140;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(30, 285);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(889, 72);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipo de devolución";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(517, 35);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(107, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nota de crédito";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(260, 35);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(135, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cambio de producto";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(44, 35);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Reembolso";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(23, 363);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(889, 155);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nuevgo producto";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(114, 22);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(620, 113);
            dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Producto";
            Column2.Name = "Column2";
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.Name = "Column4";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(button2);
            groupBox5.Location = new Point(30, 525);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(889, 85);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(768, 32);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(114, 27);
            button5.TabIndex = 10;
            button5.Text = "Menú principal";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(462, 32);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(145, 27);
            button4.TabIndex = 9;
            button4.Text = "Imprimir comprobante";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(261, 32);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(139, 27);
            button3.TabIndex = 8;
            button3.Text = "Procesar devolución";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(75, 32);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(126, 27);
            button2.TabIndex = 7;
            button2.Text = "Validar devolución";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Devolución
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 628);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Devolución";
            Text = "Devolución";
            Load += Devolución_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadvendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mótivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}