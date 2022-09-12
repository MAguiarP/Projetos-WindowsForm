using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Triangulo : IFigura

    {
        public double CalcularArea(double medida)
        {
            return (Math.Pow(medida, 2) * Math.Sqrt(3)) / 4 ;
        }
        public double CalcularPerimetro(double medida)
        {
            return medida * 3;
        }
    }
}
