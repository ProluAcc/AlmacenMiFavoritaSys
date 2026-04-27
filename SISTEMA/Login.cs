namespace SISTEMA
{
    public partial class Login : Form
    {
        ClaseUsuarios cu = new();
        ClaseRol u = new();
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            u.usuario = txtUsuario.Text;
            u.contrasena = txtContrasena.Text;

            try
            {
                if (!cu.usersContrasenas.ContainsKey(u.usuario))
                {
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = ""; txtUsuario.Focus();
                }
                else if (u.contrasena != cu.usersContrasenas[u.usuario])
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Text = ""; txtContrasena.Focus();
                }
                else if (u.contrasena == cu.usersContrasenas[u.usuario])
                {
                    MessageBox.Show($"¡Bienvenido al sistema {u.usuario}!", "Bienvenido(a)", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
