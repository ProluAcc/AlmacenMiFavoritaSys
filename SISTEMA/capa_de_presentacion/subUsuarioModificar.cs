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
        public struct usuario { public string nombre; public string username; public string correo; public string contrasena; public string pregunta; public string respuesta; public string estado; public int rol; }
        public subUsuarioModificar()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlRol obj = new ControlRol(); obj.Show(); this.Hide();
        }
    }
}
