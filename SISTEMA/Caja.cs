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
            Bienvenida obj = new Bienvenida(); obj.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArqueoCaja obj = new ArqueoCaja(); obj.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CierreCaja obj = new CierreCaja(); obj.Show(); 
        }
    }
}
