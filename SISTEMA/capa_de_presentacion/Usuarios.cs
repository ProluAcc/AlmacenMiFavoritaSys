using SISTEMA.capa_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SISTEMA.subUsuarioModificar;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISTEMA
{
    public partial class Usuarios : Form
    {
        private int editingIndex;
        private ClaseRol r;
        private ClaseUsuarios u;

        private List<ClaseUsuarios> ListaUsuarios = new List<ClaseUsuarios>();
        public Usuarios()
        {
            InitializeComponent();

            r = new ClaseRol();
            u = new ClaseUsuarios();
            //btnGuardarH.Click += btnGuardarH_Click;
            //btnLimpiarK.Click += btnLimpiarK_Click;
            btnBuscarD.Click += btnBuscarD_Click_1;
            btnEditarM.Click += btnEditarM_Click;
            btnIngresarW.Click += btnIngresarW_Click;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            dataGridView1.CellClick += dataGridView1_CellClick;

            cmbBuscarQ.Items.Add("nombre");
            cmbBuscarQ.Items.Add("username");
            cmbBuscarQ.Items.Add("correo");
            cmbBuscarQ.Items.Add("estado");
            cmbBuscarQ.Items.Add("rol");

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            InicializarCombos();
        }

        private void InicializarCombos()
        {
            /*comboRolR.Items.Clear();
            comboRolR.Items.AddRange(new object[] { "Admin", "Cajero", "Encargado de Compras", "Gerente" });
            comboRolR.SelectedIndex = -1;

            comboEstadoY.Items.Clear();
            comboEstadoY.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstadoY.SelectedIndex = -1;

            cmbBuscarQ.Items.Clear();
            cmbBuscarQ.Items.AddRange(new object[] { "Nombre", "Usuario", "Correo", "Rol", "Estado" });
            cmbBuscarQ.SelectedIndex = 1;*/
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
            /*txtNombreT.Clear();
            txtUsuarioL.Clear();
            txtEmailU.Clear();
            textContraseñaJ.Clear();
            txtPreguntaL.Clear();
            txtRespuestaT.Clear();
            // Dejar los combos en blanco para que el usuario los seleccione manualmente
            comboRolR.SelectedIndex = -1;
            comboEstadoY.SelectedIndex = -1;
            editingIndex = -1;*/
        }

        private void btnGuardarH_Click(object sender, EventArgs e)
        {
            // Acción 'Ingresar' — aquí la dejo como "cargar al formulario" el usuario seleccionado actualmente.
            /*if (dataGridView1.SelectedRows.Count == 0)
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
            MessageBox.Show("Usuario cargado en el formulario.", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void btnLimpiarK_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            /*var criterio = textbuscarT.Text.Trim();
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
                    resultado = usuarios.Where(u => u.estado?.Equals(criterio, StringComparison.OrdinalIgnoreCase) ?? false);
                    break;
                default:
                    resultado = usuarios.Where(u => u.nombre?.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;
            }

            RefrescarGrid(resultado);*/
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cargar fila seleccionada en los campos para editar
            /*if (e.RowIndex < 0 || e.RowIndex >= usuarios.Count) return;

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

            MessageBox.Show("Usuario cargado para edición. Usa ✏️EDITAR para aplicar cambios.", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            /*if (editingIndex < 0 || editingIndex >= usuarios.Count)
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
            MessageBox.Show("Usuario actualizado correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void btnIngresarW_Click(object sender, EventArgs e)
        {
            /*try
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
            catch (Exception x) { MessageBox.Show("Error al guardar usuario: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }*/
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
            subUsuarioAgregar obj = new subUsuarioAgregar(); obj.ShowDialog();
        }

        private void btnGuardarH_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditarM_Click_1(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= dataGridView1.Rows.Count)
            {
                MessageBox.Show("Debes hacer clic en una fila del usuario que deseas editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //obtiene los datos de la fila seleccionada del DataGridView
                DataGridViewRow fila = dataGridView1.Rows[editingIndex];

                var usuarioParaEditar = new ClaseUsuarios
                {
                    id_usuario = Convert.ToInt32(fila.Cells[0].Value ?? 0),
                    nombre = fila.Cells[2].Value?.ToString() ?? "",
                    username = fila.Cells[3].Value?.ToString() ?? "",
                    correo = fila.Cells[5].Value?.ToString() ?? "",
                    contrasena = fila.Cells[4].Value?.ToString() ?? "",
                    pregunta = fila.Cells[6].Value?.ToString() ?? "",
                    respuesta = fila.Cells[7].Value?.ToString() ?? "",
                    rol = fila.Cells[1].Value?.ToString() ?? "",
                    estado = fila.Cells[8].Value?.ToString() ?? ""
                };               

                // Pasar el usuario directamente al formulario
                subUsuarioModificar obj = new subUsuarioModificar(usuarioParaEditar);
                obj.ShowDialog();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al cargar el usuario para edición: " + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarD_Click_1(object sender, EventArgs e)
        {
            //guarda los datos 
            string parametro = cmbBuscarQ.Text;
            string dato = textbuscarT.Text;

            //si el parametro es rol
            if (parametro == "rol")
            {
                //se consigue el id del rol 
                int numeroRol = r.ConseguirNumeroRol(dato);

                //se busca el usuario mediante el id del rol
                u.BuscarUsuario(numeroRol, dataGridView1);
            }
            else
            {
                u.BuscarUsuario(parametro, dato, dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Guardar el índice de la fila seleccionada
                editingIndex = e.RowIndex;

                //guarda los datos del usuario en las variables de la clase usuario
                var nuevoUser = new ClaseUsuarios
                {
                    id_usuario = Convert.ToInt32(dataGridView1.Rows[editingIndex].Cells[0].Value),
                    rol = dataGridView1.Rows[editingIndex].Cells[1].Value.ToString(),
                    nombre = dataGridView1.Rows[editingIndex].Cells[2].Value.ToString(),
                    username = dataGridView1.Rows[editingIndex].Cells[3].Value.ToString(),
                    contrasena = dataGridView1.Rows[editingIndex].Cells[4].Value.ToString(),
                    correo = dataGridView1.Rows[editingIndex].Cells[5].Value.ToString(),
                    pregunta = dataGridView1.Rows[editingIndex].Cells[6].Value.ToString(),
                    respuesta = dataGridView1.Rows[editingIndex].Cells[7].Value.ToString(),
                    estado = dataGridView1.Rows[editingIndex].Cells[8].Value.ToString()
                };

                //lo añade a la lista
                ListaUsuarios.Add(nuevoUser);
                MessageBox.Show("Usuario cargado correctamente.\nUtilice el botón ✏EDITAR para editar los datos del usuario.\nPresione ⛔DESHABILITAR para cambiar el estado del usuario a Inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
