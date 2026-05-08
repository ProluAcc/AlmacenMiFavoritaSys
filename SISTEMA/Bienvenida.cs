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

namespace SISTEMA
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login(); obj.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Compra());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Devolución());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new Credito());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventas());
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new Caja());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedores());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirForm(new Productos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new Usuarios());
        }

        private void AbrirForm(object formHijo)
        {
            //toma todos los controles del panel
            for (int i = panelContenedor.Controls.Count; i > 0; i--)
            {
                //los elimina cada uno
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form form = formHijo as Form;
            form.TopLevel = false; //no será un formulario de nivel superior, será secundario
            form.Dock = DockStyle.Fill; //hace que el formulario se estire para cubrir todo el panel contenedor 
            this.panelContenedor.Controls.Add(form); //se añade al panel
            this.panelContenedor.Tag = form; //se establece la instancia como contenedor de datos del panel
            form.Show(); //se muestra
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
