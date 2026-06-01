using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    class ClaseRol
    {
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
                if(string.IsNullOrWhiteSpace(_nombre)) MessageBox.Show("El campo 'Nombre' no puede ir vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                
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
