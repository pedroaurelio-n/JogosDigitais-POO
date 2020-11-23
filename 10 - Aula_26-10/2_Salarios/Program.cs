using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2_Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //o usuário digita o número de funcionários que serão registrados e salvos na variável N
            Console.Write("Quantos funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            //criação de uma lista que armazenará objetos da classe Funcionario
            List<Funcionario> lista = new List<Funcionario>();

            //loop que repete o número de vezes que o usuário digitou para a quantidade de funcionários
            for (int i = 0; i < N; i++)
            {
                //toda iteração do loop o usuário digitará os valores para a Id, Nome e Salario
                Console.WriteLine("\nFuncionário #" + (i + 1) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //depois de ler os valores, um objeto Funcionario é criado e inserido na lista na posição de número atual do loop (iniciando em 0)
                //o objeto é criado primeiramente com os valores de id e nome
                lista.Insert(i, new Funcionario(id, nome));
                //mas em seguida a variável Salario do objeto atual é definida também
                lista[i].Salario = salario;
            }

            //input do usuário para o id do funcionário que receberá aumento que será salva na string idAumento
            Console.Write("\nId do funcionário que receberá aumento: ");
            string idAumento = Console.ReadLine();

            //como o id estará formatado no padrão 000, uma segunda lista vai ser criada e preenchida com os objetos da primeira lista que terão o id digitado pelo usuário
            //eu tava tendo problemas pq os ids iniciais estavam sendo digitados como 001, mas estavam sendo armazenados na classe como 1 por serem variáveis int
            //então se a input digitada na idAumento fosse "001", o findall não iria achar um objeto correspondente, pois a id dele seria somente 1
            //então só converti o Id da classe para 000, aí não teve problemas
            List<Funcionario> lista2 = lista.FindAll(x => x.Id.ToString("000") == idAumento);

            //se nenhum resultado for encontrado, output de "funcionário não existe"
            if (lista2 == null)
            {
                Console.WriteLine("O funcionário de ID " + lista2[0].Id.ToString("000") + " não existe!");
                Console.ReadKey();
            }

            //se o funcionário de tal id existir, realizar as coisas abaixo
            else
            {
                //input para a porcentagem desejada de aumento para o funcionário de índice 0 da lista2, que só tem o funcionário com a id desejada
                Console.Write("Porcentagem de aumento de salário: ");
                lista2[0].AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                //mostrar todos os funcionários
                Console.WriteLine("\nLista atualizada de funcionários da Bravo: ");
                //para cada Funcionario em lista, mostrar o objeto que já terá a formatação correta
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.ReadKey();
        }
    }
}
