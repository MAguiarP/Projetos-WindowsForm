using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Dados Confirmados,Inscrição enviada" + textoNome.Text );
            
          string.Copy srttextoNome;



        }
    }
}
