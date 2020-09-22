using System;
using System.Globalization;

namespace _2_CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor dolar = new Conversor();

            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade de dólares que será comprada: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conversao = Conversor.ConverterMoeda(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em reais: " + conversao.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
