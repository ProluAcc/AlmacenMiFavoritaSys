namespace Pantalla_ventas
{
    partial class Ventas
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            txtfecha = new TextBox();
            txtfactura = new TextBox();
            txtcliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtmedida = new TextBox();
            label11 = new Label();
            cmbcategoria = new ComboBox();
            label14 = new Label();
            txtdescuento = new TextBox();
            label13 = new Label();
            numericant = new NumericUpDown();
            txtprecio = new TextBox();
            cmbproducto = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnlimpiar = new Button();
            dgvventas = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column68 = new DataGridViewTextBoxColumn();
            Column69 = new DataGridViewTextBoxColumn();
            Column66 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column67 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtiva = new TextBox();
            txttotal = new TextBox();
            groupBox3 = new GroupBox();
            button8 = new Button();
            btncambio = new Button();
            button7 = new Button();
            label12 = new Label();
            txtsubtotal = new TextBox();
            txtefectivo = new TextBox();
            groupBox5 = new GroupBox();
            buttonIngresar = new Button();
            groupBox4 = new GroupBox();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvventas).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(txtfactura);
            groupBox1.Controls.Add(txtcliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(1036, 10);
            button4.Name = "button4";
            button4.Size = new Size(81, 35);
            button4.TabIndex = 14;
            button4.Text = "AYUDA";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtfecha
            // 
            txtfecha.ForeColor = Color.Black;
            txtfecha.Location = new Point(299, 19);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(126, 23);
            txtfecha.TabIndex = 11;
            // 
            // txtfactura
            // 
            txtfactura.ForeColor = Color.Black;
            txtfactura.Location = new Point(128, 19);
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(100, 23);
            txtfactura.TabIndex = 10;
            // 
            // txtcliente
            // 
            txtcliente.ForeColor = Color.Black;
            txtcliente.Location = new Point(595, 19);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(165, 23);
            txtcliente.TabIndex = 9;
            txtcliente.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(237, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 7;
            label2.Text = "No. de factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(443, 20);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(txtmedida);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmbcategoria);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtdescuento);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(numericant);
            groupBox2.Controls.Add(txtprecio);
            groupBox2.Controls.Add(cmbproducto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(2, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(646, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(302, 18);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(113, 23);
            txtmedida.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(225, 21);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 13;
            label11.Text = "Talla:";
            // 
            // cmbcategoria
            // 
            cmbcategoria.ForeColor = Color.Black;
            cmbcategoria.FormattingEnabled = true;
            cmbcategoria.Location = new Point(88, 22);
            cmbcategoria.Name = "cmbcategoria";
            cmbcategoria.Size = new Size(115, 23);
            cmbcategoria.TabIndex = 12;
            cmbcategoria.SelectedIndexChanged += cmbtipo_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(5, 21);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 11;
            label14.Text = "Categoría:";
            // 
            // txtdescuento
            // 
            txtdescuento.ForeColor = Color.Black;
            txtdescuento.Location = new Point(537, 58);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(103, 23);
            txtdescuento.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(429, 60);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 9;
            label13.Text = "Descuento %:";
            // 
            // numericant
            // 
            numericant.ForeColor = Color.Black;
            numericant.Location = new Point(302, 59);
            numericant.Name = "numericant";
            numericant.Size = new Size(113, 23);
            numericant.TabIndex = 8;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(537, 22);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(101, 23);
            txtprecio.TabIndex = 5;
            // 
            // cmbproducto
            // 
            cmbproducto.ForeColor = Color.Black;
            cmbproducto.FormattingEnabled = true;
            cmbproducto.Location = new Point(88, 59);
            cmbproducto.Name = "cmbproducto";
            cmbproducto.Size = new Size(115, 23);
            cmbproducto.TabIndex = 3;
            cmbproducto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(429, 21);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(220, 59);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "Cantidad:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 60);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Producto:";
            label4.Click += label4_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = SystemColors.ButtonFace;
            btnlimpiar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnlimpiar.ForeColor = Color.FromArgb(69, 69, 210);
            btnlimpiar.Location = new Point(9, 60);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(133, 35);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "🗑LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // dgvventas
            // 
            dgvventas.AllowUserToDeleteRows = false;
            dgvventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvventas.Columns.AddRange(new DataGridViewColumn[] { Column4, Column68, Column69, Column66, Column5, Column3, Column67, Column16 });
            dgvventas.Location = new Point(2, 189);
            dgvventas.Name = "dgvventas";
            dgvventas.Size = new Size(1044, 196);
            dgvventas.TabIndex = 2;
            dgvventas.TabStop = false;
            // 
            // Column4
            // 
            Column4.HeaderText = "Producto";
            Column4.Name = "Column4";
            Column4.Width = 250;
            // 
            // Column68
            // 
            Column68.HeaderText = "Categoría";
            Column68.Name = "Column68";
            Column68.Width = 150;
            // 
            // Column69
            // 
            Column69.HeaderText = "Medida";
            Column69.Name = "Column69";
            // 
            // Column66
            // 
            Column66.HeaderText = "Precio";
            Column66.Name = "Column66";
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.HeaderText = "Valor";
            Column3.Name = "Column3";
            // 
            // Column67
            // 
            Column67.HeaderText = "Descuento";
            Column67.Name = "Column67";
            // 
            // Column16
            // 
            Column16.HeaderText = "% Descuento";
            Column16.Name = "Column16";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(379, 27);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 3;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(564, 25);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 4;
            label8.Text = "Monto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(522, 39);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(10, 27);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 7;
            label10.Text = "IVA";
            label10.Click += label10_Click;
            // 
            // txtiva
            // 
            txtiva.ForeColor = Color.Black;
            txtiva.Location = new Point(48, 26);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(115, 23);
            txtiva.TabIndex = 8;
            // 
            // txttotal
            // 
            txttotal.ForeColor = Color.Black;
            txttotal.Location = new Point(429, 24);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(132, 23);
            txttotal.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(btncambio);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtsubtotal);
            groupBox3.Controls.Add(txtefectivo);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txttotal);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtiva);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(2, 400);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1129, 93);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(69, 69, 210);
            button8.Location = new Point(899, 22);
            button8.Name = "button8";
            button8.Size = new Size(106, 49);
            button8.TabIndex = 20;
            button8.Text = "GENERAR PDF";
            button8.UseVisualStyleBackColor = false;
            // 
            // btncambio
            // 
            btncambio.BackColor = SystemColors.ButtonFace;
            btncambio.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btncambio.ForeColor = Color.FromArgb(69, 69, 210);
            btncambio.Location = new Point(775, 29);
            btncambio.Name = "btncambio";
            btncambio.Size = new Size(106, 35);
            btncambio.TabIndex = 19;
            btncambio.Text = "💱CAMBIO";
            btncambio.UseVisualStyleBackColor = false;
            btncambio.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(1017, 29);
            button7.Name = "button7";
            button7.Size = new Size(106, 35);
            button7.TabIndex = 18;
            button7.Text = "HISTORIAL";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(169, 27);
            label12.Name = "label12";
            label12.Size = new Size(68, 20);
            label12.TabIndex = 11;
            label12.Text = "Subtotal";
            // 
            // txtsubtotal
            // 
            txtsubtotal.ForeColor = Color.Black;
            txtsubtotal.Location = new Point(240, 25);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(132, 23);
            txtsubtotal.TabIndex = 12;
            // 
            // txtefectivo
            // 
            txtefectivo.Location = new Point(622, 24);
            txtefectivo.Name = "txtefectivo";
            txtefectivo.Size = new Size(134, 23);
            txtefectivo.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(buttonIngresar);
            groupBox5.Controls.Add(btnlimpiar);
            groupBox5.Location = new Point(664, 72);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(150, 108);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Acciones";
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = SystemColors.ButtonFace;
            buttonIngresar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            buttonIngresar.ForeColor = Color.FromArgb(69, 69, 210);
            buttonIngresar.Location = new Point(9, 19);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(133, 35);
            buttonIngresar.TabIndex = 20;
            buttonIngresar.Text = "🔽INGRESAR";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(820, 72);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(226, 108);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Crear";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(30, 44);
            button1.Name = "button1";
            button1.Size = new Size(165, 35);
            button1.TabIndex = 21;
            button1.Text = "💸DEVOLUCIÓN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Categoría";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Medida";
            Column2.Name = "Column2";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1131, 493);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(dgvventas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvventas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtfecha;
        private TextBox txtfactura;
        private TextBox txtcliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbproducto;
        private TextBox txtprecio;
        private DataGridView dgvventas;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtiva;
        private TextBox txttotal;
        private GroupBox groupBox3;
        private NumericUpDown numericant;
        private TextBox txtefectivo;
        private Label label12;
        private TextBox txtsubtotal;
        private Label label14;
        private TextBox txtdescuento;
        private Label label13;
        private Button button3;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label15;
        private GroupBox groupBox5;
        private Button button2;
        private Button button6;
        private Button button7;
        private GroupBox groupBox4;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private VScrollBar vScrollBar1;
        private Button btnlimpiar;
        private Button button4;
        private Button btncambio;
        private Button buttonIngresar;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column68;
        private DataGridViewTextBoxColumn Column69;
        private DataGridViewTextBoxColumn Column66;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column67;
        private DataGridViewTextBoxColumn Column16;
        private Button button1;
        private TextBox txtmedida;
        private Label label11;
        private ComboBox cmbcategoria;
        private Button button8;
    }
}
