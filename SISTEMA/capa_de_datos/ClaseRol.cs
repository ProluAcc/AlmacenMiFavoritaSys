using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SISTEMA.capa_de_datos
{
    class ClaseRol
    {
        Conexion connection = new Conexion();
        private int _idrol;
        private string _nombre;
        private string _descripcion;
        private bool _activo;

        public string nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                if (string.IsNullOrWhiteSpace(_nombre)) MessageBox.Show("El campo 'Nombre' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public int idrol
        {
            get { return _idrol; }
            set
            {
                _idrol = value;
                if (_idrol < 0) MessageBox.Show("El campo 'Rol' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ConseguirNombreRol(int numeroRol)
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

                //selecciona el rol segun el id dado
                string consulta = "select * from rol where id_rol = @numeroRol";

                //realiza la consulta a la base de datos según la consulta anterior y a la conexión creada
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    //reemplaza el parametro
                    comando.Parameters.AddWithValue("@numeroRol", numeroRol);

                    //utilza el datareader para guardar los resultados de la consulta y poder leerlos
                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        // Si el reader tiene filas, significa que el correo existe
                        if (reader.Read())
                        {
                            //guarda la respuesta
                            nombre = reader.GetString(1);
                            return nombre;
                        }
                        else
                        {
                            MessageBox.Show("El rol no existe.", "Error de Acceso");
                            return "Nulo";
                        }
                    }
                }
            }
        }

        public int ConseguirNumeroRol(string NombreRol)
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

                //selecciona el rol segun el nombre dado
                string consulta = "select * from rol where nombre = @NombreRol";

                //realiza la consulta a la base de datos según la consulta anterior y a la conexión creada
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    //reemplaza el parametro @correo con el valor dado como correo
                    comando.Parameters.AddWithValue("@NombreRol", NombreRol);

                    //utilza el datareader para guardar los resultados de la consulta y poder leerlos
                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        // Si el reader tiene filas, significa que el rol existe
                        if (reader.Read())
                        {
                            //guarda la respuesta
                            idrol = reader.GetByte(0);
                            return idrol;
                        }
                        else
                        {
                            MessageBox.Show("El rol no existe.", "Error de Acceso");
                            return 0;
                        }
                    }
                }
            }
        }

        public bool AgregarRol(string nombre, string descripcion, bool estado)
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

                //hace el insert del nuevo rol
                string consulta = "insert into rol(nombre, descripcion, estado) values (@nombre, @descripcion, @estado);";

                //realiza la consulta a la base de datos según la consulta anterior y a la conexión creada
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    //reemplaza los parametros anteriores con los datos                 
                    comando.Parameters.AddWithValue("@nombre", nombre);                   
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@estado", estado);

                    //ExecuteNonQuery devuelve el número de filas afectadas
                    int filasAfectadas = comando.ExecuteNonQuery();

                    //Si filasAfectadas > 0, significa que el correo existe y la contraseña fue actualizada
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }       

        public string descripcion
        {
            get { return _descripcion; }
            set
            {
                _descripcion = value;
                if (string.IsNullOrWhiteSpace(_descripcion)) MessageBox.Show("El campo 'Descripción' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public bool activo
        {
            get { return _activo; }
            set {
                _activo = value;
                string m = _activo.ToString();
                if(string.IsNullOrWhiteSpace(m)) MessageBox.Show("El campo 'Rol' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
            

        internal ClaseUsuarios ClaseUsuarios
        {
            get => default;
            set
            {
            }
        }
    }
}
