using System;
using System.Globalization;

namespace _1_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área do retângulo: " + Retangulo.Area(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro do retângulo: " + Retangulo.Perimetro(largura, altura).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal do retângulo: " + Retangulo.Diagonal(largura, altura).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
