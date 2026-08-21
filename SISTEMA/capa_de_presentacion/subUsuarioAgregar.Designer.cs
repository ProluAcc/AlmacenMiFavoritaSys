namespace SISTEMA
{
    partial class subUsuarioAgregar
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
            txtNombre = new TextBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label11 = new Label();
            txtRespuesta = new TextBox();
            label1 = new Label();
            txtPregunta = new TextBox();
            button6 = new Button();
            comboEstado = new ComboBox();
            label9 = new Label();
            comboRol = new ComboBox();
            label7 = new Label();
            btnIngresarW = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 23);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 145;
            label2.Text = "AGREGAR USUARIO";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(575, 79);
            button7.TabIndex = 144;
            button7.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(16, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 27);
            txtNombre.TabIndex = 149;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 148;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(16, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(145, 27);
            txtUsuario.TabIndex = 147;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(16, 98);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 146;
            label3.Text = "Nombre completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(16, 228);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 153;
            label6.Text = "Correo Electronico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(184, 98);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 152;
            label5.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.Location = new Point(16, 251);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(145, 27);
            txtCorreo.TabIndex = 151;
            txtCorreo.TextChanged += txtEmailU_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 11F);
            txtContrasena.Location = new Point(184, 121);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(172, 27);
            txtContrasena.TabIndex = 150;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.Location = new Point(184, 228);
            label11.Name = "label11";
            label11.Size = new Size(180, 20);
            label11.TabIndex = 157;
            label11.Text = "Respuesta de Seguridad:";
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Segoe UI", 11F);
            txtRespuesta.Location = new Point(184, 251);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(172, 27);
            txtRespuesta.TabIndex = 156;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(184, 162);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 155;
            label1.Text = "Pregunta de Seguridad:";
            // 
            // txtPregunta
            // 
            txtPregunta.Font = new Font("Segoe UI", 11F);
            txtPregunta.Location = new Point(184, 185);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(172, 27);
            txtPregunta.TabIndex = 154;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(519, 184);
            button6.Name = "button6";
            button6.Size = new Size(37, 29);
            button6.TabIndex = 162;
            button6.Text = "➕";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboEstado
            // 
            comboEstado.Font = new Font("Segoe UI", 11F);
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(378, 119);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(135, 28);
            comboEstado.TabIndex = 161;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(378, 96);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 160;
            label9.Text = "Estado:";
            // 
            // comboRol
            // 
            comboRol.Font = new Font("Segoe UI", 11F);
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(378, 184);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(135, 28);
            comboRol.TabIndex = 159;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(380, 159);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 158;
            label7.Text = "Rol:";
            // 
            // btnIngresarW
            // 
            btnIngresarW.BackColor = SystemColors.ButtonFace;
            btnIngresarW.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnIngresarW.ForeColor = Color.FromArgb(69, 69, 210);
            btnIngresarW.Location = new Point(145, 298);
            btnIngresarW.Name = "btnIngresarW";
            btnIngresarW.Size = new Size(134, 36);
            btnIngresarW.TabIndex = 163;
            btnIngresarW.Text = "➕AGREGAR";
            btnIngresarW.UseVisualStyleBackColor = false;
            btnIngresarW.Click += btnIngresarW_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(298, 298);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 197;
            button2.Text = "✖️CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // subUsuarioAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(575, 346);
            Controls.Add(button2);
            Controls.Add(btnIngresarW);
            Controls.Add(button6);
            Controls.Add(comboEstado);
            Controls.Add(label9);
            Controls.Add(comboRol);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(txtRespuesta);
            Controls.Add(label1);
            Controls.Add(txtPregunta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button7);
            Name = "subUsuarioAgregar";
            Text = "subUsuarioAgregar";
            Load += subUsuarioAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button7;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtUsuario;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label label11;
        private TextBox txtRespuesta;
        private Label label1;
        private TextBox txtPregunta;
        private Button button6;
        private ComboBox comboEstado;
        private Label label9;
        private ComboBox comboRol;
        private Label label7;
        private Button btnIngresarW;
        private Button button2;
    }
}