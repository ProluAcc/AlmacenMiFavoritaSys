namespace SISTEMA
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnNivelacionInventario = new Button();
            btnInventario = new Button();
            panel3 = new Panel();
            label5 = new Label();
            button6 = new Button();
            label3 = new Label();
            btnUsuario = new Button();
            btnClientes = new Button();
            btnProducto = new Button();
            btnProveedor = new Button();
            panelContenedor = new Panel();
            label2 = new Label();
            lblBienvenida = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(4, 382);
            button4.Name = "button4";
            button4.Size = new Size(158, 43);
            button4.TabIndex = 22;
            button4.Text = "Crédito ->";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(69, 69, 210);
            button3.Location = new Point(4, 284);
            button3.Name = "button3";
            button3.Size = new Size(156, 43);
            button3.TabIndex = 21;
            button3.Text = "Ventas ->";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(69, 69, 210);
            button2.Location = new Point(4, 333);
            button2.Name = "button2";
            button2.Size = new Size(156, 43);
            button2.TabIndex = 20;
            button2.Text = "Compras ->";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnNivelacionInventario);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnUsuario);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(btnProveedor);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 686);
            panel1.TabIndex = 82;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(2, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 1);
            panel2.TabIndex = 8;
            // 
            // btnNivelacionInventario
            // 
            btnNivelacionInventario.BackColor = SystemColors.ButtonFace;
            btnNivelacionInventario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnNivelacionInventario.ForeColor = Color.FromArgb(69, 69, 210);
            btnNivelacionInventario.Location = new Point(3, 609);
            btnNivelacionInventario.Name = "btnNivelacionInventario";
            btnNivelacionInventario.Size = new Size(156, 52);
            btnNivelacionInventario.TabIndex = 87;
            btnNivelacionInventario.Text = "Nivelación de Inventario ->";
            btnNivelacionInventario.UseVisualStyleBackColor = false;
            btnNivelacionInventario.Click += btnNivelacionInventario_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.ButtonFace;
            btnInventario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnInventario.ForeColor = Color.FromArgb(69, 69, 210);
            btnInventario.Location = new Point(3, 564);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(156, 40);
            btnInventario.TabIndex = 86;
            btnInventario.Text = "Inventario ->";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(2, 525);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 1);
            panel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 529);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 85;
            label5.Text = "Administrar";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(69, 69, 210);
            button6.Location = new Point(3, 106);
            button6.Name = "button6";
            button6.Size = new Size(156, 44);
            button6.TabIndex = 83;
            button6.Text = "Caja ->";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 249);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 5;
            label3.Text = "Módulos";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = SystemColors.ButtonFace;
            btnUsuario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnUsuario.ForeColor = Color.FromArgb(69, 69, 210);
            btnUsuario.Location = new Point(3, 474);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(156, 40);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario ->";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.ButtonFace;
            btnClientes.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnClientes.ForeColor = Color.FromArgb(69, 69, 210);
            btnClientes.Location = new Point(3, 431);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(156, 37);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes ->";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = SystemColors.ButtonFace;
            btnProducto.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnProducto.ForeColor = Color.FromArgb(69, 69, 210);
            btnProducto.Location = new Point(2, 156);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(156, 39);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto ->";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = SystemColors.ButtonFace;
            btnProveedor.FlatAppearance.BorderColor = Color.FromArgb(222, 72, 72);
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnProveedor.ForeColor = Color.FromArgb(69, 69, 210);
            btnProveedor.Location = new Point(2, 201);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(158, 37);
            btnProveedor.TabIndex = 1;
            btnProveedor.Text = "Proveedor ->";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gainsboro;
            panelContenedor.BorderStyle = BorderStyle.FixedSingle;
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(lblBienvenida);
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(button1);
            panelContenedor.Location = new Point(167, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(975, 727);
            panelContenedor.TabIndex = 83;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 139);
            label2.Name = "label2";
            label2.Size = new Size(223, 32);
            label2.TabIndex = 23;
            label2.Text = "¿Qué desea hacer?";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(364, 85);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(260, 32);
            lblBienvenida.TabIndex = 22;
            lblBienvenida.Text = "¡Bienvenido, Usuario!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 255);
            button1.Location = new Point(432, 497);
            button1.Name = "button1";
            button1.Size = new Size(117, 51);
            button1.TabIndex = 20;
            button1.Text = "<- REGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1142, 688);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "Bienvenida";
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Button btnUsuario;
        private Button btnClientes;
        private Button btnProducto;
        private Button btnProveedor;
        private Button button6;
        private Panel panelContenedor;
        private Label label2;
        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnNivelacionInventario;
        private Button btnInventario;
        private Panel panel3;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}