using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Models
{
    internal class Caminhoes : Veiculos
    {
        public int QuantEixos {  get; set; }
        public double CapacidadeCarga {  get; set; }
        public string? TipoCarroceria { get; set; }

        public Caminhoes(int quantEixos, double capacidadeCarga, string tipoCarroceria, string descricao, string nomeMarca, string anoFabrica, double valorDiaria)
            : base(descricao, nomeMarca, anoFabrica, valorDiaria)
        {
            QuantEixos = quantEixos;
            CapacidadeCarga = capacidadeCarga;
            TipoCarroceria = tipoCarroceria;
        }


        public override double CalcularAluguel(int dias)
        {
            var valorTotal = dias * ValorDiaria;
            
            if (CapacidadeCarga > 10000) 
                return valorTotal * 1.20; // Acrecimo 20%
            
            return valorTotal;
        }
    }
}
