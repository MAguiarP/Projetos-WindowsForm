using System;
using System.Windows.Forms;
/*
 * Programa para calculo da divisão de valores.
 * O usuário deve informar m dividendo e um divisor e clicar no botão dividir
 */
/*
 * Programa..........:Dividir
 * Autor.............:Matheus
 * Versão............:1.0
 * Revisão...........:15/06/2022
 */
namespace Divisão
{
    public partial class FrmDivisao : Form
    {
        public FrmDivisao()
        {
            InitializeComponent();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            //Cria as variáveis
            int IntDividendo, IntDivisor, IntQuociente;

            try
            {
            //Adiciona o valor dos controles ás variáveis criadas

                IntDividendo = Convert.ToInt32(TxtDividendo.Text);
                IntDivisor = Convert.ToInt32(TxtDivisor.Text);
            //Realiza o cálculo da divisão
                IntQuociente = IntDividendo / IntDivisor;
            //Mostra o resultado ao usuário
                TxtQuociente.Text = Convert.ToString(IntQuociente);
            }
            catch ()
            {
            //Caso o usuário queira fazer uma divisão por zero gera a exceção
                MessageBox.Show(Erro.Message);
                TxtDivisor.Focus();
            }
        }
    }
}
