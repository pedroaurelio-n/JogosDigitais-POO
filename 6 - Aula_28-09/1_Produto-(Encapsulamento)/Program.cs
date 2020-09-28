using System;

namespace _1_Produto__Encapsulamento_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Digite o nome do produto: ");
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

            Console.ReadKey();*/

            Produto p = new Produto("ps5", 6000.00, 10);
            Console.WriteLine(p.Nome + ", " + p.Preco + ", " + p.Quantidade);

            p.Nome = "Nome";

            Console.WriteLine(p.Nome + ", " + p.Preco + ", " + p.Quantidade);
        }
    }
}
