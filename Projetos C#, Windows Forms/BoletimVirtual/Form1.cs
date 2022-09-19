using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int Int1, Int2, Int3, Int4, Media;
            Int1 = Convert.ToInt32(Txt1.Text);
            Int2 = Convert.ToInt32(Txt2.Text);
            Int3 = Convert.ToInt32(Txt3.Text);
            Int4 = Convert.ToInt32(Txt4.Text);

            Media = Int1 + Int2 + Int3 + Int4;

            if (Media <= 199)
            {
                LblResultado.Text = " Você Está Reprovado " + "\r\n" + Media + " Sua Média " ;
            }
            else if (Media >= 200)
            {
                LblResultado.Text = " Você Está Aprovado" + "\r\n" + Media + " Sua Média ";
            }
        }
    }
}
