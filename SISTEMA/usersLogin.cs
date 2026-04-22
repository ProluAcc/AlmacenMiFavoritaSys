using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    class usersLogin
    {
        private string _usuario;
        private string _contrasena;

        public string usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                if (_usuario == "") MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string contrasena
        {
            get { return _contrasena; }
            set
            {
                _contrasena = value;
                if (_contrasena == "") MessageBox.Show("Contraseña de usuario incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
