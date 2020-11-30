using _1_FolhaPagamento.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _1_FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de lista que armazenará objetos da classe Funcionario
            List<Funcionario> lista = new List<Funcionario>();

            //input do usuário para a quantidade de funcionários que será salva em n
            Console.Write("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            //declaração de todas as variáveis para não surgirem erros de variáveis não definidas
            char terceirizado;
            string nome;
            int horas;
            double adicional;
            double valorHora;

            //loop que repetirá n vezes 
            for (int i = 0; i < n; i++)
            {
                //input do usuário para o tipo de funcionário (terceirizado ou comum), nome e horas trabalhadas
                Console.WriteLine("\nFuncionário #" + (i + 1) + " data:");

                Console.Write("Terceirizado (s/n)? ");
                terceirizado = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Horas: ");
                horas = int.Parse(Console.ReadLine());

                //se for terceirizado, input para o adicional e valor por hora
                if (terceirizado == 's')
                {
                    Console.Write("Adicional: ");
                    adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Valor por hora: ");
                    valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //criação e adição de um objeto FuncionarioTerceirizado na lista por meio de upcasting
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorHora, adicional));
                }

                //se for comum, input para o valor por hora
                else if (terceirizado == 'n')
                {
                    Console.Write("Valor por hora: ");
                    valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ////criação e adição de um objeto Funcionario na lista
                    lista.Add(new Funcionario(nome, horas, valorHora));
                }

                //como estou copiando a estrutura do programa dos slides, eu manti a ordem tipo -> nome -> horas -> (adicional) -> valor
                //então acabou tendo uma repetição no código da parte valor por hora. mas nada de preocupante
                //é possível tirar essa repetição utilizando uma ordem diferente ou modificando a declaração de variáveis pra garantir que todas tenham o escopo e valores certos
            }

            //output do nome e pagamento para cada funcionário dentro da lista
            Console.WriteLine("\nPagamentos:");
            foreach (Funcionario func in lista)
            {
                //o programa escreve o objeto inteiro pelo writeline pois a classe tem um método tostring
                Console.WriteLine(func);
            }

            Console.ReadKey();
        }
    }
}
