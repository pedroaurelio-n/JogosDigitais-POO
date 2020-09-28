using System;
using System.Globalization;

namespace _3_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as notas do aluno: ");
            float nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno a = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine("Nota Final: " + a.GerarNotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.NotaFinal >= 60)
            {
                Console.WriteLine("\nAprovado");
            }

            else
            {
                Console.WriteLine("\nReprovado");
                Console.WriteLine("Faltaram " + (60 - a.NotaFinal).ToString("F2", CultureInfo.InvariantCulture) + " ponto(s)");
            }

            Console.ReadKey();
        }
    }
}
