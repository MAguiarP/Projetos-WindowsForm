namespace Sobrescrita
{
    internal class Funcionario
    {
        private double Salario;

        public virtual double CalcularSalario()
        {
            Salario = 1000.00;
            return Salario;
        }
    }
}
