using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Clientes : Form
    {

        private List<ClaseClientes> cliente = new List<ClaseClientes>();
        private int indexEditar = -1;
        public Clientes()
        {
            InitializeComponent();
            IniciarCB();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";

            cbEstado.SelectedIndex = -1;
            cbBuscar.SelectedIndex = -1;
            indexEditar = -1;
        }

        private void RefrescarGrid(IEnumerable<ClaseClientes> lista)
        {
            dgvCliente.Rows.Clear();
            foreach (var i in lista)
            {
                dgvCliente.Rows.Add(i.nombre, i.telefono, i.direccion, i.correo, i.estado);
            }
        }

        public void IniciarCB()
        {
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.SelectedIndex = -1;

            cbBuscar.Items.Add("Nombre");
            cbBuscar.Items.Add("Correo");
            cbBuscar.Items.Add("Teléfono");
            cbBuscar.Items.Add("Estado");
            cbBuscar.SelectedIndex = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Any(x => x.correo.Equals(txtCorreo.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("El correo del cliente ya existe. Usa ✏EDITAR para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClaseClientes nuevo = new ClaseClientes();

                nuevo.nombre = txtNombre.Text.Trim();
                nuevo.correo = txtCorreo.Text.Trim();
                nuevo.telefono = txtTelefono.Text.Trim();
                nuevo.direccion = txtDireccion.Text.Trim();
                nuevo.estado = cbEstado.SelectedItem.ToString();

                cliente.Add(nuevo);

                RefrescarGrid(cliente);

                MessageBox.Show("Cliente ingresado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indexEditar < 0 || indexEditar >= cliente.Count)
            {
                MessageBox.Show("No hay ningún cliente cargado para editar. Haz doble clic en la fila a editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var u = cliente[indexEditar];
            u.nombre = txtNombre.Text.Trim();
            u.telefono = txtTelefono.Text.Trim();
            u.direccion = txtDireccion.Text.Trim();
            u.correo = txtCorreo.Text.Trim();
            u.estado = cbEstado.SelectedItem.ToString();

            RefrescarGrid(cliente);
            Limpiar();
            MessageBox.Show("Cliente actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var criterio = txtBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                RefrescarGrid(cliente);
                return;
            }

            var campo = cbBuscar.SelectedItem.ToString();
            IEnumerable<ClaseClientes> resultado = cliente;

            switch (campo)
            {
                case "Nombre":
                    resultado = cliente.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Teléfono":
                    resultado = cliente.Where(u => u.telefono?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Correo":
                    resultado = cliente.Where(u => u.correo?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Estado":
                    resultado = cliente.Where(u => u.estado?.Equals(criterio, StringComparison.OrdinalIgnoreCase) ?? false);
                    break;
                default:
                    resultado = cliente.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
            }

            RefrescarGrid(resultado);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= cliente.Count) return;

            indexEditar = e.RowIndex;
            var u = cliente[indexEditar];

            txtNombre.Text = u.nombre;            
            txtCorreo.Text = u.correo;
            txtDireccion.Text = u.direccion;
            txtTelefono.Text = u.telefono;
            cbEstado.Text = u.estado;

            MessageBox.Show("Cliente cargado para edición. Usa ✏️EDITAR para aplicar cambios.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
