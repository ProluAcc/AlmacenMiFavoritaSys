using Control_de_egresos_de_caja;
using SISTEMA;

namespace caja
{
    public partial class Caja : Form
    {
        public Caja(string username)
        {
            InitializeComponent();
            lblUsuario.Text = $"Usuario: {username}";
            lblDolar.Text = $"Cambio de Dólar: $1-> {CalcularDolar()}";
        }

        private double CalcularDolar()
        {
            double tc = 0.00;
            double tcActual = 36.6243;
            double iNic = 0.04;
            double iEU = 0.02;

            tc = tcActual * ((1 + iNic) / (1 + iEU));
            return Math.Round(tc, 2);
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

        private void button4_Click(object sender, EventArgs e)
        {
            ArqueoCaja obj = new ArqueoCaja(); obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CierreCaja obj = new CierreCaja(); obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ControlEgresosCaja obj = new ControlEgresosCaja(); obj.ShowDialog();
        }
    }
}
