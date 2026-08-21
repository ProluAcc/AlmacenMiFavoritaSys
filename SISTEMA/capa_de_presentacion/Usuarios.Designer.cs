namespace SISTEMA
{
    partial class Usuarios
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
            label1 = new Label();
            panel2 = new Panel();
            button7 = new Button();
            btnIngresarW = new Button();
            btnEditarM = new Button();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            cmbBuscarQ = new ComboBox();
            textbuscarT = new TextBox();
            btnBuscarD = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 77;
            label1.Text = "NUEVO USUARIO";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 68);
            panel2.TabIndex = 101;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(69, 69, 210);
            button7.Location = new Point(834, 15);
            button7.Name = "button7";
            button7.Size = new Size(73, 35);
            button7.TabIndex = 119;
            button7.Text = "AYUDA";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // btnIngresarW
            // 
            btnIngresarW.BackColor = SystemColors.ButtonFace;
            btnIngresarW.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnIngresarW.ForeColor = Color.FromArgb(69, 69, 210);
            btnIngresarW.Location = new Point(346, 103);
            btnIngresarW.Name = "btnIngresarW";
            btnIngresarW.Size = new Size(118, 36);
            btnIngresarW.TabIndex = 107;
            btnIngresarW.Text = "⬇️INGRESAR";
            btnIngresarW.UseVisualStyleBackColor = false;
            btnIngresarW.Click += btnIngresarW_Click_1;
            // 
            // btnEditarM
            // 
            btnEditarM.BackColor = SystemColors.ButtonFace;
            btnEditarM.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnEditarM.ForeColor = Color.FromArgb(69, 69, 210);
            btnEditarM.Location = new Point(475, 104);
            btnEditarM.Name = "btnEditarM";
            btnEditarM.Size = new Size(129, 35);
            btnEditarM.TabIndex = 117;
            btnEditarM.Text = "✏️EDITAR";
            btnEditarM.UseVisualStyleBackColor = false;
            btnEditarM.Click += btnEditarM_Click_1;
            // 
            // Column7
            // 
            Column7.HeaderText = "Estado ";
            Column7.Name = "Column7";
            Column7.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Rol ";
            Column4.Name = "Column4";
            Column4.Width = 110;
            // 
            // Column9
            // 
            Column9.HeaderText = "Respuesta";
            Column9.Name = "Column9";
            Column9.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Pregunta";
            Column3.Name = "Column3";
            Column3.Width = 110;
            // 
            // Column1
            // 
            Column1.HeaderText = "Contraseña";
            Column1.Name = "Column1";
            Column1.Width = 110;
            // 
            // Column5
            // 
            Column5.HeaderText = "Correo Electronico ";
            Column5.Name = "Column5";
            Column5.Width = 110;
            // 
            // Column6
            // 
            Column6.HeaderText = "Usuario ";
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre Completo ";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column6, Column5, Column1, Column3, Column9, Column4, Column7 });
            dataGridView1.Location = new Point(0, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(924, 209);
            dataGridView1.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.Location = new Point(207, 160);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 96;
            label10.Text = "Buscar por:";
            // 
            // cmbBuscarQ
            // 
            cmbBuscarQ.Font = new Font("Segoe UI", 11F);
            cmbBuscarQ.FormattingEnabled = true;
            cmbBuscarQ.Location = new Point(302, 157);
            cmbBuscarQ.Name = "cmbBuscarQ";
            cmbBuscarQ.Size = new Size(121, 28);
            cmbBuscarQ.TabIndex = 97;
            // 
            // textbuscarT
            // 
            textbuscarT.Font = new Font("Segoe UI", 11F);
            textbuscarT.Location = new Point(429, 157);
            textbuscarT.Name = "textbuscarT";
            textbuscarT.Size = new Size(157, 27);
            textbuscarT.TabIndex = 98;
            // 
            // btnBuscarD
            // 
            btnBuscarD.BackColor = SystemColors.ButtonFace;
            btnBuscarD.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnBuscarD.ForeColor = Color.FromArgb(69, 69, 210);
            btnBuscarD.Location = new Point(604, 152);
            btnBuscarD.Name = "btnBuscarD";
            btnBuscarD.Size = new Size(118, 36);
            btnBuscarD.TabIndex = 102;
            btnBuscarD.Text = "🔍 BUSCAR";
            btnBuscarD.UseVisualStyleBackColor = false;
            btnBuscarD.Click += btnBuscarD_Click_1;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(926, 412);
            Controls.Add(btnEditarM);
            Controls.Add(btnIngresarW);
            Controls.Add(btnBuscarD);
            Controls.Add(dataGridView1);
            Controls.Add(textbuscarT);
            Controls.Add(cmbBuscarQ);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private Button btnIngresarW;
        private Button btnEditarM;
        private Button button7;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox cmbBuscarQ;
        private TextBox textbuscarT;
        private Button btnBuscarD;
    }
}