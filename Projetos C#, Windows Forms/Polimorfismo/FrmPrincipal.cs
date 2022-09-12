using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text != "")
            {
                if (OptQuadrado.Checked)
                {
                    IFigura figura = new Quadrado();

                    double Medida = figura.CalcularArea(Convert.ToInt32(TxtNumero.Text));
                    double Perimetro = figura.CalcularPerimetro(Convert.ToInt32(TxtNumero.Text));
                    LblMostrar.Text = "Perímetro: " + Perimetro + "\r\n Área: " + Medida;
                }

                else if (OptTriangulo.Checked)
                {
                    IFigura figura = new Triangulo();
                    double Medida = figura.CalcularArea(Convert.ToInt32(TxtNumero.Text));
                    double Perimetro = figura.CalcularPerimetro(Convert.ToInt32(TxtNumero.Text));
                    LblMostrar.Text = "Perímetro: " + Perimetro + "\r\n Área: " + Medida;
                }

                
                else MessageBox.Show("Você deve selecionar a forma geométrica desejada!");
            }
                else MessageBox.Show("Informe o valor do lado!");
        }
    }

            
            
            
}
    

