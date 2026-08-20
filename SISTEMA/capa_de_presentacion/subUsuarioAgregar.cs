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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISTEMA
{
    public partial class subUsuarioAgregar : Form
    {

        ClaseUsuarios usr;
        ClaseRol r;
        Conexion connection = new Conexion();
        public subUsuarioAgregar()
        {
            InitializeComponent();
            usr = new ClaseUsuarios();
            r = new ClaseRol();
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("Inactivo");
            comboEstado.SelectedIndex = 0;
            CargarRoles();
        }

        private void subUsuarioAgregar_Load(object sender, EventArgs e)
        {

        }

        private void txtEmailU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlRol obj = new ControlRol(); obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarW_Click(object sender, EventArgs e)
        {
            usr.rol = comboRol.Text;
            int numeroRol = r.ConseguirNumeroRol(usr.rol);
            usr.correo = txtCorreo.Text;
            usr.nombre = txtNombre.Text;
            usr.username = txtUsuario.Text;
            usr.contrasena = txtContrasena.Text;
            usr.pregunta = txtPregunta.Text;
            usr.respuesta = txtRespuesta.Text;
            usr.estado = comboEstado.Text;

            try
            {
                if (usr.VerificarSiUsuarioExiste(usr.correo))
                {
                    MessageBox.Show("El usuarioq que se desea agregar ya existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (usr.AgregarUsuario(numeroRol, usr.nombre, usr.username, usr.contrasena, usr.correo, usr.pregunta, usr.respuesta, usr.estado))
                    {
                        MessageBox.Show("Usuario agregado con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else MessageBox.Show("Hubo un error al ingresar el usuario. Verifique la información de los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
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
    }
}
