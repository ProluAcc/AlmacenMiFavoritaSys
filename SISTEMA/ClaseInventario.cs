using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseInventario
    {
        private int _id_inventario;
        private int _stock_actual;
        private int _stock_minimo;
        private string _disponibilidad;
        private int _id_producto;

        internal ClaseProducto ClaseProducto
        {
            get => default;
            set
            {
            }
        }
    }
}
