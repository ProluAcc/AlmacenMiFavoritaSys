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
    public partial class Proveedores : Form
    {
        List<ClaseProveedor> p = new List<ClaseProveedor>();
        private int indexEditar = -1;
        public Proveedores()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefrescarGrid(IEnumerable<ClaseProveedor> lista)
        {
            dgvProveedor.Rows.Clear();
            foreach (var i in lista)
            {
                dgvProveedor.Rows.Add(i.nombre, i.telefono, i.direccion, i.correo, i.fecha_registro, i.estado);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarComboBox()
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = -1;

            cmbBuscar.Items.Add("Nombre");
            cmbBuscar.Items.Add("Teléfono");
            cmbBuscar.Items.Add("Correo");
            cmbBuscar.Items.Add("Estado");
            cmbBuscar.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (p.Any(x => x.nombre.Equals(txtCorreo.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("El nombre del proveedor ya existe. Usa ✏EDITAR para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClaseProveedor pro = new ClaseProveedor
                {
                    nombre = txtNombre.Text,
                    telefono = txtTelefono.Text,
                    correo = txtCorreo.Text,
                    direccion = txtDireccion.Text,
                    estado = cmbEstado.SelectedItem?.ToString() ?? "Activo",
                    fecha_registro = dtpFecha.Text
                };

                p.Add(pro);
                RefrescarGrid(p);

                MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (indexEditar < 0 || indexEditar >= p.Count)
                {
                    MessageBox.Show("No hay ningún proveedor cargado para editar. Haz doble clic en la fila a editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var u = p[indexEditar];
                u.nombre = txtNombre.Text.Trim();
                u.telefono = txtTelefono.Text.Trim();
                u.direccion = txtDireccion.Text.Trim();
                u.correo = txtCorreo.Text.Trim();
                u.fecha_registro = dtpFecha.Text.Trim();
                u.estado = cmbEstado.SelectedItem.ToString();

                RefrescarGrid(p);
                Limpiar();
                MessageBox.Show("Proveedor actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var criterio = txtBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    RefrescarGrid(p);
                    return;
                }

                var campo = cmbBuscar.SelectedItem.ToString();
                IEnumerable<ClaseProveedor> resultado = p;

                switch (campo)
                {
                    case "Nombre":
                        resultado = p.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                        break;
                    case "Teléfono":
                        resultado = p.Where(u => u.telefono?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                        break;
                    case "Correo":
                        resultado = p.Where(u => u.correo?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                        break;
                    case "Estado":
                        resultado = p.Where(u => u.estado?.Equals(criterio, StringComparison.OrdinalIgnoreCase) ?? false);
                        break;
                    default:
                        resultado = p.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                        break;
                }

                RefrescarGrid(resultado);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= p.Count) return;

                indexEditar = e.RowIndex;
                var u = p[indexEditar];

                txtNombre.Text = u.nombre;
                txtCorreo.Text = u.correo;
                txtDireccion.Text = u.direccion;
                txtTelefono.Text = u.telefono;
                dtpFecha.Text = u.fecha_registro;
                cmbEstado.Text = u.estado;

                MessageBox.Show("Proveedor cargado para edición. Presiona ✏️EDITAR para aplicar cambios.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
