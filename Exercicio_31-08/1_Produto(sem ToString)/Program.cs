using System;
using System.Globalization;

namespace POO_31_8_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto em reais: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade em estoque do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nDados do produto " +
                $"\nNome: {p.Nome}" +
                $"\nPreço: R${p.Preco.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{p.Quantidade.ToString(CultureInfo.InvariantCulture)} unidades" +
                $"\nTotal: R${p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}\n");


            Console.Write("Digite o valor a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine($"\nDados atualizados do produto " +
                $"\nNome: {p.Nome}" +
                $"\nPreço: R${p.Preco.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{p.Quantidade.ToString(CultureInfo.InvariantCulture)} unidades" +
                $"\nTotal: R${p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}\n");


            Console.Write("Digite o valor a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine($"\nDados atualizados do produto " +
                $"\nNome: {p.Nome}" +
                $"\nPreço: R${p.Preco.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{p.Quantidade.ToString(CultureInfo.InvariantCulture)} unidades" +
                $"\nTotal: R${p.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}\n");
        }
    }
}
