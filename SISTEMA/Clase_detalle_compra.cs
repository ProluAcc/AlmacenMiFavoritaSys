using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class Clase_detalle_compra
    {
        private int _id_detalle_compra;
        private int _cantidad;
        private double _subtotal;
        private double _total;
        private int _id_producto;
        private int _id_compra;

        internal ClaseProducto ClaseProducto
        {
            get => default;
            set
            {
            }
        }

        internal ClaseCompra ClaseCompra
        {
            get => default;
            set
            {
            }
        }
    }
}
