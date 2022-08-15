using System;
using System.Windows.Forms;

namespace Estrutura_de_Repetição
{
    public partial class FrmEstruturaRepeticao : Form
    {
        public FrmEstruturaRepeticao()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            long lngNumero = Convert.ToInt64(TxtNumero.Text);
            int IntContaDivisoes = 0;

            if (OptWhile.Checked)
            {
                TxtResultado.Text = "While: \r\n";
                long lngContador = 1;
                while (lngContador <= (lngNumero / 2))
                {
                    TxtResultado.Text += "Realizar a Divisão por " + lngContador + " \r\n";
                    if (lngNumero % lngContador == 0)
                    {
                        TxtResultado.Text += " --> Divisível por " + lngContador + " \r\n";
                        IntContaDivisoes++;
                    }
                    lngContador++;

                    TxtResultado.Text += "Divisível por " + TxtNumero.Text + " \r\n";

                    if (IntContaDivisoes > 1)
                    {
                        TxtResultado.Text += "\r\n\r\n O número não é primo! ";
                    }
                    else
                    {
                        TxtResultado.Text += "\r\n\r\n O número é primo, pois é divisível por 1 e por ele mesmo!";
                    }
                }

            }
            else if (OptFor.Checked)
            {
                TxtResultado.Text = "For: \r\n";
                for (int lngContador = 1; lngContador <= (lngNumero / 2); lngContador++)
                {
                    TxtResultado.Text += "Realizar a divisão por " + lngContador + "\r\n";

                    if (lngNumero % lngContador == 0)
                    {
                        TxtResultado.Text += "Divisível por " + TxtNumero.Text + "\r\n";

                        if (IntContaDivisoes > 1)
                        {
                            TxtResultado.Text += " \r\n\r\n o número não é primo";
                        }
                        else
                        {
                            TxtResultado.Text += "\r\n\r\n o número é primo, pois é divisível por 1 é por ele mesmo!";
                        }
                    }
                }
            }
            else if (OptDo.Checked)
            {
                TxtResultado.Text = "Do: \r\n";
                long lngContador = 1;
                do
                {
                    TxtResultado.Text += "Realizar a divisão por " + lngContador + " \r\n";

                    if (lngNumero % lngContador == 0)
                    {
                        TxtResultado.Text += " --> Divisível por " + lngContador + " \r\n";
                        IntContaDivisoes++;
                    }
                    lngContador++;
                    TxtResultado.Text += "Divisível por " + TxtNumero.Text + " \r\n";
                    if (IntContaDivisoes > 1)
                    {
                        TxtResultado.Text += " \r\n\r\n O Número não é primo! ";
                    }
                    else
                    {
                        TxtResultado.Text += " \r\n\r\n O Número é primo, pois é divisível por 1 e por ele mesmo! ";
                    }
                }
                while (lngContador <= (lngNumero / 2));
            }
        }
    }
}
