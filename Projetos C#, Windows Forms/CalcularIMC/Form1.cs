using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string Nome = TxtNome.Text;
            double Peso, Altura, Imc;
            Peso = Convert.ToDouble(TxtPeso.Text);
            Altura = Convert.ToDouble(TxtAltura.Text);
            Imc = Peso / (Altura * Altura);

            if (Imc <= 18)
            {
                LblResultado.Text = Nome + " Você está abaixo do peso ideal, Seu IMC Está abaixo de 20: " + Imc ;
            }
            else if ( Imc >= 19 && Imc <= 24 ) 
            {
                LblResultado.Text = Nome + " Você está no peso normal, Seu ICM: Está entre 19 e 24 " + Imc ; 
            }
            else if ( Imc >= 25 && Imc <= 29 )
            {
                LblResultado.Text = Nome + " Você está no acima do seu Peso Ideal (SobrePeso), Seu ICM: Está entre 25 e 29 " + Imc;
            }
            else if ( Imc >= 30 && Imc <= 34 )
            {
                LblResultado.Text = Nome + " Você está no Grau de Obesidade I, Seu ICM: Está entre 30 e 34 " + Imc;
            }
            else if ( Imc >= 35 && Imc <= 39 )
            {
                LblResultado.Text = Nome + " Você está no Grau de Obesidade II, Seu ICM: Está entre 35 e 39 " + Imc;
            }
            else if ( Imc >=40 )
            {
                LblResultado.Text = Nome + " Você está no Grau de Obesidade III, Seu ICM: Está acima de 40 " + Imc;
            }
        }

    }
}
