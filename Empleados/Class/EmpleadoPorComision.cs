using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Class
{
    class EmpleadoPorComision : Empleado
    {
        public decimal VentasSemanales { get; set; }
        public decimal PorcentajeComision { get; set; }

        public EmpleadoPorComision(string nombre, decimal ventasSemanales, decimal porcentajeComision)
            : base(nombre)
        {
            VentasSemanales = ventasSemanales;
            PorcentajeComision = porcentajeComision;
        }

        public override decimal CalcularPagoSemanal()
        {
            return VentasSemanales * PorcentajeComision;
        }
    }
}
