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
        private string _cedula;
        private string _nombreCompleto;
        private string _correo;
        private string _telefono;
        private string _estado;
        private string _usuario;
        private string _contrasena;
        private string _rol;

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
        public string cedula
        {
            get { return _cedula; }
            set {
                _cedula = value;
                if (_cedula == "") MessageBox.Show("El campo 'Cédula' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string nombreCompleto
        {
            get { return _nombreCompleto; }
            set
            {
                _cedula = value;
                if (_cedula == "") MessageBox.Show("El campo 'Cédula' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                if (_telefono == "") MessageBox.Show("El campo 'Teléfono' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public string usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                if (_usuario == "") MessageBox.Show("El campo 'Usuario' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
