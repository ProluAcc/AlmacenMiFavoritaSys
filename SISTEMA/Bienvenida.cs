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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login(); obj.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores obj = new Proveedores(); obj.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuarios obj = new Usuarios(); obj.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes(); obj.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Productos obj = new Productos(); obj.Show(); this.Hide();
        }
    }
}
