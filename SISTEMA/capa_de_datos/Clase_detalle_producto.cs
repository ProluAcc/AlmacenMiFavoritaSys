using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA.capa_de_datos
{
    internal class Clase_detalle_producto
    {
        private int _id_detalle_producto;
        private string _categoria;
        private string _medida;
        private string _marca;
        private string _descripcion;
        private double _precio_venta;
        private double _precio_compra;
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
