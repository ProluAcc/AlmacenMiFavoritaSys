using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    class ClaseUsuarios
    {
        private int _id_usuario;
        private string _nombre;
        private string _username;       
        private string _contrasena;
        private string _correo;
        private string _pregunta;
        private string _respuesta;
        private string _estado;
        private int _idrol;

        //validaciones
        public int id_usuario
        {
            get { return _id_usuario; }
            set
            {
                _id_usuario = value;
                if (_id_usuario <= 0 || string.IsNullOrEmpty(_id_usuario.ToString()) || string.IsNullOrWhiteSpace(_id_usuario.ToString())) MessageBox.Show("El id de usuario no puede ir vacio o ser cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public string nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                if (_nombre == "") MessageBox.Show("El campo 'Nombre' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string username
        {
            get { return _username; }
            set
            {
                _username = value;
                if (_username == "") MessageBox.Show("El campo 'Username' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string correo
        {
            get { return _correo; }
            set
            {
                _correo = value;
                if (_correo == "") MessageBox.Show("El campo 'Correo' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string estado
        {
            get { return _estado; }
            set {
                _estado = value;
                if (_estado == "") MessageBox.Show("El estado no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string contrasena 
        {
            get { return _contrasena; }
            set
            {
                _contrasena = value;
                if (_contrasena == "") MessageBox.Show("El campo 'Contraseña' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int idrol
        {
            get { return _idrol; }
            set
            {
                _idrol = value;
                string m = _idrol.ToString();
                if (string.IsNullOrWhiteSpace(m)) MessageBox.Show("El rol no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool iniciarSesion(string username, string contrasena)
        {
            //instanciar la conexion 
            Conexion connection = new Conexion();

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
                string consulta = "select u.contrasena, r.nombre from rol r join usuario u on r.id_rol = u.id_rol where u.username = @usuario";

                //realiza la consulta a la base de datos según la consulta anterior y a la conexión creada
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    //reemplaza el parametro @usuario con el valor dado como username
                    comando.Parameters.AddWithValue("@usuario", username);

                    //utilza el datareader para guardar los resultados de la consulta y poder leerlos
                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        // Si el reader tiene filas, significa que el usuario existe
                        if (reader.Read())
                        {
                            //la fila 0 es la contraseña y la 1 es el rol 
                            string contrasenaAlmacenada = reader.GetString(0);
                            string rolUsuario = reader.GetString(1);
                            
                            if (contrasena == contrasenaAlmacenada)
                            {
                                MessageBox.Show($"Bienvenido, has iniciado sesión como {rolUsuario}.", "Acceso Concedido");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.", "Error de Acceso");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe.", "Error de Acceso");
                            return false;
                        }
                    }
                }
            }            
        }


        internal ClaseVenta ClaseVenta
        {
            get => default;
            set
            {
            }
        }

        internal ClaseCompra ClaseCompra
        {
            get => default;
            set
            {
            }
        }

        internal ClaseRol ClaseRol
        {
            get => default;
            set
            {
            }
        }
    }
}
