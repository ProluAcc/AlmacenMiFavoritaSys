using Control_de_egresos_de_caja;
using SISTEMA;

namespace caja
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu(); obj.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArqueoCaja obj = new ArqueoCaja(); obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CierreCaja obj = new CierreCaja(); obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AperturaCaja obj = new AperturaCaja(); obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ControlEgresosCaja obj = new ControlEgresosCaja(); obj.ShowDialog();
        }
    }
}
