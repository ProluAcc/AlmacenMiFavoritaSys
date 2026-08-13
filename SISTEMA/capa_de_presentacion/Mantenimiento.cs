using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            txtNombreRespaldo.Text = "AlmacenMiFavoritaBD_" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss");
            txtNombreRespaldo.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreRespaldo = txtNombreRespaldo.Text;

            // Pedir ubicación y nombre de archivo al usuario
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                //filtrar para que solo se guarden archivos con extension backup 
                sfd.Filter = "Backup files (*.backup)|*.backup|All files (*.*)|*.*";
                sfd.FileName = nombreRespaldo + ".backup";
                sfd.Title = "Guardar respaldo de la base de datos";

                //si se cancela, no hace nada
                if (sfd.ShowDialog() != DialogResult.OK) return;

                //obtiene la ruta del archivo de respaldo
                string destino = sfd.FileName;

                try
                {
                    // Obtener parámetros de conexión desde la clase Conexion
                    var conexion = new Conexion();
                    var builder = new NpgsqlConnectionStringBuilder(conexion.con);

                    //guarda los datos de conexion 
                    string host = builder.Host;
                    int port = builder.Port;
                    string username = builder.Username;
                    string password = builder.Password;
                    string database = builder.Database;

                    // Nombre del ejecutable pg_dump
                    string pgDumpExe = "pg_dump";

                    // Argumentos recomendados: formato custom para permitir restauración con pg_restore
                    string arguments = $"--host \"{host}\" --port {port} --username \"{username}\" --format custom --blobs --verbose --file \"{destino}\" \"{database}\"";

                    //se configura para ejecutar pg_dump con los argumentos especificados anteriormetne
                    var psi = new ProcessStartInfo(pgDumpExe, arguments)
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };

                    // Evitar que pg_dump pida contraseña interactiva
                    psi.Environment["PGPASSWORD"] = password;

                    //empieza el proceso de pg_dump
                    using (var process = Process.Start(psi))
                    {
                        // Leer salidas para diagnóstico 
                        string stdOut = process.StandardOutput.ReadToEnd();
                        string stdErr = process.StandardError.ReadToEnd();

                        //esperar a que el proceso termine para mostrar si el respaldo fue exitoso o no
                        process.WaitForExit();

                        if (process.ExitCode == 0)
                        {
                            MessageBox.Show("Respaldo creado correctamente:\n" + destino, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string mensaje = $"pg_dump finalizó con código {process.ExitCode}.\nError: {stdErr}";
                            MessageBox.Show(mensaje, "Error al crear respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el respaldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
