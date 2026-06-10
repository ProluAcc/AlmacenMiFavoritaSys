using Pantalla_de_devolución;
using SISTEMA;

namespace Pantalla_ventas
{
    public partial class Ventas : Form
    {
        int numeroFactura;
        double subtotal = 0;
        double total = 0;

        Dictionary<string, double> producto = new Dictionary<string, double>()
        {
            {"Camisa Polo", 500},
            {"Camisa Manga Larga", 700},
            {"Camiseta Deportiva", 800},
            {"Pantalón Jeans", 600},
            {"Pantalón de Vestir", 650},
            { "Tenis Deportivos", 1200},
            { "Zapatos Formales", 1500},
            { "Botines", 1300 },
            { "Blusa Casual", 450 },
            { "Blusa Elegante", 650 },
            { "Camiseta Básica", 350 },
            { "Camiseta Estampada", 400 },
            { "Camisa Manga Larga m", 700 },
            { "Vestido Casual", 900 },
            { "Vestido de Fiesta", 1500 },
            { "Falda Corta", 500 },
            { "Falda Larga", 600 },
            { "Pantalón Jeans Dama", 800 },
        };

        Dictionary<string, List<string>> tipos = new Dictionary<string, List<string>>()
        {
            {
             "Ropa Masculina",
                new List<string>()
                {
                 "Camisa Polo",
                 "Camisa Manga Larga",
                 "Camiseta Deportiva",
                 "Pantalón Jeans",
                 "Pantalón de Vestir",
                }
            },

            {
            "Calzado masculino",
               new List<string>()
               {
                   "Tenis Deportivos",
                   "Zapatos Formales",
                   "Botas",
               }
            },

            {
                "Ropa Femenina",
                new List<string>()
                {
                    "Blusa Casual",
                    "Blusa Elegante",
                    "Camiseta Básica",
                    "Camiseta Estampada",
                    "Camisa Manga Larga m",
                    "Vestido Casual",
                    "Vestido de Fiesta",
                    "Falda Corta",
                    "Falda Larga",
                    "Pantalón Jeans Dama"
                }
            }
        };

        public Ventas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoseleccionado = cmbproducto.Text;

            txtprecio.Text = producto[productoseleccionado].ToString();

            double precioUnitario = Convert.ToDouble(txtprecio.Text);
            int cantidad = (int)numericant.Value;

            double total = precioUnitario * cantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToShortDateString();
            txtfecha.Enabled = false;

            txtfactura.Enabled = false;


            cmbtipo.Items.Add("Ropa Masculina");
            cmbtipo.Items.Add("Calzado masculino");
            cmbtipo.Items.Add("Ropa Femenina");

            if (File.Exists("factura.txt"))
            {
                numeroFactura = Convert.ToInt32(File.ReadAllText("factura.txt"));
            }
            else
            {
                numeroFactura = 1;
            }

            txtfactura.Text = numeroFactura.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu(); obj.Show(); this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Devolución obj = new Devolución(); obj.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbproducto.Items.Clear();

            string tiposeleccionado = cmbtipo.Text;

            if (tipos.ContainsKey(tiposeleccionado))
            {
                foreach (string producto in tipos[tiposeleccionado])
                {
                    cmbproducto.Items.Add(producto);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbproducto.SelectedIndex = -1;
            cmbtipo.SelectedIndex = -1;
            txttalla.Clear();
            numericant.Value = 0;
            txtprecio.Clear();
            txtdescuento.Clear();

            txtiva.Clear();
            txtsubtotal.Clear();
            txttotal.Clear();
            txtefectivo.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HistorialVentas obj = new HistorialVentas(); obj.ShowDialog();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string producto = cmbproducto.Text;
                string categoria = cmbtipo.Text;
                string talla = txttalla.Text;
                int cantidad = (int)numericant.Value;

                double porcentaje_descuento = Convert.ToDouble(txtdescuento.Text);
                double precio = Convert.ToDouble(txtprecio.Text);
                double descuento = precio * (porcentaje_descuento / 100);

                double valor = precio * cantidad;
                subtotal += valor - descuento;
                total += subtotal;

                if (txtdescuento.Text != "")
                {
                    descuento = Convert.ToDouble(txtdescuento.Text);
                }

                dgvventas.Rows.Add(producto, categoria, talla, precio, cantidad, valor, descuento, porcentaje_descuento.ToString() + "%", total);

                cmbtipo.SelectedIndex = -1;
                cmbproducto.SelectedIndex = -1;
                numericant.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la venta: " + ex.Message);
            }

            CalcularFactura();
        }

        private void CalcularFactura()
        {
            double subtotal = 0;

            foreach (DataGridViewRow fila in dgvventas.Rows)
                if (fila.Cells[6].Value != null)
                    subtotal += Convert.ToDouble(fila.Cells[5].Value);

            double iva = subtotal * 0.15;
            double total = subtotal + iva;

            txtsubtotal.Text = subtotal.ToString("N2");
            txtiva.Text = iva.ToString("N2");
            txttotal.Text = total.ToString("N2");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Devolución obj = new Devolución(); obj.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtefectivo.Text == "")
            {
                MessageBox.Show("Ingrese el monto entregado por el cliente.");
                return;
            }

            double monto = Convert.ToDouble(txtefectivo.Text);
            double total = Convert.ToDouble(txttotal.Text);

            if (monto < total)
            {
                MessageBox.Show("El monto es insuficiente para realizar el pago.");
                return;
            }

            double cambio = monto - total;

            MessageBox.Show(
                "Gracias por su compra, su cambio es de C$ " + cambio.ToString("N2"),
                "Pago realizado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            numeroFactura++;
            File.WriteAllText("factura.txt", numeroFactura.ToString("D3"));
            txtfactura.Text = numeroFactura.ToString();
        }
    }
}
