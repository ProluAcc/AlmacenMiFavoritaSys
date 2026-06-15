using SISTEMA;
using System.Globalization;

namespace Registro_de_compra
{

    public partial class Compra : Form
    {
        // running totals
        private decimal _subtotalAcumulado = 0m;
        private decimal _ivaAcumulado = 0m;
        private decimal _totalAcumulado = 0m;

        // IVA rate (change if your tax rate is different)
        private const decimal IvaRate = 0.15m;

        public Compra(string username)
        {
            InitializeComponent();
            comboBox3.Text = username;

            // wire the ingresar button (button3) to the handler
            // the designer didn't set an event handler for button3; do it here
            //button3.Click += button3.Click;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validate product
            var producto = comboBox1.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(producto))
            {
                MessageBox.Show("Seleccione o escriba el nombre del producto.", "Producto requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate quantity
            if (!TryParseDecimalFromControl(textBox9.Text, out var cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor que 0.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate price
            if (!TryParseDecimalFromControl(textBox10.Text, out var precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio de compra válido (>= 0).", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Calculate line values
            var lineaSubtotal = cantidad * precio;
            var lineaIva = Math.Round(lineaSubtotal * IvaRate, 2);
            var lineaTotal = lineaSubtotal + lineaIva;

            // Add row to DataGridView
            dataGridView1.Rows.Add(
                producto,
                cantidad.ToString("G"),                 // Cantidad
                precio.ToString("F2", CultureInfo.InvariantCulture),    // Precio de compra
                lineaSubtotal.ToString("F2", CultureInfo.InvariantCulture), // Subtotal
                lineaIva.ToString("F2", CultureInfo.InvariantCulture),       // IVA
                lineaTotal.ToString("F2", CultureInfo.InvariantCulture)      // Total
            );

            // Update running totals
            _subtotalAcumulado += lineaSubtotal;
            _ivaAcumulado += lineaIva;
            _totalAcumulado += lineaTotal;

            // Update labels in panel8 to show numeric totals.
            // The designer used label8/label9/label10 as text labels; replace their Text
            // to present the numeric values together with the label.
            label8.Text = $"Subtotal: C${_subtotalAcumulado:F2}";
            label9.Text = $"IVA ({IvaRate:P0}): C${_ivaAcumulado:F2}";
            label10.Text = $"Total Compra: C${_totalAcumulado:F2}";

            // Optional: clear product entry controls so user can add next line quickly
            comboBox1.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;

            // Focus product input for faster data entry
            comboBox1.Focus();
        }

        // helper: try parse decimal respecting both comma and dot decimal separators
        private static bool TryParseDecimalFromControl(string raw, out decimal value)
        {
            value = 0m;
            if (string.IsNullOrWhiteSpace(raw))
                return false;

            // try invariant then culture with comma
            var styles = System.Globalization.NumberStyles.Number;
            if (decimal.TryParse(raw, styles, CultureInfo.InvariantCulture, out value))
                return true;
            if (decimal.TryParse(raw, styles, new CultureInfo("es-ES"), out value))
                return true;
            if (decimal.TryParse(raw, styles, CultureInfo.CurrentCulture, out value))
                return true;

            // last resort: replace comma/dot and try again
            var cleaned = raw.Replace(",", ".").Replace(" ", string.Empty);
            return decimal.TryParse(cleaned, styles, CultureInfo.InvariantCulture, out value);


        }

        private void Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
