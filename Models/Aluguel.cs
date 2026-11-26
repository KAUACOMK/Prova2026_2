using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Models
{
    internal class Aluguel
    {
        public Veiculos _veiculo { get; set; }
        public DateTime DataIncio { get; set; }
        public DateTime DataFim { get; set; }
        public int _totalDeDias { get; set; }
        public double _valorTotalAluguel { get; set; }

        public Aluguel(Veiculos veiculo, DateTime dataIncio, DateTime dataFim)
        { 
            _totalDeDias = (dataFim - dataIncio).Days; // Veio no inicio para tratar os dias antes de inserir o restante dos dados

            if (_totalDeDias <= 0)
                throw new Exception("A data de fim deve ser posterior a data e inicio, revise as datas informadas!");

            _veiculo = veiculo;
            DataIncio = dataIncio;
            DataFim = dataFim;
        }

        public double CalcularTotalAluguel(int dias)
        {
            var valorTotal = _veiculo.CalcularAluguel(dias);
            
            _valorTotalAluguel = valorTotal;

            return valorTotal;
        }
    }
}
