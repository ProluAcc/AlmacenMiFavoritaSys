namespace SISTEMA
{
    partial class subUsuarioEliminar
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
            btnCancelar = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.Size = new Size(250, 32);
            label2.TabIndex = 161;
            label2.Text = "ELIMINAR USUARIO";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(844, 79);
            button7.TabIndex = 160;
            button7.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(69, 69, 210);
            btnCancelar.Location = new Point(614, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 34);
            btnCancelar.TabIndex = 166;
            btnCancelar.Text = "🗑ELIMINAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(482, 97);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 165;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(315, 102);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 164;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(167, 102);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 163;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(100, 105);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 162;
            label7.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column6, Column5, Column1, Column3, Column9, Column4, Column7 });
            dataGridView1.Location = new Point(1, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 127);
            dataGridView1.TabIndex = 167;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre Completo ";
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "Usuario ";
            Column6.Name = "Column6";
            // 
            // Column5
            // 
            Column5.HeaderText = "Correo Electronico ";
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.HeaderText = "Contraseña";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Pregunta";
            Column3.Name = "Column3";
            // 
            // Column9
            // 
            Column9.HeaderText = "Respuesta";
            Column9.Name = "Column9";
            // 
            // Column4
            // 
            Column4.HeaderText = "Rol ";
            Column4.Name = "Column4";
            // 
            // Column7
            // 
            Column7.HeaderText = "Estado ";
            Column7.Name = "Column7";
            // 
            // subUsuarioEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(844, 278);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(button7);
            Name = "subUsuarioEliminar";
            Text = "subUsuarioEliminar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button7;
        private Button btnCancelar;
        private Button button1;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
    }
}