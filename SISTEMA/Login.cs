namespace SISTEMA
{
    public partial class Login : Form
    {
        ClaseUsuarios cu = new();
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cu.username = txtUsuario.Text;
            cu.contrasena = txtContrasena.Text;

            try
            {
                if (!cu.usersContrasenas.ContainsKey(cu.username))
                {
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = ""; txtUsuario.Focus();
                }
                else if (cu.contrasena != cu.usersContrasenas[cu.username])
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Text = ""; txtContrasena.Focus();
                }
                else if (cu.contrasena == cu.usersContrasenas[cu.username])
                {
                    MessageBox.Show($"¡Bienvenido al sistema {cu.username}!", "Bienvenido(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bienvenida obj = new Bienvenida(); obj.Show(); this.Hide();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtUsuario.Focus();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Recuperacion obj = new Recuperacion(); obj.Show(); this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
