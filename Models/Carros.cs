using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Models
{
    internal class Carros : Veiculos
    {
        public int QuantPortas { get; set; }
        public string? TamBagageiro { get; set; }

        public Carros(int quantPortas, string tamBagageiro, string descricao, string nomeMarca, string anoFabrica, double valorDiaria)
            : base(descricao, nomeMarca, anoFabrica, valorDiaria)
        {
            QuantPortas = quantPortas;
            TamBagageiro = tamBagageiro;
        }

        public override double CalcularAluguel(int dias)
        {
            var valorTotal = dias * ValorDiaria;

            if (dias > 7)
                return valorTotal * 0.90; //Desconto 10%
        
            return valorTotal;
        }
    }
}
