using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAniversário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            float A, B, C;

            A = float.Parse(TxtAniA.Text);
            B = float.Parse(TxtAniB.Text);
            C = float.Parse(TxtAniC.Text);

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C && A == C)
                    LblMostrar.Text = " Todos os Aniversáriantes fazem Aniversário no mesmo dia!!! ";
                else if (A == B || A == C || C == 8)
                    LblMostrar.Text = " Os Aniversáriantes fazem Aniversários em dias Diferentes!!! ";
                else
                    LblMostrar.Text = "Hoje é o seu Aniversário";


            }
            else
                LblMostrar.Text = " Aniversário de só um =) ";



            }
    }
}
