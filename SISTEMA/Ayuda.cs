using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    public class Ayuda: Form 
    {
        private TextBox txtContenido;
        private Button btnCerrar;

        public Ayuda()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Ayuda - Usuarios";
            this.Size = new Size(600, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtContenido = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F),
                ScrollBars = ScrollBars.Vertical,
                BackColor = SystemColors.Window,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(10)
            };

            btnCerrar = new Button()
            {
                Text = "Cerrar",
                Dock = DockStyle.Bottom,
                Height = 40,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };
            btnCerrar.Click += (s, e) => this.Close();

            Controls.Add(txtContenido);
            Controls.Add(btnCerrar);

            // Texto de ayuda que puedes personalizar
            txtContenido.Text =
                "Ayuda - Gestión de Usuarios\n\n" +
                "1) Crear usuario\n" +
                "   - Rellena: Nombre completo, Usuario, Correo, Contraseña, Pregunta y Respuesta.\n" +
                "   - Selecciona Rol y Estado (obligatorio).\n" +
                "   - Pulsa '💾GUARDAR' para crear.\n\n" +
                "2) Editar usuario\n" +
                "   - Haz doble clic en la fila o selecciónala y pulsa '✏️EDITAR' para aplicar cambios.\n\n" +
                "3) Buscar usuarios\n" +
                "   - Selecciona campo en 'Buscar por', escribe el término y pulsa '🔍 BUSCAR'.\n\n" +
                "4) Notas\n" +
                "   - La cédula/código se genera automáticamente.\n" +
                "   - Si necesitas exportar o imprimir, indícalo para añadir esa función.\n\n" +
                "Contacto: equipo de desarrollo / documentación interna.";
        }
    }
}
