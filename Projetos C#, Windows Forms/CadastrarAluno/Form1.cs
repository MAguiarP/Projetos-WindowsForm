using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cria um objeto do tipo classe Aluno
        readonly Aluno ObjAluno = new Aluno();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Utiliza o método DefinirNome da classe ALuno para armazenar o nome do aluno
            ObjAluno.DefinirNome(TxtNome.Text);

            /* Utiliza o método DefinirIdade da classe Aluno para Armazenar a idade do 
             * Aluno convertendo o campo TxtIdade Para INTeger, sendo que ele é do tipo
             * string.
             */
            ObjAluno.DefinirIdade(Convert.ToInt16(TxtIdade.Text));
            
            // Utiliza o método DefinirMatricula da classe Aluno para armazenar a Curso do aluno
            ObjAluno.DefinirCurso(TxtCurso.Text);

            // Utiliza o método DefinirMatricula da classe Aluno para armazenar a matrícula do aluno
            ObjAluno.DefinirMatricula(TxtMatricula.Text);

            // Limpa os campos da tela
            TxtNome.Text = "";
            TxtIdade.Text = "";
            TxtMatricula.Text = "";
                TxtCurso.Text = "";

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            // Cria váriaveis para receber os dados do Aluno
            string StrNome;
            int IntIdade;
            string StrMatricula;
            string StrCurso;

            // Utiliza o método ObterNome da classe Aluno para obter o nome do aluno
            StrNome = ObjAluno.ObterNome();

            // Utiliza o método ObterIdade da classe Aluno para obter a idade do aluno
            IntIdade = ObjAluno.ObterIdade();

            // Utiliza o método ObterMatricula da classe Aluno para obter a Matricula do aluno
            StrMatricula = ObjAluno.ObterMatricula();

            // Utiliza o método ObterCurso da classe Aluno para obter o Curso do aluno
            StrCurso = ObjAluno.ObterCurso();

            //Exibe uma MessaBox com os dados do aluno cadastrado anteriormente
            MessageBox.Show(" Nome: " + StrNome + "  \n\r Idade: " + IntIdade + "  \n\r Matrícula: " + StrMatricula + "  \n\r Curso: " + StrCurso, "  \n\r Aluno Cadastrado!!!");
        }
    }
}
