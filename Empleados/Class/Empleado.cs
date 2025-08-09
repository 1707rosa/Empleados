using System;

namespace Empleados.Class
{
    // Clase base abstracta
    abstract class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public abstract decimal CalcularPagoSemanal();
    }
}
