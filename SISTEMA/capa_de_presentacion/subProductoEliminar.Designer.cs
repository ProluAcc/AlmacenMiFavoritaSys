namespace SISTEMA
{
    partial class subProductoEliminar
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
            btnCancelar = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            button7 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(69, 69, 210);
            btnCancelar.Location = new Point(665, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 34);
            btnCancelar.TabIndex = 115;
            btnCancelar.Text = "🗑ELIMINAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(533, 100);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 114;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(366, 105);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 113;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(218, 105);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(151, 108);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 111;
            label7.Text = "Buscar:";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(956, 79);
            button7.TabIndex = 116;
            button7.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(274, 32);
            label2.TabIndex = 117;
            label2.Text = "ELIMINAR PRODUCTO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8, Column9, Column6, Column10 });
            dataGridView1.Location = new Point(0, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(956, 178);
            dataGridView1.TabIndex = 118;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre del Producto";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Medida";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Marca";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Descripción";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Precio Venta";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Precio Compra";
            Column9.Name = "Column9";
            // 
            // Column6
            // 
            Column6.HeaderText = "Stock Máximo";
            Column6.Name = "Column6";
            Column6.Width = 60;
            // 
            // Column10
            // 
            Column10.HeaderText = "Stock Mínimo";
            Column10.Name = "Column10";
            Column10.Width = 60;
            // 
            // subProductoEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(958, 340);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Name = "subProductoEliminar";
            Text = "subProductoEliminar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button button1;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private Button button7;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column10;
    }
}