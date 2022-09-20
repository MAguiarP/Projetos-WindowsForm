using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFormulario
{
    internal class Idade
    {
        public string CalcularIdade(int IntDia, int IntMes, int IntAno)
        {
            string StrMensagem = string.Empty;

            DateTime dataNascimento = new DateTime(IntAno, IntMes, IntDia);

            TimeSpan idade = DateTime.Now - dataNascimento;
            int anos = Convert.ToInt32(idade.Days / 365 );
            int meses = Convert.ToInt32(idade.Days % 365 / 30 );
            int dias = Convert.ToInt32(idade.Days % 365 % 30 );

            StrMensagem = "Tem " + anos + "Anos " + meses + "Meses e " + dias + "dias de vida ";
            return StrMensagem;
        }
        public string CalcularIdade(int IntAno, int IntMes)
        {
            string StrMensagem = string.Empty;
            DateTime DataNascimento = new DateTime(IntAno, IntMes, 30);
            TimeSpan Idade = DateTime.Now - DataNascimento;
            int Anos = Convert.ToInt32(Idade.Days / 365);

            StrMensagem = "tem " + Anos + " anos de vida ";

            return StrMensagem;
        }
    }
}
