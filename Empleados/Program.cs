using System;
using System.Collections.Generic;
using Empleados.Class;

namespace Empleados
{
    class Program
    {
        static void Main()
        {
            List<Empleado> empleados = new List<Empleado>()
            {
                new EmpleadoAsalariado("Ana", 800m),
                new EmpleadoPorHora("Luis", 20m, 45),
                new EmpleadoPorComision("Carlos", 5000m, 0.06m),
                new EmpleadoAsalariadoComision("María", 500m, 3000m, 0.04m)
            };

            Console.WriteLine("=== Nómina semanal ===");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"{empleado.Nombre}: nomina semanal ${empleado.CalcularPagoSemanal():0.00}");
            }

            Console.ReadLine();
        }
    }
}
