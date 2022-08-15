namespace Sobrescrita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            Supervisor  supervisor = new Supervisor();
            Gerente gerente = new Gerente();

            if (OptGerente.Checked)
            {
                MessageBox.Show("O Salário do Gerente é: " +  gerente.CalcularSalario() + "\n\r" + Convert.ToString(TxtNome.Text) + "\n\r" + Convert.ToString(TxtEmpresa.Text) + "\n\r" + "Parabéns por Trabalhar para Nossa empresa!");
            }
            else if (OptSupervisor.Checked)
            {
                MessageBox.Show("O Salário do Supervisor é: " +  supervisor.CalcularSalario() + "\n\r" + Convert.ToString(TxtNome.Text) + "\n\r" + Convert.ToString(TxtEmpresa.Text) + "\n\r" + "Parabéns por Trabalhar para Nossa empresa!");  
            }    
            else if (OptFuncionario.Checked)
                MessageBox.Show("O Salário do Funcionário é: " +  funcionario.CalcularSalario() + "\n\r" + Convert.ToString(TxtNome.Text) + "\n\r" + Convert.ToString(TxtEmpresa.Text) + "\n\r" + "Parabéns por Trabalhar para Nossa empresa!");
        }   

    }
}