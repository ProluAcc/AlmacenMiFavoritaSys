using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caja;
using Pantalla_de_devolución;
using Registro_de_compra;
using Pantalla_ventas;
using Inventario;
using Control_de_egresos_de_caja;

namespace SISTEMA
{
    public partial class Menu : Form
    {
        string nombreUsuario;
        public Menu(string username)
        {
            InitializeComponent();
            MostrarFormularioMdi(new frmBienvenida(username));
            nombreUsuario = username;
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void MostrarFormularioMdi(Form formulario)
        {
            // Cerrar formulario anterior si existe
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                Application.DoEvents();
            }

            // Configurar nuevo formulario
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.Manual;

            // Calcular posición centrada
            int x = (this.ClientSize.Width - formulario.Width) / 2;
            int y = (this.ClientSize.Height - formulario.Height) / 2;
            formulario.Location = new Point(x, y);

            formulario.Show();
            formulario.Focus();
        }

        private void cajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Caja(nombreUsuario));
        }

        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new AperturaCaja(nombreUsuario));
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Productos());
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Proveedores());
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Usuarios());
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Clientes());
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Compra(nombreUsuario));
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Ventas());
        }

        private void créditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Credito());
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Form2());
        }

        private void nivelaciónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new NivelacionInventario());
        }

        private void controlDeEgresosDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new ControlEgresosCaja());
        }


        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Categoria());
        }

        private void medidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Talla());
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new ControlRol());
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new ReportCompras());
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new ReporteProductos());
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new ReporteVentas());
        }

        private void respaldoDeLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Mantenimiento());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormularioMdi(new Marca());
        }
    }
}
