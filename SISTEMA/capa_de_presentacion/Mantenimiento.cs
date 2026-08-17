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
            txtNombreRespaldo.Text = "AlmacenMiFavoritaBD1_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss");
            txtNombreRespaldo.Enabled = false;
            txtRestauracion.Enabled = false;
            txtRutaRespaldo.Enabled = false;
            txtRestauracion.Enabled = false;
            txtFechaRespaldo.Enabled = false;
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
                sfd.Filter = "Backup files (*.dump)|*.dump|All files (*.*)|*.*";
                sfd.FileName = nombreRespaldo + ".dump";
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

                    // Argumentos en formato custom para permitir restauración con pg_restore
                    //string arguments = $"--host \"{host}\" --port {port} --username \"{username}\" --format custom --blobs --verbose --file \"{destino}\" \"{database}\"";
                    string arguments = $"-h {host} -p {port} -U {username} -F c -b -v -f \"{destino}\" {database}";

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
                            MessageBox.Show("Respaldo creado correctamente en:\n" + destino, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvRespaldo.Rows.Add(nombreRespaldo, destino, DateTime.Now.ToString("el dd/MM/yyyy  hh:mm:ss"));
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            string rutaRestaurar = dgvRespaldo.CurrentRow?.Cells[1].Value?.ToString();

            if (string.IsNullOrEmpty(rutaRestaurar))
            {
                MessageBox.Show("Seleccione un respaldo existente para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el archivo existe
            if (!System.IO.File.Exists(rutaRestaurar))
            {
                MessageBox.Show("El archivo de respaldo no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                //crear la base de datos donde se hará la restauración
                string createdbExe = "createdb";
                string createdbArgs = $"-h {host} -p {port} -U {username} {database + "_restaurada"}";

                var createdbPsi = new ProcessStartInfo(createdbExe, createdbArgs)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                //pasar contraseña para no terner que escribirla
                createdbPsi.Environment["PGPASSWORD"] = password;

                //empieza el proceso de crear la base de datos
                using (var createdbProcess = Process.Start(createdbPsi))
                {
                    //capturar errores de ejecucion
                    string createdbErr = createdbProcess.StandardError.ReadToEnd();
                    createdbProcess.WaitForExit();

                    // Si el código es 0 o la BD ya existe, continua
                    if (createdbProcess.ExitCode != 0 && !createdbErr.Contains("already exists"))
                    {
                        MessageBox.Show($"Error al crear base de datos:\n{createdbErr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Base de datos para restauración creada. Empezando a copiar el contenido...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Nombre del ejecutable pg_restore
                string pgRestoreExe = "pg_restore";

                // Argumentos en formato custom para permitir restauración con pg_restore
                //string arguments = $"--host \"{host}\" --port {port} --username \"{username}\" --format custom --verbose --file \"{rutaRestaurar}\" \"{database}\"";
                //string arguments = $"--host \"{host}\" --port {port} --username svc_restore -n admin -n public --clean --if-exists --no-owner --no-comments --no-acl --exit-on-error --file \"{rutaRestaurar}\"";
                //string arguments = $"-h {host} -p {port} -U {username} -d {database} -v --clean --if-exists --no-owner --no-comments --no-acl \"{rutaRestaurar}\"";
                string arguments = $"-h {host} -p {port} -U {username} -d {database + "_restaurada"} -v -F c --clean --if-exists --no-owner --no-comments --no-acl \"{rutaRestaurar}\"";

                //se configura para ejecutar pg_restore con los argumentos especificados anteriormetne
                var psi = new ProcessStartInfo(pgRestoreExe, arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                // Evitar que pg_restore pida contraseña interactiva
                psi.Environment["PGPASSWORD"] = password;

                //empieza el proceso de pg_restore
                using (var process = Process.Start(psi))
                {
                    // Leer salidas para diagnóstico 
                    string stdOut = process.StandardOutput.ReadToEnd();
                    string stdErr = process.StandardError.ReadToEnd();

                    //esperar a que el proceso termine para mostrar si el respaldo fue exitoso o no
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Restauración creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        string mensaje = $"pg_restore finalizó con código {process.ExitCode}.\n\nError: {stdErr}\n\nSalida: {stdOut}";
                        MessageBox.Show(mensaje, "Error al restaurar base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRespaldo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtRestauracion.Text = dgvRespaldo.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtRutaRespaldo.Text = dgvRespaldo.Rows[e.RowIndex].Cells[1].Value?.ToString();
            txtFechaRespaldo.Text = dgvRespaldo.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }
    }
}
