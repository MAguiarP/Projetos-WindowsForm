using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            
            {
                if (OptFor.Checked)
                {

                    for (int i = 0; i <= 8;)
                    {

                        MessageBox.Show(Convert.ToString(i + Convert.ToInt16(TxtNumero.Text) ));
                        i++;



                    }
                }
            }
        }
    }
}
