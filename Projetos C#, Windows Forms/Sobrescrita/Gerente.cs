namespace Sobrescrita
{
    internal class Gerente : Funcionario
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario() + 1000.00;
        }
    }
}
