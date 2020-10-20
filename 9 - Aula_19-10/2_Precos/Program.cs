using System;
using System.Globalization;

namespace _2_Precos
{
    class Program
    {
        static void Main(string[] args)
        {
            //input do usuário em uma variável n que define o número de produtos
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //criação de um array da classe Produto com tamanho n
            Produto[] vect = new Produto[n];

            //loop for com variável inicial i=0 que pede entradas do usuário n vezes e cria um novo Produto no índice i do array com o nome e preço digitados nessa iteração do loop
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nDigite o nome do produto " + (i + 1) + ": ");
                string name = Console.ReadLine();

                Console.Write("Digite o preço do produto " + (i + 1) + ": ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }

            //variável double para a soma dos valores
            double sum = 0.00;

            //loop for que soma todos os valores de Price armazenados no array e atualiza no sum
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            //cálculo e output da média de valores (soma total dividida pelo tamanho do array)
            Console.WriteLine("\nA média de preço dos produtos é: " + (sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture));

            //impede o programa de fechar automaticamente
            Console.ReadKey();
        }
    }
}
