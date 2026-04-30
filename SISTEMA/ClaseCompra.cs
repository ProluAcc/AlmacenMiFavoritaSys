using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseCompra
    {
        private string _id_compra;
        private string _fecha_compra;
        private string _fecha_entrega;
        private int _numero_factura;
        private int _id_proveedor;
        private int _id_usuario;

        internal ClaseProveedor ClaseProveedor
        {
            get => default;
            set
            {
            }
        }

        internal ClaseProducto ClaseProducto
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
    }
}
