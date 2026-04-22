namespace SISTEMA
{
    partial class Credito
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
            btnBuscarCliente = new Button();
            cbCliente = new ComboBox();
            label4 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            txtFactura = new TextBox();
            label2 = new Label();
            btnGenerarCuenta = new Button();
            groupBox2 = new GroupBox();
            txtTotal = new TextBox();
            label18 = new Label();
            panel4 = new Panel();
            txtSubtotal = new TextBox();
            label16 = new Label();
            label14 = new Label();
            panel7 = new Panel();
            cbVencimiento = new ComboBox();
            comboBox2 = new ComboBox();
            cbPlazo = new ComboBox();
            txtObservaciones = new TextBox();
            label15 = new Label();
            panel8 = new Panel();
            label17 = new Label();
            panel9 = new Panel();
            label19 = new Label();
            panel10 = new Panel();
            label21 = new Label();
            label22 = new Label();
            panel11 = new Panel();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnValidarCredito = new Button();
            btnRegistrarVenta = new Button();
            txtiva = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(cbCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFactura);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 49);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(769, 16);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(108, 23);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(495, 16);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(254, 23);
            cbCliente.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 19);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Cliente:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(249, 16);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(121, 23);
            txtFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 19);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(83, 16);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(100, 23);
            txtFactura.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "No. Factura:";
            // 
            // btnGenerarCuenta
            // 
            btnGenerarCuenta.Location = new Point(723, 393);
            btnGenerarCuenta.Name = "btnGenerarCuenta";
            btnGenerarCuenta.Size = new Size(165, 23);
            btnGenerarCuenta.TabIndex = 2;
            btnGenerarCuenta.Text = "Generar Cuenta por Cobrar";
            btnGenerarCuenta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtiva);
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(panel7);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(11, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 329);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(522, 296);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(129, 23);
            txtTotal.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(485, 299);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 18;
            label18.Text = "Total:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(448, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 1);
            panel4.TabIndex = 9;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(522, 226);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(129, 23);
            txtSubtotal.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(489, 257);
            label16.Name = "label16";
            label16.Size = new Size(27, 15);
            label16.TabIndex = 16;
            label16.Text = "IVA:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(462, 231);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 10;
            label14.Text = "Subtotal:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(cbVencimiento);
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(cbPlazo);
            panel7.Controls.Add(txtObservaciones);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(label22);
            panel7.Controls.Add(panel11);
            panel7.Location = new Point(657, 164);
            panel7.Name = "panel7";
            panel7.Size = new Size(216, 154);
            panel7.TabIndex = 15;
            panel7.Paint += panel7_Paint;
            // 
            // cbVencimiento
            // 
            cbVencimiento.FormattingEnabled = true;
            cbVencimiento.Location = new Point(108, 92);
            cbVencimiento.Name = "cbVencimiento";
            cbVencimiento.Size = new Size(98, 23);
            cbVencimiento.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(107, 63);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 23);
            comboBox2.TabIndex = 14;
            // 
            // cbPlazo
            // 
            cbPlazo.FormattingEnabled = true;
            cbPlazo.Location = new Point(108, 35);
            cbPlazo.Name = "cbPlazo";
            cbPlazo.Size = new Size(98, 23);
            cbPlazo.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(108, 123);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(100, 23);
            txtObservaciones.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 124);
            label15.Name = "label15";
            label15.Size = new Size(87, 15);
            label15.TabIndex = 13;
            label15.Text = "Observaciones:";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(6, 118);
            panel8.Name = "panel8";
            panel8.Size = new Size(203, 1);
            panel8.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 95);
            label17.Name = "label17";
            label17.Size = new Size(76, 15);
            label17.TabIndex = 11;
            label17.Text = "Vencimiento:";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(5, 89);
            panel9.Name = "panel9";
            panel9.Size = new Size(203, 1);
            panel9.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 69);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 9;
            label19.Text = "Cuotas:";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(5, 60);
            panel10.Name = "panel10";
            panel10.Size = new Size(203, 1);
            panel10.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 40);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 6;
            label21.Text = "Plazo:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Blue;
            label22.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(2, 8);
            label22.Name = "label22";
            label22.Size = new Size(152, 15);
            label22.TabIndex = 0;
            label22.Text = "Condiciones del Crédito";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Blue;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Location = new Point(-1, -1);
            panel11.Name = "panel11";
            panel11.Size = new Size(216, 33);
            panel11.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(657, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 136);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Lime;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(143, 109);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 14;
            label13.Text = "Aprobado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 108);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 13;
            label12.Text = "Estado:";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(6, 104);
            panel6.Name = "panel6";
            panel6.Size = new Size(203, 1);
            panel6.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(130, 86);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 12;
            label11.Text = "C$ 000000000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 86);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 11;
            label10.Text = "Disponible:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(5, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 1);
            panel5.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 64);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 10;
            label9.Text = "C$ 000000000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 64);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 9;
            label8.Text = "Pendiente:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(5, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 1);
            panel3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 40);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 7;
            label7.Text = "C$ 000000000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 40);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 6;
            label6.Text = "Limite:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 8);
            label5.Name = "label5";
            label5.Size = new Size(210, 15);
            label5.TabIndex = 0;
            label5.Text = "Información Crediticia del Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 33);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 194);
            dataGridView1.TabIndex = 0;
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
            // Column5
            // 
            Column5.HeaderText = "IVA";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Subtotal";
            Column6.Name = "Column6";
            // 
            // btnValidarCredito
            // 
            btnValidarCredito.Location = new Point(453, 393);
            btnValidarCredito.Name = "btnValidarCredito";
            btnValidarCredito.Size = new Size(94, 23);
            btnValidarCredito.TabIndex = 6;
            btnValidarCredito.Text = "Validar Crédito";
            btnValidarCredito.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(562, 393);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(158, 23);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar Venta a Crédito";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // txtiva
            // 
            txtiva.Location = new Point(522, 257);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(129, 23);
            txtiva.TabIndex = 20;
            // 
            // Credito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 427);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(btnValidarCredito);
            Controls.Add(groupBox2);
            Controls.Add(btnGenerarCuenta);
            Controls.Add(groupBox1);
            Name = "Credito";
            Text = "Credito";
            Load += Credito_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtFecha;
        private Label label3;
        private TextBox txtFactura;
        private Label label2;
        private Label label1;
        private Button btnGenerarCuenta;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnBuscarCliente;
        private ComboBox cbCliente;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label12;
        private Panel panel6;
        private Label label11;
        private Label label10;
        private Panel panel5;
        private Label label9;
        private Label label8;
        private Panel panel4;
        private Panel panel7;
        private TextBox txtObservaciones;
        private Label label15;
        private Panel panel8;
        private Label label17;
        private Panel panel9;
        private Label label19;
        private Panel panel10;
        private Label label21;
        private Label label22;
        private Panel panel11;
        private ComboBox comboBox2;
        private ComboBox cbPlazo;
        private Label label18;
        private TextBox textBox3;
        private TextBox txtSubtotal;
        private Label label16;
        private Label label14;
        private ComboBox cbVencimiento;
        private TextBox txtTotal;
        private Button btnValidarCredito;
        private Button btnRegistrarVenta;
        private TextBox txtiva;
    }
}