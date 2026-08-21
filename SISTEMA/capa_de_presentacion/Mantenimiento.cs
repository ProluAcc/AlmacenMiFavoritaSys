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

        private async void btnRestaurar_Click(object sender, EventArgs e)
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
                string restoredDatabase = database + "_restaurada";

                //crear la base de datos donde se hará la restauración SOLO si no existe
                string createdbExe = "createdb";
                string createdbArgs = $"-h {host} -p {port} -U {username} {restoredDatabase}";

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

                    // Si el código es 0, la BD se creó. Si no es 0, verificar si ya existe
                    if (createdbProcess.ExitCode == 0)
                    {
                        MessageBox.Show("Base de datos para restauración creada. Empezando a copiar el contenido...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (createdbErr.Contains("ya existe"))
                    {
                        MessageBox.Show("Base de datos para restauración ya existe. Procedeiendo a sobrescribir el contenido...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al crear base de datos:\n{createdbErr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Nombre del ejecutable pg_restore
                string pgRestoreExe = "pg_restore";

                // Argumentos con --clean --if-exists para limpiar y sobrescribir datos existentes
                string arguments = $"-h {host} -p {port} -U {username} -d {restoredDatabase} -v -F c --clean --if-exists --no-owner --no-comments --no-acl \"{rutaRestaurar}\"";

                //se configura para ejecutar pg_restore con los argumentos especificados anteriormetne
                var psi = new ProcessStartInfo(pgRestoreExe, arguments)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false
                };

                // Evitar que pg_restore pida contraseña interactiva
                psi.Environment["PGPASSWORD"] = password;

                //empieza el proceso de pg_restore
                using (var process = Process.Start(psi))
                {
                    // Leer ambos streams de forma asincrónica para evitar deadlock
                    var stdOutTask = process.StandardOutput.ReadToEndAsync();
                    var stdErrTask = process.StandardError.ReadToEndAsync();

                    await Task.WhenAll(stdOutTask, stdErrTask);

                    string stdOut = stdOutTask.Result;
                    string stdErr = stdErrTask.Result;

                    //esperar a que el proceso termine para mostrar si el respaldo fue exitoso o no
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Restauración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
