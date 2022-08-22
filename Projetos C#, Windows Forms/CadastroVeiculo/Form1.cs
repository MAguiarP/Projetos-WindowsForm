using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Veículo ObjVeiculo = new Veículo();

        private void BtnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
         

            // Utiliza o método DefinirMarca da classe veículo para armazenar a marca
            ObjVeiculo.DefinirMarca(TxtMarca.Text);

            // Utiliza o método DefinirMarca da classe veículo para armazenar o Modelo
            ObjVeiculo.DefinirModelo(TxtModelo.Text);

            // Utiliza o método DefinirMarca da classe veículo para armazenar o ano
            ObjVeiculo.DefinirAno(TxtAno.Text);

            // Limpa os campos da tela
            TxtAno.Text = "";
            TxtModelo.Text = "";
            TxtMarca.Text = "";
        }

        private void BtnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            
            // Cria váriáveis para receber os dados do Veículo
            string StrMarca;
            string StrModelo;
            string StrAno;

            // Utiliza o método ObterMarca da classe Veículo para obter a Marca,Modelo e Ano
            StrMarca = ObjVeiculo.ObterMarca();
            StrModelo = ObjVeiculo.ObterModelo();
            StrAno = ObjVeiculo.ObterAno();

            // Exibe uma MessageBox com os dados do Veículo cadastrado anteriormente
            MessageBox.Show("  \r\n Marca do Veículo: " + StrMarca + "  \r\n Modelo: "
                + StrModelo + "  \r\n Ano: " + StrAno, "  \r\n Veículo Cadastrado!!! "); ;
           
        }
    }
}
