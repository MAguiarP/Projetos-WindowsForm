using System;
using System.Windows.Forms;

namespace Calcular_13º_Salário
{
    public partial class frmCalcular13Salario : Form
    {
        public frmCalcular13Salario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal DecSalario, DecValorMensal, DecResultado = 0; string StrMesSelecionado = String.Empty;

            DecSalario = Convert.ToDecimal(TxtSalario.Text);
            DecValorMensal = DecSalario / 12;

            switch (Convert.ToByte(TxtMesReferencia.Text))
            {
                case 1:
                    {
                        StrMesSelecionado = "Janeiro";
                       
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 2:
                    {
                        StrMesSelecionado = "Fevereiro";
                        
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 3:
                    {
                        StrMesSelecionado = "Março";
                        DecResultado = DecValorMensal * 3;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 4:
                    {
                        StrMesSelecionado = "Abril";
                        DecResultado = DecValorMensal * 4;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 5:
                    {
                        StrMesSelecionado = "Maio";
                        DecResultado = DecValorMensal * 5;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 6:
                    {
                        StrMesSelecionado = "Junho";
                        DecResultado = DecValorMensal * 6;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 7:
                    {
                        StrMesSelecionado = "Julho";
                        DecResultado = DecValorMensal * 7;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 8:
                    {
                        StrMesSelecionado = "Agosto";
                        DecResultado = DecValorMensal * 8;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 9:
                    {
                        StrMesSelecionado = "Setembro";
                        DecResultado = DecValorMensal * 9;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 10:
                    {
                        StrMesSelecionado = "Outubro";
                        DecResultado = DecValorMensal * 10;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 11:
                    {
                        StrMesSelecionado = "Novembro";
                        DecResultado = DecValorMensal * 11;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
                case 12:
                    {
                        StrMesSelecionado = "Dezembro";
                        DecResultado = DecValorMensal * 12;
                        LblResultado.Text = "O Valor do 13º Salário no mês de " + StrMesSelecionado + " é igual a " + DecResultado + "Reais";
                        break;
                    }
            }
        }
    }
}
