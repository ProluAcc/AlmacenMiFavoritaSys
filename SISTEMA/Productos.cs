using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SISTEMA
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            CBcategoria.Items.Add("Camisa");
            CBcategoria.Items.Add("Pantalón");
            CBcategoria.Items.Add("Zapatos");
            CBtalla.Items.Add("S");
            CBtalla.Items.Add("M");
            CBtalla.Items.Add("L");
            CBtalla.Items.Add("XL");
            CBtalla.Items.Add("XXL");
            CBtalla.Items.Add("XXXL");
            CBmarca.Items.Add("GUCCI");
            CBmarca.Items.Add("PRADA");
            CBmarca.Items.Add("BRAD & SHOW");
            CBmarca.Items.Add("PENGUIN");
            CBmarca.Items.Add("ADIDAS");
            CBmarca.Items.Add("NIKE");
            CBmarca.Items.Add("LEVI");
            CBmarca.Items.Add("B.S Style SCRN CLASSIC 2023");
            CBbuscar.Items.Add("Código");
            CBbuscar.Items.Add("Nombre");
            CBbuscar.Items.Add("Categoría");
            CBbuscar.Items.Add("Talla");
            CBbuscar.Items.Add("Marca");
            TXTstockmin.Text = "10";
            TXTstockmin.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu(); obj.Show(); this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria(); obj.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Talla obj = new Talla(); obj.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
             TXTcodigo.Text,
             TXTdescripcion.Text,
             CBcategoria.Text,
             CBtalla.Text,
             CBmarca.Text,
             TXTpreciov.Text,
             TXTnombre.Text,
             TXTprecioc.Text,
             TXTstockmax.Text,
             TXTstockmin.Text
             );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = TXTbuscar.Text.Trim();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                int columna = CBbuscar.SelectedIndex;

                if (fila.Cells[columna].Value != null &&
                    fila.Cells[columna].Value.ToString().Contains(buscar))
                {
                    dataGridView1.ClearSelection();
                    fila.Selected = true;
                    dataGridView1.CurrentCell = fila.Cells[columna];
                    return;
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTstockmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            TXTstockmin.Text = "1"; // valor fijo

            TXTcodigo.Clear();
            TXTnombre.Clear();
            TXTprecioc.Clear();
            TXTpreciov.Clear();
            TXTstockmax.Clear();
            TXTdescripcion.Clear();


            CBmarca.SelectedIndex = -1;
            CBcategoria.SelectedIndex = -1;
            CBtalla.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca(); obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

}
