namespace SISTEMA
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            button8 = new Button();
            panel1 = new Panel();
            btnUsuario = new Button();
            btnClientes = new Button();
            btnProducto = new Button();
            btnProveedor = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cbEstado = new ComboBox();
            txtRuc = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(23, 23, 255);
            button8.Location = new Point(780, 23);
            button8.Name = "button8";
            button8.Size = new Size(80, 36);
            button8.TabIndex = 83;
            button8.Text = "Inicio";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 72, 72);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnUsuario);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnProveedor);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 467);
            panel1.TabIndex = 81;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(222, 72, 72);
            btnUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.Location = new Point(3, 385);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(159, 56);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(222, 72, 72);
            btnClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(3, 316);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(159, 63);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(222, 72, 72);
            btnProducto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducto.Location = new Point(3, 246);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(159, 64);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(222, 72, 72);
            btnProveedor.FlatAppearance.BorderColor = Color.FromArgb(222, 72, 72);
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedor.Location = new Point(3, 171);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(159, 69);
            btnProveedor.TabIndex = 1;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(176, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(685, 248);
            dataGridView1.TabIndex = 80;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre de Cliente";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Teléfono";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Código RUC";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Editar";
            Column5.Name = "Column5";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(706, 162);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 23);
            txtBuscar.TabIndex = 79;
            // 
            // cbBuscar
            // 
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(615, 161);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(85, 23);
            cbBuscar.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(535, 163);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 77;
            label7.Text = "Buscar por:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(69, 69, 255);
            btnCancelar.Location = new Point(267, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 27);
            btnCancelar.TabIndex = 76;
            btnCancelar.Text = "🚫Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(69, 69, 255);
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(176, 161);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 27);
            btnGuardar.TabIndex = 75;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(746, 118);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(114, 23);
            cbEstado.TabIndex = 74;
            // 
            // txtRuc
            // 
            txtRuc.Location = new Point(536, 118);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(204, 23);
            txtRuc.TabIndex = 73;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(384, 118);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 23);
            txtTelefono.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(746, 98);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 71;
            label6.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(536, 98);
            label5.Name = "label5";
            label5.Size = new Size(154, 17);
            label5.TabIndex = 70;
            label5.Text = "Código RUC (Opcional):";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 23);
            txtNombre.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(384, 98);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 68;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(175, 98);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 67;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(69, 69, 255);
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 29);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 66;
            label2.Text = "Nuevo Cliente";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(69, 69, 255);
            button7.Enabled = false;
            button7.Location = new Point(163, 0);
            button7.Name = "button7";
            button7.Size = new Size(710, 83);
            button7.TabIndex = 82;
            button7.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(871, 469);
            Controls.Add(button8);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbEstado);
            Controls.Add(txtRuc);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button7);
            Name = "Clientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Panel panel1;
        private Button btnUsuario;
        private Button btnClientes;
        private Button btnProducto;
        private Button btnProveedor;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbEstado;
        private TextBox txtRuc;
        private TextBox txtTelefono;
        private Label label6;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button7;
    }
}