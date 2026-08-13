using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA.capa_de_datos;

namespace SISTEMA
{
    public partial class Recuperacion : Form
    {
        ClaseUsuarios cu = new ClaseUsuarios();
        public Recuperacion()
        {
            InitializeComponent();
            txtPregunta.Enabled = false;
            txtRespuesta.Enabled = false;
            btnComprobar.Enabled = false;
            txtNuevaContrasena.Enabled = false;
            txtConfirmacion.Enabled = false;
            btnRecuperar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login obj = new Login(); obj.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cu.correo = txtCorreo.Text;
                string pregunta = cu.BuscarCorreo(cu.correo);
                MessageBox.Show("Correo encontrado. Responde la pregunta de seguridad para recuperar tu contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPregunta.Text = pregunta;
                txtPregunta.Enabled = true;
                txtRespuesta.Enabled = true;
                btnComprobar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtCorreo.Focus();
            }
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                cu.correo = txtCorreo.Text;
                cu.respuesta = txtRespuesta.Text;
                if (cu.ComprobarRespuesta(cu.correo, cu.respuesta))
                {
                    MessageBox.Show("Respuesta correcta. Ahora puedes cambiar tu contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevaContrasena.Enabled = true;
                    txtConfirmacion.Enabled = true;
                    btnRecuperar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Text = "";
                    txtRespuesta.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtRespuesta.Focus();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                cu.contrasena = txtConfirmacion.Text;
                if(txtNuevaContrasena.Text == cu.contrasena)
                {
                    if (cu.CambiarContrasena(cu.correo, cu.contrasena))
                    {
                        MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login obj = new Login(); obj.Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no pudo ser cambiada. El correo especificado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmacion.Text = "";
                        txtConfirmacion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContrasena.Text = "";
                    txtConfirmacion.Text = "";
                    txtNuevaContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtConfirmacion.Focus();
            }
        }
    }
}
