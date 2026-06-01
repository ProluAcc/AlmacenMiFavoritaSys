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
            button8 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(23, 23, 255);
            button8.Location = new Point(883, 20);
            button8.Name = "button8";
            button8.Size = new Size(80, 36);
            button8.TabIndex = 83;
            button8.Text = "Inicio";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4 });
            dataGridView1.Location = new Point(12, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(814, 289);
            dataGridView1.TabIndex = 80;
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
            Column3.Width = 125;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(69, 69, 210);
            btnCancelar.Location = new Point(676, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 34);
            btnCancelar.TabIndex = 76;
            btnCancelar.Text = "🚫CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(69, 69, 210);
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(840, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 39);
            btnGuardar.TabIndex = 75;
            btnGuardar.Text = "💾 GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
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
            // txtRuc
            // 
            txtRuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtRuc.Location = new Point(372, 117);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(204, 27);
            txtRuc.TabIndex = 73;
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
            label2.BackColor = Color.FromArgb(69, 69, 210);
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 66;
            label2.Text = "Nuevo Cliente";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(69, 69, 210);
            button7.Enabled = false;
            button7.Location = new Point(-1, -1);
            button7.Name = "button7";
            button7.Size = new Size(977, 79);
            button7.TabIndex = 82;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.Location = new Point(582, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 86;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(387, 181);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 87;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 69, 210);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(558, 180);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 88;
            button2.Text = "⬇️INGRESAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(69, 69, 210);
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(849, 226);
            button5.Name = "button5";
            button5.Size = new Size(105, 35);
            button5.TabIndex = 117;
            button5.Text = "✏️EDITAR";
            button5.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(975, 527);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button8);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private DataGridView dataGridView1;
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
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private Button button2;
        private Button button5;
    }
}