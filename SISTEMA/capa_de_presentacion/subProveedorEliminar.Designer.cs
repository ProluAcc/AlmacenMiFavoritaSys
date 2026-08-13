namespace SISTEMA.capa_de_presentacion
{
    partial class subProveedorEliminar
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
            label2 = new Label();
            button7 = new Button();
            btnCancelar = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            dgvProveedor = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 22);
            label2.Name = "label2";
            label2.Size = new Size(285, 32);
            label2.TabIndex = 148;
            label2.Text = "ELIMINAR PROVEEDOR";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(823, 79);
            button7.TabIndex = 147;
            button7.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(69, 69, 210);
            btnCancelar.Location = new Point(585, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 34);
            btnCancelar.TabIndex = 153;
            btnCancelar.Text = "🗑ELIMINAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(453, 100);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 152;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(286, 105);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 151;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(138, 105);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(71, 108);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 149;
            label7.Text = "Buscar:";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Column2, Column4, Column3, Column1, Column6, Column5 });
            dgvProveedor.ImeMode = ImeMode.On;
            dgvProveedor.Location = new Point(0, 140);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(823, 152);
            dgvProveedor.TabIndex = 155;
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
            // subProveedorEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(824, 292);
            Controls.Add(dgvProveedor);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(button7);
            Name = "subProveedorEliminar";
            Text = "subProveedorEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button7;
        private Button btnCancelar;
        private Button button1;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private DataGridView dgvProveedor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
    }
}