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
            txtRestauracion = new TextBox();
            btnSeleccionar = new Button();
            btnRestaurar = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnEliminar = new Button();
            btnDescargar = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button1.Size = new Size(976, 61);
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
            groupBox1.Size = new Size(385, 109);
            groupBox1.TabIndex = 102;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Respaldo";
            // 
            // btnRespaldo
            // 
            btnRespaldo.BackColor = SystemColors.ControlLight;
            btnRespaldo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnRespaldo.ForeColor = Color.FromArgb(69, 69, 210);
            btnRespaldo.Location = new Point(176, 51);
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
            txtNombreRespaldo.Location = new Point(176, 18);
            txtNombreRespaldo.Name = "txtNombreRespaldo";
            txtNombreRespaldo.Size = new Size(190, 27);
            txtNombreRespaldo.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre del Respaldo:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(txtRestauracion);
            groupBox2.Controls.Add(btnSeleccionar);
            groupBox2.Controls.Add(btnRestaurar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(417, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(546, 109);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restaurar Base de Datos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtRestauracion
            // 
            txtRestauracion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtRestauracion.Location = new Point(202, 28);
            txtRestauracion.Name = "txtRestauracion";
            txtRestauracion.Size = new Size(338, 27);
            txtRestauracion.TabIndex = 16;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = SystemColors.ControlLight;
            btnSeleccionar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.FromArgb(69, 69, 210);
            btnSeleccionar.Location = new Point(6, 22);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(190, 38);
            btnSeleccionar.TabIndex = 16;
            btnSeleccionar.Text = "SELECCIONAR ARCHIVO";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = SystemColors.ControlLight;
            btnRestaurar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnRestaurar.ForeColor = Color.FromArgb(69, 69, 210);
            btnRestaurar.Location = new Point(392, 65);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(148, 38);
            btnRestaurar.TabIndex = 15;
            btnRestaurar.Text = "💾RESTAURAR";
            btnRestaurar.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(933, 215);
            dataGridView1.TabIndex = 104;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del Respaldo";
            Column1.Name = "Column1";
            Column1.Width = 890;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(945, 251);
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
            button7.Location = new Point(890, 14);
            button7.Name = "button7";
            button7.Size = new Size(73, 35);
            button7.TabIndex = 107;
            button7.Text = "AYUDA";
            button7.UseVisualStyleBackColor = false;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(975, 527);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnSeleccionar;
        private Button btnRestaurar;
        private Label label3;
        private TextBox txtRestauracion;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnEliminar;
        private Button btnDescargar;
        private DataGridViewTextBoxColumn Column1;
        private Button button7;
    }
}