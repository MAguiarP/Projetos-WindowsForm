using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarAluno
{
    internal class Aluno : Pessoa
    {
        // Cria varíaveis (atributos) para armazenar a matrícula o Curso do Aluno.
        public string StrMatricula;
        public string StrCurso;

        /* Método que permite definir o nome do aluno
         * lembrando que a variável StrNome foi 
         * um atributo herdado da classe Pessoa.
         */
        public void DefinirNome(string Nome)
        {
            this.StrNome = Nome;
        }

        /* Nétodo que permite definir o nome do aluno
         * lemnrando que a va´riável IntIdade também foi 
         * um atributo herdado da classe Pessoa.
         */
        public void DefinirIdade(int Idade)
        {
            this.IntIdade = Idade;
        }

        // Mètodo que permite definir a matrícula do aluno
        public void DefinirMatricula(string Matricula)
        {
            this.StrMatricula = Matricula;
        }

        // Método que permite definir o curso do aluno
        public void DefinirCurso(string Curso)
        {
            this.StrCurso = Curso;
        }

        /*Método que permite obter o nome do aluno, lembrando que a variável
         * StrNome foi um atributo herdado da classe Pessoa.
         */
         public string ObterNome()
         {
            return this.StrNome;
         }

        /* Método que permite obter a idade do aluno lembrando que a variável
         * IntIdade Também foi um atributo herdado da classe Pessoa.
         */

        public int ObterIdade()
        {
            return this.IntIdade;
        }

        // Método que permite obter a matrícula do aluno
        public string ObterMatricula()
        {
            return this.StrMatricula;
        }

        // Método que permite obter o curso do aluno
        public string ObterCurso()
        {
            return this.StrCurso;
        }
    }
}
