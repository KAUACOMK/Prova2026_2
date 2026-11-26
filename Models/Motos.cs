using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Models
{
    internal class Motos : Veiculos
    {
        public string? Cilindradas { get; set; }
        public string? PartidaEletrica { get; set; }
        public string? Peso { get; set; }
        public string? CapTanque { get; set; }
       
        public Motos(string cilindradas, string partidaEletrica, string peso, string capTanque, string descricao, string nomeMarca, string anoFabrica, double valorDiaria )
            : base(descricao, nomeMarca, anoFabrica, valorDiaria)
        {
            Cilindradas = cilindradas;
            PartidaEletrica = partidaEletrica;
            Peso = peso;
            CapTanque = capTanque;
        }

        public override double CalcularAluguel(int dias)
        {
            var valorTotal = dias * ValorDiaria;

            if (dias > 5)
                return valorTotal * 0.85; // Deconto 15%

            return valorTotal;
        }
    }
}
