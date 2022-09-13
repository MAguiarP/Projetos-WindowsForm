using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoa
{
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

        private void BtnMostrarDataCompleta_Click(object sender, EventArgs e)
        {
            Validar objValidar = new Validar();
            string StrMensagem = "O (A) ";
            StrMensagem += TxtNome.Text;
            StrMensagem += "\r\n";
           StrMensagem += objValidar.CalcularIdadePessoa(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtAno.Text));

            LblResultado.Text = StrMensagem;
        }

        private void BtnMostrarData_Click(object sender, EventArgs e)
        {
            Validar ObjValidar = new Validar();

            string StrMensagem = "O (A) ";

            StrMensagem += TxtNome.Text;
            StrMensagem += "\r\n";
            StrMensagem += ObjValidar.ClassificarQIeCalcularIdadePessoa(Convert.ToInt32(txtAno.Text), Convert.ToInt32(txtMes.Text));

            LblResultado.Text = StrMensagem;
        }
    }
}
