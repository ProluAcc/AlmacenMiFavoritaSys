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
    public partial class Usuarios : Form
    {
        private List<ClaseUsuarios> usuarios = new List<ClaseUsuarios>();
        private int editingIndex = -1;

        public Usuarios()
        {
            InitializeComponent();

            btnGuardarH.Click += btnGuardarH_Click;
            btnLimpiarK.Click += btnLimpiarK_Click;
            btnBuscarD.Click += btnBuscarD_Click;
            btnEditarM.Click += btnEditarM_Click;
            btnIngresarW.Click += btnIngresarW_Click;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            InicializarCombos();            
        }

        private void InicializarCombos()
        {
            comboRolR.Items.Clear();
            comboRolR.Items.AddRange(new object[] { "Admin", "Cajero", "Encargado de Compras", "Gerente" });
            comboRolR.SelectedIndex = -1;

            comboEstadoY.Items.Clear();
            comboEstadoY.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstadoY.SelectedIndex = -1;

            cmbBuscarQ.Items.Clear();
            cmbBuscarQ.Items.AddRange(new object[] { "Nombre", "Usuario", "Correo", "Rol", "Estado" });
            cmbBuscarQ.SelectedIndex = 1;
        }

        private void RefrescarGrid(IEnumerable<ClaseUsuarios> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var u in lista)
            {
                dataGridView1.Rows.Add(u.nombre, u.username, u.correo, u.contrasena, u.pregunta, u.respuesta, u.rol, u.estado);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreT.Clear();
            txtUsuarioL.Clear();
            txtEmailU.Clear();
            textContraseñaJ.Clear();
            txtPreguntaL.Clear();
            txtRespuestaT.Clear();
            // Dejar los combos en blanco para que el usuario los seleccione manualmente
            comboRolR.SelectedIndex = -1;
            comboEstadoY.SelectedIndex = -1;
            editingIndex = -1;
        }

        private void btnGuardarH_Click(object sender, EventArgs e)
        {
            // Acción 'Ingresar' — aquí la dejo como "cargar al formulario" el usuario seleccionado actualmente.
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila en el listado para 'Ingresar'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= usuarios.Count) return;

            var u = usuarios[idx];
            txtNombreT.Text = u.nombre;
            txtUsuarioL.Text = u.username;
            txtEmailU.Text = u.correo;
            textContraseñaJ.Text = u.contrasena;
            comboRolR.SelectedItem = u.rol;
            comboEstadoY.SelectedItem = u.estado;

            editingIndex = idx;
            MessageBox.Show("Usuario cargado en el formulario.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarK_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            var criterio = textbuscarT.Text.Trim();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                RefrescarGrid(usuarios);
                return;
            }

            var campo = cmbBuscarQ.SelectedItem?.ToString() ?? "Nombre";
            IEnumerable<ClaseUsuarios> resultado = usuarios;

            switch (campo)
            {
                case "Nombre":
                    resultado = usuarios.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Rol":
                    resultado = usuarios.Where(u => u.rol?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Correo":
                    resultado = usuarios.Where(u => u.correo?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Usuario":
                    resultado = usuarios.Where(u => u.username?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Estado":
                    resultado = usuarios.Where(u => u.estado?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                default:
                    resultado = usuarios.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
            }

            RefrescarGrid(resultado);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cargar fila seleccionada en los campos para editar
            if (e.RowIndex < 0 || e.RowIndex >= usuarios.Count) return;

            editingIndex = e.RowIndex;
            var u = usuarios[editingIndex];

            txtNombreT.Text = u.nombre;
            txtUsuarioL.Text = u.username;
            txtEmailU.Text = u.correo;
            textContraseñaJ.Text = u.contrasena;
            txtPreguntaL.Text = u.pregunta;
            txtRespuestaT.Text = u.respuesta;
            comboRolR.SelectedItem = u.rol;
            comboEstadoY.SelectedItem = u.estado;

            MessageBox.Show("Usuario cargado para edición. Usa ✏️EDITAR para aplicar cambios.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= usuarios.Count)
            {
                MessageBox.Show("No hay ningún usuario cargado para editar. Haz doble clic en la fila a editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var u = usuarios[editingIndex];
            u.nombre = txtNombreT.Text.Trim();
            u.username = txtUsuarioL.Text.Trim();
            u.correo = txtEmailU.Text.Trim();
            u.contrasena = textContraseñaJ.Text;
            u.pregunta = txtPreguntaL.Text.Trim();
            u.respuesta = txtRespuestaT.Text.Trim();
            u.rol = comboRolR.SelectedItem?.ToString() ?? "";
            u.estado = comboEstadoY.SelectedItem?.ToString() ?? "";

            RefrescarGrid(usuarios);
            LimpiarCampos();
            MessageBox.Show("Usuario actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresarW_Click(object sender, EventArgs e)
        {
            try
            {
                // Agregar nuevo usuario (no duplicados por 'Usuario')
                if (usuarios.Any(x => x.username.Equals(txtUsuarioL.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Usa editar para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevo = new ClaseUsuarios
                {
                    nombre = txtNombreT.Text.Trim(),
                    rol = comboRolR.SelectedItem.ToString(),
                    correo = txtEmailU.Text.Trim(),
                    username = txtUsuarioL.Text.Trim(),
                    estado = comboEstadoY.SelectedItem.ToString(),
                    pregunta = txtPreguntaL.Text.Trim(),
                    respuesta = txtRespuestaT.Text.Trim(),
                    contrasena = textContraseñaJ.Text
                };

                usuarios.Add(nuevo);
                RefrescarGrid(usuarios);
                LimpiarCampos();
                MessageBox.Show("Usuario guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x) { MessageBox.Show("Error al guardar usuario: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlRol obj = new ControlRol(); obj.ShowDialog();
        }

        private void btnIngresarW_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarH_Click_1(object sender, EventArgs e)
        {

        }
    }
}
