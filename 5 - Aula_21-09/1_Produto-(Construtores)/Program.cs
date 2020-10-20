using System;
using System.Globalization;

namespace _1_Produto__Construtores_
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada do usuário de dados que serão guardados em variáveis privadas inicialmente
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto em reais: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            //instância de um objeto p da classe Produto já utilizando as variáveis privadas como parâmetros
            Produto p = new Produto(nome, preco, quantidade);

            //mostra de informações do objeto formatadas pelo ToString
            Console.WriteLine("\nDados do produto \n" + p + "\n\n");

            //método de adicionar produtos utilizado
            Console.Write("Digite o valor a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            //mostra de informações do objeto formatadas pelo ToString
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");

            //método de remover produtos utilizado
            Console.Write("Digite o valor a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            //mostra de informações do objeto formatadas pelo ToString
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");

            Console.ReadKey();
        }
    }
}