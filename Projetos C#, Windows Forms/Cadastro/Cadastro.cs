using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            string StrNome; 
            StrNome = TxtNome.Text;
            string StrSobrenome;
            StrSobrenome = TxtSobrenome.Text;

            MessageBox.Show(StrNome + StrSobrenome);
           
            if (OptCasado.Checked)
            {
                MessageBox.Show("Casado(a)");
            }
            else if (OptDivorciado.Checked)
            {
                MessageBox.Show("Divorciado(a)");
            }
            else if (OptSolteiro.Checked)
            {
                MessageBox.Show("Solteiro(a)");
            }
            else if (OptViuvo.Checked)
            {
                MessageBox.Show("Viúvo(a)");
            }

            BtnLimpar.Focus();
            


        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtSobrenome.Text = "";
            TxtNome.Focus();
            OptSolteiro.Checked = false;
            OptCasado.Checked = false;
            OptDivorciado.Checked = false;
            OptViuvo.Checked = false;
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
