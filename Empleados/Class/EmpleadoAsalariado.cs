namespace Empleados.Class
{
    class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string nombre, decimal salarioSemanal)
            : base(nombre)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPagoSemanal()
        {
            return SalarioSemanal;
        }
    }
}

