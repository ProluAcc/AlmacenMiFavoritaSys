using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseCredito
    {
        private int _id_credito;
        private string _fecha_inicio;
        private string _fecha_vencimiento;
        private double _monto;
        private int _cuotas;
        private double _porcentaje_interes;
        private string _forma_pago;
        private string _estado;
        private int _id_venta;

        internal ClaseVenta ClaseVenta
        {
            get => default;
            set
            {
            }
        }

        internal ClaseVenta ClaseVenta1
        {
            get => default;
            set
            {
            }
        }
    }
}
