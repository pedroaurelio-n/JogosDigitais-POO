using _1_LojaProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1_LojaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            //input do usuário para a quantidade de produtos que será salvo na variável n
            Console.Write("Entre com número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //criação de uma lista que armazena objetos da classe produtos
            List<Produto> lista = new List<Produto>();

            //loop for que repete n vezes
            for (int i = 0; i < n; i++)
            {
                //input do usuário para as informações do produto
                Console.WriteLine("\nPRODUTO #" + (i + 1));

                Console.Write("Comum, Usado ou Importado (C/U/I)? ");
                string tipoProduto = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //switch que verifica a variável tipoProduto
                switch (tipoProduto)
                {
                    //se for do tipo comum (C), inserir um objeto Produto na lista com os valores digitados
                    case "C":
                        lista.Insert(i, new Produto(nome, preco));
                        break;

                    //se for do tipo usado (U), pedir input para a data de fabricação
                    //e inserir um objeto ProdutoUsado na lista com os valores digitados
                    //uso de upcasting pois atribui da subclasse ProdutoUsado numa referência da superclasse Produto dentro da lista
                    case "U":
                        Console.Write("Fabricado (DD/MM/AA): ");
                        DateTime fabricacao = DateTime.Parse(Console.ReadLine());

                        lista.Insert(i, new ProdutoUsado(nome, preco, fabricacao));
                        break;

                    //se for do tipo importado (I), pedir input para a taxa
                    //e inserir um objeto ProdutoImportado na lista com os valores digitados
                    //uso de upcasting pois atribui da subclasse ProdutoImportado numa referência da superclasse Produto dentro da lista
                    case "I":
                        Console.Write("Taxa: ");
                        double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Insert(i, new ProdutoImportado(nome, preco, taxa));
                        break;
                }
            }

            //output do programa que mosta as informações de todos os objetos na lista
            //o método PrecoTag será usado em todos os objetos e o tipo dele determinará se o método será sobreposto ou não
            Console.WriteLine("\nEtiquetas: ");
            foreach(Produto prod in lista)
            {
                Console.WriteLine(prod.PrecoTag());
            }

            Console.ReadKey();
        }
    }
}
