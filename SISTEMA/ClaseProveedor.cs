using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseProveedor
    {
        private int _id_proveedor;
        private string _nombre;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private string _estado;
        private string _fecha_registro;

        public string nombre {
            get { return _nombre; }
            set
            {
                _nombre = value;
                if (string.IsNullOrWhiteSpace(_nombre))
                {
                    MessageBox.Show("El campo 'Nombre del Proveedor' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string telefono {  
            get { return _telefono; }
            set
            {
                _telefono = value;
                if (string.IsNullOrWhiteSpace(_telefono))
                {
                    MessageBox.Show("El campo 'Teléfono' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string correo
        {
            get { return _correo; }
            set
            {
                _correo = value;
                if (string.IsNullOrWhiteSpace(_correo))
                {
                    MessageBox.Show("El campo 'Correo' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string direccion
        {
            get { return _direccion; }
            set
            {
                _direccion = value;
                if (string.IsNullOrWhiteSpace(_direccion))
                {
                    MessageBox.Show("El campo 'Dirección' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                if (string.IsNullOrWhiteSpace(_estado))
                {
                    MessageBox.Show("El campo 'Estado' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string fecha_registro
        {
            get { return _fecha_registro; }
            set
            {
                _fecha_registro = value;
                if (string.IsNullOrWhiteSpace(_fecha_registro))
                {
                    MessageBox.Show("El campo 'Fecha de Registro' no puede ir vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
