using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
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

namespace SISTEMA
{
    public partial class subUsuarioModificar : Form
    {
        private int editingIndex = 0;
        private ClaseRol Claserol = new ClaseRol();
        private ClaseUsuarios usr = new ClaseUsuarios();
        private Conexion connection = new Conexion();
        public subUsuarioModificar(List<ClaseUsuarios> ListaUsuarios, int index)
        {
            InitializeComponent();
            CargarRoles();
            try
            {
                editingIndex = index;

                //carga los datos en los textbox
                txtId.Text = ListaUsuarios[editingIndex].id_usuario.ToString();
                txtNombre.Text = ListaUsuarios[editingIndex].nombre;
                txtUsuario.Text = ListaUsuarios[editingIndex].username;
                txtCorreo.Text = ListaUsuarios[editingIndex].correo;
                txtContrasena.Text = ListaUsuarios[editingIndex].contrasena;
                txtPregunta.Text = ListaUsuarios[editingIndex].pregunta;
                txtRespuesta.Text = ListaUsuarios[editingIndex].respuesta;
                comboEstado.Text = ListaUsuarios[editingIndex].estado;
                string nombreRol = Claserol.ConseguirNombreRol(int.Parse(ListaUsuarios[editingIndex].rol));
                comboRol.Text = nombreRol;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarRoles()
        {
            //crea el objeto de conexion a la base de datos con el string de conexion
            using (NpgsqlConnection conexion = new NpgsqlConnection(connection.con))
            {
                try
                {
                    //inicia la conexion 
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //busca la constraseña y el rol filtrandolo por el nombre de usuario
                string consulta = "select * from rol;";

                //realiza la consulta a la base de datos según la consulta anterior y a la conexión creada
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    //utilza el datareader para guardar los resultados de la consulta y poder leerlos
                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        // Limpia items previos
                        comboRol.Items.Clear();

                        // Lee todas las filas de la consulta
                        while (reader.Read())
                        {
                            string nombreRol = reader.GetString(1);
                            comboRol.Items.Add(nombreRol);
                        }

                        // Verifica si se cargó al menos un rol
                        if (comboRol.Items.Count == 0)
                        {
                            MessageBox.Show("No hay roles disponibles.", "Error de Acceso");
                        }
                        else
                        {
                            comboRol.SelectedIndex = 0; // Selecciona el primer rol por defecto
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlRol obj = new ControlRol(); obj.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarW_Click(object sender, EventArgs e)
        {
            usr.id_usuario = Convert.ToInt32(txtId.Text);
            usr.rol = comboRol.Text;
            int numeroRol = Claserol.ConseguirNumeroRol(usr.rol);
            usr.correo = txtCorreo.Text;
            usr.nombre = txtNombre.Text;
            usr.username = txtUsuario.Text;
            usr.contrasena = txtContrasena.Text;
            usr.pregunta = txtPregunta.Text;
            usr.respuesta = txtRespuesta.Text;
            usr.estado = comboEstado.Text;
            try
            {
                if (usr.EditarUsuario(usr.id_usuario,numeroRol, usr.nombre, usr.username, usr.contrasena, usr.correo, usr.pregunta, usr.respuesta, usr.estado))
                {
                    MessageBox.Show("Usuario editado con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else MessageBox.Show("Hubo un error al editar el usuario. Verifique la información de los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
