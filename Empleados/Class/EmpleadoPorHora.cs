namespace Empleados.Class
{
    class EmpleadoPorHora : Empleado
    {
        public decimal PagoPorHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public EmpleadoPorHora(string nombre, decimal pagoPorHora, int horasTrabajadas)
            : base(nombre)
        {
            PagoPorHora = pagoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularPagoSemanal()
        {
            if (HorasTrabajadas <= 40)
            {
                return HorasTrabajadas * PagoPorHora;
            }
            else
            {
                int horasExtra = HorasTrabajadas - 40;
                return (40 * PagoPorHora) + (horasExtra * PagoPorHora * 1.5m);
            }
        }
    }
}
