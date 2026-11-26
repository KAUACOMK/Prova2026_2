using Prova.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var carro1 = new Carros(2, "1000L", "Corrola Sedan", "Toyota", "2025", 350);
            var moto1 = new Motos("321Cc", "Sim", "180Kg", "21L", "MT-03", "Yamaha", "2026", 150.0);
            var caminhao1 = new Caminhoes(9, 9000, "SIDER", "FH440", "Volvo", "2017", 2500.0);

            var aluguelCarro = new Aluguel(carro1, Convert.ToDateTime("2026/11/25"), Convert.ToDateTime("2026/12/05"));
            var aluguelMoto = new Aluguel(moto1, Convert.ToDateTime("2026/11/25"), Convert.ToDateTime("2026/12/05"));
            var aluguelCaminhao = new Aluguel(caminhao1, Convert.ToDateTime("2026/11/25"), Convert.ToDateTime("2026/12/05"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("$$$$$$ TABELA DE ALUGUEIS $$$$$$");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Carro: {carro1.NomeMarca} {carro1.Descricao} Ano: {carro1.AnoFabricacao} ");
            Console.ResetColor();
            Console.WriteLine($"Quantidade de Dias: {aluguelCarro._totalDeDias}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor Aluguel {aluguelCarro.CalcularTotalAluguel(aluguelCarro._totalDeDias):C2}");
            Console.WriteLine();
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Carro: {moto1.NomeMarca} {moto1.Descricao} Ano: {moto1.AnoFabricacao} ");
            Console.ResetColor();
            Console.WriteLine($"Quantidade de Dias: {aluguelMoto._totalDeDias}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aluguel Moto: {aluguelMoto.CalcularTotalAluguel(aluguelMoto._totalDeDias):C2}");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Carro: {caminhao1.NomeMarca} {caminhao1.Descricao} Ano: {caminhao1.AnoFabricacao}");
            Console.ResetColor();
            Console.WriteLine($"Quantidade de Dias: {aluguelCaminhao._totalDeDias}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aluguel Caminhão: {aluguelCaminhao.CalcularTotalAluguel(aluguelCaminhao._totalDeDias):C2}");
            Console.ResetColor();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}