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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida(string username)
        {
            InitializeComponent();
            label1.Text = $"¡Bienvenido, {username}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login(); obj.Show(); this.Hide();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
