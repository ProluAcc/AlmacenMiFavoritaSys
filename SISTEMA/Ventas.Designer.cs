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
            btnaceptar = new Button();
            txtfecha = new TextBox();
            txtfactura = new TextBox();
            txtcliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnlimpiar = new Button();
            btningresar = new Button();
            button6 = new Button();
            cmbtipo = new ComboBox();
            label14 = new Label();
            txtdescuento = new TextBox();
            label13 = new Label();
            numericant = new NumericUpDown();
            txtprecio = new TextBox();
            cmbproducto = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvventas = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button3 = new Button();
            label12 = new Label();
            textBox9 = new TextBox();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            groupBox4 = new GroupBox();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
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
            groupBox1.Controls.Add(btnaceptar);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(txtfactura);
            groupBox1.Controls.Add(txtcliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1072, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = SystemColors.ButtonFace;
            btnaceptar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnaceptar.ForeColor = Color.FromArgb(69, 69, 210);
            btnaceptar.Location = new Point(780, 17);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(115, 35);
            btnaceptar.TabIndex = 13;
            btnaceptar.Text = "✅ACEPTAR";
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // txtfecha
            // textBox3
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
            label1.Location = new Point(413, 20);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre del cliente:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(btnlimpiar);
            groupBox2.Controls.Add(btningresar);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(cmbtipo);
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
            groupBox2.Size = new Size(637, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = SystemColors.ButtonFace;
            btnlimpiar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnlimpiar.ForeColor = Color.FromArgb(69, 69, 210);
            btnlimpiar.Location = new Point(810, 58);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(106, 35);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "🗑LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = SystemColors.ButtonFace;
            btningresar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btningresar.ForeColor = Color.FromArgb(69, 69, 210);
            btningresar.Location = new Point(682, 58);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(123, 35);
            btningresar.TabIndex = 15;
            btningresar.Text = "🔽INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(19, 58);
            button6.Name = "button6";
            button6.Size = new Size(142, 35);
            button6.TabIndex = 14;
            button6.Text = "💸DEVOLUCIÓN";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // cmbtipo
            // 
            cmbtipo.ForeColor = Color.Black;
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Location = new Point(51, 17);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(72, 23);
            cmbtipo.TabIndex = 12;
            cmbtipo.SelectedIndexChanged += cmbtipo_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(6, 58);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 11;
            label14.Text = "Categoría:";
            // 
            // txtdescuento
            // 
            txtdescuento.ForeColor = Color.Black;
            txtdescuento.Location = new Point(644, 18);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(101, 23);
            txtdescuento.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(435, 22);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 9;
            label13.Text = "Descuento %:";
            // 
            // numericant
            // 
            numericant.ForeColor = Color.Black;
            numericant.Location = new Point(459, 20);
            numericant.Name = "numericant";
            numericant.Size = new Size(87, 23);
            numericant.TabIndex = 8;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(810, 18);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(101, 23);
            txtprecio.TabIndex = 5;
            // 
            // cmbproducto
            // 
            cmbproducto.ForeColor = Color.Black;
            cmbproducto.FormattingEnabled = true;
            cmbproducto.Location = new Point(215, 18);
            cmbproducto.Name = "cmbproducto";
            cmbproducto.Size = new Size(160, 23);
            cmbproducto.TabIndex = 3;
            cmbproducto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(464, 57);
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
            label5.Location = new Point(383, 20);
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
            label4.Location = new Point(134, 19);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Producto:";
            label4.Click += label4_Click;
            // 
            // dgvventas
            // 
            dgvventas.AllowUserToDeleteRows = false;
            dgvventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvventas.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column15, Column16, Column6 });
            dgvventas.Location = new Point(2, 189);
            dgvventas.Name = "dgvventas";
            dgvventas.Size = new Size(844, 196);
            dgvventas.TabIndex = 2;
            dgvventas.TabStop = false;
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
            // textBox6
            // 
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(48, 26);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(429, 24);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(132, 23);
            textBox7.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(2, 400);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1072, 63);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(950, 16);
            button7.Name = "button7";
            button7.Size = new Size(106, 35);
            button7.TabIndex = 18;
            button7.Text = "HISTORIAL";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(838, 16);
            button3.Name = "button3";
            button3.Size = new Size(106, 35);
            button3.TabIndex = 17;
            button3.Text = "💱CAMBIO";
            button3.UseVisualStyleBackColor = false;
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
            // textBox9
            // 
            textBox9.ForeColor = Color.Black;
            textBox9.Location = new Point(240, 25);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(132, 23);
            textBox9.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(622, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 23);
            textBox4.TabIndex = 10;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(button1);
            groupBox5.Location = new Point(645, 71);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(150, 108);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Acciones";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(22, 63);
            button2.Name = "button2";
            button2.Size = new Size(106, 35);
            button2.TabIndex = 19;
            button2.Text = "🗑LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(13, 20);
            button1.Name = "button1";
            button1.Size = new Size(123, 35);
            button1.TabIndex = 18;
            button1.Text = "🔽INGRESAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(12, 20);
            button6.Name = "button6";
            button6.Size = new Size(142, 35);
            button6.TabIndex = 17;
            button6.Text = "💸DEVOLUCIÓN";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(button6);
            groupBox4.Location = new Point(801, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(169, 108);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Crear";
            // 
            // Column4
            // 
            Column4.HeaderText = "Producto";
            Column4.Name = "Column4";
            Column4.Width = 250;
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
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
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
            // Column15
            // 
            vScrollBar1.Location = new Point(976, 1);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 727);
            vScrollBar1.TabIndex = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // Column16
            // 
            Column16.HeaderText = "% Descuento";
            Column16.Name = "Column16";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1076, 466);
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
        private TextBox textBox6;
        private TextBox textBox7;
        private GroupBox groupBox3;
        private NumericUpDown numericant;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox9;
        private ComboBox cmbtipo;
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
        private Button button1;
        private Button button6;
        private Button button7;
        private GroupBox groupBox4;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column6;
        private VScrollBar vScrollBar1;
        private Button btnaceptar;
        private Button btnlimpiar;
        private Button btningresar;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button3;
        private Button button5;
    }
}
