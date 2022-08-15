using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ValorDigitado;
            try
            { 
            ValorDigitado = Convert.ToInt16(textValor.Text);
            
            
                for (int i = 1; i <= 12; i++)
                {
                    listBox1.Items.Add(i + " X " + ValorDigitado + " = " + (i * ValorDigitado));
                }
            }
            catch(System.FormatException) 
            {
                MessageBox.Show(" Essa calculo não existe!! ");
            }

            catch(System.OverflowException)
            {
                MessageBox.Show(" Esse calculo é muito extenso!!!! ");
            }
        }
            

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
