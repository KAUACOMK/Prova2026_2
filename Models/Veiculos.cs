using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Prova.Models
{
    internal abstract class Veiculos
    {
        public int VeiculoId { get; set; }
        public string? Descricao { get; set; }
        public string? NomeMarca { get; set; }
        public string? AnoFabricacao { get; set; }

        private double _valorDiaria { get; set; } // atributo incapsulado

        public double ValorDiaria 
        {
            get => _valorDiaria; 
            set 
            {
                if (value < 0)
                    throw new Exception("Valor da diária informado deve ser igual ou maior que zero!"); // Tratamento de valor diaria.
                _valorDiaria = value;
            } 
        }

        public Veiculos (string descricao, string nomeMarca, string anoFabricao, double valorDiaria)
        {
            Descricao = descricao;
            NomeMarca = nomeMarca;
            AnoFabricacao = anoFabricao;
            ValorDiaria = valorDiaria;
        }

        public abstract double CalcularAluguel(int dias);

    }
}
