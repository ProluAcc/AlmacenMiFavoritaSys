namespace SISTEMA
{
    partial class HistorialVentas
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
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            textBox8 = new TextBox();
            comboBox2 = new ComboBox();
            label11 = new Label();
            button1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Control;
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(973, 259);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Historial de Ventas";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridView2.Location = new Point(6, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(961, 200);
            dataGridView2.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(69, 69, 210);
            button4.Location = new Point(460, 15);
            button4.Name = "button4";
            button4.Size = new Size(92, 35);
            button4.TabIndex = 11;
            button4.Text = "🔍Buscar";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(271, 24);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(183, 23);
            textBox8.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(100, 24);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 23);
            comboBox2.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 22);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 9;
            label11.Text = "Buscar por:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(558, 15);
            button1.Name = "button1";
            button1.Size = new Size(160, 35);
            button1.TabIndex = 13;
            button1.Text = "\U0001f9feEXPORTAR PDF";
            button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo de Venta";
            Column1.Name = "Column1";
            // 
            // Column7
            // 
            Column7.HeaderText = "No. Venta";
            Column7.Name = "Column7";
            Column7.Width = 120;
            // 
            // Column8
            // 
            Column8.HeaderText = "Fecha";
            Column8.Name = "Column8";
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Cliente";
            Column9.Name = "Column9";
            Column9.Width = 120;
            // 
            // Column10
            // 
            Column10.HeaderText = "Vendedor";
            Column10.Name = "Column10";
            Column10.Width = 120;
            // 
            // Column11
            // 
            Column11.HeaderText = "Total";
            Column11.Name = "Column11";
            Column11.Width = 120;
            // 
            // Column12
            // 
            Column12.HeaderText = "Pagado";
            Column12.Name = "Column12";
            Column12.Width = 120;
            // 
            // Column13
            // 
            Column13.HeaderText = "Estado";
            Column13.Name = "Column13";
            Column13.Width = 110;
            // 
            // Column14
            // 
            Column14.HeaderText = "Acciones";
            Column14.Name = "Column14";
            // 
            // HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(992, 278);
            Controls.Add(groupBox4);
            Name = "HistorialVentas";
            Text = "HistorialVentas";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button button1;
        private DataGridView dataGridView2;
        private Button button4;
        private TextBox textBox8;
        private ComboBox comboBox2;
        private Label label11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}