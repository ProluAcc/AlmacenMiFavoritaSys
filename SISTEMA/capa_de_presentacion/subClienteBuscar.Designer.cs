namespace SISTEMA
{
    partial class subClienteBuscar
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
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(69, 69, 210);
            button1.Location = new Point(439, 96);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 91;
            button1.Text = "🔍BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtBuscar.Location = new Point(279, 99);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 27);
            txtBuscar.TabIndex = 90;
            // 
            // cbBuscar
            // 
            cbBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(131, 99);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(142, 28);
            cbBuscar.TabIndex = 89;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(64, 102);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 88;
            label7.Text = "Buscar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 101;
            label2.Text = "BUSCAR CLIENTE";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(606, 79);
            button7.TabIndex = 100;
            button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4 });
            dataGridView1.Location = new Point(0, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 120);
            dataGridView1.TabIndex = 102;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre de Cliente";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Teléfono";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 90;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dirección";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Correo";
            Column6.Name = "Column6";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // subClienteBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(608, 271);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label7);
            Name = "subClienteBuscar";
            Text = "subClienteBuscar";
            Load += subClienteBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label7;
        private Label label2;
        private Button button7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
    }
}