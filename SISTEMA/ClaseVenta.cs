using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseVenta
    {
        private int _id_venta;
        private string _fecha_venta;
        private string _tipo_venta;       
        private int _numero_factura;
        private int _id_usuario;
        private int _id_cliente;

        internal ClaseCaja ClaseCaja
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

        internal ClaseClientes ClaseClientes
        {
            get => default;
            set
            {
            }
        }

        internal ClaseDevolucion ClaseDevolucion
        {
            get => default;
            set
            {
            }
        }

        internal ClaseCredito ClaseCredito
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
