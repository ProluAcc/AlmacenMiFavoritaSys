using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class AbrirFormulario
    {
        public void AbrirForm(object formHijo, Panel panelContenedor)
        {
            //toma todos los controles del panel
            for (int i = panelContenedor.Controls.Count; i > 0; i--)
            {
                //los elimina cada uno
                panelContenedor.Controls.RemoveAt(0);
            }
            Form form = formHijo as Form;
            form.TopLevel = false; //no será un formulario de nivel superior, será secundario
            form.Dock = DockStyle.Fill; //hace que el formulario se estire para cubrir todo el panel contenedor 
            panelContenedor.Controls.Add(form); //se añade al panel
            panelContenedor.Tag = form; //se establece la instancia como contenedor de datos del panel
            form.Show(); //se muestra
        }
    }
}
