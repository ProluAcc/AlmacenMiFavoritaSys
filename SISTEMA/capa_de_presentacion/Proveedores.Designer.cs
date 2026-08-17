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
            dgvProveedor = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            button6 = new Button();
            label6 = new Label();
            btnBuscar = new Button();
            btnEditarM = new Button();
            btnIngresarW = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(371, 146);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(187, 27);
            txtBuscar.TabIndex = 79;
            // 
            // cmbBuscar
            // 
            cmbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(206, 145);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(159, 28);
            cmbBuscar.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(111, 148);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 77;
            label7.Text = "Buscar por:";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Column2, Column4, Column3, Column1, Column6, Column5 });
            dgvProveedor.ImeMode = ImeMode.On;
            dgvProveedor.Location = new Point(4, 200);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(831, 273);
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
            button6.Location = new Point(753, 11);
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
            btnBuscar.Location = new Point(572, 139);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 38);
            btnBuscar.TabIndex = 85;
            btnBuscar.Text = "🔍BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditarM
            // 
            btnEditarM.BackColor = SystemColors.ButtonFace;
            btnEditarM.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnEditarM.ForeColor = Color.FromArgb(69, 69, 210);
            btnEditarM.Location = new Point(424, 89);
            btnEditarM.Name = "btnEditarM";
            btnEditarM.Size = new Size(129, 35);
            btnEditarM.TabIndex = 119;
            btnEditarM.Text = "✏️EDITAR";
            btnEditarM.UseVisualStyleBackColor = false;
            // 
            // btnIngresarW
            // 
            btnIngresarW.BackColor = SystemColors.ButtonFace;
            btnIngresarW.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnIngresarW.ForeColor = Color.FromArgb(69, 69, 210);
            btnIngresarW.Location = new Point(295, 88);
            btnIngresarW.Name = "btnIngresarW";
            btnIngresarW.Size = new Size(118, 36);
            btnIngresarW.TabIndex = 118;
            btnIngresarW.Text = "⬇️INGRESAR";
            btnIngresarW.UseVisualStyleBackColor = false;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(839, 476);
            Controls.Add(btnEditarM);
            Controls.Add(btnIngresarW);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cmbBuscar);
            Controls.Add(label7);
            Controls.Add(dgvProveedor);
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
        private DataGridView dgvProveedor;
        private Panel panel3;
        private Label label6;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Button button6;
        private Button btnEditarM;
        private Button btnIngresarW;
    }
}