namespace SISTEMA
{
    partial class Mantenimiento
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
            button1 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnRespaldo = new Button();
            txtNombreRespaldo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtFechaRespaldo = new TextBox();
            label5 = new Label();
            txtRutaRespaldo = new TextBox();
            label4 = new Label();
            txtRestauracion = new TextBox();
            btnRestaurar = new Button();
            label3 = new Label();
            dgvRespaldo = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnEliminar = new Button();
            btnDescargar = new Button();
            button7 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRespaldo).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Enabled = false;
            button1.Location = new Point(0, -1);
            button1.Name = "button1";
            button1.Size = new Size(1189, 61);
            button1.TabIndex = 100;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 101;
            label2.Text = "MANTENIMIENTO";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnRespaldo);
            groupBox1.Controls.Add(txtNombreRespaldo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 109);
            groupBox1.TabIndex = 102;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Respaldo";
            // 
            // btnRespaldo
            // 
            btnRespaldo.BackColor = SystemColors.ControlLight;
            btnRespaldo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnRespaldo.ForeColor = Color.FromArgb(69, 69, 210);
            btnRespaldo.Location = new Point(259, 65);
            btnRespaldo.Name = "btnRespaldo";
            btnRespaldo.Size = new Size(190, 38);
            btnRespaldo.TabIndex = 15;
            btnRespaldo.Text = "💾CREAR RESPALDO";
            btnRespaldo.UseVisualStyleBackColor = false;
            btnRespaldo.Click += button2_Click;
            // 
            // txtNombreRespaldo
            // 
            txtNombreRespaldo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNombreRespaldo.Location = new Point(108, 26);
            txtNombreRespaldo.Name = "txtNombreRespaldo";
            txtNombreRespaldo.Size = new Size(341, 27);
            txtNombreRespaldo.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 40);
            label1.TabIndex = 4;
            label1.Text = "Nombre del \r\nRespaldo:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtFechaRespaldo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtRutaRespaldo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRestauracion);
            groupBox2.Controls.Add(btnRestaurar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(473, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 192);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restaurar Base de Datos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 126);
            label6.Name = "label6";
            label6.Size = new Size(74, 40);
            label6.TabIndex = 19;
            label6.Text = "Fecha de \r\nCreación:";
            // 
            // txtFechaRespaldo
            // 
            txtFechaRespaldo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtFechaRespaldo.Location = new Point(113, 129);
            txtFechaRespaldo.Name = "txtFechaRespaldo";
            txtFechaRespaldo.Size = new Size(394, 27);
            txtFechaRespaldo.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 74);
            label5.Name = "label5";
            label5.Size = new Size(77, 40);
            label5.TabIndex = 17;
            label5.Text = "Ruta del \r\nRespaldo:";
            // 
            // txtRutaRespaldo
            // 
            txtRutaRespaldo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtRutaRespaldo.Location = new Point(114, 77);
            txtRutaRespaldo.Name = "txtRutaRespaldo";
            txtRutaRespaldo.Size = new Size(394, 27);
            txtRutaRespaldo.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(96, 40);
            label4.TabIndex = 16;
            label4.Text = "Nombre del \r\nRespaldo:";
            // 
            // txtRestauracion
            // 
            txtRestauracion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtRestauracion.Location = new Point(114, 22);
            txtRestauracion.Name = "txtRestauracion";
            txtRestauracion.Size = new Size(394, 27);
            txtRestauracion.TabIndex = 16;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = SystemColors.ControlLight;
            btnRestaurar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnRestaurar.ForeColor = Color.FromArgb(69, 69, 210);
            btnRestaurar.Location = new Point(522, 26);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(148, 50);
            btnRestaurar.TabIndex = 15;
            btnRestaurar.Text = "💾RESTAURAR";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // dgvRespaldo
            // 
            dgvRespaldo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRespaldo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            dgvRespaldo.Location = new Point(6, 22);
            dgvRespaldo.Name = "dgvRespaldo";
            dgvRespaldo.Size = new Size(1152, 215);
            dgvRespaldo.TabIndex = 104;
            dgvRespaldo.CellContentDoubleClick += dgvRespaldo_CellContentDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(dgvRespaldo);
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1164, 251);
            groupBox3.TabIndex = 105;
            groupBox3.TabStop = false;
            groupBox3.Text = "Respaldos Existentes";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(btnEliminar);
            groupBox4.Controls.Add(btnDescargar);
            groupBox4.Location = new Point(12, 181);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(299, 77);
            groupBox4.TabIndex = 106;
            groupBox4.TabStop = false;
            groupBox4.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(69, 69, 210);
            btnEliminar.Location = new Point(154, 22);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 38);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "🗑️ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDescargar
            // 
            btnDescargar.BackColor = SystemColors.ControlLight;
            btnDescargar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnDescargar.ForeColor = Color.FromArgb(69, 69, 210);
            btnDescargar.Location = new Point(6, 22);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(142, 38);
            btnDescargar.TabIndex = 16;
            btnDescargar.Text = "📎DESCARGAR";
            btnDescargar.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(1103, 11);
            button7.Name = "button7";
            button7.Size = new Size(73, 35);
            button7.TabIndex = 107;
            button7.Text = "AYUDA";
            button7.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del Respaldo";
            Column1.Name = "Column1";
            Column1.Width = 400;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ruta del Respaldo";
            Column3.Name = "Column3";
            Column3.Width = 420;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de creación";
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1188, 527);
            Controls.Add(button7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRespaldo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNombreRespaldo;
        private Button btnRespaldo;
        private GroupBox groupBox2;
        private Button btnRestaurar;
        private Label label3;
        private TextBox txtRestauracion;
        private DataGridView dgvRespaldo;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnEliminar;
        private Button btnDescargar;
        private Button button7;
        private Label label6;
        private TextBox txtFechaRespaldo;
        private Label label5;
        private TextBox txtRutaRespaldo;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}