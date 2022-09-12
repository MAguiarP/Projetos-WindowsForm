using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal interface IFigura
    {
        double CalcularArea(double medida);
        double CalcularPerimetro(double medida);
    }
}
