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
            txtBuscar = new TextBox();
            cmbBuscar = new ComboBox();
            label7 = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvProveedor = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            cmbEstado = new ComboBox();
            panel3 = new Panel();
            button6 = new Button();
            label6 = new Label();
            btnBuscar = new Button();
            txtCorreo = new TextBox();
            label1 = new Label();
            label8 = new Label();
            btnIngresar = new Button();
            btnEditar = new Button();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(272, 192);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(187, 27);
            txtBuscar.TabIndex = 79;
            // 
            // cmbBuscar
            // 
            cmbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(107, 191);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(159, 28);
            cmbBuscar.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(12, 194);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 77;
            label7.Text = "Buscar por:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDireccion.Location = new Point(473, 105);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 27);
            txtDireccion.TabIndex = 76;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtTelefono.Location = new Point(191, 105);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(123, 27);
            txtTelefono.TabIndex = 75;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNombre.Location = new Point(12, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 74;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(69, 69, 210);
            btnLimpiar.Location = new Point(840, 146);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 37);
            btnLimpiar.TabIndex = 73;
            btnLimpiar.Text = "🗑LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonFace;
            btnGuardar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(69, 69, 210);
            btnGuardar.Location = new Point(845, 242);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 42);
            btnGuardar.TabIndex = 72;
            btnGuardar.Text = "✔️GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(855, 78);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 71;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(473, 77);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 70;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(191, 77);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 69;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 68;
            label2.Text = "Nombre del proveedor:";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Column2, Column4, Column3, Column1, Column6, Column5 });
            dgvProveedor.ImeMode = ImeMode.On;
            dgvProveedor.Location = new Point(12, 242);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(823, 273);
            dgvProveedor.TabIndex = 67;
            dgvProveedor.CellContentDoubleClick += dgvProveedor_CellContentDoubleClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del proveedor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Teléfono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dirección";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // Column1
            // 
            Column1.HeaderText = "Correo";
            Column1.Name = "Column1";
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha de Registro";
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(845, 104);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(112, 28);
            cmbEstado.TabIndex = 66;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(975, 64);
            panel3.TabIndex = 81;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(889, 15);
            button6.Name = "button6";
            button6.Size = new Size(73, 35);
            button6.TabIndex = 118;
            button6.Text = "AYUDA";
            button6.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(251, 32);
            label6.TabIndex = 10;
            label6.Text = "NUEVO PROVEEDOR";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(69, 69, 210);
            btnBuscar.Location = new Point(473, 185);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 38);
            btnBuscar.TabIndex = 85;
            btnBuscar.Text = "🔍BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtCorreo.Location = new Point(320, 105);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(147, 27);
            txtCorreo.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(320, 77);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 87;
            label1.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(697, 77);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 88;
            label8.Text = "Fecha de Registro:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ButtonFace;
            btnIngresar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.FromArgb(69, 69, 210);
            btnIngresar.Location = new Point(727, 147);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 37);
            btnIngresar.TabIndex = 89;
            btnIngresar.Text = "⬇️INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button4_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonFace;
            btnEditar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(69, 69, 210);
            btnEditar.Location = new Point(845, 290);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 38);
            btnEditar.TabIndex = 117;
            btnEditar.Text = "✏️EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 11F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(697, 105);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(137, 27);
            dtpFecha.TabIndex = 118;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(dtpFecha);
            Controls.Add(btnEditar);
            Controls.Add(btnIngresar);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cmbBuscar);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvProveedor);
            Controls.Add(cmbEstado);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscar;
        private ComboBox cmbBuscar;
        private Label label7;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvProveedor;
        private ComboBox cmbEstado;
        private Panel panel3;
        private Label label6;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtCorreo;
        private Label label1;
        private Label label8;
        private Button btnIngresar;
        private Button btnEditar;
        private Button button6;
        private DateTimePicker dtpFecha;
    }
}