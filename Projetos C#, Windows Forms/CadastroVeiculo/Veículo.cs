using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    internal class Veículo
    {
        ///Variáveis privadas para a marca, modelo e ano do veículo

        private string StrMarca;
        private string StrModelo;
        private string StrAno;

        //Método que permite definir a marca do veículo
        public void DefinirMarca(string Marca)
        {
            this.StrMarca = Marca;
        }

        // Método que permite definir o modelo do veículo
        public void DefinirModelo(string Modelo)
        {
            this.StrModelo = Modelo;
        }
        
        //Método que permite definir o ano do veículo
        public void DefinirAno(string Ano)
        {
            this.StrAno = Ano;
        }

        //Método que permite obter a marca do veículo
        public string ObterMarca()
            { return this.StrMarca; }

        //Método que permite obter o modelo do veículo
        public string ObterModelo()
            { return this.StrModelo; }

        //Método que permite obter o ano do veículo
        public string ObterAno()
            { return this.StrAno; }


    }
}
