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
            dgvCliente = new DataGridView();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            cbEstado = new ComboBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button7 = new Button();
            txtCorreo = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnIngresar = new Button();
            btnEditar = new Button();
            button3 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4 });
            dgvCliente.Location = new Point(12, 226);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(814, 289);
            dgvCliente.TabIndex = 80;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            dgvCliente.CellDoubleClick += dgvCliente_CellDoubleClick;
            dgvCliente.DoubleClick += dgvCliente_DoubleClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(227, 184);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 79;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(79, 184);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 187);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 77;
            label7.Text = "Buscar:";
            label7.Click += label7_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(69, 69, 210);
            btnLimpiar.Location = new Point(676, 180);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 34);
            btnLimpiar.TabIndex = 76;
            btnLimpiar.Text = "🗑LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ButtonFace;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(69, 69, 210);
            btnGuardar.Location = new Point(832, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 39);
            btnGuardar.TabIndex = 75;
            btnGuardar.Text = "💾 GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(792, 116);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(114, 28);
            cbEstado.TabIndex = 74;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDireccion.Location = new Point(372, 117);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(204, 27);
            txtDireccion.TabIndex = 73;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtTelefono.Location = new Point(220, 117);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(792, 96);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 71;
            label6.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(372, 97);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 70;
            label5.Text = "Dirección:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNombre.Location = new Point(11, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 27);
            txtNombre.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(220, 97);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 68;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 97);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 67;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(202, 32);
            label2.TabIndex = 66;
            label2.Text = "NUEVO CLIENTE";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(-1, -1);
            button7.Name = "button7";
            button7.Size = new Size(977, 79);
            button7.TabIndex = 82;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtCorreo.Location = new Point(582, 117);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(204, 27);
            txtCorreo.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(582, 97);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 84;
            label1.Text = "Correo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(69, 69, 210);
            btnBuscar.Location = new Point(387, 181);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 33);
            btnBuscar.TabIndex = 87;
            btnBuscar.Text = "🔍BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ButtonFace;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.FromArgb(69, 69, 210);
            btnIngresar.Location = new Point(558, 180);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 88;
            btnIngresar.Text = "⬇️INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonFace;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(69, 69, 210);
            btnEditar.Location = new Point(806, 181);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 35);
            btnEditar.TabIndex = 117;
            btnEditar.Text = "✏️EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(890, 24);
            button3.Name = "button3";
            button3.Size = new Size(73, 35);
            button3.TabIndex = 118;
            button3.Text = "AYUDA";
            button3.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre de Cliente";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Teléfono";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dirección";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // Column6
            // 
            Column6.HeaderText = "Correo";
            Column6.Name = "Column6";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
            Controls.Add(button3);
            Controls.Add(btnEditar);
            Controls.Add(btnIngresar);
            Controls.Add(btnBuscar);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(dgvCliente);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cbEstado);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCliente;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cbEstado;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label6;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button7;
        private TextBox txtCorreo;
        private Label label1;
        private Button btnBuscar;
        private Button btnIngresar;
        private Button btnEditar;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
    }
}