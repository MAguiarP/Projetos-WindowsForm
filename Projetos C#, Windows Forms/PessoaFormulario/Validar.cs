using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFormulario
{
    internal class Validar
    {
        public string ClassificarQIeCalcularIdadePessoa(int IntQI, int IntAno, int IntMes)
        {
            Idade ObjIdade = new Idade();
            string StrMensagem = string.Empty;
            StrMensagem = ClassificarQIeCalcularIdadePessoa(IntQI);
            StrMensagem += ObjIdade.CalcularIdade(IntAno, IntMes);

            return StrMensagem;
        }
    }
}
