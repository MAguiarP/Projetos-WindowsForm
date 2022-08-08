using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal resultado = 0;
            if (OptAdicao.Checked)
            {
                TxtExpressao.Text = TxtNumero1.Text + " + " + TxtNumero2.Text;
                resultado =
                    Convert.ToDecimal(TxtNumero1.Text) +
                    Convert.ToDecimal(TxtNumero2.Text);
            }
            else if (OptSubtracao.Checked)
            {
                TxtExpressao.Text = TxtNumero1.Text + " - " + TxtNumero2.Text;
                resultado =
                    Convert.ToDecimal(TxtNumero1.Text) -
                    Convert.ToDecimal(TxtNumero2.Text);
            }
            else if (OptMultiplicacao.Checked)
            {
                TxtExpressao.Text = TxtNumero1.Text + " * " + TxtNumero2.Text;
                resultado =
                    Convert.ToDecimal(TxtNumero1.Text) *
                    Convert.ToDecimal(TxtNumero2.Text);
            }
            else if (OptDivisao.Checked)
            {
                TxtExpressao.Text = TxtNumero1.Text + " / " + TxtNumero2.Text;
                resultado =
                    Convert.ToDecimal(TxtNumero1.Text) /
                    Convert.ToDecimal(TxtNumero2.Text);
            }
            else if (OptRestoDivisao.Checked)
            {
                TxtExpressao.Text = TxtNumero1.Text + " % " + TxtNumero2.Text;
                resultado =
                    Convert.ToDecimal(TxtNumero1.Text) %
                    Convert.ToDecimal(TxtNumero2.Text);
            }

            TxtResultado.Text = resultado.ToString();

        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            TxtNumero1.Text = "";
            TxtNumero2.Text = "";
            TxtExpressao.Text = "";
            TxtResultado.Text = "";
            TxtNumero1.Focus();
            OptAdicao.Checked = false;
            OptSubtracao.Checked = false;
            OptMultiplicacao.Checked = false;
            OptDivisao.Checked = false;
            OptRestoDivisao.Checked = false;
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
