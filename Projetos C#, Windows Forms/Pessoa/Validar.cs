using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Validar
    {
        public string CalcularIdadePessoa(int intDia, int intAno, int intMes)
        {
            Idade objIdade = new Idade();
            string StrMensagem = CalcularIdadePessoa(intDia, intMes, intAno);
            StrMensagem += objIdade.CalcularIdade(intAno, intMes);

            return StrMensagem;
        }

        public string ClassificarQIeCalcularIdadePessoa(int intAno, int intMes)
        {
            Idade objIdade = new Idade();
            string StrMensagem = string.Empty;
            StrMensagem += objIdade.CalcularIdade(intAno, intMes);

            return StrMensagem;
        }


    }



}
