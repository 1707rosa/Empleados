namespace Empleados.Class
{
    class EmpleadoAsalariadoComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoComision(string nombre, decimal salarioBase, decimal ventasSemanales, decimal porcentajeComision)
            : base(nombre, ventasSemanales, porcentajeComision)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularPagoSemanal()
        {
            decimal bonificacion = SalarioBase * 0.10m; // 10% extra
            return SalarioBase + bonificacion + base.CalcularPagoSemanal();
        }
    }
}
