namespace Sobrescrita
{
    internal class Supervisor : Funcionario
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario() + 2000.00;
        }
    }
}
