using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Quadrado : IFigura
    {
        public double CalcularArea(double medida)
        {
            return Math.Pow(medida, 2);
        }

        public double CalcularPerimetro(double medida)
        {
            return medida * 4;
        }
    }
}
