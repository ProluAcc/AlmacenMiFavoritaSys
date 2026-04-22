namespace SISTEMA
{
    partial class Recuperacion
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 72, 72);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 304);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(23, 23, 255);
            button2.Location = new Point(17, 251);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 8;
            button2.Text = "<- Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 69, 255);
            button1.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 255);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(131, 251);
            button1.Name = "button1";
            button1.Size = new Size(85, 32);
            button1.TabIndex = 7;
            button1.Text = "Recuperar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ControlDarkDark;
            textBox3.Location = new Point(17, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Confirmar contraseña";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ControlDarkDark;
            textBox2.Location = new Point(17, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Ingresar nueva contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 184);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 4;
            label4.Text = "Confirmar contraseña nueva:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 124);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese contraseña nueva:";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(17, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "ejemplo@correo.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 0;
            label1.Text = "Recuperación de Contraseña";
            // 
            // Recuperacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(378, 331);
            Controls.Add(panel1);
            Name = "Recuperacion";
            Text = "Recuperacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}