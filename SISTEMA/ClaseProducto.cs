using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseProducto
    {
        private int _id_producto;
        private string _nombre;
        private string _codigo;    
        private int _id_detalle_producto;

        internal Clase_detalle_producto Clase_detalle_producto
        {
            get => default;
            set
            {
            }
        }

        internal Clase_detalle_compra Clase_detalle_compra
        {
            get => default;
            set
            {
            }
        }

        internal Clase_detalle_venta_producto Clase_detalle_venta_producto
        {
            get => default;
            set
            {
            }
        }
    }
}
