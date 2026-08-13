using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.capa_de_datos
{
    internal class Clase_devolucion_ventas
    {
        private int _devolucion_ventas;
        private string _fecha;
        private string _motivo;
        private int _id_venta_producto;

        internal Clase_detalle_venta_producto Clase_detalle_venta_producto
        {
            get => default;
            set
            {
            }
        }
    }
}
