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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            button7 = new Button();
            btnBuscar = new Button();
            btnIngresar = new Button();
            btnEditar = new Button();
            button3 = new Button();
            button1 = new Button();
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
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(290, 192);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 79;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(142, 192);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(75, 195);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 77;
            label7.Text = "Buscar:";
            label7.Click += label7_Click;
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
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(69, 69, 210);
            btnBuscar.Location = new Point(450, 189);
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
            btnIngresar.Location = new Point(289, 116);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(142, 34);
            btnIngresar.TabIndex = 88;
            btnIngresar.Text = "➕AGREGAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonFace;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(69, 69, 210);
            btnEditar.Location = new Point(447, 116);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 35);
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
            button3.Location = new Point(746, 24);
            button3.Name = "button3";
            button3.Size = new Size(73, 35);
            button3.TabIndex = 118;
            button3.Text = "AYUDA";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(569, 189);
            button1.Name = "button1";
            button1.Size = new Size(178, 33);
            button1.TabIndex = 196;
            button1.Text = "⛔DESHABILITAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(831, 520);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(btnEditar);
            Controls.Add(btnIngresar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvCliente);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
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
        private Label label2;
        private Button button7;
        private Button btnBuscar;
        private Button btnIngresar;
        private Button btnEditar;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}