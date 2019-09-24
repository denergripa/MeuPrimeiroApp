using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroApp
{
    class Carro
    {
        public string Modelo;
        public string Cor;
        public int QuantidadeDePortas;
        public bool PossuiArCondicionado;

        public Carro()
        {
            Modelo = "Fusca";
            Cor = "Azul";
            QuantidadeDePortas = 2;
            PossuiArCondicionado = false;

        }
        
        public string Ligar ()
        {
            return "VRUUM!!";
        }
        public string Desligar () {
            return "Carro Desligado";
        }
        public string Detalhes()
        {
            return Modelo + " - " + Cor;
        }
    }
}
