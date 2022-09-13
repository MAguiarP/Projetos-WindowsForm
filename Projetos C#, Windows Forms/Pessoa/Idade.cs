using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Idade
    {
        public string CalcularIdade(int intDia, int intMes, int intAno)
        {
            DateTime dataNascimento = new DateTime(intAno, intMes, intDia);

            TimeSpan idade = DateTime.Now - dataNascimento;
            int anos = Convert.ToInt32(idade.Days / 365);
            int meses = Convert.ToInt32(idade.Days % 365 / 30);
            int dias = Convert.ToInt32(idade.Days % 365 % 30);

            string StrMensagem = "Tem " + anos + " anos " + meses + " meses e " + dias + " dias de vida ";
            return StrMensagem;
        }

        public string CalcularIdade(int intAno, int intMes)
        {
            string StrMensagem = string.Empty;

            DateTime dataNascimento = new DateTime(intAno, intMes, 30);

            TimeSpan idade = DateTime.Now - dataNascimento;
            int anos = Convert.ToInt32(idade.Days / 365);

            StrMensagem = "Tem " + anos + "anos de vida ";
            return StrMensagem;
            {
            }

            
            

            
        }
    }
}
