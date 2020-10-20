using System;
using System.Globalization;

namespace _1_Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada do usuário em uma variável que define o número de pessoas
            Console.Write("Entre com um número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            //criação de um array double com tamanho n
            double[] vect = new double[n];

            //loop for com variável inicial i=0 que pede entradas do usuário n vezes e armazena no índice i do array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Altura da pessoa (" + (i + 1) + "): ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //variável double para a soma dos valores
            double sum = 0.00;

            //loop for que soma todos os valores armazenados no array e atualiza no sum
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            //cálculo e output da média de valores (soma total dividida pelo tamanho do array)
            Console.WriteLine("A média de altura das pessoas inseridas é = " + (sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture));

            //impede o programa de fechar automaticamente
            Console.ReadKey();
        }
    }
}
