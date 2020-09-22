using System;
using System.Globalization;

namespace _1_Produto__Construtores_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto();

            /*Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto em reais: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());*/

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto em reais: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("\nDados do produto \n" + p + "\n\n");


            Console.Write("Digite o valor a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");


            Console.Write("Digite o valor a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");

            Console.ReadKey();
        }
    }
}