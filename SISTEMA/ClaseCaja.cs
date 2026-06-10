using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA
{
    internal class ClaseCaja
    {
        private int _id_caja;
        private string _tipo_movimiento;
        private double _monto;
        private string _fecha_movimiento;        
        private double _saldo_final;
        private int _id_venta;
        private int _id_usuario;
        private int _id_compra;

        internal ClaseVenta ClaseVenta
        {
            get => default;
            set
            {
            }
        }
    }
}
