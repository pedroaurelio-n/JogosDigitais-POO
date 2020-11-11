using System;
using System.Globalization;

namespace _1_Produto__Encapsulamento_
{
    class Program
    {
        static void Main(string[] args)
        {
            //entradas do usuário para os dados
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto em reais: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque do produto: ");
            int quantidade = int.Parse(Console.ReadLine());


            //criação do objeto com as propriedades definidas
            Produto p = new Produto(preco, quantidade);
            p.Nome = nome;


            //mostra das informações do objeto com o método tostring aplicando a formatação
            Console.WriteLine("\nDados do produto \n" + p + "\n\n");


            //método para adicionar produtos
            Console.Write("Digite o quantidade a ser adicionada ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));


            //mostra das informações atualizadas do objeto
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");


            //método para remover produtos
            Console.Write("Digite o quantidade a ser removida ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));


            //mostra das informações atualizadas do objeto
            Console.WriteLine($"\nDados atualizados do produto \n" + p + "\n\n");

            Console.ReadKey();
        }
    }
}
