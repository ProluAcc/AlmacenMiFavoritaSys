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

        private class UsuarioModel
        {
            public string Cedula { get; set; }
            public string NombreCompleto { get; set; }
            public string Rol { get; set; }
            public string CorreoElectronico { get; set; }
            public string Usuario { get; set; }
            public string Estado { get; set; }
            public string Pregunta { get; set; }
            public string Respuesta { get; set; }
            public string Contrasena { get; set; }
        }

        private List<UsuarioModel> usuarios = new List<UsuarioModel>();
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
            // No cargar datos de ejemplo 
            RefrescarGrid(usuarios);
        }

        private void InicializarCombos()
        {
            comboRolR.Items.Clear();
            comboRolR.Items.AddRange(new object[] { "Admin", "Vendedor", "Supervisor" });
            comboRolR.SelectedIndex = -1;

            comboEstadoY.Items.Clear();
            comboEstadoY.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstadoY.SelectedIndex = -1;

            cmbBuscarQ.Items.Clear();
            cmbBuscarQ.Items.AddRange(new object[] { "Cédula", "Nombre", "Rol", "Correo", "Usuario", "Estado" });
            cmbBuscarQ.SelectedIndex = 1; 
        }

        private static readonly Random rng = new Random();
        private string GenerarCedula()
        {
            string ced;
            do
            {
                ced = rng.Next(100000000, 999999999).ToString(); // 9 dígitos
            } while (usuarios.Any(u => u.Cedula == ced));
            return ced;
        }

        private void CargarDatosPrueba()
        {
            // Si tienes una fuente real (BD) reemplaza esto por la carga real.
            if (usuarios.Count == 0)
            {
                usuarios.Add(new UsuarioModel
                {
                    Cedula = "0102030405",
                    NombreCompleto = "Admin Principal",
                    Rol = "Admin",
                    CorreoElectronico = "admin@example.com",
                    Usuario = "Admin",
                    Estado = "Activo",
                    Pregunta = "¿Ciudad natal?",
                    Respuesta = "Ciudad",
                    Contrasena = "MiFavorita77"
                });
            }
        }

        private void RefrescarGrid(IEnumerable<UsuarioModel> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var u in lista)
            {
                dataGridView1.Rows.Add(u.Cedula, u.NombreCompleto, u.Rol, u.CorreoElectronico, u.Usuario, u.Estado, "✏️");
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
            btnGuardarH.Text = "💾GUARDAR";
        }

        private bool ValidarCampos(out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(txtNombreT.Text)) { mensaje = "Nombre completo vacío."; return false; }
            if (string.IsNullOrWhiteSpace(txtUsuarioL.Text)) { mensaje = "Usuario vacío."; return false; }
            if (string.IsNullOrWhiteSpace(txtEmailU.Text)) { mensaje = "Correo vacío."; return false; }
            if (comboRolR.SelectedIndex < 0) { mensaje = "Selecciona un Rol."; return false; }
            if (comboEstadoY.SelectedIndex < 0) { mensaje = "Selecciona un Estado."; return false; }
            mensaje = null;
            return true;
        }

        private void btnGuardarH_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out var msg))
            {
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar nuevo usuario (no duplicados por 'Usuario')
            if (usuarios.Any(x => x.Usuario.Equals(txtUsuarioL.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El nombre de usuario ya existe. Usa editar para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new UsuarioModel
            {
                Cedula = GenerarCedula(), 
                NombreCompleto = txtNombreT.Text.Trim(),
                Rol = comboRolR.SelectedItem?.ToString() ?? "",
                CorreoElectronico = txtEmailU.Text.Trim(),
                Usuario = txtUsuarioL.Text.Trim(),
                Estado = comboEstadoY.SelectedItem?.ToString() ?? "",
                Pregunta = txtPreguntaL.Text.Trim(),
                Respuesta = txtRespuestaT.Text.Trim(),
                Contrasena = textContraseñaJ.Text
            };

            usuarios.Add(nuevo);
            RefrescarGrid(usuarios);
            LimpiarCampos();
            MessageBox.Show("Usuario guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            IEnumerable<UsuarioModel> resultado = usuarios;

            switch (campo)
            {
                case "Cédula":
                    resultado = usuarios.Where(u => u.Cedula?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Nombre":
                    resultado = usuarios.Where(u => u.NombreCompleto?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Rol":
                    resultado = usuarios.Where(u => u.Rol?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Correo":
                    resultado = usuarios.Where(u => u.CorreoElectronico?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Usuario":
                    resultado = usuarios.Where(u => u.Usuario?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                case "Estado":
                    resultado = usuarios.Where(u => u.Estado?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
                default:
                    resultado = usuarios.Where(u => u.NombreCompleto?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
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

            txtNombreT.Text = u.NombreCompleto;
            txtUsuarioL.Text = u.Usuario;
            txtEmailU.Text = u.CorreoElectronico;
            textContraseñaJ.Text = u.Contrasena;
            txtPreguntaL.Text = u.Pregunta;
            txtRespuestaT.Text = u.Respuesta;
            comboRolR.SelectedItem = u.Rol;
            comboEstadoY.SelectedItem = u.Estado;

            btnGuardarH.Text = "💾GUARDAR (nuevo)";
            MessageBox.Show("Usuario cargado para edición. Usa ✏️EDITAR para aplicar cambios.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= usuarios.Count)
            {
                MessageBox.Show("No hay ningún usuario cargado para editar. Haz doble clic en la fila a editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos(out var msg))
            {
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var u = usuarios[editingIndex];
            u.NombreCompleto = txtNombreT.Text.Trim();
            u.Usuario = txtUsuarioL.Text.Trim();
            u.CorreoElectronico = txtEmailU.Text.Trim();
            u.Contrasena = textContraseñaJ.Text;
            u.Pregunta = txtPreguntaL.Text.Trim();
            u.Respuesta = txtRespuestaT.Text.Trim();
            u.Rol = comboRolR.SelectedItem?.ToString() ?? "";
            u.Estado = comboEstadoY.SelectedItem?.ToString() ?? "";

            RefrescarGrid(usuarios);
            LimpiarCampos();
            MessageBox.Show("Usuario actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresarW_Click(object sender, EventArgs e)
        {
            // Acción 'Ingresar' — aquí la dejo como "cargar al formulario" el usuario seleccionado actualmente.
            // Si quieres que haga otra cosa (p.ej. iniciar sesión) dime y lo adapto.
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila en el listado para 'Ingresar'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idx = dataGridView1.SelectedRows[0].Index;
            if (idx < 0 || idx >= usuarios.Count) return;

            var u = usuarios[idx];
            txtNombreT.Text = u.NombreCompleto;
            txtUsuarioL.Text = u.Usuario;
            txtEmailU.Text = u.CorreoElectronico;
            textContraseñaJ.Text = u.Contrasena;
            comboRolR.SelectedItem = u.Rol;
            comboEstadoY.SelectedItem = u.Estado;

            editingIndex = idx;
            MessageBox.Show("Usuario cargado en el formulario.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu(); obj.Show(); this.Hide();
        }
    }
}
