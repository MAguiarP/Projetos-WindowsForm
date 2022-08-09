using System;
using System.Windows.Forms;

namespace Mostrar_Mês
{
    public partial class mostrarmes : Form
    {
        public mostrarmes()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            switch (Convert.ToByte(TxtMes.Text))
            {
                case 1:
                    {
                        LblResultado.Text = "Janeiro";
                        break;
                    }
                case 2:
                    {
                        LblResultado.Text = "Fevereiro";
                        break;
                    }
                case 3:
                    {
                        LblResultado.Text = "Março";
                        break;
                    }
                case 4:
                    {
                        LblResultado.Text = "Abril";
                        break;
                    }
                case 5:
                    {
                        LblResultado.Text = "Maio";
                        break;
                    }
                case 6:
                    {
                        LblResultado.Text = "Junho";
                        break;
                    }
                case 7:
                    {
                        LblResultado.Text = "Julho";
                        break;
                    }
                case 8:
                    {
                        LblResultado.Text = "Agosto";
                        break;
                    }
                case 9:
                    {
                        LblResultado.Text = "Setembro";
                        break;
                    }
                case 10:
                    {
                        LblResultado.Text = "Outubro";
                        break;
                    }
                case 11:
                    {
                        LblResultado.Text = "Novembro";
                        break;
                    }
                case 12:
                    {
                        LblResultado.Text = "Dezembro";
                        break;
                    }
            }
        }
    }
}