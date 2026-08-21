namespace SISTEMA
{
    partial class ControlRol
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
            groupBox1 = new GroupBox();
            rbCompra = new RadioButton();
            rbVenta = new RadioButton();
            rbInventario = new RadioButton();
            rbMantenimiento = new RadioButton();
            rbTodo = new RadioButton();
            rbCaja = new RadioButton();
            label5 = new Label();
            button1 = new Button();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button5 = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(rbCompra);
            groupBox1.Controls.Add(rbVenta);
            groupBox1.Controls.Add(rbInventario);
            groupBox1.Controls.Add(rbMantenimiento);
            groupBox1.Controls.Add(rbTodo);
            groupBox1.Controls.Add(rbCaja);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categoría";
            // 
            // rbCompra
            // 
            rbCompra.AutoSize = true;
            rbCompra.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbCompra.Location = new Point(83, 131);
            rbCompra.Name = "rbCompra";
            rbCompra.Size = new Size(85, 24);
            rbCompra.TabIndex = 132;
            rbCompra.TabStop = true;
            rbCompra.Text = "Compra";
            rbCompra.UseVisualStyleBackColor = true;
            // 
            // rbVenta
            // 
            rbVenta.AutoSize = true;
            rbVenta.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbVenta.Location = new Point(181, 131);
            rbVenta.Name = "rbVenta";
            rbVenta.Size = new Size(69, 24);
            rbVenta.TabIndex = 131;
            rbVenta.TabStop = true;
            rbVenta.Text = "Venta";
            rbVenta.UseVisualStyleBackColor = true;
            // 
            // rbInventario
            // 
            rbInventario.AutoSize = true;
            rbInventario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbInventario.Location = new Point(271, 131);
            rbInventario.Name = "rbInventario";
            rbInventario.Size = new Size(103, 24);
            rbInventario.TabIndex = 130;
            rbInventario.TabStop = true;
            rbInventario.Text = "Inventario";
            rbInventario.UseVisualStyleBackColor = true;
            // 
            // rbMantenimiento
            // 
            rbMantenimiento.AutoSize = true;
            rbMantenimiento.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbMantenimiento.Location = new Point(17, 166);
            rbMantenimiento.Name = "rbMantenimiento";
            rbMantenimiento.Size = new Size(139, 24);
            rbMantenimiento.TabIndex = 129;
            rbMantenimiento.TabStop = true;
            rbMantenimiento.Text = "Mantenimiento";
            rbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // rbTodo
            // 
            rbTodo.AutoSize = true;
            rbTodo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbTodo.Location = new Point(162, 166);
            rbTodo.Name = "rbTodo";
            rbTodo.Size = new Size(67, 24);
            rbTodo.TabIndex = 128;
            rbTodo.TabStop = true;
            rbTodo.Text = "Todo";
            rbTodo.UseVisualStyleBackColor = true;
            // 
            // rbCaja
            // 
            rbCaja.AutoSize = true;
            rbCaja.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            rbCaja.Location = new Point(17, 131);
            rbCaja.Name = "rbCaja";
            rbCaja.Size = new Size(57, 24);
            rbCaja.TabIndex = 121;
            rbCaja.TabStop = true;
            rbCaja.Text = "Caja";
            rbCaja.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(240, 20);
            label5.TabIndex = 120;
            label5.Text = "Módulos a los que tendrá acceso:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(129, 200);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 117;
            button1.Text = "✔️GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtDescripcion.Location = new Point(106, 57);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 27);
            txtDescripcion.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 97;
            label1.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtNombre.Location = new Point(83, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 95;
            label3.Text = "Nombre:";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(402, 68);
            button4.Name = "button4";
            button4.Size = new Size(265, 35);
            button4.TabIndex = 119;
            button4.Text = "🔓HABILITAR/DESHABILITAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(287, 68);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 118;
            button2.Text = "✏EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(249, 20);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 116;
            button3.Text = "🔍BUSCAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox6.Location = new Point(78, 24);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 27);
            textBox6.TabIndex = 115;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(16, 27);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 114;
            label4.Text = "Buscar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(16, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 247);
            dataGridView1.TabIndex = 104;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripción";
            Column2.Name = "Column2";
            Column2.Width = 370;
            // 
            // Column3
            // 
            Column3.HeaderText = "Activo";
            Column3.Name = "Column3";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 48);
            panel1.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(69, 69, 210);
            button5.Location = new Point(1009, 5);
            button5.Name = "button5";
            button5.Size = new Size(73, 35);
            button5.TabIndex = 18;
            button5.Text = "AYUDA";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 81;
            label2.Text = "AGREGAR ROL";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(407, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 376);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
            // 
            // ControlRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1094, 439);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ControlRol";
            Text = "ControlRol";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox textBox6;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtDescripcion;
        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rbCompra;
        private RadioButton rbVenta;
        private RadioButton rbInventario;
        private RadioButton rbMantenimiento;
        private RadioButton rbTodo;
        private RadioButton rbCaja;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button5;
    }
}