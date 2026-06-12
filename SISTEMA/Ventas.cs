using Pantalla_de_devolución;
using SISTEMA;
using System.Diagnostics;
using System.Text;

namespace Pantalla_ventas
{
    public partial class Ventas : Form
    {
        int numeroFactura;
        double subtotal = 0;
        double total = 0;

        public double Cambio { get; set; }

        Dictionary<string, double> producto = new Dictionary<string, double>()
        {
            { "Camisa Polo", 500 },
            { "Camisa Manga Larga", 700 },
            { "Camisa Manga Corta", 550 },
            { "Camisa Casual Cuadros", 650 },
            { "Camisa Formal Slim Fit", 800 },
            { "Pantalon Jeans Claico", 700 },
            { "Pantalon Jeans Skinny", 750 },
            { "Pantalon de Vestir", 850 },
            { "Pantalon Cargo", 900 },
            { "Pantalon Chino", 800 },
            { "Zapatos Formales", 1500 },
            { "Tenis Deportivos", 1200 },
            { "Botas de Trabajo", 1800 },
            { "Chinelas Playeras", 500 },
            { "Tacones Elegantes", 1400 },
            { "Sandalias Casuales", 900 },
            { "Botines Dama", 1600 },
            { "Chinelas Dama", 450 },
            { "Blusa Elegante", 650 },
            { "Camiseta Basica", 350 },
            { "Camisa Manga Larga Dama", 700 },
            { "Vestido de Fiesta", 1500 },
            { "Falda Corta", 500 },
            { "Falda Larga", 600 },
        };

        Dictionary<string, List<string>> tipos = new Dictionary<string, List<string>>()
        {
            {
             "Camisetas masculinas",
                new List<string>()
                {
                   "Camisa Polo",
                   "Camisa Manga Larga",
                   "Camisa Manga Corta",
                   "Camisa Casual Cuadros",
                   "Camisa Formal Slim Fit"
                }
            },

            {
            "Pantalones masculinos",
               new List<string>()
               {
                   "Pantalon Jeans Clasico",
                   "Pantalon Jeans Skinny",
                   "Pantalon de Vestir",
                   "Pantalon Cargo",
                   "Pantalon Chino"
               }
            },

            {
                "Calzado",
                new List<string>()
                {
                    "Zapatos Formales",
                    "Tenis Deportivos",
                    "Botas de Trabajo",
                    "Chinelas Playeras",
                    "Tacones Elegantes",
                    "Sandalias Casuales",
                    "Botines Dama",
                    "Chinelas Dama"
                }

            },

            {
                "Ropa Femenina",
                new List<string>()
                {
                    "Blusa Elegante",
                    "Camiseta Basica",
                    "Camisa Manga Larga Dama",
                    "Vestido de Fiesta",
                    "Falda Corta",
                    "Falda Larga",
                }
            }
        };

        Dictionary<string, List<string>> tallasPorProducto = new Dictionary<string, List<string>>()
        {
            { "Camisa Polo", new List<string>() { "S", "M", "L", "XL" } },
            { "Camisa Manga Larga", new List<string>() { "S", "M", "L", "XL" } },
            { "Camisa Manga Corta", new List<string>() { "S", "M", "L", "XL" } },
            { "Camisa Casual Cuadros", new List<string>() { "S", "M", "L", "XL" } },
            { "Camisa Formal Slim Fit", new List<string>() { "S", "M", "L", "XL" } },

            { "Pantalon Jeans Cl嫳ico", new List<string>() { "30", "32", "34", "36", "38", "40" } },
            { "Pantalon Jeans Skinny", new List<string>() { "30", "32", "34", "36", "38", "40" } },
            { "Pantalon de Vestir", new List<string>() { "30", "32", "34", "36", "38", "40" } },
            { "Pantalon Cargo", new List<string>() { "30", "32", "34", "36", "38", "40" } },
            { "Pantalon Chino", new List<string>() { "30", "32", "34", "36", "38", "40" } },

            { "Zapatos Formales", new List<string>() { "38", "39", "40", "41", "42", "43" } },
            { "Tenis Deportivos", new List<string>() { "38", "39", "40", "41", "42", "43" } },
            { "Botas de Trabajo", new List<string>() { "38", "39", "40", "41", "42", "43" } },
            { "Chinelas Playeras", new List<string>() { "38", "39", "40", "41", "42", "43" } },

            { "Tacones Elegantes", new List<string>() { "35", "36", "37", "38", "39" } },
            { "Sandalias Casuales", new List<string>() { "35", "36", "37", "38", "39" } },
            { "Botines Dama", new List<string>() { "35", "36", "37", "38", "39" } },
            { "Chinelas Dama", new List<string>() { "35", "36", "37", "38", "39" } },

            { "Blusa Elegante", new List<string>() { "S", "M", "L", "XL" } },
            { "Camiseta Basica", new List<string>() { "S", "M", "L", "XL" } },
            { "Camisa Manga Larga Dama", new List<string>() { "S", "M", "L", "XL" } },
            { "Vestido de Fiesta", new List<string>() { "S", "M", "L", "XL" } },
            { "Falda Corta", new List<string>() { "S", "M", "L", "XL" } },
            { "Falda Larga", new List<string>() { "S", "M", "L", "XL" } },
        };



        public Ventas()
        {
            InitializeComponent();
            btnnuevoo.Enabled = false;
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
            string productoSeleccionado = cmbproducto.Text;

            if (producto.ContainsKey(productoSeleccionado))
            {
                txtprecio.Text = producto[productoSeleccionado].ToString();
            }

            cmbbtalla.Items.Clear();

            if (tallasPorProducto.ContainsKey(productoSeleccionado))
            {
                foreach (string talla in tallasPorProducto[productoSeleccionado])
                {
                    cmbbtalla.Items.Add(talla);
                }
            }

            cmbbtalla.SelectedIndex = -1;


            string productoseleccionado = cmbproducto.Text;


            MessageBox.Show(productoseleccionado);
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
            txtfecha.Enabled = false;
            txtfecha.Text = DateTime.Now.ToShortDateString();
            txtfecha.Enabled = false;

            txtfactura.Enabled = false;


            cmbcategoria.Items.Add("Camisetas masculinas");
            cmbcategoria.Items.Add("Pantalones masculinos");
            cmbcategoria.Items.Add("Calzado");
            cmbcategoria.Items.Add("Ropa Femenina");

            cmbbtalla.DropDownStyle = ComboBoxStyle.DropDownList;


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
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cmbcategoria.SelectedIndex = -1;
            cmbproducto.SelectedIndex = -1;
            cmbbtalla.SelectedIndex = -1;
            numericant.Value = 0;
            txtprecio.Clear();
            txtdescuento.Clear();
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
                string categoria = cmbcategoria.Text;
                string talla = cmbbtalla.Text;
                double precio = Convert.ToDouble(txtprecio.Text);
                int cantidad = (int)numericant.Value;
                double valor = precio * cantidad;

                double porcentaje_descuento = Convert.ToDouble(txtdescuento.Text);
                if (porcentaje_descuento < 0 || porcentaje_descuento > 100)
                {
                    MessageBox.Show("El descuento debe estar entre 0 y 100%.");
                    return;
                }

                double descuento = valor * (porcentaje_descuento / 100); //valor(20% / 100)


                if (txtcliente.Text == "" ||
                cmbcategoria.Text == "" ||
                cmbproducto.Text == "" ||
                cmbbtalla.Text == " " ||
                txtdescuento.Text == "" ||
                txtprecio.Text == "" ||
                numericant.Value == 0)
                {
                    MessageBox.Show("Debe completar todos los campos antes de ingresar la venta.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbbtalla.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una talla valida.");
                    return;
                }

                dgvventas.Rows.Add(producto, categoria, talla, precio, cantidad, valor, porcentaje_descuento.ToString() + "%", descuento);


                btnfactura.Enabled = false;
                btncambio.Enabled = true;
                btnnuevoo.Enabled = false;
                cmbcategoria.SelectedIndex = -1;
                cmbproducto.SelectedIndex = -1;
                numericant.Value = 0;

                CalcularFactura(valor, descuento);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la venta: " + ex.Message);
            }

            numeroFactura++;
            File.WriteAllText("factura.txt", numeroFactura.ToString("D3"));
            txtfactura.Text = numeroFactura.ToString();
        }

        private void CalcularFactura(double valor, double descuento)
        {
            double iva = valor * 0.15;
            subtotal += valor + iva;
            total = subtotal - descuento;

            txtsubtotal.Text = subtotal.ToString("N2");
            txtiva.Text = iva.ToString("N2");
            txttotal.Text = total.ToString("N2");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Devolución obj = new Devolución(); obj.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

            MessageBox.Show("Gracias por su compra, su cambio es de C$ " + cambio.ToString("N2"), "Pago realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnfactura.Enabled = false;
            buttonIngresar.Enabled = false;
            btnlimpiar.Enabled = false;

            numeroFactura++;
            File.WriteAllText("factura.txt", numeroFactura.ToString("D3"));
            txtfactura.Text = numeroFactura.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<html>");
            html.Append("<head>");
            html.Append("<title>Factura</title>");
            html.Append("</head>");
            html.Append("<body>");

            html.Append("<h1 align='center'>LA FAVORITA - MATAGALPA</h1>");
            html.Append("<h2 align='center'>FACTURA DE VENTA</h2>");

            html.Append("<p><b>No. Factura:</b> " + txtfactura.Text + "</p>");
            html.Append("<p><b>Fecha:</b> " + txtfecha.Text + "</p>");
            html.Append("<p><b>Cliente:</b> " + txtcliente.Text + "</p>");

            html.Append("<br>");

            html.Append("<table border='1' cellpadding='5' cellspacing='0'>");

            html.Append("<tr>");
            html.Append("<th>Producto</th>");
            html.Append("<th>Categoria</th>");
            html.Append("<th>Medida</th>");
            html.Append("<th>Precio</th>");
            html.Append("<th>Cantidad</th>");
            html.Append("<th>Valor</th>");
            html.Append("<th>Descuento</th>");
            html.Append("<th>% Descuento</th>");
            html.Append("</tr>");

            foreach (DataGridViewRow fila in dgvventas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    html.Append("<tr>");

                    html.Append("<td>" + fila.Cells[0].Value + "</td>");
                    html.Append("<td>" + fila.Cells[1].Value + "</td>");
                    html.Append("<td>" + fila.Cells[2].Value + "</td>");
                    html.Append("<td>" + fila.Cells[3].Value + "</td>");
                    html.Append("<td>" + fila.Cells[4].Value + "</td>");
                    html.Append("<td>" + fila.Cells[5].Value + "</td>");
                    html.Append("<td>" + fila.Cells[6].Value + "</td>");
                    html.Append("<td>" + fila.Cells[7].Value + "</td>");

                    html.Append("</tr>");
                }
            }

            html.Append("</table>");

            html.Append("<br><br>");

            html.Append("<p><b>Subtotal:</b> C$ " + txtsubtotal.Text + "</p>");
            html.Append("<p><b>IVA (15%):</b> C$ " + txtiva.Text + "</p>");
            html.Append("<p><b>Total:</b> C$ " + txttotal.Text + "</p>");
            html.Append("<p><b>Monto recibido:</b> C$ " + txtefectivo.Text + "</p>");

            html.Append("<br>");
            html.Append("<h3>：racias por su compra!</h3>");

            html.Append("</body>");
            html.Append("</html>");

            File.WriteAllText("Factura_" + txtfactura.Text + ".html", html.ToString());

            Process.Start(new ProcessStartInfo()
            {
                FileName = "Factura_" + txtfactura.Text + ".html",
                UseShellExecute = true
            });

            MessageBox.Show("Factura generada correctamente.");

            numeroFactura++;
            File.WriteAllText("factura.txt", numeroFactura.ToString("D3"));
            txtfactura.Text = numeroFactura.ToString();

            btnnuevoo.Enabled = true;
            btnfactura.Enabled = false;
            buttonIngresar.Enabled = false;
            btnlimpiar.Enabled = false;
            btncambio.Enabled = false;
            dgvventas.Rows.Clear();
        }
   
        private void btnnuevoo_Click(object sender, EventArgs e)
        {
            txtcliente.Clear();
            cmbproducto.SelectedIndex = -1;
            cmbcategoria.SelectedIndex = -1;
            cmbbtalla.SelectedIndex = -1;
            numericant.Value = 0;
            txtprecio.Clear();
            txtdescuento.Clear();

            txtiva.Clear();
            txtsubtotal.Clear();
            txttotal.Clear();
            txtefectivo.Clear();

            buttonIngresar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnnuevoo.Enabled = true;

            numeroFactura++;
            File.WriteAllText("factura.txt", numeroFactura.ToString("D3"));
            txtfactura.Text = numeroFactura.ToString();

            btnnuevoo.Enabled = false;
        }

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbtalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbtalla.Items.Add("Camisetas masculinas");
            cmbbtalla.Items.Add("Pantalones masculinos");
            cmbbtalla.Items.Add("Calzado");
            cmbbtalla.Items.Add("Ropa Femenina");
        }

        private void cmbcategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbcategoria_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            cmbproducto.Items.Clear();

            string tiposeleccionado = cmbcategoria.Text;

            if (tipos.ContainsKey(tiposeleccionado))
            {
                foreach (string producto in tipos[tiposeleccionado])
                {
                    cmbproducto.Items.Add(producto);
                }
            }
        }
    }
}
