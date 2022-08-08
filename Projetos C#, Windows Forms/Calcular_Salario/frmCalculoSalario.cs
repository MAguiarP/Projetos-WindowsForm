using System;
using System.Windows.Forms;

namespace Calcular_Salario
{
    public partial class frmCalculoSalario : Form
    {
        public frmCalculoSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strNomeFuncionario;
            int intSalarioAtual;
            int intValorAumento;
            int intTotalSalario;
            int intTempoServico;

            strNomeFuncionario = txtNmFuncionario.Text;
            intSalarioAtual = Convert.ToInt32(txtSalarioAtual.Text);
            intTempoServico = Convert.ToInt32(txtTempoServico.Text);
            if ((intSalarioAtual < 1000) || (intTempoServico > 1))
            {
                intValorAumento = intSalarioAtual * 5 / 100;
                intTotalSalario = intValorAumento + intSalarioAtual;
                MessageBox.Show(strNomeFuncionario + " você terá " + intValorAumento + " Reais de aumento. Seu salário total será " + intTotalSalario + " Reais", " Total Salário ");
                txtNmFuncionario.Focus();
            }
            else
            {
                MessageBox.Show(strNomeFuncionario + " você não terá aumento de salário. ", "Aviso");
                txtNmFuncionario.Focus();
            }
        }
    }
}
