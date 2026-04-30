using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class Clase_detalle_venta_producto
    {
        private int _id_venta_producto;
        private double _subtotal;
        private double _descuento;
        private double _total;
        private int _id_producto;
        private int _id_venta;

        internal Clase_devolucion_ventas Clase_devolucion_ventas
        {
            get => default;
            set
            {
            }
        }
    }
}
