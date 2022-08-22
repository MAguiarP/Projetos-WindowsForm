using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarProfessor
{
    internal class Professor : Pessoa
    {
        public string StrDisciplina;
        public string Matricula;
    }

    public void DefinirNome(string Nome)
    {
        this.StrNome = Nome;
    }
}

