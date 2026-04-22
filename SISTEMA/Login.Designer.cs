namespace SISTEMA
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnRecuperar = new Button();
            label4 = new Label();
            splitter2 = new Splitter();
            label5 = new Label();
            txtContrasena = new TextBox();
            btnEntrar = new Button();
            label6 = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 72, 72);
            panel2.Controls.Add(btnRecuperar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(splitter2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(372, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 281);
            panel2.TabIndex = 7;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.FromArgb(69, 69, 255);
            btnRecuperar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecuperar.ForeColor = Color.White;
            btnRecuperar.Location = new Point(99, 233);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(89, 30);
            btnRecuperar.TabIndex = 15;
            btnRecuperar.Text = "Recuperar ->";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 205);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 14;
            label4.Text = "¿No recuerdas la contraseña?";
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Bottom;
            splitter2.Location = new Point(0, 216);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(300, 65);
            splitter2.TabIndex = 13;
            splitter2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 90);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(27, 108);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(214, 23);
            txtContrasena.TabIndex = 11;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(69, 69, 255);
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(100, 153);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(89, 29);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 26);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 9;
            label6.Text = "Nombre de Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(27, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 23);
            txtUsuario.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(685, 331);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnRecuperar;
        private Label label4;
        private Splitter splitter2;
        private Label label5;
        private TextBox txtContrasena;
        private Button btnEntrar;
        private Label label6;
        private TextBox txtUsuario;
    }
}
