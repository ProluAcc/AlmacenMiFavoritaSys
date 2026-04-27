using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    class ClaseUsuarios
    {
        public Dictionary<string, string> usersContrasenas = new Dictionary<string, string>()
        {
            { "Christiam", "c1234" },
            { "Jack", "j1234"},
            {"Kelly", "k1234" },
            {"Amaru", "a1234" },
            {"Helkind", "h1234" },
            {"Admin", "MiFavorita77" }
        };

        private int _id_usuario;
        private string _nombre;
        private string _correo;
        private string _estado;
        private string _contrasena;
        private string _pregunta;
        private string _respuesta;
        private string _rol;
        private string _descripcionRol;

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
                if (_nombre == "") MessageBox.Show("El campo 'Cédula' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string rol
        {
            get { return _rol; }
            set
            {
                _rol = value;
                if (_rol == "") MessageBox.Show("El rol no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
